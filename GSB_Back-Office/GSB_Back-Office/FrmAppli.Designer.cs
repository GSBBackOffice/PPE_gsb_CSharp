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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btnAjouterProduit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.colNomProduit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPresentationProduit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDosageProduit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrixVenteProduit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrixEchantillonProduit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPageProduits.SuspendLayout();
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
            this.tabPageProduits.Controls.Add(this.dataGridView2);
            this.tabPageProduits.Controls.Add(this.button1);
            this.tabPageProduits.Controls.Add(this.btnAjouterProduit);
            this.tabPageProduits.Controls.Add(this.textBox5);
            this.tabPageProduits.Controls.Add(this.textBox4);
            this.tabPageProduits.Controls.Add(this.textBox3);
            this.tabPageProduits.Controls.Add(this.textBox2);
            this.tabPageProduits.Controls.Add(this.textBox1);
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
            // tabPagePraticiens
            // 
            this.tabPagePraticiens.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPagePraticiens.Location = new System.Drawing.Point(4, 24);
            this.tabPagePraticiens.Name = "tabPagePraticiens";
            this.tabPagePraticiens.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePraticiens.Size = new System.Drawing.Size(754, 335);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Présentation :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dosage :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(325, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prixe de Vente HT :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(325, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Prix Echantillon :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(135, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(135, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(135, 86);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(455, 30);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(455, 58);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 9;
            // 
            // btnAjouterProduit
            // 
            this.btnAjouterProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterProduit.Location = new System.Drawing.Point(431, 86);
            this.btnAjouterProduit.Name = "btnAjouterProduit";
            this.btnAjouterProduit.Size = new System.Drawing.Size(124, 23);
            this.btnAjouterProduit.TabIndex = 10;
            this.btnAjouterProduit.Text = "Ajouter";
            this.btnAjouterProduit.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(328, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Réinitialiser";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNomProduit,
            this.colPresentationProduit,
            this.colDosageProduit,
            this.colPrixVenteProduit,
            this.colPrixEchantillonProduit});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.Location = new System.Drawing.Point(60, 134);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(519, 150);
            this.dataGridView2.TabIndex = 12;
            // 
            // colNomProduit
            // 
            this.colNomProduit.HeaderText = "Nom";
            this.colNomProduit.Name = "colNomProduit";
            // 
            // colPresentationProduit
            // 
            this.colPresentationProduit.HeaderText = "Présentation";
            this.colPresentationProduit.Name = "colPresentationProduit";
            // 
            // colDosageProduit
            // 
            this.colDosageProduit.HeaderText = "Dosage";
            this.colDosageProduit.Name = "colDosageProduit";
            // 
            // colPrixVenteProduit
            // 
            this.colPrixVenteProduit.HeaderText = "Prix de Vente";
            this.colPrixVenteProduit.Name = "colPrixVenteProduit";
            // 
            // colPrixEchantillonProduit
            // 
            this.colPrixEchantillonProduit.HeaderText = "Prix Echantillon";
            this.colPrixEchantillonProduit.Name = "colPrixEchantillonProduit";
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAjouterProduit;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomProduit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPresentationProduit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDosageProduit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrixVenteProduit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrixEchantillonProduit;
    }
}