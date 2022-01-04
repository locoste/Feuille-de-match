using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feuille_de_match
{
    class Equipe
    {
        private List<Joueur> equipe;

        public Equipe()
        {
            this.equipe = new List<Joueur>(0);
        }

        public List<Joueur> get_equipe()
        {
            return this.equipe;
        }

        public void add_player(Joueur joueur)
        {
            equipe.Add(joueur);
        }
    }
}
