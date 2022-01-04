using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Feuille_de_match
{
    public partial class Feuille_image : Form
    {
        private Image_terrain image;
        private List<Joueur> joueur_list;
        private string date_match;
        public Feuille_image()
        {
            InitializeComponent();
            this.image = new Image_terrain(new Bitmap(System.Drawing.Image.FromFile("C:\\Users\\louis\\OneDrive\\Documents\\Rugby\\Terrain-Fac.jpg")));
            //this.field_image.Image = this.image.get_image();
        }

        public void set_image(List<Joueur> joueurs, string[] lieu, string date, string heure, Image lyon2, Image adv)
        {
            this.joueur_list = joueurs;
            this.date_match = date;

            for (int i = 0; i < joueurs.Count; i++)
            {
                if (joueurs[i].get_poste().get_num() < 16)
                {
                    this.image.set_new_player(joueurs[i].get_poste().get_point(), joueurs[i], joueurs[i].get_poste().get_num(), joueurs[i].get_joueur_image());
                } else
                {
                    this.image.set_new_player_remplacant(joueurs[i].get_poste().get_point(), joueurs[i], joueurs[i].get_poste().get_num());
                }
            }

            this.image.set_teams_images(lyon2, adv);

            this.image.set_place_date_time(lieu, date, heure);

            this.field_image.Image = this.image.get_image();
        }

        private void save_image_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Images|*.png;*.bmp;*.jpg";
            ImageFormat format = ImageFormat.Png;
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(sfd.FileName);
                switch (ext)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                }
                this.field_image.Image.Save(sfd.FileName, format);

                save_team(sfd.FileName);
            }
        }

        private void save_team(string path)
        {
            //string path = @".\\MyTeam_" + this.date_match +".bin";
            path = path.Substring(0, path.LastIndexOf(".")) + ".bin";

            Stream SaveFileStream = File.Create(path);
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(SaveFileStream, this.joueur_list);
            SaveFileStream.Close();
        }
    }
}
