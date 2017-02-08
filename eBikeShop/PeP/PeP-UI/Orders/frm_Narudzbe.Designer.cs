namespace PeP_UI.Orders
{
    partial class frm_Narudzbe
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listSkladista = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBrojNaruzbe = new System.Windows.Forms.Label();
            this.btnProcesiraj = new System.Windows.Forms.Button();
            this.dgStavkeNarudzbe = new System.Windows.Forms.DataGridView();
            this.NarudzbaStavkaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sifra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Iznoss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblIznos = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblKupac = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTrazi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgNarudzbe = new System.Windows.Forms.DataGridView();
            this.NarudzbaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojNarudzbe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Iznos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtDatum = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStavkeNarudzbe)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgNarudzbe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.listSkladista);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblBrojNaruzbe);
            this.groupBox1.Controls.Add(this.btnProcesiraj);
            this.groupBox1.Controls.Add(this.dgStavkeNarudzbe);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblIznos);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblDatum);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblKupac);
            this.groupBox1.Location = new System.Drawing.Point(474, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 438);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalji narudžbe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Skladište:";
            // 
            // listSkladista
            // 
            this.listSkladista.FormattingEnabled = true;
            this.listSkladista.Location = new System.Drawing.Point(104, 25);
            this.listSkladista.Name = "listSkladista";
            this.listSkladista.Size = new System.Drawing.Size(137, 21);
            this.listSkladista.TabIndex = 14;
            this.listSkladista.Validating += new System.ComponentModel.CancelEventHandler(this.listSkladista_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Broj narudžbe:";
            // 
            // lblBrojNaruzbe
            // 
            this.lblBrojNaruzbe.AutoSize = true;
            this.lblBrojNaruzbe.Location = new System.Drawing.Point(101, 102);
            this.lblBrojNaruzbe.Name = "lblBrojNaruzbe";
            this.lblBrojNaruzbe.Size = new System.Drawing.Size(19, 13);
            this.lblBrojNaruzbe.TabIndex = 12;
            this.lblBrojNaruzbe.Text = "----";
            // 
            // btnProcesiraj
            // 
            this.btnProcesiraj.Location = new System.Drawing.Point(358, 13);
            this.btnProcesiraj.Name = "btnProcesiraj";
            this.btnProcesiraj.Size = new System.Drawing.Size(75, 35);
            this.btnProcesiraj.TabIndex = 4;
            this.btnProcesiraj.Text = "Procesiraj";
            this.btnProcesiraj.UseVisualStyleBackColor = true;
            this.btnProcesiraj.Click += new System.EventHandler(this.btnProcesiraj_Click);
            // 
            // dgStavkeNarudzbe
            // 
            this.dgStavkeNarudzbe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStavkeNarudzbe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NarudzbaStavkaID,
            this.Naziv,
            this.Sifra,
            this.Cijena,
            this.Kolicina,
            this.Iznoss});
            this.dgStavkeNarudzbe.Location = new System.Drawing.Point(8, 169);
            this.dgStavkeNarudzbe.Name = "dgStavkeNarudzbe";
            this.dgStavkeNarudzbe.Size = new System.Drawing.Size(425, 258);
            this.dgStavkeNarudzbe.TabIndex = 11;
            // 
            // NarudzbaStavkaID
            // 
            this.NarudzbaStavkaID.DataPropertyName = "NarudzbaStavkaID";
            this.NarudzbaStavkaID.HeaderText = "NarudzbaStavkaID";
            this.NarudzbaStavkaID.Name = "NarudzbaStavkaID";
            this.NarudzbaStavkaID.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.Width = 132;
            // 
            // Sifra
            // 
            this.Sifra.DataPropertyName = "Sifra";
            this.Sifra.HeaderText = "Sifra";
            this.Sifra.Name = "Sifra";
            this.Sifra.Width = 70;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            this.Cijena.Width = 60;
            // 
            // Kolicina
            // 
            this.Kolicina.DataPropertyName = "Kolicina";
            this.Kolicina.HeaderText = "Kom";
            this.Kolicina.Name = "Kolicina";
            this.Kolicina.Width = 40;
            // 
            // Iznoss
            // 
            this.Iznoss.DataPropertyName = "Iznos";
            this.Iznoss.HeaderText = "Iznos (KM)";
            this.Iznoss.Name = "Iznoss";
            this.Iznoss.Width = 80;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(155, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Stavke narudžbe";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Kupac:";
            // 
            // lblIznos
            // 
            this.lblIznos.AutoSize = true;
            this.lblIznos.Location = new System.Drawing.Point(292, 102);
            this.lblIznos.Name = "lblIznos";
            this.lblIznos.Size = new System.Drawing.Size(16, 13);
            this.lblIznos.TabIndex = 8;
            this.lblIznos.Text = "---";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Iznos:";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(292, 80);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(16, 13);
            this.lblDatum.TabIndex = 6;
            this.lblDatum.Text = "---";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Datum:";
            // 
            // lblKupac
            // 
            this.lblKupac.AutoSize = true;
            this.lblKupac.Location = new System.Drawing.Point(101, 80);
            this.lblKupac.Name = "lblKupac";
            this.lblKupac.Size = new System.Drawing.Size(19, 13);
            this.lblKupac.TabIndex = 5;
            this.lblKupac.Text = "----";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDatum);
            this.groupBox2.Controls.Add(this.btnTrazi);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dgNarudzbe);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(456, 438);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pretraga narudžbi";
            // 
            // btnTrazi
            // 
            this.btnTrazi.Location = new System.Drawing.Point(375, 13);
            this.btnTrazi.Name = "btnTrazi";
            this.btnTrazi.Size = new System.Drawing.Size(75, 33);
            this.btnTrazi.TabIndex = 3;
            this.btnTrazi.Text = "Traži";
            this.btnTrazi.UseVisualStyleBackColor = true;
            this.btnTrazi.Click += new System.EventHandler(this.btnTrazi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Datum:";
            // 
            // dgNarudzbe
            // 
            this.dgNarudzbe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNarudzbe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NarudzbaID,
            this.BrojNarudzbe,
            this.Datum,
            this.ImePrezime,
            this.Iznos});
            this.dgNarudzbe.Location = new System.Drawing.Point(6, 55);
            this.dgNarudzbe.Name = "dgNarudzbe";
            this.dgNarudzbe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgNarudzbe.Size = new System.Drawing.Size(443, 372);
            this.dgNarudzbe.TabIndex = 0;
            this.dgNarudzbe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgNarudzbe_CellContentClick);
            // 
            // NarudzbaID
            // 
            this.NarudzbaID.DataPropertyName = "NarudzbaID";
            this.NarudzbaID.HeaderText = "NarudzbaID";
            this.NarudzbaID.Name = "NarudzbaID";
            this.NarudzbaID.Visible = false;
            // 
            // BrojNarudzbe
            // 
            this.BrojNarudzbe.DataPropertyName = "BrojNarudzbe";
            this.BrojNarudzbe.HeaderText = "Broj narudžbe";
            this.BrojNarudzbe.Name = "BrojNarudzbe";
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            // 
            // ImePrezime
            // 
            this.ImePrezime.DataPropertyName = "Kupac";
            this.ImePrezime.HeaderText = "Kupac";
            this.ImePrezime.Name = "ImePrezime";
            // 
            // Iznos
            // 
            this.Iznos.DataPropertyName = "Iznos";
            this.Iznos.HeaderText = "Iznos (KM)";
            this.Iznos.Name = "Iznos";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // txtDatum
            // 
            this.txtDatum.Location = new System.Drawing.Point(81, 24);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(200, 20);
            this.txtDatum.TabIndex = 4;
            // 
            // frm_Narudzbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 457);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_Narudzbe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Narudžbe";
            this.Load += new System.EventHandler(this.frm_Narudzbe_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStavkeNarudzbe)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgNarudzbe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgNarudzbe;
        private System.Windows.Forms.DataGridView dgStavkeNarudzbe;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblIznos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblKupac;
        private System.Windows.Forms.Button btnTrazi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBrojNaruzbe;
        private System.Windows.Forms.DataGridViewTextBoxColumn NarudzbaStavkaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sifra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iznoss;
        private System.Windows.Forms.DataGridViewTextBoxColumn NarudzbaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojNarudzbe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImePrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iznos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox listSkladista;
        private System.Windows.Forms.Button btnProcesiraj;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.DateTimePicker txtDatum;
    }
}