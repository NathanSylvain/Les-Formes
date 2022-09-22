using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace ExerciceSomatif2.Models
{
    public class RectanglePlein : Rectangle
    {
        public RectanglePlein() : base()
        {

        }

        protected override void Dessiner(Graphics graphics)
        {
            SolidBrush brush = new SolidBrush(couleur);
            graphics.FillRectangle(brush, 0, 0, 90, 70);
        }

        public override string ObtenirType()
        {
            return "rectangle plein";
        }
    }
}
