﻿using System;
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

<<<<<<< Updated upstream
        private void FrmAppli_Load(object sender, System.EventArgs e)
        {
             
        }
        private void FrmAppli_Load(object sender, EventArgs e)
        {
            DAOProduit.initProduits();
        }
        #region practiciens
=======

>>>>>>> Stashed changes
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
        private void dgvVisiteur_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbNomVisiteur.Text = dgvVisiteur.CurrentRow.Cells[0].FormattedValue.ToString();
            txbPrenomVisiteur.Text = dgvVisiteur.CurrentRow.Cells[1].FormattedValue.ToString();
            txbAdresseVisiteur.Text = dgvVisiteur.CurrentRow.Cells[2].FormattedValue.ToString();
            txbCPVisiteur.Text = dgvVisiteur.CurrentRow.Cells[3].FormattedValue.ToString();
            txbVilleVisiteur.Text = dgvVisiteur.CurrentRow.Cells[4].FormattedValue.ToString();
            dtpDateVisiteur.Value = Convert.ToDateTime(dgvVisiteur.CurrentRow.Cells[5].FormattedValue);
            string secteur = dgvVisiteur.CurrentRow.Cells[6].FormattedValue.ToString();
            cbxSecteurVisiteur.Text = secteur;
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
<<<<<<< Updated upstream

<<<<<<< HEAD
        
=======
<<<<<<< HEAD
=======

>>>>>>> Stashed changes
        private void FrmAppli_Load(object sender, EventArgs e)
        {
            
            #region Visiteur
            DAOVisiteur.lesVisiteurs2 = DAOVisiteur.allVisiteur();
            dgvVisiteur.DataSource = null;
            dgvVisiteur.DataSource = DAOVisiteur.lesVisiteurs2;
            #endregion

            #region Praticien
            DAOPraticien.toutLesPraticiens = DAOPraticien.affichePraticien();
            dgvPraticiens.DataSource = null;
            dgvPraticiens.DataSource = DAOPraticien.toutLesPraticiens;

            #endregion


        }

<<<<<<< Updated upstream
        private void label14_Click(object sender, EventArgs e)
=======
>>>>>>> CHARLES
=======
        private void label14_Click(object sender, EventArgs e) { }

>>>>>>> Stashed changes
        private void initVisiteur(object sender, EventArgs e)

        {

        }
<<<<<<< Updated upstream
<<<<<<< HEAD
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
=======
<<<<<<< HEAD
<<<<<<< HEAD
=======


>>>>>>> Stashed changes
        /* private void initVisiteur(object sender, EventArgs e)
{

        foreach(Visiteur v in Visiteur.lesVisiteurs)
    {
        dgvVisiteur.Rows.Add( v.NomVisiteur, v.PrenomVisiteur, v.Adresse, v.CpVisiteur, v.VilleVisiteur, v.DateEmbauche , v.SecteurVisiteur);
    }
}*/

        
        private void initPraticien(object sendeer, EventArgs e)
        {

        }
<<<<<<< Updated upstream
>>>>>>> CHARLES

=======
>>>>>>> AXEL

>>>>>>> CHARLES
=======
>>>>>>> Stashed changes
    }
}
