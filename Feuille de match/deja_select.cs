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

        public void set_joueur_en_double(List<string> joueurs)
        {
            foreach (string joueur in joueurs)
            {
                this.joueurs.Text += joueur + ", ";
            }
            this.joueurs.Text = this.joueurs.Text.Substring(0, this.joueurs.Text.Length - 2);
        }

    }
}
