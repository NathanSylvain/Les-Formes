using ExerciceSomatif2.Controles;
using ExerciceSomatif2.Models;

namespace ExerciceSomatif2
{
    public partial class FormAffichageForme : Form
    {
        private readonly Controlleur controlleur;
       
        public FormAffichageForme()
        {
            InitializeComponent(); 
            controlleur = new Controlleur();
            
            Abonnement();
            

        }

        private void Abonnement()
        {
            controlleur.TypeChanged += Controlleur_TypeChanged;
        }

        private void Controlleur_TypeChanged(object? sender, Models.Forme formeCourante)
        {
            dessinControl1.InitAffichage(formeCourante); 
        }

        private void btnChanger_Click(object sender, EventArgs e)
        {
            controlleur.Dessiner();
            
        }
    }
}