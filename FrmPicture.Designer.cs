namespace PhotoSelector
{
    partial class FrmPicture
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
            this.BoxPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BoxPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // BoxPicture
            // 
            this.BoxPicture.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BoxPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BoxPicture.Location = new System.Drawing.Point(0, 0);
            this.BoxPicture.Name = "BoxPicture";
            this.BoxPicture.Size = new System.Drawing.Size(800, 450);
            this.BoxPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BoxPicture.TabIndex = 0;
            this.BoxPicture.TabStop = false;
            // 
            // FrmPicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BoxPicture);
            this.KeyPreview = true;
            this.Name = "FrmPicture";
            this.Text = "FrmPicture";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPicture_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.BoxPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox BoxPicture;
    }
}