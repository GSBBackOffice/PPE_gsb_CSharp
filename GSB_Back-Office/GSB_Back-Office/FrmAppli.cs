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

        private void tabPagePraticiens_Click(object sender, EventArgs e)
        {

        }

        private void btnAjouterPraticien_Click(object sender, EventArgs e)
        {
            FrmAjoutPraticien frmAjoutPRaticien = new FrmAjoutPraticien();
            frmAjoutPRaticien.Show();
        }
    }
}
