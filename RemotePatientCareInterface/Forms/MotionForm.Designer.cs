namespace RemotePatientCareInterface.Forms
{
    partial class MotionForm
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
            this.MotionHeader = new System.Windows.Forms.Panel();
            this.MotionLabel = new System.Windows.Forms.Label();
            this.MotionHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // MotionHeader
            // 
            this.MotionHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.MotionHeader.Controls.Add(this.MotionLabel);
            this.MotionHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.MotionHeader.Location = new System.Drawing.Point(0, 0);
            this.MotionHeader.Name = "MotionHeader";
            this.MotionHeader.Size = new System.Drawing.Size(1082, 50);
            this.MotionHeader.TabIndex = 1;
            // 
            // MotionLabel
            // 
            this.MotionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MotionLabel.AutoSize = true;
            this.MotionLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MotionLabel.Font = new System.Drawing.Font("Corbel Light", 29F);
            this.MotionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MotionLabel.Location = new System.Drawing.Point(483, 0);
            this.MotionLabel.Name = "MotionLabel";
            this.MotionLabel.Size = new System.Drawing.Size(132, 47);
            this.MotionLabel.TabIndex = 1;
            this.MotionLabel.Text = "Motion";
            this.MotionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MotionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(216)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1082, 667);
            this.Controls.Add(this.MotionHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MotionForm";
            this.Text = "MotionForm";
            this.MotionHeader.ResumeLayout(false);
            this.MotionHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MotionHeader;
        private System.Windows.Forms.Label MotionLabel;
    }
}