namespace RemotePatientCareInterface
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.Home = new FontAwesome.Sharp.IconButton();
            this.btnMenu = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.Motion = new FontAwesome.Sharp.IconButton();
            this.Temp = new FontAwesome.Sharp.IconButton();
            this.Light = new FontAwesome.Sharp.IconButton();
            this.Serum = new FontAwesome.Sharp.IconButton();
            this.topBar = new System.Windows.Forms.Panel();
            this.minimizeForm = new System.Windows.Forms.Button();
            this.maximizeForm = new System.Windows.Forms.Button();
            this.exitForm = new System.Windows.Forms.Button();
            this.panelDesktopPanel = new System.Windows.Forms.Panel();
            this.WelcomePicture = new System.Windows.Forms.PictureBox();
            this.IntroductionParagraph = new System.Windows.Forms.Label();
            this.WelcomeMsg = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.topBar.SuspendLayout();
            this.panelDesktopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WelcomePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.panelMenu.Controls.Add(this.Home);
            this.panelMenu.Controls.Add(this.btnMenu);
            this.panelMenu.Controls.Add(this.iconPictureBox1);
            this.panelMenu.Controls.Add(this.Motion);
            this.panelMenu.Controls.Add(this.Temp);
            this.panelMenu.Controls.Add(this.Light);
            this.panelMenu.Controls.Add(this.Serum);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(246, 741);
            this.panelMenu.TabIndex = 0;
            // 
            // Home
            // 
            this.Home.AccessibleName = "";
            this.Home.FlatAppearance.BorderSize = 0;
            this.Home.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(72)))));
            this.Home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(168)))), ((int)(((byte)(1)))));
            this.Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home.Font = new System.Drawing.Font("Corbel Light", 30F);
            this.Home.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Home.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.Home.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Home.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Home.IconSize = 50;
            this.Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Home.Location = new System.Drawing.Point(0, 152);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(246, 84);
            this.Home.TabIndex = 13;
            this.Home.Tag = "Home";
            this.Home.Text = "  Home";
            this.Home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.btnMenu.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenu.Location = new System.Drawing.Point(0, 81);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(253, 65);
            this.btnMenu.TabIndex = 12;
            this.btnMenu.Tag = "  ";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.iconPictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("iconPictureBox1.BackgroundImage")));
            this.iconPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconPictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.iconPictureBox1.ErrorImage = null;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 75;
            this.iconPictureBox1.InitialImage = null;
            this.iconPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(246, 75);
            this.iconPictureBox1.TabIndex = 11;
            this.iconPictureBox1.TabStop = false;
            // 
            // Motion
            // 
            this.Motion.FlatAppearance.BorderSize = 0;
            this.Motion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(209)))), ((int)(((byte)(161)))));
            this.Motion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.Motion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Motion.Font = new System.Drawing.Font("Corbel Light", 30F);
            this.Motion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Motion.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.Motion.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Motion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Motion.IconSize = 50;
            this.Motion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Motion.Location = new System.Drawing.Point(-3, 512);
            this.Motion.Name = "Motion";
            this.Motion.Size = new System.Drawing.Size(249, 84);
            this.Motion.TabIndex = 10;
            this.Motion.Tag = "Motion";
            this.Motion.Text = "  Motion";
            this.Motion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Motion.UseVisualStyleBackColor = true;
            this.Motion.Click += new System.EventHandler(this.Motion_Click);
            // 
            // Temp
            // 
            this.Temp.FlatAppearance.BorderSize = 0;
            this.Temp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(87)))), ((int)(((byte)(119)))));
            this.Temp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(59)))), ((int)(((byte)(87)))));
            this.Temp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Temp.Font = new System.Drawing.Font("Corbel Light", 30F);
            this.Temp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Temp.IconChar = FontAwesome.Sharp.IconChar.TemperatureLow;
            this.Temp.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Temp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Temp.IconSize = 50;
            this.Temp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Temp.Location = new System.Drawing.Point(-3, 422);
            this.Temp.Name = "Temp";
            this.Temp.Size = new System.Drawing.Size(249, 84);
            this.Temp.TabIndex = 9;
            this.Temp.Tag = "Temp";
            this.Temp.Text = "  Temp";
            this.Temp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Temp.UseVisualStyleBackColor = true;
            this.Temp.Click += new System.EventHandler(this.Temp_Click);
            // 
            // Light
            // 
            this.Light.AccessibleName = "";
            this.Light.FlatAppearance.BorderSize = 0;
            this.Light.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(111)))), ((int)(((byte)(211)))));
            this.Light.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(135)))));
            this.Light.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Light.Font = new System.Drawing.Font("Corbel Light", 30F);
            this.Light.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Light.IconChar = FontAwesome.Sharp.IconChar.Lightbulb;
            this.Light.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Light.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Light.IconSize = 50;
            this.Light.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Light.Location = new System.Drawing.Point(0, 332);
            this.Light.Name = "Light";
            this.Light.Size = new System.Drawing.Size(246, 84);
            this.Light.TabIndex = 8;
            this.Light.Tag = "Light";
            this.Light.Text = "  Light";
            this.Light.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Light.UseVisualStyleBackColor = true;
            this.Light.Click += new System.EventHandler(this.Light_Click);
            // 
            // Serum
            // 
            this.Serum.AccessibleName = "";
            this.Serum.FlatAppearance.BorderSize = 0;
            this.Serum.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(207)))), ((int)(((byte)(250)))));
            this.Serum.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(188)))), ((int)(((byte)(249)))));
            this.Serum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Serum.Font = new System.Drawing.Font("Corbel Light", 30F);
            this.Serum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Serum.IconChar = FontAwesome.Sharp.IconChar.Brush;
            this.Serum.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Serum.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Serum.IconSize = 50;
            this.Serum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Serum.Location = new System.Drawing.Point(0, 242);
            this.Serum.Name = "Serum";
            this.Serum.Size = new System.Drawing.Size(246, 84);
            this.Serum.TabIndex = 7;
            this.Serum.Tag = "Serum";
            this.Serum.Text = "  Serum";
            this.Serum.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Serum.UseVisualStyleBackColor = true;
            this.Serum.Click += new System.EventHandler(this.Serum_Click);
            // 
            // topBar
            // 
            this.topBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.topBar.Controls.Add(this.minimizeForm);
            this.topBar.Controls.Add(this.maximizeForm);
            this.topBar.Controls.Add(this.exitForm);
            this.topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBar.Location = new System.Drawing.Point(246, 0);
            this.topBar.Name = "topBar";
            this.topBar.Size = new System.Drawing.Size(1098, 35);
            this.topBar.TabIndex = 1;
            this.topBar.Paint += new System.Windows.Forms.PaintEventHandler(this.topBar_Paint);
            this.topBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topBar_MouseDown);
            // 
            // minimizeForm
            // 
            this.minimizeForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.minimizeForm.FlatAppearance.BorderSize = 0;
            this.minimizeForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeForm.ForeColor = System.Drawing.Color.White;
            this.minimizeForm.Location = new System.Drawing.Point(981, 0);
            this.minimizeForm.Name = "minimizeForm";
            this.minimizeForm.Size = new System.Drawing.Size(35, 35);
            this.minimizeForm.TabIndex = 5;
            this.minimizeForm.Text = "__";
            this.minimizeForm.UseVisualStyleBackColor = true;
            this.minimizeForm.Click += new System.EventHandler(this.minimizeForm_Click);
            // 
            // maximizeForm
            // 
            this.maximizeForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("maximizeForm.BackgroundImage")));
            this.maximizeForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.maximizeForm.FlatAppearance.BorderSize = 0;
            this.maximizeForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizeForm.Location = new System.Drawing.Point(1022, 0);
            this.maximizeForm.Name = "maximizeForm";
            this.maximizeForm.Size = new System.Drawing.Size(35, 35);
            this.maximizeForm.TabIndex = 4;
            this.maximizeForm.UseVisualStyleBackColor = true;
            this.maximizeForm.Click += new System.EventHandler(this.maximizeForm_Click);
            // 
            // exitForm
            // 
            this.exitForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitForm.BackgroundImage")));
            this.exitForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.exitForm.FlatAppearance.BorderSize = 0;
            this.exitForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.exitForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitForm.Location = new System.Drawing.Point(1063, 0);
            this.exitForm.Name = "exitForm";
            this.exitForm.Size = new System.Drawing.Size(35, 35);
            this.exitForm.TabIndex = 3;
            this.exitForm.UseVisualStyleBackColor = true;
            this.exitForm.Click += new System.EventHandler(this.exitForm_Click);
            // 
            // panelDesktopPanel
            // 
            this.panelDesktopPanel.Controls.Add(this.WelcomePicture);
            this.panelDesktopPanel.Controls.Add(this.IntroductionParagraph);
            this.panelDesktopPanel.Controls.Add(this.WelcomeMsg);
            this.panelDesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPanel.Location = new System.Drawing.Point(246, 35);
            this.panelDesktopPanel.Name = "panelDesktopPanel";
            this.panelDesktopPanel.Size = new System.Drawing.Size(1098, 706);
            this.panelDesktopPanel.TabIndex = 2;
            
            // 
            // WelcomePicture
            // 
            this.WelcomePicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.WelcomePicture.ErrorImage = null;
            this.WelcomePicture.Image = ((System.Drawing.Image)(resources.GetObject("WelcomePicture.Image")));
            this.WelcomePicture.InitialImage = null;
            this.WelcomePicture.Location = new System.Drawing.Point(448, 387);
            this.WelcomePicture.Name = "WelcomePicture";
            this.WelcomePicture.Size = new System.Drawing.Size(254, 264);
            this.WelcomePicture.TabIndex = 2;
            this.WelcomePicture.TabStop = false;
            // 
            // IntroductionParagraph
            // 
            this.IntroductionParagraph.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.IntroductionParagraph.AutoSize = true;
            this.IntroductionParagraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IntroductionParagraph.Font = new System.Drawing.Font("Corbel Light", 25F);
            this.IntroductionParagraph.Location = new System.Drawing.Point(30, 129);
            this.IntroductionParagraph.Name = "IntroductionParagraph";
            this.IntroductionParagraph.Size = new System.Drawing.Size(1046, 246);
            this.IntroductionParagraph.TabIndex = 1;
            this.IntroductionParagraph.Text = resources.GetString("IntroductionParagraph.Text");
            this.IntroductionParagraph.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WelcomeMsg
            // 
            this.WelcomeMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.WelcomeMsg.AutoSize = true;
            this.WelcomeMsg.Font = new System.Drawing.Font("Corbel Light", 25F);
            this.WelcomeMsg.Location = new System.Drawing.Point(273, 46);
            this.WelcomeMsg.Name = "WelcomeMsg";
            this.WelcomeMsg.Size = new System.Drawing.Size(592, 41);
            this.WelcomeMsg.TabIndex = 0;
            this.WelcomeMsg.Text = "Welcome to Remote Patient Care Interface";
            this.WelcomeMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(216)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1344, 741);
            this.Controls.Add(this.panelDesktopPanel);
            this.Controls.Add(this.topBar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1344, 741);
            this.Name = "Form1";
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.topBar.ResumeLayout(false);
            this.panelDesktopPanel.ResumeLayout(false);
            this.panelDesktopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WelcomePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel topBar;
        private System.Windows.Forms.Button minimizeForm;
        private System.Windows.Forms.Button maximizeForm;
        private System.Windows.Forms.Button exitForm;
        private FontAwesome.Sharp.IconButton Serum;
        private FontAwesome.Sharp.IconButton Temp;
        private FontAwesome.Sharp.IconButton Light;
        private FontAwesome.Sharp.IconButton Motion;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton btnMenu;
        private System.Windows.Forms.Panel panelDesktopPanel;
        private FontAwesome.Sharp.IconButton Home;
        private System.Windows.Forms.PictureBox WelcomePicture;
        private System.Windows.Forms.Label IntroductionParagraph;
        private System.Windows.Forms.Label WelcomeMsg;
    }
}

