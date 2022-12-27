namespace WiFiQRCodeExtractor
{
    partial class WiFiQRCodeExtractor
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.networkNameValue = new System.Windows.Forms.TextBox();
            this.networkNameLabel = new System.Windows.Forms.Label();
            this.previewCamera = new System.Windows.Forms.PictureBox();
            this.restartButton = new System.Windows.Forms.Button();
            this.passwordCopiedLabel = new System.Windows.Forms.Label();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.rawQrcodeContentLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.previewCamera)).BeginInit();
            this.SuspendLayout();
            // 
            // networkNameValue
            // 
            this.networkNameValue.Location = new System.Drawing.Point(150, 309);
            this.networkNameValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.networkNameValue.Name = "networkNameValue";
            this.networkNameValue.Size = new System.Drawing.Size(379, 26);
            this.networkNameValue.TabIndex = 0;
            this.networkNameValue.Visible = false;
            // 
            // networkNameLabel
            // 
            this.networkNameLabel.AutoSize = true;
            this.networkNameLabel.Location = new System.Drawing.Point(14, 314);
            this.networkNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.networkNameLabel.Name = "networkNameLabel";
            this.networkNameLabel.Size = new System.Drawing.Size(111, 20);
            this.networkNameLabel.TabIndex = 1;
            this.networkNameLabel.Text = "Network name";
            this.networkNameLabel.Visible = false;
            // 
            // previewCamera
            // 
            this.previewCamera.Location = new System.Drawing.Point(18, 18);
            this.previewCamera.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.previewCamera.Name = "previewCamera";
            this.previewCamera.Size = new System.Drawing.Size(518, 266);
            this.previewCamera.TabIndex = 2;
            this.previewCamera.TabStop = false;
            // 
            // restartButton
            // 
            this.restartButton.Location = new System.Drawing.Point(18, 369);
            this.restartButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(300, 35);
            this.restartButton.TabIndex = 3;
            this.restartButton.Text = "Restart";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Visible = false;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // passwordCopiedLabel
            // 
            this.passwordCopiedLabel.AutoSize = true;
            this.passwordCopiedLabel.Location = new System.Drawing.Point(126, 143);
            this.passwordCopiedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordCopiedLabel.Name = "passwordCopiedLabel";
            this.passwordCopiedLabel.Size = new System.Drawing.Size(272, 20);
            this.passwordCopiedLabel.TabIndex = 4;
            this.passwordCopiedLabel.Text = "Password dumped into your clipboard";
            this.passwordCopiedLabel.Visible = false;
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Location = new System.Drawing.Point(117, 340);
            this.instructionsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(334, 20);
            this.instructionsLabel.TabIndex = 5;
            this.instructionsLabel.Text = "Present WiFi QR code in front of your webcam";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(423, 369);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(112, 35);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // rawQrcodeContentLabel
            // 
            this.rawQrcodeContentLabel.AutoSize = true;
            this.rawQrcodeContentLabel.Location = new System.Drawing.Point(14, 215);
            this.rawQrcodeContentLabel.Name = "rawQrcodeContentLabel";
            this.rawQrcodeContentLabel.Size = new System.Drawing.Size(171, 20);
            this.rawQrcodeContentLabel.TabIndex = 7;
            this.rawQrcodeContentLabel.Text = "RAW QRCode content";
            this.rawQrcodeContentLabel.Visible = false;
            // 
            // WiFiQRCodeExtractor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 423);
            this.ControlBox = false;
            this.Controls.Add(this.rawQrcodeContentLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.instructionsLabel);
            this.Controls.Add(this.passwordCopiedLabel);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.previewCamera);
            this.Controls.Add(this.networkNameLabel);
            this.Controls.Add(this.networkNameValue);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "WiFiQRCodeExtractor";
            this.Text = "WiFiQRCodeExtractor";
            ((System.ComponentModel.ISupportInitialize)(this.previewCamera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox networkNameValue;
        private System.Windows.Forms.Label networkNameLabel;
        private System.Windows.Forms.PictureBox previewCamera;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Label passwordCopiedLabel;
        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label rawQrcodeContentLabel;
    }
}

