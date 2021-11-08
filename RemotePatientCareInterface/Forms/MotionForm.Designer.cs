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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LoadingMessage = new System.Windows.Forms.Label();
            this.GetCamera = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SendMessage = new FontAwesome.Sharp.IconButton();
            this.WillConvSpeach = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 443);
            this.panel1.TabIndex = 2;
            // 
            // LoadingMessage
            // 
            this.LoadingMessage.AutoSize = true;
            this.LoadingMessage.Font = new System.Drawing.Font("Corbel Light", 14F);
            this.LoadingMessage.ForeColor = System.Drawing.Color.Red;
            this.LoadingMessage.Location = new System.Drawing.Point(106, 502);
            this.LoadingMessage.Name = "LoadingMessage";
            this.LoadingMessage.Size = new System.Drawing.Size(486, 23);
            this.LoadingMessage.TabIndex = 3;
            this.LoadingMessage.Text = "Attention : It takes time to connect camera, please stay patient.\r\n";
            // 
            // GetCamera
            // 
            this.GetCamera.Font = new System.Drawing.Font("Corbel Light", 20.25F);
            this.GetCamera.Location = new System.Drawing.Point(811, 56);
            this.GetCamera.Name = "GetCamera";
            this.GetCamera.Size = new System.Drawing.Size(234, 54);
            this.GetCamera.TabIndex = 4;
            this.GetCamera.Text = "Get IP Camera";
            this.GetCamera.UseVisualStyleBackColor = true;
            this.GetCamera.Click += new System.EventHandler(this.GetCamera_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(811, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 62);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(811, 271);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(234, 62);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(811, 352);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(234, 62);
            this.button3.TabIndex = 7;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(811, 437);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(234, 62);
            this.button4.TabIndex = 8;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // SendMessage
            // 
            this.SendMessage.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.SendMessage.IconColor = System.Drawing.Color.Black;
            this.SendMessage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SendMessage.IconSize = 100;
            this.SendMessage.Location = new System.Drawing.Point(922, 533);
            this.SendMessage.Name = "SendMessage";
            this.SendMessage.Size = new System.Drawing.Size(123, 105);
            this.SendMessage.TabIndex = 9;
            this.SendMessage.UseVisualStyleBackColor = true;
            this.SendMessage.Click += new System.EventHandler(this.SendMessage_Click);
            // 
            // WillConvSpeach
            // 
            this.WillConvSpeach.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.WillConvSpeach.Location = new System.Drawing.Point(12, 533);
            this.WillConvSpeach.Name = "WillConvSpeach";
            this.WillConvSpeach.Size = new System.Drawing.Size(888, 105);
            this.WillConvSpeach.TabIndex = 10;
            this.WillConvSpeach.Text = "Write and send voice command to patient...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(891, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Send Message";
            // 
            // MotionForm
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(216)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1082, 667);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WillConvSpeach);
            this.Controls.Add(this.SendMessage);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GetCamera);
            this.Controls.Add(this.LoadingMessage);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MotionHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MotionForm";
            this.Text = "MotionForm";
            this.MotionHeader.ResumeLayout(false);
            this.MotionHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MotionHeader;
        private System.Windows.Forms.Label MotionLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LoadingMessage;
        private System.Windows.Forms.Button GetCamera;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private FontAwesome.Sharp.IconButton SendMessage;
        private System.Windows.Forms.RichTextBox WillConvSpeach;
        private System.Windows.Forms.Label label1;
    }
}