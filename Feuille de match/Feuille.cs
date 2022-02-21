using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Feuille_de_match
{
    public partial class Feuille : Form
    {
        private Equipe equipe;
        private List<Poste> postes;
        private Image_terrain image;
        private List<Joueur> joueurs_positionne;
        private List<string> tmp_joueur;

        public Feuille()
        {
            InitializeComponent();
            this.equipe = new Equipe();
            //this.field_image.Image = System.Drawing.Image.FromFile("C:\\Users\\louis\\OneDrive\\Documents\\Rugby\\terrain.jpg");

            //this.image = new Image(new Bitmap(this.field_image.Image));
            this.postes = new List<Poste>(0);
            this.tmp_joueur = new List<string>();
            set_position();
        }

        private void set_position()
        {
            string[] postes_list = System.IO.File.ReadAllLines(".\\Position.txt");
            string[] coo = System.IO.File.ReadAllLines(".\\Coordonnees.txt");
            string[] joueurs = System.IO.File.ReadAllLines(".\\Joueur.txt");

            for (int i = 0; i< postes_list.Length; i++)
            {
                string[] c = coo[i].Split(',');
                postes.Add(new Poste(i + 1, postes_list[i], int.Parse(c[0]), int.Parse(c[1])));
                this.positions.Items.Add((i + 1) + " " + postes_list[i]);
                this.tmp_joueur.Add(" ");
            }
            foreach(string joueur in joueurs)
            {
                Joueur j = new Joueur(joueur.Split(',')[0], joueur.Split(',')[1]);
                if(joueur.Split(',').Length == 3)
                {
                    j.set_joueur_image(joueur.Split(' ')[2]);
                }
                this.equipe.add_player(j);
                this.list_players.Items.Add(j.nom_liste());
            }
            this.joueurs_positionne = new List<Joueur>();
            for (int i = 0; i < postes_list.Length; i++)
            {
                this.joueurs_positionne.Add(new Joueur());
                this.joueurs_positionne[i].set_poste(postes[i]);
            }
        }

        private void add_player_Click(object sender, EventArgs e)
        {
            Add_player add_player = new Add_player();

            add_player.ShowDialog();

            if(add_player.DialogResult == DialogResult.OK)
            {
                Joueur joueur = new Joueur(add_player.prenom.Text, add_player.nom.Text);
                if (add_player.Surnom.Text != "")
                {
                    joueur.set_surnom(add_player.Surnom.Text);
                }
                if (add_player.player_image.Image != null)
                {
                    joueur.set_joueur_image(add_player.image_path.Text);
                }
                this.equipe.add_player(joueur);
         
                this.list_players.Items.Add(joueur.nom_liste());

                File.AppendAllText(@".\\Joueur.txt", Environment.NewLine + joueur.nom_complet());

            }
        }

        private void position_button_Click(object sender, EventArgs e)
        {
            if (this.positions.SelectedItem != null && this.list_players.SelectedIndex != -1)
            {
                
                    switch (this.positions.SelectedIndex)
                    {
                        case 0:
                            this.nom1.Text = this.list_players.SelectedItem.ToString();
                            break;
                        case 1:
                            this.nom2.Text = this.list_players.SelectedItem.ToString();
                            break;
                        case 2:
                            this.nom3.Text = this.list_players.SelectedItem.ToString();
                            break;
                        case 3:
                            this.nom4.Text = this.list_players.SelectedItem.ToString();
                            break;
                        case 4:
                            this.nom5.Text = this.list_players.SelectedItem.ToString();
                            break;
                        case 5:
                            this.nom6.Text = this.list_players.SelectedItem.ToString();
                            break;
                        case 6:
                            this.nom7.Text = this.list_players.SelectedItem.ToString();
                            break;
                        case 7:
                            this.nom8.Text = this.list_players.SelectedItem.ToString();
                            break;
                        case 8:
                            this.nom9.Text = this.list_players.SelectedItem.ToString();
                            break;
                        case 9:
                            this.nom10.Text = this.list_players.SelectedItem.ToString();
                            break;
                        case 10:
                            this.nom11.Text = this.list_players.SelectedItem.ToString();
                            break;
                        case 11:
                            this.nom12.Text = this.list_players.SelectedItem.ToString();
                            break;
                        case 12:
                            this.nom13.Text = this.list_players.SelectedItem.ToString();
                            break;
                        case 13:
                            this.nom14.Text = this.list_players.SelectedItem.ToString();
                            break;
                        case 14:
                            this.nom15.Text = this.list_players.SelectedItem.ToString();
                            break;
                        case 15:
                            this.nom16.Text = this.list_players.SelectedItem.ToString();
                            break;
                        case 16:
                            this.nom17.Text = this.list_players.SelectedItem.ToString();
                            break;
                        case 17:
                            this.nom18.Text = this.list_players.SelectedItem.ToString();
                            break;
                        case 18:
                            this.nom19.Text = this.list_players.SelectedItem.ToString();
                            break;
                        case 19:
                            this.nom20.Text = this.list_players.SelectedItem.ToString();
                            break;
                        case 20:
                            this.nom21.Text = this.list_players.SelectedItem.ToString();
                            break;
                        case 21:
                            this.nom22.Text = this.list_players.SelectedItem.ToString();
                            break;
                        case 22:
                            this.nom23.Text = this.list_players.SelectedItem.ToString();
                            break;
                        case 23:
                            this.nomCoach.Text = this.list_players.SelectedItem.ToString();
                            break;
                        case 24:
                            this.nomCoach2.Text = this.list_players.SelectedItem.ToString();
                            break;
                        default:
                            break;
                    }
                    this.tmp_joueur[this.positions.SelectedIndex] = this.list_players.SelectedItem.ToString();
                    this.equipe.get_equipe()[this.list_players.SelectedIndex].set_poste(postes[this.positions.SelectedIndex]);
                    this.joueurs_positionne[this.positions.SelectedIndex] =  this.equipe.get_equipe()[this.list_players.SelectedIndex];
                
            } else
            {
                var message_erreur_form = new message_erreur();
                message_erreur_form.ShowDialog();
                if (message_erreur_form.DialogResult == DialogResult.OK)
                {
                    message_erreur_form.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> tmp_joueur_feuille = new List<string>();
            List<string> joueur_double = new List<string>();
            foreach(Joueur select_joueur in this.joueurs_positionne)
            {
                if (tmp_joueur_feuille.Contains(select_joueur.nom_complet()) & select_joueur.nom_complet() != " ")
                {
                    joueur_double.Add(select_joueur.nom_complet());
                }
                tmp_joueur_feuille.Add(select_joueur.nom_complet());
            }

            if (joueur_double.Count > 0)
            {
                joueur_en_double_windows(joueur_double);
            }
            else
            {
                Feuille_image feuille_match_form = new Feuille_image();
                feuille_match_form.set_image(this.joueurs_positionne, this.lieu_match.Lines, this.date.Text, this.heure.Text, this.image_lyon2.Image, this.image_adv.Image);
                feuille_match_form.Show();
            }
        }

        private void joueur_en_double_windows(List<string> joueur_double)
        {
            deja_select doublons = new deja_select();
            doublons.set_joueur_en_double(joueur_double);
            
            if (doublons.ShowDialog() == DialogResult.OK)
            {
                doublons.Close();
            }
        }

        private void image_adv_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    System.Drawing.Image image1 = System.Drawing.Image.FromFile(filePath);

                    this.image_adv.Image = image1;
                }
            }
        }

        private void get_team_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    Stream openFileStream = File.OpenRead(filePath);
                    BinaryFormatter deserializer = new BinaryFormatter();
                    this.joueurs_positionne = (List<Joueur>)deserializer.Deserialize(openFileStream);
                    for (int i = this.joueurs_positionne.Count; i < this.postes.Count; i++)
                    {
                        this.joueurs_positionne.Add(new Joueur());
                        this.joueurs_positionne[i].set_poste(this.postes[i]);
                    }
                    //TestLoan.TimeLastLoaded = DateTime.Now;
                    openFileStream.Close();

                    set_team_players();
                }
            }
        }

        private void set_team_players()
        {
            this.nom1.Text = this.joueurs_positionne[0].nom_complet();
            this.nom2.Text = this.joueurs_positionne[1].nom_complet();
            this.nom3.Text = this.joueurs_positionne[2].nom_complet();
            this.nom4.Text = this.joueurs_positionne[3].nom_complet();
            this.nom5.Text = this.joueurs_positionne[4].nom_complet();
            this.nom6.Text = this.joueurs_positionne[5].nom_complet();
            this.nom7.Text = this.joueurs_positionne[6].nom_complet();
            this.nom8.Text = this.joueurs_positionne[7].nom_complet();
            this.nom9.Text = this.joueurs_positionne[8].nom_complet();
            this.nom10.Text = this.joueurs_positionne[9].nom_complet();
            this.nom11.Text = this.joueurs_positionne[10].nom_complet();
            this.nom12.Text = this.joueurs_positionne[11].nom_complet();
            this.nom13.Text = this.joueurs_positionne[12].nom_complet();
            this.nom14.Text = this.joueurs_positionne[13].nom_complet();
            this.nom15.Text = this.joueurs_positionne[14].nom_complet();
            if (this.joueurs_positionne.Count >= 16)
            {
                this.nom16.Text = this.joueurs_positionne[15].nom_complet();
            }
            if (this.joueurs_positionne.Count >= 17)
            {
                this.nom17.Text = this.joueurs_positionne[16].nom_complet();
            }
            if (this.joueurs_positionne.Count >= 18)
            {
                this.nom18.Text = this.joueurs_positionne[17].nom_complet();
            }
            if (this.joueurs_positionne.Count >= 19)
            {
                this.nom19.Text = this.joueurs_positionne[18].nom_complet();
            }
            if (this.joueurs_positionne.Count >= 20)
            {
                this.nom20.Text = this.joueurs_positionne[19].nom_complet();
            }
            if (this.joueurs_positionne.Count >= 21)
            {
                this.nom21.Text = this.joueurs_positionne[20].nom_complet();
            }
            if (this.joueurs_positionne.Count >= 22)
            {
                this.nom22.Text = this.joueurs_positionne[21].nom_complet();
            }
            if (this.joueurs_positionne.Count >= 23)
            {
                this.nom23.Text = this.joueurs_positionne[22].nom_complet();
            }
            if (this.joueurs_positionne.Count >= 24)
            {
                this.nomCoach.Text = this.joueurs_positionne[23].nom_complet();
            }
            if (this.joueurs_positionne.Count >= 25)
            {
                this.nomCoach2.Text = this.joueurs_positionne[24].nom_complet();
            }
        }
    }
}
