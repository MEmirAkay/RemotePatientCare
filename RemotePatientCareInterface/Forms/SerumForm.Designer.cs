namespace RemotePatientCareInterface.Forms
{
    partial class SerumForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SerumForm));
            this.SerumHeader = new System.Windows.Forms.Panel();
            this.SerumLabel = new System.Windows.Forms.Label();
            this.SerumLevelBG = new System.Windows.Forms.PictureBox();
            this.SerumLevel = new System.Windows.Forms.PictureBox();
            this.SerumLoadFull = new System.Windows.Forms.Button();
            this.SerumLoadHalf = new System.Windows.Forms.Button();
            this.SerumLoadQuarter = new System.Windows.Forms.Button();
            this.SerumDrainAll = new System.Windows.Forms.Button();
            this.SerumDrainHalf = new System.Windows.Forms.Button();
            this.SerumDrainQuarter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SerumHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SerumLevelBG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SerumLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // SerumHeader
            // 
            this.SerumHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(188)))), ((int)(((byte)(249)))));
            this.SerumHeader.Controls.Add(this.SerumLabel);
            this.SerumHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.SerumHeader.Location = new System.Drawing.Point(0, 0);
            this.SerumHeader.Name = "SerumHeader";
            this.SerumHeader.Size = new System.Drawing.Size(1082, 50);
            this.SerumHeader.TabIndex = 1;
            // 
            // SerumLabel
            // 
            this.SerumLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SerumLabel.AutoSize = true;
            this.SerumLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SerumLabel.Font = new System.Drawing.Font("Corbel Light", 29F);
            this.SerumLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SerumLabel.Location = new System.Drawing.Point(483, 0);
            this.SerumLabel.Name = "SerumLabel";
            this.SerumLabel.Size = new System.Drawing.Size(124, 47);
            this.SerumLabel.TabIndex = 1;
            this.SerumLabel.Text = "Serum";
            this.SerumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SerumLevelBG
            // 
            this.SerumLevelBG.BackColor = System.Drawing.Color.White;
            this.SerumLevelBG.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SerumLevelBG.BackgroundImage")));
            this.SerumLevelBG.ErrorImage = null;
            this.SerumLevelBG.InitialImage = null;
            this.SerumLevelBG.Location = new System.Drawing.Point(83, 103);
            this.SerumLevelBG.Name = "SerumLevelBG";
            this.SerumLevelBG.Size = new System.Drawing.Size(200, 500);
            this.SerumLevelBG.TabIndex = 2;
            this.SerumLevelBG.TabStop = false;
            // 
            // SerumLevel
            // 
            this.SerumLevel.BackColor = System.Drawing.Color.White;
            this.SerumLevel.ErrorImage = null;
            this.SerumLevel.InitialImage = null;
            this.SerumLevel.Location = new System.Drawing.Point(83, 103);
            this.SerumLevel.Name = "SerumLevel";
            this.SerumLevel.Size = new System.Drawing.Size(200, 500);
            this.SerumLevel.TabIndex = 3;
            this.SerumLevel.TabStop = false;
            // 
            // SerumLoadFull
            // 
            this.SerumLoadFull.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(190)))), ((int)(((byte)(204)))));
            this.SerumLoadFull.FlatAppearance.BorderSize = 0;
            this.SerumLoadFull.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(219)))), ((int)(((byte)(252)))));
            this.SerumLoadFull.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            this.SerumLoadFull.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SerumLoadFull.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SerumLoadFull.Location = new System.Drawing.Point(378, 103);
            this.SerumLoadFull.Name = "SerumLoadFull";
            this.SerumLoadFull.Size = new System.Drawing.Size(266, 100);
            this.SerumLoadFull.TabIndex = 4;
            this.SerumLoadFull.Text = "Fill 100%";
            this.SerumLoadFull.UseVisualStyleBackColor = false;
            this.SerumLoadFull.Click += new System.EventHandler(this.SerumLoadFull_Click);
            // 
            // SerumLoadHalf
            // 
            this.SerumLoadHalf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(190)))), ((int)(((byte)(204)))));
            this.SerumLoadHalf.FlatAppearance.BorderSize = 0;
            this.SerumLoadHalf.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(219)))), ((int)(((byte)(252)))));
            this.SerumLoadHalf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            this.SerumLoadHalf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SerumLoadHalf.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Bold);
            this.SerumLoadHalf.Location = new System.Drawing.Point(378, 298);
            this.SerumLoadHalf.Name = "SerumLoadHalf";
            this.SerumLoadHalf.Size = new System.Drawing.Size(266, 100);
            this.SerumLoadHalf.TabIndex = 5;
            this.SerumLoadHalf.Text = "Fill 50%";
            this.SerumLoadHalf.UseVisualStyleBackColor = false;
            // 
            // SerumLoadQuarter
            // 
            this.SerumLoadQuarter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(190)))), ((int)(((byte)(204)))));
            this.SerumLoadQuarter.FlatAppearance.BorderSize = 0;
            this.SerumLoadQuarter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(219)))), ((int)(((byte)(252)))));
            this.SerumLoadQuarter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            this.SerumLoadQuarter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SerumLoadQuarter.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Bold);
            this.SerumLoadQuarter.Location = new System.Drawing.Point(378, 503);
            this.SerumLoadQuarter.Name = "SerumLoadQuarter";
            this.SerumLoadQuarter.Size = new System.Drawing.Size(266, 100);
            this.SerumLoadQuarter.TabIndex = 6;
            this.SerumLoadQuarter.Text = "Fill 25%";
            this.SerumLoadQuarter.UseVisualStyleBackColor = false;
            // 
            // SerumDrainAll
            // 
            this.SerumDrainAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(190)))), ((int)(((byte)(204)))));
            this.SerumDrainAll.FlatAppearance.BorderSize = 0;
            this.SerumDrainAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(219)))), ((int)(((byte)(252)))));
            this.SerumDrainAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            this.SerumDrainAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SerumDrainAll.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Bold);
            this.SerumDrainAll.Location = new System.Drawing.Point(788, 503);
            this.SerumDrainAll.Name = "SerumDrainAll";
            this.SerumDrainAll.Size = new System.Drawing.Size(266, 100);
            this.SerumDrainAll.TabIndex = 9;
            this.SerumDrainAll.Text = "Drain 100%";
            this.SerumDrainAll.UseVisualStyleBackColor = false;
            // 
            // SerumDrainHalf
            // 
            this.SerumDrainHalf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(190)))), ((int)(((byte)(204)))));
            this.SerumDrainHalf.FlatAppearance.BorderSize = 0;
            this.SerumDrainHalf.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(219)))), ((int)(((byte)(252)))));
            this.SerumDrainHalf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            this.SerumDrainHalf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SerumDrainHalf.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Bold);
            this.SerumDrainHalf.Location = new System.Drawing.Point(788, 298);
            this.SerumDrainHalf.Name = "SerumDrainHalf";
            this.SerumDrainHalf.Size = new System.Drawing.Size(266, 100);
            this.SerumDrainHalf.TabIndex = 8;
            this.SerumDrainHalf.Text = "Drain 50%";
            this.SerumDrainHalf.UseVisualStyleBackColor = false;
            // 
            // SerumDrainQuarter
            // 
            this.SerumDrainQuarter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(190)))), ((int)(((byte)(204)))));
            this.SerumDrainQuarter.FlatAppearance.BorderSize = 0;
            this.SerumDrainQuarter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(219)))), ((int)(((byte)(252)))));
            this.SerumDrainQuarter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            this.SerumDrainQuarter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SerumDrainQuarter.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SerumDrainQuarter.Location = new System.Drawing.Point(788, 103);
            this.SerumDrainQuarter.Name = "SerumDrainQuarter";
            this.SerumDrainQuarter.Size = new System.Drawing.Size(266, 100);
            this.SerumDrainQuarter.TabIndex = 7;
            this.SerumDrainQuarter.Text = "Drain 25%";
            this.SerumDrainQuarter.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel Light", 20.25F);
            this.label1.Location = new System.Drawing.Point(64, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 33);
            this.label1.TabIndex = 10;
            this.label1.Text = "Current Serum Level";
            // 
            // SerumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(216)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1082, 667);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SerumDrainAll);
            this.Controls.Add(this.SerumDrainHalf);
            this.Controls.Add(this.SerumDrainQuarter);
            this.Controls.Add(this.SerumLoadQuarter);
            this.Controls.Add(this.SerumLoadHalf);
            this.Controls.Add(this.SerumLoadFull);
            this.Controls.Add(this.SerumLevel);
            this.Controls.Add(this.SerumLevelBG);
            this.Controls.Add(this.SerumHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SerumForm";
            this.Text = "SerumForm";
            this.SerumHeader.ResumeLayout(false);
            this.SerumHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SerumLevelBG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SerumLevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel SerumHeader;
        private System.Windows.Forms.Label SerumLabel;
        private System.Windows.Forms.PictureBox SerumLevelBG;
        private System.Windows.Forms.PictureBox SerumLevel;
        private System.Windows.Forms.Button SerumLoadFull;
        private System.Windows.Forms.Button SerumLoadHalf;
        private System.Windows.Forms.Button SerumLoadQuarter;
        private System.Windows.Forms.Button SerumDrainAll;
        private System.Windows.Forms.Button SerumDrainHalf;
        private System.Windows.Forms.Button SerumDrainQuarter;
        private System.Windows.Forms.Label label1;
    }
}