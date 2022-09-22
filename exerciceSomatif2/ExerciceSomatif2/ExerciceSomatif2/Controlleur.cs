using ExerciceSomatif2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExerciceSomatif2.Models;
using System.Drawing;
using Rectangle = ExerciceSomatif2.Models.Rectangle;

namespace ExerciceSomatif2
{
    public class Controlleur
    {

        private Forme formeCourante;
        private readonly Random random;
        private Forme[] formes;
        private string type;


        public Forme FormeCourante { get => formeCourante; }

        public event EventHandler<Forme> TypeChanged;

        public string Type { get => type; }

        public Controlleur()
        {
            random = new Random();
            formes = new Forme[4];
            formes[0] = new Rectangle();
            formes[1] = new RectanglePlein();
            formes[2] = new Cercle();
            formes[3] = new CerclePlein();
        }

        public Forme ChoisirTypeFormeHasard()
        {
            
            Forme nouvelleForme = formes[random.Next(4)];
            if (formeCourante== nouvelleForme)
            {
                return nouvelleForme = formes[random.Next(4)];
            }
            else
            {
                formeCourante = nouvelleForme;

                type = nouvelleForme.ObtenirType();
                return formeCourante;
            }
            
            
            
        }

        public void ChangerForme()
        {
            ChoisirTypeFormeHasard();
            formeCourante.Dessiner();

        }

        public void Dessiner()
        {
            TypeChanged?.Invoke(this, ChoisirTypeFormeHasard());
        }
    }
}
