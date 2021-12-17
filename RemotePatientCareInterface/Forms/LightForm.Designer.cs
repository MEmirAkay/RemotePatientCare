namespace RemotePatientCareInterface.Forms
{
    partial class LightForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LightHeader = new System.Windows.Forms.Panel();
            this.LightLabel = new System.Windows.Forms.Label();
            this.LightPicture = new FontAwesome.Sharp.IconPictureBox();
            this.OnLamp = new FontAwesome.Sharp.IconButton();
            this.CurrentLightIntensty = new System.Windows.Forms.Label();
            this.SetLightIntensty = new System.Windows.Forms.Label();
            this.OnOffLight = new System.Windows.Forms.Label();
            this.LightLevel = new System.Windows.Forms.PictureBox();
            this.SerumLevelLow = new System.Windows.Forms.PictureBox();
            this.UpLightIntensty = new FontAwesome.Sharp.IconButton();
            this.LightIntenstyStatus = new FontAwesome.Sharp.IconButton();
            this.DownLightIntensty = new FontAwesome.Sharp.IconButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LightText = new System.Windows.Forms.Label();
            this.LightHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LightPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LightLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SerumLevelLow)).BeginInit();
            this.SuspendLayout();
            // 
            // LightHeader
            // 
            this.LightHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(135)))));
            this.LightHeader.Controls.Add(this.LightLabel);
            this.LightHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.LightHeader.Location = new System.Drawing.Point(0, 0);
            this.LightHeader.Name = "LightHeader";
            this.LightHeader.Size = new System.Drawing.Size(1082, 50);
            this.LightHeader.TabIndex = 1;
            // 
            // LightLabel
            // 
            this.LightLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LightLabel.AutoSize = true;
            this.LightLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LightLabel.Font = new System.Drawing.Font("Corbel Light", 29F);
            this.LightLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LightLabel.Location = new System.Drawing.Point(483, 0);
            this.LightLabel.Name = "LightLabel";
            this.LightLabel.Size = new System.Drawing.Size(100, 47);
            this.LightLabel.TabIndex = 1;
            this.LightLabel.Text = "Light";
            this.LightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LightPicture
            // 
            this.LightPicture.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LightPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(216)))), ((int)(((byte)(224)))));
            this.LightPicture.ForeColor = System.Drawing.Color.Black;
            this.LightPicture.IconChar = FontAwesome.Sharp.IconChar.Lightbulb;
            this.LightPicture.IconColor = System.Drawing.Color.Black;
            this.LightPicture.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.LightPicture.IconSize = 178;
            this.LightPicture.ImageLocation = "";
            this.LightPicture.Location = new System.Drawing.Point(432, 220);
            this.LightPicture.Name = "LightPicture";
            this.LightPicture.Size = new System.Drawing.Size(178, 194);
            this.LightPicture.TabIndex = 2;
            this.LightPicture.TabStop = false;
            this.LightPicture.Click += new System.EventHandler(this.LightPicture_Click);
            // 
            // OnLamp
            // 
            this.OnLamp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OnLamp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.OnLamp.FlatAppearance.BorderSize = 0;
            this.OnLamp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OnLamp.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.OnLamp.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.OnLamp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.OnLamp.IconSize = 50;
            this.OnLamp.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.OnLamp.Location = new System.Drawing.Point(432, 528);
            this.OnLamp.Name = "OnLamp";
            this.OnLamp.Size = new System.Drawing.Size(178, 83);
            this.OnLamp.TabIndex = 3;
            this.OnLamp.UseVisualStyleBackColor = true;
            this.OnLamp.Click += new System.EventHandler(this.OnLamp_Click);
            // 
            // CurrentLightIntensty
            // 
            this.CurrentLightIntensty.AutoSize = true;
            this.CurrentLightIntensty.Font = new System.Drawing.Font("Corbel Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CurrentLightIntensty.Location = new System.Drawing.Point(12, 76);
            this.CurrentLightIntensty.Name = "CurrentLightIntensty";
            this.CurrentLightIntensty.Size = new System.Drawing.Size(323, 42);
            this.CurrentLightIntensty.TabIndex = 4;
            this.CurrentLightIntensty.Text = "Current Light Intensty";
            // 
            // SetLightIntensty
            // 
            this.SetLightIntensty.AutoSize = true;
            this.SetLightIntensty.Font = new System.Drawing.Font("Corbel Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SetLightIntensty.Location = new System.Drawing.Point(755, 76);
            this.SetLightIntensty.Name = "SetLightIntensty";
            this.SetLightIntensty.Size = new System.Drawing.Size(263, 42);
            this.SetLightIntensty.TabIndex = 5;
            this.SetLightIntensty.Text = "Set Light Intensty";
            // 
            // OnOffLight
            // 
            this.OnOffLight.AutoSize = true;
            this.OnOffLight.Font = new System.Drawing.Font("Corbel Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OnOffLight.Location = new System.Drawing.Point(468, 454);
            this.OnOffLight.Name = "OnOffLight";
            this.OnOffLight.Size = new System.Drawing.Size(115, 42);
            this.OnOffLight.TabIndex = 6;
            this.OnOffLight.Text = "On/Off";
            // 
            // LightLevel
            // 
            this.LightLevel.BackColor = System.Drawing.Color.White;
            this.LightLevel.ErrorImage = null;
            this.LightLevel.InitialImage = null;
            this.LightLevel.Location = new System.Drawing.Point(87, 142);
            this.LightLevel.Name = "LightLevel";
            this.LightLevel.Size = new System.Drawing.Size(211, 469);
            this.LightLevel.TabIndex = 8;
            this.LightLevel.TabStop = false;
            this.LightLevel.Click += new System.EventHandler(this.LightLevel_Click);
            // 
            // SerumLevelLow
            // 
            this.SerumLevelLow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(135)))));
            this.SerumLevelLow.ErrorImage = null;
            this.SerumLevelLow.InitialImage = null;
            this.SerumLevelLow.Location = new System.Drawing.Point(87, 142);
            this.SerumLevelLow.Name = "SerumLevelLow";
            this.SerumLevelLow.Size = new System.Drawing.Size(211, 469);
            this.SerumLevelLow.TabIndex = 7;
            this.SerumLevelLow.TabStop = false;
            // 
            // UpLightIntensty
            // 
            this.UpLightIntensty.FlatAppearance.BorderSize = 0;
            this.UpLightIntensty.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(196)))));
            this.UpLightIntensty.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(218)))));
            this.UpLightIntensty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpLightIntensty.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleUp;
            this.UpLightIntensty.IconColor = System.Drawing.Color.Black;
            this.UpLightIntensty.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.UpLightIntensty.Location = new System.Drawing.Point(762, 183);
            this.UpLightIntensty.Name = "UpLightIntensty";
            this.UpLightIntensty.Size = new System.Drawing.Size(256, 95);
            this.UpLightIntensty.TabIndex = 9;
            this.UpLightIntensty.UseVisualStyleBackColor = true;
            this.UpLightIntensty.Click += new System.EventHandler(this.UpLightIntensty_Click);
            // 
            // LightIntenstyStatus
            // 
            this.LightIntenstyStatus.Enabled = false;
            this.LightIntenstyStatus.FlatAppearance.BorderSize = 0;
            this.LightIntenstyStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LightIntenstyStatus.Font = new System.Drawing.Font("Corbel Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LightIntenstyStatus.IconChar = FontAwesome.Sharp.IconChar.None;
            this.LightIntenstyStatus.IconColor = System.Drawing.Color.Black;
            this.LightIntenstyStatus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.LightIntenstyStatus.Location = new System.Drawing.Point(762, 277);
            this.LightIntenstyStatus.Name = "LightIntenstyStatus";
            this.LightIntenstyStatus.Size = new System.Drawing.Size(256, 160);
            this.LightIntenstyStatus.TabIndex = 10;
            this.LightIntenstyStatus.Text = "Off";
            this.LightIntenstyStatus.UseVisualStyleBackColor = true;
            // 
            // DownLightIntensty
            // 
            this.DownLightIntensty.FlatAppearance.BorderSize = 0;
            this.DownLightIntensty.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(196)))));
            this.DownLightIntensty.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(218)))));
            this.DownLightIntensty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DownLightIntensty.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleDown;
            this.DownLightIntensty.IconColor = System.Drawing.Color.Black;
            this.DownLightIntensty.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DownLightIntensty.Location = new System.Drawing.Point(762, 435);
            this.DownLightIntensty.Name = "DownLightIntensty";
            this.DownLightIntensty.Size = new System.Drawing.Size(256, 95);
            this.DownLightIntensty.TabIndex = 11;
            this.DownLightIntensty.UseVisualStyleBackColor = true;
            this.DownLightIntensty.Click += new System.EventHandler(this.DownLightIntensty_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LightText
            // 
            this.LightText.AutoSize = true;
            this.LightText.Font = new System.Drawing.Font("Corbel Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LightText.Location = new System.Drawing.Point(484, 142);
            this.LightText.Name = "LightText";
            this.LightText.Size = new System.Drawing.Size(85, 39);
            this.LightText.TabIndex = 12;
            this.LightText.Text = "None";
            // 
            // LightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(216)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1082, 667);
            this.Controls.Add(this.LightText);
            this.Controls.Add(this.DownLightIntensty);
            this.Controls.Add(this.LightIntenstyStatus);
            this.Controls.Add(this.UpLightIntensty);
            this.Controls.Add(this.LightLevel);
            this.Controls.Add(this.SerumLevelLow);
            this.Controls.Add(this.OnOffLight);
            this.Controls.Add(this.SetLightIntensty);
            this.Controls.Add(this.CurrentLightIntensty);
            this.Controls.Add(this.OnLamp);
            this.Controls.Add(this.LightPicture);
            this.Controls.Add(this.LightHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LightForm";
            this.Text = "LightForm";
            this.LightHeader.ResumeLayout(false);
            this.LightHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LightPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LightLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SerumLevelLow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel LightHeader;
        private System.Windows.Forms.Label LightLabel;
        private FontAwesome.Sharp.IconPictureBox LightPicture;
        private FontAwesome.Sharp.IconButton OnLamp;
        private System.Windows.Forms.Label CurrentLightIntensty;
        private System.Windows.Forms.Label SetLightIntensty;
        private System.Windows.Forms.Label OnOffLight;
        private System.Windows.Forms.PictureBox LightLevel;
        private System.Windows.Forms.PictureBox SerumLevelLow;
        private FontAwesome.Sharp.IconButton UpLightIntensty;
        private FontAwesome.Sharp.IconButton LightIntenstyStatus;
        private FontAwesome.Sharp.IconButton DownLightIntensty;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LightText;
    }
}