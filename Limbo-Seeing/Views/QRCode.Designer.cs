
namespace Limbo_Seeing.Views
{
    partial class QRCode
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
            this.QRCodeimage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.QRCodeimage)).BeginInit();
            this.SuspendLayout();
            // 
            // QRCodeimage
            // 
            this.QRCodeimage.Location = new System.Drawing.Point(12, 12);
            this.QRCodeimage.Name = "QRCodeimage";
            this.QRCodeimage.Size = new System.Drawing.Size(258, 264);
            this.QRCodeimage.TabIndex = 0;
            this.QRCodeimage.TabStop = false;
            // 
            // QRCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(282, 288);
            this.Controls.Add(this.QRCodeimage);
            this.Name = "QRCode";
            this.Text = "QRCode";
            ((System.ComponentModel.ISupportInitialize)(this.QRCodeimage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox QRCodeimage;
    }
}