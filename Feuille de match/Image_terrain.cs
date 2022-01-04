using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feuille_de_match
{
    class Image_terrain
    {
        private Bitmap image;
        private FontFamily police;

        public Image_terrain(Bitmap image)
        {
            this.image = image;
            set_police();
        }

        public void set_police()
        {
            PrivateFontCollection privateFontCollection = new PrivateFontCollection();
            privateFontCollection.AddFontFile("C:\\Users\\louis\\OneDrive\\Documents\\Rugby\\sports_world\\Sports-World-Regular.ttf");
            //this.police = privateFontCollection.Families[0].Name;
            this.police = new FontFamily(privateFontCollection.Families[0].Name, privateFontCollection);
        }

        public Bitmap get_image()
        {
            return this.image;
        }

        public void set_new_player(Point point, Joueur joueur, int position, string image_player_path = null)
        {
            Bitmap image_player;
            if (image_player_path == null)
            {
                image_player = new Bitmap(System.Drawing.Image.FromFile("C:\\Users\\louis\\OneDrive\\Documents\\Rugby\\maillot Lyon 2.jpg"));
            } else
            {
                image_player = new Bitmap(System.Drawing.Image.FromFile(image_player_path));
            }
            using (Graphics graphics = Graphics.FromImage(this.image))
            {
                Font drawFont = new Font(this.police, 8);
                SolidBrush drawBrush = new SolidBrush(Color.Black);

                StringFormat stringFormat = new StringFormat();
                stringFormat.Alignment = StringAlignment.Center;
                stringFormat.LineAlignment = StringAlignment.Center;

                Bitmap player_img = new Bitmap(image_player, new Size(50,50));
                player_img.MakeTransparent();
                graphics.DrawImage(player_img, new Rectangle(point, player_img.Size));
                graphics.DrawString(position + " " + joueur.get_nom_feuille(), drawFont, drawBrush, point.X + 25, point.Y + 50, stringFormat);
            }
        }

        public void set_new_player_remplacant(Point point, Joueur joueur, int position)
        {
            
            using (Graphics graphics = Graphics.FromImage(this.image))
            {
                Font drawFont = new Font(this.police, 10);
                SolidBrush drawBrush = new SolidBrush(Color.Black);

                StringFormat stringFormat = new StringFormat();
                stringFormat.Alignment = StringAlignment.Center;
                stringFormat.LineAlignment = StringAlignment.Center;

                graphics.DrawString(position + " " + joueur.get_nom_feuille(), drawFont, drawBrush, point.X, point.Y, stringFormat);
            }
        }

        public void set_place_date_time(string[] lieu, string date, string heure)
        {
            using (Graphics graphics = Graphics.FromImage(this.image))
            {
                Font drawFont = new Font(this.police, 8);
                SolidBrush drawBrush = new SolidBrush(Color.Black);

                StringFormat stringFormat = new StringFormat();
                //stringFormat.Alignment = StringAlignment.Center;
                //stringFormat.LineAlignment = StringAlignment.Center;

                graphics.DrawString(lieu[0], drawFont, drawBrush, 30, 100, stringFormat);
                graphics.DrawString(lieu[1], drawFont, drawBrush, 30, 120, stringFormat);
                graphics.DrawString(lieu[2], drawFont, drawBrush, 30, 140, stringFormat);

                graphics.DrawString(date, drawFont, drawBrush, 200, 100, stringFormat);
                graphics.DrawString(heure, drawFont, drawBrush, 250, 120, stringFormat);
            }
        }

        public void set_teams_images(Image lyon2, Image adv)
        {
            //20 - 125 px
            using (Graphics graphics = Graphics.FromImage(this.image))
            {
                decimal factor = lyon2.Height / 105;
                Bitmap player_lyon2 = new Bitmap(lyon2, new Size((int)Math.Truncate(lyon2.Width / factor), 105));
                Color transp = new Bitmap(lyon2).GetPixel(1, 1);
                player_lyon2.MakeTransparent(transp);
                graphics.DrawImage(player_lyon2, new Rectangle(new Point(300, 20), player_lyon2.Size));

                if(adv != null)
                {
                    decimal factor2 = adv.Height / 105;
                    Bitmap player_adv = new Bitmap(adv, new Size((int)Math.Truncate(adv.Width / factor2), 105));
                    player_lyon2.MakeTransparent();
                    graphics.DrawImage(player_adv, new Rectangle(new Point(480, 20), player_adv.Size));
                }
            }
        }
    }
}
