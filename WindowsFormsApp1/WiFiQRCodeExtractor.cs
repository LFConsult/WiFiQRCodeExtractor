using System.Text.RegularExpressions;
using AForge.Video.DirectShow;
using System.Windows.Forms;
using System.Threading;
using System.Drawing;
using AForge.Video;
using System.Media;
using System;
using ZXing;

namespace WiFiQRCodeExtractor
{
    /// <summary>
    /// A simple program to extract content from WiFiQRCodes.
    /// Just put the password into clipboard...
    /// Thanks ZXing and AForge for the awesome work!
    /// </summary>
    public partial class WiFiQRCodeExtractor : Form
    {
        /// <summary>
        /// The video capture device.
        /// </summary>
        public VideoCaptureDevice videoDevice;

        /// <summary>
        /// A frame.
        /// </summary>
        private Bitmap bitmap;

        /// <summary>
        /// Indicates if a frame containaing a QRCode was datected.
        /// </summary>
        public bool qrcodeDetected = false;

        public WiFiQRCodeExtractor()
        {
            InitializeComponent();
            startDetection();
        }

        /// <summary>
        /// Grab the first video input source and start processing new frames.
        /// </summary>
        public void startDetection()
        {
            FilterInfoCollection videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            videoDevice = new VideoCaptureDevice(videoDevices[Convert.ToInt32(0)].MonikerString);
            videoDevice.NewFrame += new NewFrameEventHandler(video_newFrame);
            videoDevice.VideoResolution = videoDevice.VideoCapabilities[0];
            videoDevice.Start();
        }

        /// <summary>
        /// On every new frame from video capture source.
        /// </summary>
        public void video_newFrame(object sender, NewFrameEventArgs eventArgs)
        {
            bitmap = eventArgs.Frame;
            IBarcodeReader reader = new BarcodeReader();
            var result = reader.Decode(bitmap);

            if (result != null)
            {
                if (qrcodeDetected == false)
                {
                    videoDevice.NewFrame -= new NewFrameEventHandler(video_newFrame);
                    videoDevice.SignalToStop();
                    previewCamera.Image = null;
                    SystemSounds.Asterisk.Play();
                    // Thanks https://gist.github.com/error454/3229018
                    string ssidPattern = @"(?<=S:)((?:[^\;\?\""\$\[\\\]\+])|(?:\[\;,:]))+(?<!\;)(?=;)";
                    string passwordPattern = @"(?<=P:)((?:\[\;,:])|(?:[^;]))+(?<!\;)(?=;)";
                    string rawQrcodeContent = result.Text;
                    Match ssidM = Regex.Match(rawQrcodeContent, ssidPattern);
                    Match passwordM = Regex.Match(rawQrcodeContent, passwordPattern);
                    // Not always in the same order
                    // Ex. : WIFI:S:NetworkSSID;T:WPA;P:idjh876786;H:false;;
                    // Ex. : WIFI:T:WPA;P:idjh876786;S:NetworkSSID;H:false;;
                    Invoke((MethodInvoker)delegate {
                        networkNameLabel.Visible = true;
                        networkNameValue.Visible = true;
                        networkNameValue.Text = ssidM.ToString();
                        Clipboard.SetText(passwordM.ToString());
                        restartButton.Visible = true;
                        previewCamera.Visible = false;
                        passwordCopiedLabel.Visible = true;
                        instructionsLabel.Visible = false;
                        #if DEBUG
                        rawQrcodeContentLabel.Visible = true;
                        rawQrcodeContentLabel.Text = result.Text;
                        #endif
                    });
                }
                qrcodeDetected = true;
            }
            else
            {
                try
                {
                    previewCamera.Image = bitmap;
                    previewCamera.SizeMode = PictureBoxSizeMode.Zoom;
                    Thread.Sleep(100);
                }
                catch (Exception ex)
                {
                    // Nothing to do here, just follow normal program execution.
                }
            }
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            videoDevice.NewFrame += new NewFrameEventHandler(video_newFrame);
            qrcodeDetected = false;
            startDetection();
            restartButton.Visible = false;
            passwordCopiedLabel.Visible= false;
            previewCamera.Visible = true;
            networkNameLabel.Visible = false;
            networkNameValue.Visible = false;
            instructionsLabel.Visible = true;
            rawQrcodeContentLabel.Visible = false;
            rawQrcodeContentLabel.Text = String.Empty;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            if (videoDevice.IsRunning)
            {
                videoDevice.NewFrame -= new NewFrameEventHandler(video_newFrame);

                videoDevice.SignalToStop();

                // wait ~ 3 seconds
                for (int i = 0; i < 30; i++)
                {
                    if (!videoDevice.IsRunning)
                        break;
                    Thread.Sleep(100);
                }

                if (videoDevice.IsRunning)
                {
                    videoDevice.Stop();
                }

                videoDevice.Source = null;
            }
            this.Close();
        }
    }
}
