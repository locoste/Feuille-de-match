using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feuille_de_match
{
    [Serializable()]
    public class Poste
    {
        private int numero;
        private string poste;

        private int x;
        private int y;

        public Poste(int num, string poste, int x, int y)
        {
            this.numero = num;
            this.poste = poste;
            this.x = x;
            this.y = y;
        }

        public int get_num()
        {
            return this.numero;
        }

        public string get_poste()
        {
            return this.poste;
        }

        public Point get_point()
        {
            return new Point(x, y);
        }
    }
}
