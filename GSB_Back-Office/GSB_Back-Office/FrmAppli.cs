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
    public partial class FrmAppli : Form
    {
        public FrmAppli()
        {
            InitializeComponent();
        }
        private void FrmAppli_Load(object sender, EventArgs e)
        {
            DAOProduit.initProduits();
        }
        #region practiciens
        private void tabPagePraticiens_Click(object sender, EventArgs e)
        {

        }

        private void btnAjouterPraticien_Click(object sender, EventArgs e)
        {
            FrmAjoutPraticien frmAjoutPRaticien = new FrmAjoutPraticien();
            frmAjoutPRaticien.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void btnAddV_Click(object sender, EventArgs e)
        {
            FrmAjoutVisiteur frmAjoutVisiteur = new FrmAjoutVisiteur();
            frmAjoutVisiteur.Show();
        }

        private void tabPageVisiteurs_Click(object sender, EventArgs e)
        {

        }

        private void btn_ModifV_Click(object sender, EventArgs e)
        {

        }

        
        private void initVisiteur(object sender, EventArgs e)
        {
            
                foreach(Visiteur v in Visiteur.lesVisiteurs)
            {
                dgvVisiteur.Rows.Add(v.NumVisiteur, v.NomVisiteur, v.PrenomVisiteur, v.Adresse, v.CpVisiteur, v.VilleVisiteur, v.DateEmbauche);
            }
        }
        #endregion

        private void tabPageProduits_Enter(object sender, EventArgs e)
        {
            

        }
        private void initCbxProduit()
        {
            foreach(Produit p in Produit.lesProduits)
            {
                cbxProduit.Items.Add(p.NomProduit);
            }
        }
        private void tabPageProduits_Click(object sender, EventArgs e)
        {

        }
    }
}
