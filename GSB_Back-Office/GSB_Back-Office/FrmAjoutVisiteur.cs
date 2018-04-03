using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSB_Back_Office
{
    public partial class FrmAjoutVisiteur : Form
    {
        private bool condi;
        public FrmAjoutVisiteur()
        {
            InitializeComponent();
        }

        private void btnAjoutVisiteur_Click(object sender, EventArgs e)
        {

            Visiteur visiteur = new Visiteur(txbNomVisiteurAjout.Text, txbPrenomVisiteurAjout.Text,
                txbAdresseVisiteurAjout.Text, txbCPVisiteurAjout.Text, txbVilleVisiteurAjout.Text, dtpEmbauche.Text, cbxAjoutSecteurVisiteur.Text);
            Visiteur.ajouterVisiteur(visiteur);
          
             

            // FrmAjoutVisiteur frmAjoutVis = new FrmAjoutVisiteur();
            this.Close();
            // frmAjoutVis.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dtpEmbauche_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
