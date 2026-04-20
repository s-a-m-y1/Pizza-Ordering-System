namespace WindowsFormsApp1
{
    partial class Frm_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Home));
            this.BUT_Enter_Next = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BUT_Enter_Next
            // 
            this.BUT_Enter_Next.BackColor = System.Drawing.Color.NavajoWhite;
            this.BUT_Enter_Next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BUT_Enter_Next.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.BUT_Enter_Next.Font = new System.Drawing.Font("MV Boli", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUT_Enter_Next.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.BUT_Enter_Next.Image = ((System.Drawing.Image)(resources.GetObject("BUT_Enter_Next.Image")));
            this.BUT_Enter_Next.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BUT_Enter_Next.Location = new System.Drawing.Point(1130, 646);
            this.BUT_Enter_Next.Name = "BUT_Enter_Next";
            this.BUT_Enter_Next.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BUT_Enter_Next.Size = new System.Drawing.Size(152, 72);
            this.BUT_Enter_Next.TabIndex = 11;
            this.BUT_Enter_Next.Text = "Next";
            this.BUT_Enter_Next.UseVisualStyleBackColor = false;
            this.BUT_Enter_Next.Click += new System.EventHandler(this.BUT_Enter_Next_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.NavajoWhite;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.button1.Font = new System.Drawing.Font("MV Boli", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(12, 656);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(152, 72);
            this.button1.TabIndex = 12;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1294, 740);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BUT_Enter_Next);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Frm_Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Frm_Home_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BUT_Enter_Next;
        private System.Windows.Forms.Button button1;
    }
}