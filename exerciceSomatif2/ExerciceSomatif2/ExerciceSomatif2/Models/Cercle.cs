using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ExerciceSomatif2.Models
{
    public  class Cercle : Forme
    {
        
        public Cercle() : base(Color.Orange)
        {
            
        }
      
        protected override void Dessiner(Graphics graphics)
        {
            
            graphics.DrawEllipse(new Pen(couleur,3), 0, 0, 90, 90);
        }

        public override string ObtenirType()
        {
            return "cercle";
        }
    }
}
