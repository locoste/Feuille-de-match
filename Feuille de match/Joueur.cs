using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feuille_de_match
{
    [Serializable()]
    public class Joueur
    {
        private string nom;
        private string prenom;
        private string surnom;

        private string image_joueur;

        private Poste poste;

        public Joueur(string prenom, string nom)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.surnom = null;
            this.image_joueur = null;
        }

        public Joueur()
        {
            this.nom = " ";
            this.prenom = " ";
        }

        public void set_surnom(string surnom)
        {
            this.surnom = surnom;
        }

        public string nom_complet()
        {
            return this.prenom+ " " + this.nom;
        }

        public string nom_liste()
        {
            return this.prenom + " " + this.nom;
        }

        public string nom_fichier()
        {
            return this.prenom + "," + this.nom;
        }

        public string get_nom_feuille()
        {
            return this.prenom[0] + "." + this.nom;
        }

        public string get_surnom()
        {
            return this.surnom;
        }

        public string get_nom()
        {
            return this.nom;
        }

        public void set_nom(string nom)
        {
            this.nom = nom;
        }

        public void set_prenom(string prenom)
        {
            this.prenom = prenom;
        }

        public string get_joueur_image()
        {
            return this.image_joueur;
        }

        public void set_joueur_image(string image)
        {
            this.image_joueur = image;
        }

        public void set_poste(Poste poste)
        {
            this.poste = poste;
        }

        public Poste get_poste()
        {
            return this.poste;
        }
    }
}
