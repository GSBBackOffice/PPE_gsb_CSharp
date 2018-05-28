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
    public partial class FrmIdentification : Form
    {
        public FrmIdentification()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Identification id = new Identification();
            if (id.verifConnexion(txbIdentifiant.Text,txbPassword.Text))
            {
                FrmAppli frmappli = new FrmAppli();
                frmappli.Show();                
            }
            else
            {
                lblIdentification.Text = "Identifiant ou Mot de passe incorrecte";
            }
        }

        private void FrmIdentification_Load(object sender, EventArgs e)
        {

        }
    }
}
