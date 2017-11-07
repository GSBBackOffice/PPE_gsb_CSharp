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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAppli));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageProduits = new System.Windows.Forms.TabPage();
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
            this.cbxProduit = new System.Windows.Forms.ComboBox();
            this.lblMedicament = new System.Windows.Forms.Label();
            this.dgvInteractionProduit = new System.Windows.Forms.DataGridView();
            this.dgvEffetThera = new System.Windows.Forms.DataGridView();
            this.colNomProduit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInteractionProduit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvContrindication = new System.Windows.Forms.DataGridView();
            this.colContrindication = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEffetThera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPageProduits.SuspendLayout();
            this.tabPageVisiteurs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInteractionProduit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEffetThera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContrindication)).BeginInit();
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
            this.tabPagePraticiens.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPagePraticiens.Location = new System.Drawing.Point(4, 24);
            this.tabPagePraticiens.Name = "tabPagePraticiens";
            this.tabPagePraticiens.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePraticiens.Size = new System.Drawing.Size(757, 463);
            this.tabPagePraticiens.TabIndex = 1;
            this.tabPagePraticiens.Text = "Praticiens";
            this.tabPagePraticiens.UseVisualStyleBackColor = true;
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
            // cbxProduit
            // 
            this.cbxProduit.FormattingEnabled = true;
            this.cbxProduit.Location = new System.Drawing.Point(340, 6);
            this.cbxProduit.Name = "cbxProduit";
            this.cbxProduit.Size = new System.Drawing.Size(121, 24);
            this.cbxProduit.TabIndex = 12;
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
            // dgvInteractionProduit
            // 
            this.dgvInteractionProduit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInteractionProduit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvInteractionProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInteractionProduit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNomProduit,
            this.colInteractionProduit});
            this.dgvInteractionProduit.Location = new System.Drawing.Point(16, 128);
            this.dgvInteractionProduit.Name = "dgvInteractionProduit";
            this.dgvInteractionProduit.Size = new System.Drawing.Size(702, 150);
            this.dgvInteractionProduit.TabIndex = 14;
            // 
            // dgvEffetThera
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvEffetThera.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEffetThera.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEffetThera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEffetThera.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEffetThera});
            this.dgvEffetThera.Location = new System.Drawing.Point(16, 284);
            this.dgvEffetThera.Name = "dgvEffetThera";
            this.dgvEffetThera.Size = new System.Drawing.Size(334, 150);
            this.dgvEffetThera.TabIndex = 15;
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
            // dgvContrindication
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContrindication.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            // colEffetThera
            // 
            this.colEffetThera.HeaderText = "Effets Thérapeutiques";
            this.colEffetThera.Name = "colEffetThera";
            this.colEffetThera.Width = 280;
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
            this.tabPageVisiteurs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInteractionProduit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEffetThera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContrindication)).EndInit();
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
    }
}