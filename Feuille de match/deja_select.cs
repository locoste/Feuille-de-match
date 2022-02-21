using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Feuille_de_match
{
    public partial class deja_select : Form
    {
        public deja_select()
        {
            InitializeComponent();
        }

        public void set_joueur_en_double(List<string> joueurs, List<Joueur> joueurs_positionne)
        {
            foreach (string joueur in joueurs.Distinct())
            {
                string poste_double = "(";
                for(int i = 0; i <joueurs_positionne.Count; i++)
                {
                    if (joueurs_positionne[i].nom_complet() == joueur)
                    {
                        poste_double += (i + 1).ToString() + ", ";
                    }
                }
                poste_double = poste_double.Substring(0, poste_double.Length - 2);
                poste_double += ")";
                this.joueurs.Text += joueur + poste_double +"\n";
                this.joueurs.TextAlign = ContentAlignment.MiddleCenter;
            }
            //this.joueurs.Text = this.joueurs.Text.Substring(0, this.joueurs.Text.Length - 2);
        }

    }
}
