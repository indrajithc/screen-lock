namespace @lock
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
            this.pch = new System.Windows.Forms.Button();
            this.esc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pch
            // 
            this.pch.BackColor = System.Drawing.Color.Black;
            this.pch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pch.Location = new System.Drawing.Point(2, 32);
            this.pch.Name = "pch";
            this.pch.Size = new System.Drawing.Size(139, 56);
            this.pch.TabIndex = 5;
            this.pch.Text = "●●●";
            this.pch.UseVisualStyleBackColor = false;
            this.pch.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // esc
            // 
            this.esc.AccessibleDescription = "";
            this.esc.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.esc.FlatAppearance.BorderSize = 0;
            this.esc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.esc.Location = new System.Drawing.Point(2, 6);
            this.esc.Name = "esc";
            this.esc.Size = new System.Drawing.Size(241, 20);
            this.esc.TabIndex = 6;
            this.esc.Text = "button1";
            this.esc.UseVisualStyleBackColor = false;
            this.esc.Click += new System.EventHandler(this.esc_Click);
            this.esc.MouseClick += new System.Windows.Forms.MouseEventHandler(this.esc_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(731, 534);
            this.Controls.Add(this.esc);
            this.Controls.Add(this.pch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Opacity = 0.09D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.dont_do);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragLeave += new System.EventHandler(this.Form1_DragLeave);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDoubleClick);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button pch;
        private System.Windows.Forms.Button esc;
    }
}

