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
    public partial class FrmAjoutPraticien : Form
    {
        public FrmAjoutPraticien()
        {
            InitializeComponent();
        }

        private void btnAjoutPraticien_Click(object sender, EventArgs e)
        {
            Praticien praticien = new Praticien();
            praticien.ajouterPraticien(txbCodePraticienAjout.ToString(), txbRaisonSocPraticienAjout.ToString(), txbAdressePraticienAjout.ToString(), txbTelPraticienAjout.ToString(), txbContactPraticienAjout.ToString(), txbCoefNotorietePraticienAjout.ToString(), txbCoeffConfiancePraticienAjout.ToString(), txbSpécialitePraticienAjout.ToString());
        }
    }
}
