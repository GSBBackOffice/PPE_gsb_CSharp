namespace GSB_Back_Office
{
    partial class FrmAppli
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAppli));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageProduits = new System.Windows.Forms.TabPage();
            this.dgvContrindication = new System.Windows.Forms.DataGridView();
            this.colContrindication = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEffetThera = new System.Windows.Forms.DataGridView();
            this.colEffetThera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvInteractionProduit = new System.Windows.Forms.DataGridView();
            this.colNomProduit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInteractionProduit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMedicament = new System.Windows.Forms.Label();
            this.cbxProduit = new System.Windows.Forms.ComboBox();
            this.btnModifierProduit = new System.Windows.Forms.Button();
            this.txbPrixEchantillonProduit = new System.Windows.Forms.TextBox();
            this.txbPrixVenteProduit = new System.Windows.Forms.TextBox();
            this.txbDosageProduit = new System.Windows.Forms.TextBox();
            this.txbPresentationProduit = new System.Windows.Forms.TextBox();
            this.txbNomProduit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPagePraticiens = new System.Windows.Forms.TabPage();
            this.btnAjouterPraticien = new System.Windows.Forms.Button();
            this.btnModifierPraticien = new System.Windows.Forms.Button();
            this.txbSpécialitePraticien = new System.Windows.Forms.TextBox();
            this.txbCoeffConfiancePraticien = new System.Windows.Forms.TextBox();
            this.txbCoefNotorietePraticien = new System.Windows.Forms.TextBox();
            this.txbContactPraticien = new System.Windows.Forms.TextBox();
            this.txbTelPraticien = new System.Windows.Forms.TextBox();
            this.txbAdressePraticien = new System.Windows.Forms.TextBox();
            this.txbRaisonSocPraticien = new System.Windows.Forms.TextBox();
            this.txbCodePraticien = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvPraticiens = new System.Windows.Forms.DataGridView();
            this.colRaisSocPraticien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAdrPraticien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelPraticien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContactPraticien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCoefNotorietePraticien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCoefConfiancePraticien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSpePraticien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageVisiteurs = new System.Windows.Forms.TabPage();
            this.btnAddV = new System.Windows.Forms.Button();
            this.btn_ModifV = new System.Windows.Forms.Button();
            this.txbVilleVisiteur = new System.Windows.Forms.TextBox();
            this.txbCPVisiteur = new System.Windows.Forms.TextBox();
            this.txbAdresseVisiteur = new System.Windows.Forms.TextBox();
            this.txbPrenomVisiteur = new System.Windows.Forms.TextBox();
            this.txbNomVisiteur = new System.Windows.Forms.TextBox();
            this.txtB_DateV = new System.Windows.Forms.Label();
            this.txtB_VilleV = new System.Windows.Forms.Label();
            this.txtB_CPV = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.dgvVisiteur = new System.Windows.Forms.DataGridView();
            this.dtpDateVisiteur = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.cbxSecteurVisiteur = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageProduits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContrindication)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEffetThera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInteractionProduit)).BeginInit();
            this.tabPagePraticiens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPraticiens)).BeginInit();
            this.tabPageVisiteurs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteur)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageProduits);
            this.tabControl1.Controls.Add(this.tabPagePraticiens);
            this.tabControl1.Controls.Add(this.tabPageVisiteurs);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(60, 20);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(20, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(765, 491);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageProduits
            // 
            this.tabPageProduits.AutoScroll = true;
            this.tabPageProduits.Controls.Add(this.dgvContrindication);
            this.tabPageProduits.Controls.Add(this.dgvEffetThera);
            this.tabPageProduits.Controls.Add(this.dgvInteractionProduit);
            this.tabPageProduits.Controls.Add(this.lblMedicament);
            this.tabPageProduits.Controls.Add(this.cbxProduit);
            this.tabPageProduits.Controls.Add(this.btnModifierProduit);
            this.tabPageProduits.Controls.Add(this.txbPrixEchantillonProduit);
            this.tabPageProduits.Controls.Add(this.txbPrixVenteProduit);
            this.tabPageProduits.Controls.Add(this.txbDosageProduit);
            this.tabPageProduits.Controls.Add(this.txbPresentationProduit);
            this.tabPageProduits.Controls.Add(this.txbNomProduit);
            this.tabPageProduits.Controls.Add(this.label5);
            this.tabPageProduits.Controls.Add(this.label4);
            this.tabPageProduits.Controls.Add(this.label3);
            this.tabPageProduits.Controls.Add(this.label2);
            this.tabPageProduits.Controls.Add(this.label1);
            this.tabPageProduits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageProduits.Location = new System.Drawing.Point(4, 24);
            this.tabPageProduits.Name = "tabPageProduits";
            this.tabPageProduits.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProduits.Size = new System.Drawing.Size(757, 463);
            this.tabPageProduits.TabIndex = 0;
            this.tabPageProduits.Text = "Produits";
            this.tabPageProduits.UseVisualStyleBackColor = true;
            // 
            // dgvContrindication
            // 
            this.dgvContrindication.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContrindication.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colContrindication});
            this.dgvContrindication.Location = new System.Drawing.Point(384, 284);
            this.dgvContrindication.Name = "dgvContrindication";
            this.dgvContrindication.Size = new System.Drawing.Size(334, 150);
            this.dgvContrindication.TabIndex = 16;
            // 
            // colContrindication
            // 
            this.colContrindication.HeaderText = "Contrindication";
            this.colContrindication.Name = "colContrindication";
            this.colContrindication.Width = 280;
            // 
            // dgvEffetThera
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvEffetThera.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEffetThera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEffetThera.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEffetThera});
            this.dgvEffetThera.Location = new System.Drawing.Point(16, 284);
            this.dgvEffetThera.Name = "dgvEffetThera";
            this.dgvEffetThera.Size = new System.Drawing.Size(334, 150);
            this.dgvEffetThera.TabIndex = 15;
            // 
            // colEffetThera
            // 
            this.colEffetThera.HeaderText = "Effets Thérapeutiques";
            this.colEffetThera.Name = "colEffetThera";
            this.colEffetThera.Width = 280;
            // 
            // dgvInteractionProduit
            // 
            this.dgvInteractionProduit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInteractionProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInteractionProduit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNomProduit,
            this.colInteractionProduit});
            this.dgvInteractionProduit.Location = new System.Drawing.Point(16, 128);
            this.dgvInteractionProduit.Name = "dgvInteractionProduit";
            this.dgvInteractionProduit.Size = new System.Drawing.Size(702, 150);
            this.dgvInteractionProduit.TabIndex = 14;
            // 
            // colNomProduit
            // 
            this.colNomProduit.HeaderText = "Médicament";
            this.colNomProduit.Name = "colNomProduit";
            this.colNomProduit.Width = 150;
            // 
            // colInteractionProduit
            // 
            this.colInteractionProduit.HeaderText = "Interactions";
            this.colInteractionProduit.Name = "colInteractionProduit";
            this.colInteractionProduit.Width = 500;
            // 
            // lblMedicament
            // 
            this.lblMedicament.AutoSize = true;
            this.lblMedicament.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicament.Location = new System.Drawing.Point(224, 9);
            this.lblMedicament.Name = "lblMedicament";
            this.lblMedicament.Size = new System.Drawing.Size(88, 16);
            this.lblMedicament.TabIndex = 13;
            this.lblMedicament.Text = "Médicament :";
            // 
            // cbxProduit
            // 
            this.cbxProduit.FormattingEnabled = true;
            this.cbxProduit.Location = new System.Drawing.Point(340, 6);
            this.cbxProduit.Name = "cbxProduit";
            this.cbxProduit.Size = new System.Drawing.Size(121, 24);
            this.cbxProduit.TabIndex = 12;
            // 
            // btnModifierProduit
            // 
            this.btnModifierProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifierProduit.Location = new System.Drawing.Point(397, 90);
            this.btnModifierProduit.Name = "btnModifierProduit";
            this.btnModifierProduit.Size = new System.Drawing.Size(227, 23);
            this.btnModifierProduit.TabIndex = 10;
            this.btnModifierProduit.Text = "Modifier";
            this.btnModifierProduit.UseVisualStyleBackColor = true;
            // 
            // txbPrixEchantillonProduit
            // 
            this.txbPrixEchantillonProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPrixEchantillonProduit.Location = new System.Drawing.Point(524, 62);
            this.txbPrixEchantillonProduit.Name = "txbPrixEchantillonProduit";
            this.txbPrixEchantillonProduit.Size = new System.Drawing.Size(100, 22);
            this.txbPrixEchantillonProduit.TabIndex = 9;
            // 
            // txbPrixVenteProduit
            // 
            this.txbPrixVenteProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPrixVenteProduit.Location = new System.Drawing.Point(524, 34);
            this.txbPrixVenteProduit.Name = "txbPrixVenteProduit";
            this.txbPrixVenteProduit.Size = new System.Drawing.Size(100, 22);
            this.txbPrixVenteProduit.TabIndex = 8;
            // 
            // txbDosageProduit
            // 
            this.txbDosageProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDosageProduit.Location = new System.Drawing.Point(204, 90);
            this.txbDosageProduit.Name = "txbDosageProduit";
            this.txbDosageProduit.Size = new System.Drawing.Size(100, 22);
            this.txbDosageProduit.TabIndex = 7;
            // 
            // txbPresentationProduit
            // 
            this.txbPresentationProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPresentationProduit.Location = new System.Drawing.Point(204, 62);
            this.txbPresentationProduit.Name = "txbPresentationProduit";
            this.txbPresentationProduit.Size = new System.Drawing.Size(100, 22);
            this.txbPresentationProduit.TabIndex = 6;
            // 
            // txbNomProduit
            // 
            this.txbNomProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNomProduit.Location = new System.Drawing.Point(204, 34);
            this.txbNomProduit.Name = "txbNomProduit";
            this.txbNomProduit.Size = new System.Drawing.Size(100, 22);
            this.txbNomProduit.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(394, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Prix Echantillon :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(394, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prixe de Vente HT :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(126, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dosage :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Présentation :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom :";
            // 
            // tabPagePraticiens
            // 
            this.tabPagePraticiens.Controls.Add(this.btnAjouterPraticien);
            this.tabPagePraticiens.Controls.Add(this.btnModifierPraticien);
            this.tabPagePraticiens.Controls.Add(this.txbSpécialitePraticien);
            this.tabPagePraticiens.Controls.Add(this.txbCoeffConfiancePraticien);
            this.tabPagePraticiens.Controls.Add(this.txbCoefNotorietePraticien);
            this.tabPagePraticiens.Controls.Add(this.txbContactPraticien);
            this.tabPagePraticiens.Controls.Add(this.txbTelPraticien);
            this.tabPagePraticiens.Controls.Add(this.txbAdressePraticien);
            this.tabPagePraticiens.Controls.Add(this.txbRaisonSocPraticien);
            this.tabPagePraticiens.Controls.Add(this.txbCodePraticien);
            this.tabPagePraticiens.Controls.Add(this.label13);
            this.tabPagePraticiens.Controls.Add(this.label12);
            this.tabPagePraticiens.Controls.Add(this.label11);
            this.tabPagePraticiens.Controls.Add(this.label10);
            this.tabPagePraticiens.Controls.Add(this.label9);
            this.tabPagePraticiens.Controls.Add(this.label8);
            this.tabPagePraticiens.Controls.Add(this.label7);
            this.tabPagePraticiens.Controls.Add(this.label6);
            this.tabPagePraticiens.Controls.Add(this.dgvPraticiens);
            this.tabPagePraticiens.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPagePraticiens.Location = new System.Drawing.Point(4, 24);
            this.tabPagePraticiens.Name = "tabPagePraticiens";
            this.tabPagePraticiens.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePraticiens.Size = new System.Drawing.Size(757, 463);
            this.tabPagePraticiens.TabIndex = 1;
            this.tabPagePraticiens.Text = "Praticiens";
            this.tabPagePraticiens.UseVisualStyleBackColor = true;
            this.tabPagePraticiens.Click += new System.EventHandler(this.tabPagePraticiens_Click);
            // 
            // btnAjouterPraticien
            // 
            this.btnAjouterPraticien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterPraticien.Location = new System.Drawing.Point(568, 366);
            this.btnAjouterPraticien.Name = "btnAjouterPraticien";
            this.btnAjouterPraticien.Size = new System.Drawing.Size(183, 50);
            this.btnAjouterPraticien.TabIndex = 18;
            this.btnAjouterPraticien.Text = "Ajouter un Praticien";
            this.btnAjouterPraticien.UseVisualStyleBackColor = true;
            this.btnAjouterPraticien.Click += new System.EventHandler(this.btnAjouterPraticien_Click);
            // 
            // btnModifierPraticien
            // 
            this.btnModifierPraticien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifierPraticien.Location = new System.Drawing.Point(568, 310);
            this.btnModifierPraticien.Name = "btnModifierPraticien";
            this.btnModifierPraticien.Size = new System.Drawing.Size(183, 50);
            this.btnModifierPraticien.TabIndex = 17;
            this.btnModifierPraticien.Text = "Modifier";
            this.btnModifierPraticien.UseVisualStyleBackColor = true;
            // 
            // txbSpécialitePraticien
            // 
            this.txbSpécialitePraticien.Location = new System.Drawing.Point(450, 394);
            this.txbSpécialitePraticien.Name = "txbSpécialitePraticien";
            this.txbSpécialitePraticien.Size = new System.Drawing.Size(100, 22);
            this.txbSpécialitePraticien.TabIndex = 16;
            // 
            // txbCoeffConfiancePraticien
            // 
            this.txbCoeffConfiancePraticien.Location = new System.Drawing.Point(450, 366);
            this.txbCoeffConfiancePraticien.Name = "txbCoeffConfiancePraticien";
            this.txbCoeffConfiancePraticien.Size = new System.Drawing.Size(100, 22);
            this.txbCoeffConfiancePraticien.TabIndex = 15;
            // 
            // txbCoefNotorietePraticien
            // 
            this.txbCoefNotorietePraticien.Location = new System.Drawing.Point(450, 338);
            this.txbCoefNotorietePraticien.Name = "txbCoefNotorietePraticien";
            this.txbCoefNotorietePraticien.Size = new System.Drawing.Size(100, 22);
            this.txbCoefNotorietePraticien.TabIndex = 14;
            // 
            // txbContactPraticien
            // 
            this.txbContactPraticien.Location = new System.Drawing.Point(450, 310);
            this.txbContactPraticien.Name = "txbContactPraticien";
            this.txbContactPraticien.Size = new System.Drawing.Size(100, 22);
            this.txbContactPraticien.TabIndex = 13;
            // 
            // txbTelPraticien
            // 
            this.txbTelPraticien.Location = new System.Drawing.Point(133, 394);
            this.txbTelPraticien.Name = "txbTelPraticien";
            this.txbTelPraticien.Size = new System.Drawing.Size(100, 22);
            this.txbTelPraticien.TabIndex = 12;
            // 
            // txbAdressePraticien
            // 
            this.txbAdressePraticien.Location = new System.Drawing.Point(133, 366);
            this.txbAdressePraticien.Name = "txbAdressePraticien";
            this.txbAdressePraticien.Size = new System.Drawing.Size(100, 22);
            this.txbAdressePraticien.TabIndex = 11;
            // 
            // txbRaisonSocPraticien
            // 
            this.txbRaisonSocPraticien.Location = new System.Drawing.Point(133, 338);
            this.txbRaisonSocPraticien.Name = "txbRaisonSocPraticien";
            this.txbRaisonSocPraticien.Size = new System.Drawing.Size(100, 22);
            this.txbRaisonSocPraticien.TabIndex = 10;
            // 
            // txbCodePraticien
            // 
            this.txbCodePraticien.Location = new System.Drawing.Point(133, 310);
            this.txbCodePraticien.Name = "txbCodePraticien";
            this.txbCodePraticien.Size = new System.Drawing.Size(100, 22);
            this.txbCodePraticien.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(294, 397);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 16);
            this.label13.TabIndex = 8;
            this.label13.Text = "Spécialité";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(294, 369);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(152, 16);
            this.label12.TabIndex = 7;
            this.label12.Text = "Coefficient confiance";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(294, 341);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 16);
            this.label11.TabIndex = 6;
            this.label11.Text = "Coefficient notoriété";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(294, 313);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 16);
            this.label10.TabIndex = 5;
            this.label10.Text = "Contact";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 399);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "Téléphone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 369);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Adresse";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Raison Sociale";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Code praticien";
            // 
            // dgvPraticiens
            // 
            this.dgvPraticiens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPraticiens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRaisSocPraticien,
            this.colAdrPraticien,
            this.colTelPraticien,
            this.colContactPraticien,
            this.colCoefNotorietePraticien,
            this.colCoefConfiancePraticien,
            this.colSpePraticien});
            this.dgvPraticiens.Location = new System.Drawing.Point(6, 6);
            this.dgvPraticiens.Name = "dgvPraticiens";
            this.dgvPraticiens.Size = new System.Drawing.Size(745, 298);
            this.dgvPraticiens.TabIndex = 0;
            // 
            // colRaisSocPraticien
            // 
            this.colRaisSocPraticien.HeaderText = "Raison Sociale Praticien";
            this.colRaisSocPraticien.Name = "colRaisSocPraticien";
            // 
            // colAdrPraticien
            // 
            this.colAdrPraticien.HeaderText = "Adresse";
            this.colAdrPraticien.Name = "colAdrPraticien";
            // 
            // colTelPraticien
            // 
            this.colTelPraticien.HeaderText = "Telephone";
            this.colTelPraticien.Name = "colTelPraticien";
            // 
            // colContactPraticien
            // 
            this.colContactPraticien.HeaderText = "Contact";
            this.colContactPraticien.Name = "colContactPraticien";
            // 
            // colCoefNotorietePraticien
            // 
            this.colCoefNotorietePraticien.HeaderText = "Coefficient Notoriété";
            this.colCoefNotorietePraticien.Name = "colCoefNotorietePraticien";
            // 
            // colCoefConfiancePraticien
            // 
            this.colCoefConfiancePraticien.HeaderText = "Coefficient Confiance";
            this.colCoefConfiancePraticien.Name = "colCoefConfiancePraticien";
            // 
            // colSpePraticien
            // 
            this.colSpePraticien.HeaderText = "Spécialité";
            this.colSpePraticien.Name = "colSpePraticien";
            // 
            // tabPageVisiteurs
            // 
            this.tabPageVisiteurs.Controls.Add(this.button1);
            this.tabPageVisiteurs.Controls.Add(this.cbxSecteurVisiteur);
            this.tabPageVisiteurs.Controls.Add(this.label14);
            this.tabPageVisiteurs.Controls.Add(this.dtpDateVisiteur);
            this.tabPageVisiteurs.Controls.Add(this.btnAddV);
            this.tabPageVisiteurs.Controls.Add(this.btn_ModifV);
            this.tabPageVisiteurs.Controls.Add(this.txbVilleVisiteur);
            this.tabPageVisiteurs.Controls.Add(this.txbCPVisiteur);
            this.tabPageVisiteurs.Controls.Add(this.txbAdresseVisiteur);
            this.tabPageVisiteurs.Controls.Add(this.txbPrenomVisiteur);
            this.tabPageVisiteurs.Controls.Add(this.txbNomVisiteur);
            this.tabPageVisiteurs.Controls.Add(this.txtB_DateV);
            this.tabPageVisiteurs.Controls.Add(this.txtB_VilleV);
            this.tabPageVisiteurs.Controls.Add(this.txtB_CPV);
            this.tabPageVisiteurs.Controls.Add(this.label18);
            this.tabPageVisiteurs.Controls.Add(this.label19);
            this.tabPageVisiteurs.Controls.Add(this.label20);
            this.tabPageVisiteurs.Controls.Add(this.dgvVisiteur);
            this.tabPageVisiteurs.Location = new System.Drawing.Point(4, 24);
            this.tabPageVisiteurs.Name = "tabPageVisiteurs";
            this.tabPageVisiteurs.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVisiteurs.Size = new System.Drawing.Size(757, 463);
            this.tabPageVisiteurs.TabIndex = 2;
            this.tabPageVisiteurs.Text = "Visiteurs";
            this.tabPageVisiteurs.UseVisualStyleBackColor = true;
            this.tabPageVisiteurs.Click += new System.EventHandler(this.tabPageVisiteurs_Click);
            // 
            // btnAddV
            // 
            this.btnAddV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddV.Location = new System.Drawing.Point(561, 368);
            this.btnAddV.Name = "btnAddV";
            this.btnAddV.Size = new System.Drawing.Size(183, 37);
            this.btnAddV.TabIndex = 36;
            this.btnAddV.Text = "Ajouter un Visiteur";
            this.btnAddV.UseVisualStyleBackColor = true;
            this.btnAddV.Click += new System.EventHandler(this.btnAddV_Click);
            // 
            // btn_ModifV
            // 
            this.btn_ModifV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ModifV.Location = new System.Drawing.Point(561, 328);
            this.btn_ModifV.Name = "btn_ModifV";
            this.btn_ModifV.Size = new System.Drawing.Size(183, 34);
            this.btn_ModifV.TabIndex = 35;
            this.btn_ModifV.Text = "Modifier";
            this.btn_ModifV.UseVisualStyleBackColor = true;
            this.btn_ModifV.Click += new System.EventHandler(this.btn_ModifV_Click);
            // 
            // txbVilleVisiteur
            // 
            this.txbVilleVisiteur.Location = new System.Drawing.Point(446, 356);
            this.txbVilleVisiteur.Name = "txbVilleVisiteur";
            this.txbVilleVisiteur.Size = new System.Drawing.Size(100, 22);
            this.txbVilleVisiteur.TabIndex = 32;
            // 
            // txbCPVisiteur
            // 
            this.txbCPVisiteur.Location = new System.Drawing.Point(446, 328);
            this.txbCPVisiteur.Name = "txbCPVisiteur";
            this.txbCPVisiteur.Size = new System.Drawing.Size(100, 22);
            this.txbCPVisiteur.TabIndex = 31;
            // 
            // txbAdresseVisiteur
            // 
            this.txbAdresseVisiteur.Location = new System.Drawing.Point(129, 384);
            this.txbAdresseVisiteur.Name = "txbAdresseVisiteur";
            this.txbAdresseVisiteur.Size = new System.Drawing.Size(100, 22);
            this.txbAdresseVisiteur.TabIndex = 30;
            // 
            // txbPrenomVisiteur
            // 
            this.txbPrenomVisiteur.Location = new System.Drawing.Point(129, 356);
            this.txbPrenomVisiteur.Name = "txbPrenomVisiteur";
            this.txbPrenomVisiteur.Size = new System.Drawing.Size(100, 22);
            this.txbPrenomVisiteur.TabIndex = 29;
            // 
            // txbNomVisiteur
            // 
            this.txbNomVisiteur.Location = new System.Drawing.Point(129, 328);
            this.txbNomVisiteur.Name = "txbNomVisiteur";
            this.txbNomVisiteur.Size = new System.Drawing.Size(100, 22);
            this.txbNomVisiteur.TabIndex = 28;
            // 
            // txtB_DateV
            // 
            this.txtB_DateV.AutoSize = true;
            this.txtB_DateV.Location = new System.Drawing.Point(290, 389);
            this.txtB_DateV.Name = "txtB_DateV";
            this.txtB_DateV.Size = new System.Drawing.Size(121, 16);
            this.txtB_DateV.TabIndex = 25;
            this.txtB_DateV.Text = "Date d\'embauche :";
            // 
            // txtB_VilleV
            // 
            this.txtB_VilleV.AutoSize = true;
            this.txtB_VilleV.Location = new System.Drawing.Point(290, 359);
            this.txtB_VilleV.Name = "txtB_VilleV";
            this.txtB_VilleV.Size = new System.Drawing.Size(43, 16);
            this.txtB_VilleV.TabIndex = 24;
            this.txtB_VilleV.Text = "Ville : ";
            // 
            // txtB_CPV
            // 
            this.txtB_CPV.AutoSize = true;
            this.txtB_CPV.Location = new System.Drawing.Point(290, 331);
            this.txtB_CPV.Name = "txtB_CPV";
            this.txtB_CPV.Size = new System.Drawing.Size(88, 16);
            this.txtB_CPV.TabIndex = 23;
            this.txtB_CPV.Text = "Code Postal :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(14, 389);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 16);
            this.label18.TabIndex = 22;
            this.label18.Text = "Adresse :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(14, 359);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(61, 16);
            this.label19.TabIndex = 21;
            this.label19.Text = "Prénom :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(14, 331);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(43, 16);
            this.label20.TabIndex = 20;
            this.label20.Text = "Nom :";
            // 
            // dgvVisiteur
            // 
            this.dgvVisiteur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisiteur.Location = new System.Drawing.Point(14, 6);
            this.dgvVisiteur.Name = "dgvVisiteur";
            this.dgvVisiteur.Size = new System.Drawing.Size(730, 316);
            this.dgvVisiteur.TabIndex = 1;
            this.dgvVisiteur.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVisiteur_CellClick);
            this.dgvVisiteur.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dtpDateVisiteur
            // 
            this.dtpDateVisiteur.Location = new System.Drawing.Point(446, 384);
            this.dtpDateVisiteur.Name = "dtpDateVisiteur";
            this.dtpDateVisiteur.Size = new System.Drawing.Size(100, 22);
            this.dtpDateVisiteur.TabIndex = 37;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(290, 418);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 16);
            this.label14.TabIndex = 38;
            this.label14.Text = "Secteur :";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // cbxSecteurVisiteur
            // 
            this.cbxSecteurVisiteur.FormattingEnabled = true;
            this.cbxSecteurVisiteur.Location = new System.Drawing.Point(446, 412);
            this.cbxSecteurVisiteur.Name = "cbxSecteurVisiteur";
            this.cbxSecteurVisiteur.Size = new System.Drawing.Size(100, 24);
            this.cbxSecteurVisiteur.TabIndex = 39;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(561, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 35);
            this.button1.TabIndex = 40;
            this.button1.Text = "Supprimer";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmAppli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 515);
            this.Controls.Add(this.tabControl1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAppli";
            this.Text = "GSB Back-Office";
            this.tabControl1.ResumeLayout(false);
            this.tabPageProduits.ResumeLayout(false);
            this.tabPageProduits.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContrindication)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEffetThera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInteractionProduit)).EndInit();
            this.tabPagePraticiens.ResumeLayout(false);
            this.tabPagePraticiens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPraticiens)).EndInit();
            this.tabPageVisiteurs.ResumeLayout(false);
            this.tabPageVisiteurs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteur)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageProduits;
        private System.Windows.Forms.TabPage tabPagePraticiens;
        private System.Windows.Forms.TabPage tabPageVisiteurs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnModifierProduit;
        private System.Windows.Forms.TextBox txbPrixEchantillonProduit;
        private System.Windows.Forms.TextBox txbPrixVenteProduit;
        private System.Windows.Forms.TextBox txbDosageProduit;
        private System.Windows.Forms.TextBox txbPresentationProduit;
        private System.Windows.Forms.TextBox txbNomProduit;
        private System.Windows.Forms.Label lblMedicament;
        private System.Windows.Forms.ComboBox cbxProduit;
        private System.Windows.Forms.DataGridView dgvContrindication;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContrindication;
        private System.Windows.Forms.DataGridView dgvEffetThera;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEffetThera;
        private System.Windows.Forms.DataGridView dgvInteractionProduit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomProduit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInteractionProduit;
        private System.Windows.Forms.DataGridView dgvPraticiens;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRaisSocPraticien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAdrPraticien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelPraticien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContactPraticien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCoefNotorietePraticien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCoefConfiancePraticien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpePraticien;
        private System.Windows.Forms.TextBox txbSpécialitePraticien;
        private System.Windows.Forms.TextBox txbCoeffConfiancePraticien;
        private System.Windows.Forms.TextBox txbCoefNotorietePraticien;
        private System.Windows.Forms.TextBox txbContactPraticien;
        private System.Windows.Forms.TextBox txbTelPraticien;
        private System.Windows.Forms.TextBox txbAdressePraticien;
        private System.Windows.Forms.TextBox txbRaisonSocPraticien;
        private System.Windows.Forms.TextBox txbCodePraticien;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAjouterPraticien;
        private System.Windows.Forms.Button btnModifierPraticien;
        private System.Windows.Forms.Button btnAddV;
        private System.Windows.Forms.Button btn_ModifV;
        private System.Windows.Forms.TextBox txbVilleVisiteur;
        private System.Windows.Forms.TextBox txbCPVisiteur;
        private System.Windows.Forms.TextBox txbAdresseVisiteur;
        private System.Windows.Forms.TextBox txbPrenomVisiteur;
        private System.Windows.Forms.TextBox txbNomVisiteur;
        private System.Windows.Forms.Label txtB_DateV;
        private System.Windows.Forms.Label txtB_VilleV;
        private System.Windows.Forms.Label txtB_CPV;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridView dgvVisiteur;
        private System.Windows.Forms.DateTimePicker dtpDateVisiteur;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbxSecteurVisiteur;
    }
}