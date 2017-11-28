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
            this.tabPageVisiteurs = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colIdVisiteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomVisiteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrenomVisiteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAdresseVisiteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCpVisiteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVilleVisiteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateEmbaucheVisiteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.colRaisSocPraticien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAdrPraticien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelPraticien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContactPraticien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCoefNotorietePraticien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCoefConfiancePraticien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSpePraticien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txbCodePraticien = new System.Windows.Forms.TextBox();
            this.txbRaisonSocPraticien = new System.Windows.Forms.TextBox();
            this.txbAdressePraticien = new System.Windows.Forms.TextBox();
            this.txbTelPraticien = new System.Windows.Forms.TextBox();
            this.txbSpécialitePraticien = new System.Windows.Forms.TextBox();
            this.txbCoeffConfiancePraticien = new System.Windows.Forms.TextBox();
            this.txbCoefNotorietePraticien = new System.Windows.Forms.TextBox();
            this.txbContactPraticien = new System.Windows.Forms.TextBox();
            this.btnModifierPraticien = new System.Windows.Forms.Button();
            this.btnAjouterPraticien = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageProduits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContrindication)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEffetThera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInteractionProduit)).BeginInit();
            this.tabPagePraticiens.SuspendLayout();
            this.tabPageVisiteurs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
            this.tabPagePraticiens.Controls.Add(this.dataGridView2);
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
            // tabPageVisiteurs
            // 
            this.tabPageVisiteurs.Controls.Add(this.dataGridView1);
            this.tabPageVisiteurs.Location = new System.Drawing.Point(4, 24);
            this.tabPageVisiteurs.Name = "tabPageVisiteurs";
            this.tabPageVisiteurs.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVisiteurs.Size = new System.Drawing.Size(757, 463);
            this.tabPageVisiteurs.TabIndex = 2;
            this.tabPageVisiteurs.Text = "Visiteurs";
            this.tabPageVisiteurs.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdVisiteur,
            this.colNomVisiteur,
            this.colPrenomVisiteur,
            this.colAdresseVisiteur,
            this.colCpVisiteur,
            this.colVilleVisiteur,
            this.colDateEmbaucheVisiteur});
            this.dataGridView1.Location = new System.Drawing.Point(7, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(741, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // colIdVisiteur
            // 
            this.colIdVisiteur.HeaderText = "Id";
            this.colIdVisiteur.Name = "colIdVisiteur";
            // 
            // colNomVisiteur
            // 
            this.colNomVisiteur.HeaderText = "Nom";
            this.colNomVisiteur.Name = "colNomVisiteur";
            // 
            // colPrenomVisiteur
            // 
            this.colPrenomVisiteur.HeaderText = "Prénom";
            this.colPrenomVisiteur.Name = "colPrenomVisiteur";
            // 
            // colAdresseVisiteur
            // 
            this.colAdresseVisiteur.HeaderText = "Adresse";
            this.colAdresseVisiteur.Name = "colAdresseVisiteur";
            // 
            // colCpVisiteur
            // 
            this.colCpVisiteur.HeaderText = "CP";
            this.colCpVisiteur.Name = "colCpVisiteur";
            // 
            // colVilleVisiteur
            // 
            this.colVilleVisiteur.HeaderText = "Ville";
            this.colVilleVisiteur.Name = "colVilleVisiteur";
            // 
            // colDateEmbaucheVisiteur
            // 
            this.colDateEmbaucheVisiteur.HeaderText = "Date d\'embauche";
            this.colDateEmbaucheVisiteur.Name = "colDateEmbaucheVisiteur";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRaisSocPraticien,
            this.colAdrPraticien,
            this.colTelPraticien,
            this.colContactPraticien,
            this.colCoefNotorietePraticien,
            this.colCoefConfiancePraticien,
            this.colSpePraticien});
            this.dataGridView2.Location = new System.Drawing.Point(6, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(745, 298);
            this.dataGridView2.TabIndex = 0;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Code praticien";
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 369);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Adresse";
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(294, 313);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 16);
            this.label10.TabIndex = 5;
            this.label10.Text = "Contact";
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(294, 369);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(152, 16);
            this.label12.TabIndex = 7;
            this.label12.Text = "Coefficient confiance";
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
            // txbCodePraticien
            // 
            this.txbCodePraticien.Location = new System.Drawing.Point(133, 310);
            this.txbCodePraticien.Name = "txbCodePraticien";
            this.txbCodePraticien.Size = new System.Drawing.Size(100, 22);
            this.txbCodePraticien.TabIndex = 9;
            // 
            // txbRaisonSocPraticien
            // 
            this.txbRaisonSocPraticien.Location = new System.Drawing.Point(133, 338);
            this.txbRaisonSocPraticien.Name = "txbRaisonSocPraticien";
            this.txbRaisonSocPraticien.Size = new System.Drawing.Size(100, 22);
            this.txbRaisonSocPraticien.TabIndex = 10;
            // 
            // txbAdressePraticien
            // 
            this.txbAdressePraticien.Location = new System.Drawing.Point(133, 366);
            this.txbAdressePraticien.Name = "txbAdressePraticien";
            this.txbAdressePraticien.Size = new System.Drawing.Size(100, 22);
            this.txbAdressePraticien.TabIndex = 11;
            // 
            // txbTelPraticien
            // 
            this.txbTelPraticien.Location = new System.Drawing.Point(133, 394);
            this.txbTelPraticien.Name = "txbTelPraticien";
            this.txbTelPraticien.Size = new System.Drawing.Size(100, 22);
            this.txbTelPraticien.TabIndex = 12;
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
            // btnAjouterPraticien
            // 
            this.btnAjouterPraticien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterPraticien.Location = new System.Drawing.Point(568, 366);
            this.btnAjouterPraticien.Name = "btnAjouterPraticien";
            this.btnAjouterPraticien.Size = new System.Drawing.Size(183, 50);
            this.btnAjouterPraticien.TabIndex = 18;
            this.btnAjouterPraticien.Text = "Ajouter un Praticien";
            this.btnAjouterPraticien.UseVisualStyleBackColor = true;
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
            this.tabPageVisiteurs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageProduits;
        private System.Windows.Forms.TabPage tabPagePraticiens;
        private System.Windows.Forms.TabPage tabPageVisiteurs;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdVisiteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomVisiteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrenomVisiteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAdresseVisiteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCpVisiteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVilleVisiteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateEmbaucheVisiteur;
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
        private System.Windows.Forms.DataGridView dataGridView2;
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
    }
}