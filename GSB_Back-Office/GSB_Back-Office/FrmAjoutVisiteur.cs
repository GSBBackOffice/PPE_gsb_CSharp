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
        public FrmAjoutVisiteur()
        {
            InitializeComponent();
        }

        private void btnAjoutVisiteur_Click(object sender, EventArgs e)
        {
            Visiteur visiteur = new Visiteur(txbNumVisiteurAjout.Text, txbNomVisiteurAjout.Text, txbPrenomVisiteurAjout.Text,
                txbAdresseVisiteurAjout.Text, txbCPVisiteurAjout.Text, txbVilleVisiteurAjout.Text, txbDateEmbaucheVisiteurAjout.Text);
            Visiteur.lesVisiteurs.Add(visiteur);
            
            FrmAjoutVisiteur frmAjoutVis = new FrmAjoutVisiteur();
            frmAjoutVis.Close();
        }
    }
}
