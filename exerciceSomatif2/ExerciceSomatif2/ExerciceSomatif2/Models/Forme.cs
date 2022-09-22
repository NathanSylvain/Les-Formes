using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceSomatif2.Models
{
    public abstract class Forme
    {
        protected Color couleur;

       

        protected Forme(Color couleur)
        {
            this.couleur = couleur;
        }

        protected abstract void Dessiner(Graphics graphics);

        public Bitmap Dessiner()
        {
            Bitmap bitmap = new Bitmap(100, 100);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                Dessiner(graphics);
            }
            
            return bitmap;
        }

        public abstract string ObtenirType();
    }
}
