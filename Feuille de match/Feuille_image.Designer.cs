
namespace Feuille_de_match
{
    partial class Feuille_image
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
            this.field_image = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.save_image = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.field_image)).BeginInit();
            this.SuspendLayout();
            // 
            // field_image
            // 
            this.field_image.Location = new System.Drawing.Point(40, 28);
            this.field_image.Name = "field_image";
            this.field_image.Size = new System.Drawing.Size(796, 567);
            this.field_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.field_image.TabIndex = 0;
            this.field_image.TabStop = false;
            // 
            // save_image
            // 
            this.save_image.Location = new System.Drawing.Point(875, 28);
            this.save_image.Name = "save_image";
            this.save_image.Size = new System.Drawing.Size(138, 60);
            this.save_image.TabIndex = 1;
            this.save_image.Text = "Save Image";
            this.save_image.UseVisualStyleBackColor = true;
            this.save_image.Click += new System.EventHandler(this.save_image_Click);
            // 
            // Feuille_image
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1038, 704);
            this.Controls.Add(this.save_image);
            this.Controls.Add(this.field_image);
            this.Name = "Feuille_image";
            this.Text = "Feuille_image";
            ((System.ComponentModel.ISupportInitialize)(this.field_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox field_image;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button save_image;
    }
}