using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace ExerciceSomatif2.Models
{
    public class CerclePlein : Cercle
    {
        
        public CerclePlein() : base()
        {
        }

        protected override void Dessiner(Graphics graphics)
        {
            SolidBrush brush = new SolidBrush(couleur);
            graphics.FillEllipse(brush,0, 0, 90, 90);
        }

        public override string ObtenirType()
        {
            return "cercle Plein";
        }
    }
}
