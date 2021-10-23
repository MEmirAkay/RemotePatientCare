namespace RemotePatientCareInterface.Forms
{
    partial class TempForm
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
            this.HomeHeader = new System.Windows.Forms.Panel();
            this.TempLabel = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.TempLevel = new System.Windows.Forms.PictureBox();
            this.SerumLevelRed = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TempratureText = new System.Windows.Forms.Label();
            this.HomeHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TempLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SerumLevelRed)).BeginInit();
            this.SuspendLayout();
            // 
            // HomeHeader
            // 
            this.HomeHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(59)))), ((int)(((byte)(87)))));
            this.HomeHeader.Controls.Add(this.TempLabel);
            this.HomeHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.HomeHeader.Location = new System.Drawing.Point(0, 0);
            this.HomeHeader.Name = "HomeHeader";
            this.HomeHeader.Size = new System.Drawing.Size(1082, 50);
            this.HomeHeader.TabIndex = 1;
            // 
            // TempLabel
            // 
            this.TempLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TempLabel.AutoSize = true;
            this.TempLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TempLabel.Font = new System.Drawing.Font("Corbel Light", 29F);
            this.TempLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TempLabel.Location = new System.Drawing.Point(483, 0);
            this.TempLabel.Name = "TempLabel";
            this.TempLabel.Size = new System.Drawing.Size(110, 47);
            this.TempLabel.TabIndex = 1;
            this.TempLabel.Text = "Temp";
            this.TempLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(216)))), ((int)(((byte)(224)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Fire;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 173;
            this.iconPictureBox1.Location = new System.Drawing.Point(528, 98);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(173, 173);
            this.iconPictureBox1.TabIndex = 2;
            this.iconPictureBox1.TabStop = false;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(216)))), ((int)(((byte)(224)))));
            this.iconPictureBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Fan;
            this.iconPictureBox2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 173;
            this.iconPictureBox2.Location = new System.Drawing.Point(811, 98);
            this.iconPictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(197, 173);
            this.iconPictureBox2.TabIndex = 3;
            this.iconPictureBox2.TabStop = false;
            // 
            // TempLevel
            // 
            this.TempLevel.BackColor = System.Drawing.Color.White;
            this.TempLevel.ErrorImage = null;
            this.TempLevel.InitialImage = null;
            this.TempLevel.Location = new System.Drawing.Point(119, 98);
            this.TempLevel.Name = "TempLevel";
            this.TempLevel.Size = new System.Drawing.Size(200, 500);
            this.TempLevel.TabIndex = 5;
            this.TempLevel.TabStop = false;
            this.TempLevel.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.TempLevel_LoadCompleted);
            // 
            // SerumLevelRed
            // 
            this.SerumLevelRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(59)))), ((int)(((byte)(87)))));
            this.SerumLevelRed.ErrorImage = null;
            this.SerumLevelRed.InitialImage = null;
            this.SerumLevelRed.Location = new System.Drawing.Point(119, 98);
            this.SerumLevelRed.Name = "SerumLevelRed";
            this.SerumLevelRed.Size = new System.Drawing.Size(200, 500);
            this.SerumLevelRed.TabIndex = 4;
            this.SerumLevelRed.TabStop = false;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(151)))), ((int)(((byte)(255)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Corbel Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(813, 373);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(195, 64);
            this.button3.TabIndex = 8;
            this.button3.Text = "High";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Corbel Light", 24F);
            this.button4.Location = new System.Drawing.Point(813, 467);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(195, 64);
            this.button4.TabIndex = 9;
            this.button4.Text = "Medium";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(255)))), ((int)(((byte)(133)))));
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(255)))), ((int)(((byte)(214)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Corbel Light", 24F);
            this.button5.Location = new System.Drawing.Point(813, 558);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(195, 64);
            this.button5.TabIndex = 10;
            this.button5.Text = "Low";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(564, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 45);
            this.label1.TabIndex = 11;
            this.label1.Text = "Heater";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(872, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 45);
            this.label2.TabIndex = 12;
            this.label2.Text = "Fan";
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 80;
            this.iconButton1.Location = new System.Drawing.Point(528, 370);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(184, 118);
            this.iconButton1.TabIndex = 13;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel Light", 30.25F);
            this.label3.Location = new System.Drawing.Point(57, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 500);
            this.label3.TabIndex = 14;
            this.label3.Text = "T\r\nE\r\nM\r\nP\r\nR\r\nA\r\nT\r\nU\r\nR\r\nE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(325, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 36);
            this.label4.TabIndex = 15;
            this.label4.Text = "- 50 C";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(325, 573);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 36);
            this.label6.TabIndex = 17;
            this.label6.Text = "-0 C";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(508, 515);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 36);
            this.label5.TabIndex = 18;
            this.label5.Text = "Current Tempraure:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TempratureText
            // 
            this.TempratureText.AutoSize = true;
            this.TempratureText.Font = new System.Drawing.Font("Corbel", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TempratureText.Location = new System.Drawing.Point(525, 558);
            this.TempratureText.Name = "TempratureText";
            this.TempratureText.Size = new System.Drawing.Size(178, 78);
            this.TempratureText.TabIndex = 20;
            this.TempratureText.Text = "None";
            // 
            // TempForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(216)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1082, 667);
            this.Controls.Add(this.TempratureText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.TempLevel);
            this.Controls.Add(this.SerumLevelRed);
            this.Controls.Add(this.iconPictureBox2);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.HomeHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TempForm";
            this.Text = "TempForm";
            this.Load += new System.EventHandler(this.TempForm_Load);
            this.HomeHeader.ResumeLayout(false);
            this.HomeHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TempLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SerumLevelRed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel HomeHeader;
        private System.Windows.Forms.Label TempLabel;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.PictureBox TempLevel;
        private System.Windows.Forms.PictureBox SerumLevelRed;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label TempratureText;
    }
}