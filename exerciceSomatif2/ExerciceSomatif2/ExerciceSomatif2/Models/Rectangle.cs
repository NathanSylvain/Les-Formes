using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace ExerciceSomatif2.Models
{
    public class Rectangle:Forme
    {
        public Rectangle():base(Color.Green)
        {

        }

        protected override void Dessiner(Graphics graphics)
        {
            graphics.DrawRectangle(new Pen(couleur,3),0, 0, 90, 60);

        }

        public override string ObtenirType()
        {
            return "Rectangle";
        }
    }
}
