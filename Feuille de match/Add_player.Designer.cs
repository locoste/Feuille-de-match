
namespace Feuille_de_match
{
    partial class Add_player
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
            this.label1 = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.prenom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Surnom = new System.Windows.Forms.TextBox();
            this.add_player_image = new System.Windows.Forms.Button();
            this.player_image = new System.Windows.Forms.PictureBox();
            this.Add = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.image_path = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player_image)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(132, 53);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(167, 22);
            this.nom.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prenom";
            // 
            // prenom
            // 
            this.prenom.Location = new System.Drawing.Point(132, 79);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(167, 22);
            this.prenom.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Surnom";
            // 
            // Surnom
            // 
            this.Surnom.Location = new System.Drawing.Point(132, 133);
            this.Surnom.Name = "Surnom";
            this.Surnom.Size = new System.Drawing.Size(167, 22);
            this.Surnom.TabIndex = 5;
            // 
            // add_player_image
            // 
            this.add_player_image.Location = new System.Drawing.Point(464, 189);
            this.add_player_image.Name = "add_player_image";
            this.add_player_image.Size = new System.Drawing.Size(75, 48);
            this.add_player_image.TabIndex = 6;
            this.add_player_image.Text = "Ajouter photo";
            this.add_player_image.UseVisualStyleBackColor = true;
            this.add_player_image.Click += new System.EventHandler(this.add_player_image_Click);
            // 
            // player_image
            // 
            this.player_image.Location = new System.Drawing.Point(428, 39);
            this.player_image.Name = "player_image";
            this.player_image.Size = new System.Drawing.Size(150, 130);
            this.player_image.TabIndex = 7;
            this.player_image.TabStop = false;
            // 
            // Add
            // 
            this.Add.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Add.Location = new System.Drawing.Point(121, 214);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 8;
            this.Add.Text = "Ajouter";
            this.Add.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(224, 214);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Annuler";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // image_path
            // 
            this.image_path.AutoSize = true;
            this.image_path.Location = new System.Drawing.Point(476, 241);
            this.image_path.Name = "image_path";
            this.image_path.Size = new System.Drawing.Size(72, 17);
            this.image_path.TabIndex = 10;
            this.image_path.Text = "lien image";
            // 
            // Add_player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 267);
            this.Controls.Add(this.image_path);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.player_image);
            this.Controls.Add(this.add_player_image);
            this.Controls.Add(this.Surnom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.label1);
            this.Name = "Add_player";
            this.Text = "Add_player";
            ((System.ComponentModel.ISupportInitialize)(this.player_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button add_player_image;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox nom;
        public System.Windows.Forms.TextBox prenom;
        public System.Windows.Forms.TextBox Surnom;
        public System.Windows.Forms.PictureBox player_image;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.Label image_path;
    }
}