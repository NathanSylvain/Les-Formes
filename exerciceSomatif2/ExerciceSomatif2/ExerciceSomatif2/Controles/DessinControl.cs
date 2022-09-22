using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExerciceSomatif2.Models;

namespace ExerciceSomatif2.Controles
{
    public partial class DessinControl : UserControl
    {
        public Forme forme;

      
        public DessinControl()
        {
            InitializeComponent();
            lblAType.Text = "";
        }
 
        public void InitAffichage(Forme formecourante)
        {
            forme = formecourante;
            lblAType.Text = forme.ObtenirType();
            picForme.Image = forme.Dessiner();
        }

    }
}
