namespace PeP_UI.Products
{
    partial class frm_Proizvodi
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
            this.txtSifra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.vrsteList = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.jedinicaMjereList = new System.Windows.Forms.ComboBox();
            this.slikaBox = new System.Windows.Forms.PictureBox();
            this.txtSlika = new System.Windows.Forms.TextBox();
            this.btnDodajSliku = new System.Windows.Forms.Button();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.dgProizvodi = new System.Windows.Forms.DataGridView();
            this.ProizvodID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sifra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrstaProizvoda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JedinicaMjere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aktivan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Slika = new System.Windows.Forms.DataGridViewImageColumn();
            this.cbxAktivan = new System.Windows.Forms.CheckBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnUredi = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNazivSifra = new System.Windows.Forms.TextBox();
            this.groupBoxPretraga = new System.Windows.Forms.GroupBox();
            this.vrstePretragaList = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnTrazi = new System.Windows.Forms.Button();
            this.groupBoxNoviProizvod = new System.Windows.Forms.GroupBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtCijena = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.slikaBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProizvodi)).BeginInit();
            this.groupBoxPretraga.SuspendLayout();
            this.groupBoxNoviProizvod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSifra
            // 
            this.txtSifra.Location = new System.Drawing.Point(101, 62);
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.Size = new System.Drawing.Size(264, 20);
            this.txtSifra.TabIndex = 2;
            this.txtSifra.Validating += new System.ComponentModel.CancelEventHandler(this.txtSifra_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Šifra:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(101, 95);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(264, 20);
            this.txtNaziv.TabIndex = 3;
            this.txtNaziv.Validating += new System.ComponentModel.CancelEventHandler(this.txtNaziv_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Naziv:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cijena:";
            // 
            // vrsteList
            // 
            this.vrsteList.FormattingEnabled = true;
            this.vrsteList.Location = new System.Drawing.Point(101, 30);
            this.vrsteList.Name = "vrsteList";
            this.vrsteList.Size = new System.Drawing.Size(264, 21);
            this.vrsteList.TabIndex = 1;
            this.vrsteList.Validating += new System.ComponentModel.CancelEventHandler(this.vrsteList_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Jed. mjere:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Vrsta:";
            // 
            // jedinicaMjereList
            // 
            this.jedinicaMjereList.FormattingEnabled = true;
            this.jedinicaMjereList.Location = new System.Drawing.Point(225, 126);
            this.jedinicaMjereList.Name = "jedinicaMjereList";
            this.jedinicaMjereList.Size = new System.Drawing.Size(39, 21);
            this.jedinicaMjereList.TabIndex = 5;
            this.jedinicaMjereList.Validating += new System.ComponentModel.CancelEventHandler(this.jedinicaMjereList_Validating);
            // 
            // slikaBox
            // 
            this.slikaBox.BackColor = System.Drawing.Color.White;
            this.slikaBox.Location = new System.Drawing.Point(426, 17);
            this.slikaBox.Name = "slikaBox";
            this.slikaBox.Size = new System.Drawing.Size(153, 149);
            this.slikaBox.TabIndex = 12;
            this.slikaBox.TabStop = false;
            this.slikaBox.Click += new System.EventHandler(this.slikaBox_Click);
            // 
            // txtSlika
            // 
            this.txtSlika.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSlika.Location = new System.Drawing.Point(89, 146);
            this.txtSlika.Name = "txtSlika";
            this.txtSlika.Size = new System.Drawing.Size(136, 20);
            this.txtSlika.TabIndex = 7;
            // 
            // btnDodajSliku
            // 
            this.btnDodajSliku.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajSliku.Location = new System.Drawing.Point(232, 145);
            this.btnDodajSliku.Name = "btnDodajSliku";
            this.btnDodajSliku.Size = new System.Drawing.Size(56, 22);
            this.btnDodajSliku.TabIndex = 8;
            this.btnDodajSliku.Text = "Dodaj";
            this.btnDodajSliku.UseVisualStyleBackColor = true;
            this.btnDodajSliku.Click += new System.EventHandler(this.btnDodajSliku_Click);
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvaj.Location = new System.Drawing.Point(629, 122);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(75, 42);
            this.btnSacuvaj.TabIndex = 10;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Slika:";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // dgProizvodi
            // 
            this.dgProizvodi.ColumnHeadersHeight = 24;
            this.dgProizvodi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgProizvodi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProizvodID,
            this.Naziv,
            this.Sifra,
            this.VrstaProizvoda,
            this.JedinicaMjere,
            this.Cijena,
            this.Aktivan,
            this.Slika});
            this.dgProizvodi.Location = new System.Drawing.Point(9, 58);
            this.dgProizvodi.Name = "dgProizvodi";
            this.dgProizvodi.RowTemplate.Height = 65;
            this.dgProizvodi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProizvodi.Size = new System.Drawing.Size(696, 205);
            this.dgProizvodi.TabIndex = 17;
            // 
            // ProizvodID
            // 
            this.ProizvodID.DataPropertyName = "ProizvodID";
            this.ProizvodID.HeaderText = "ProizvodID";
            this.ProizvodID.Name = "ProizvodID";
            this.ProizvodID.Visible = false;
            this.ProizvodID.Width = 21;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.Width = 90;
            // 
            // Sifra
            // 
            this.Sifra.DataPropertyName = "Sifra";
            this.Sifra.HeaderText = "Sifra";
            this.Sifra.Name = "Sifra";
            this.Sifra.Width = 91;
            // 
            // VrstaProizvoda
            // 
            this.VrstaProizvoda.DataPropertyName = "VrstaProizvoda";
            this.VrstaProizvoda.HeaderText = "Vrsta";
            this.VrstaProizvoda.Name = "VrstaProizvoda";
            this.VrstaProizvoda.Width = 90;
            // 
            // JedinicaMjere
            // 
            this.JedinicaMjere.DataPropertyName = "JedinicaMjere";
            this.JedinicaMjere.HeaderText = "Jed. mje.";
            this.JedinicaMjere.Name = "JedinicaMjere";
            this.JedinicaMjere.Width = 90;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            this.Cijena.Width = 90;
            // 
            // Aktivan
            // 
            this.Aktivan.DataPropertyName = "Status";
            this.Aktivan.HeaderText = "Aktivan";
            this.Aktivan.Name = "Aktivan";
            this.Aktivan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Aktivan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Aktivan.Width = 91;
            // 
            // Slika
            // 
            this.Slika.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Slika.DataPropertyName = "Slika";
            this.Slika.HeaderText = "Slika";
            this.Slika.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Slika.Name = "Slika";
            this.Slika.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Slika.Width = 90;
            // 
            // cbxAktivan
            // 
            this.cbxAktivan.AutoSize = true;
            this.cbxAktivan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAktivan.Location = new System.Drawing.Point(291, 123);
            this.cbxAktivan.Name = "cbxAktivan";
            this.cbxAktivan.Size = new System.Drawing.Size(62, 17);
            this.cbxAktivan.TabIndex = 6;
            this.cbxAktivan.Text = "Aktivan";
            this.cbxAktivan.UseVisualStyleBackColor = true;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdustani.Location = new System.Drawing.Point(629, 53);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 42);
            this.btnOdustani.TabIndex = 9;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            // 
            // btnUredi
            // 
            this.btnUredi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUredi.Location = new System.Drawing.Point(630, 269);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(75, 23);
            this.btnUredi.TabIndex = 14;
            this.btnUredi.Text = "Uredi";
            this.btnUredi.UseVisualStyleBackColor = true;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Naziv/Šifra:";
            // 
            // txtNazivSifra
            // 
            this.txtNazivSifra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNazivSifra.Location = new System.Drawing.Point(84, 24);
            this.txtNazivSifra.Name = "txtNazivSifra";
            this.txtNazivSifra.Size = new System.Drawing.Size(135, 20);
            this.txtNazivSifra.TabIndex = 11;
            // 
            // groupBoxPretraga
            // 
            this.groupBoxPretraga.Controls.Add(this.vrstePretragaList);
            this.groupBoxPretraga.Controls.Add(this.label8);
            this.groupBoxPretraga.Controls.Add(this.btnUredi);
            this.groupBoxPretraga.Controls.Add(this.btnTrazi);
            this.groupBoxPretraga.Controls.Add(this.label7);
            this.groupBoxPretraga.Controls.Add(this.txtNazivSifra);
            this.groupBoxPretraga.Controls.Add(this.dgProizvodi);
            this.groupBoxPretraga.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPretraga.Location = new System.Drawing.Point(12, 208);
            this.groupBoxPretraga.Name = "groupBoxPretraga";
            this.groupBoxPretraga.Size = new System.Drawing.Size(714, 302);
            this.groupBoxPretraga.TabIndex = 24;
            this.groupBoxPretraga.TabStop = false;
            this.groupBoxPretraga.Text = "Pretraga proizvoda";
            // 
            // vrstePretragaList
            // 
            this.vrstePretragaList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vrstePretragaList.FormattingEnabled = true;
            this.vrstePretragaList.Location = new System.Drawing.Point(294, 23);
            this.vrstePretragaList.Name = "vrstePretragaList";
            this.vrstePretragaList.Size = new System.Drawing.Size(115, 21);
            this.vrstePretragaList.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(254, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Vrsta:";
            // 
            // btnTrazi
            // 
            this.btnTrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrazi.Location = new System.Drawing.Point(630, 14);
            this.btnTrazi.Name = "btnTrazi";
            this.btnTrazi.Size = new System.Drawing.Size(75, 38);
            this.btnTrazi.TabIndex = 13;
            this.btnTrazi.Text = "Traži";
            this.btnTrazi.UseVisualStyleBackColor = true;
            this.btnTrazi.Click += new System.EventHandler(this.btnTrazi_Click);
            // 
            // groupBoxNoviProizvod
            // 
            this.groupBoxNoviProizvod.Controls.Add(this.txtCijena);
            this.groupBoxNoviProizvod.Controls.Add(this.label6);
            this.groupBoxNoviProizvod.Controls.Add(this.btnOdustani);
            this.groupBoxNoviProizvod.Controls.Add(this.btnDodajSliku);
            this.groupBoxNoviProizvod.Controls.Add(this.cbxAktivan);
            this.groupBoxNoviProizvod.Controls.Add(this.txtSlika);
            this.groupBoxNoviProizvod.Controls.Add(this.slikaBox);
            this.groupBoxNoviProizvod.Controls.Add(this.btnSacuvaj);
            this.groupBoxNoviProizvod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxNoviProizvod.Location = new System.Drawing.Point(12, 11);
            this.groupBoxNoviProizvod.Name = "groupBoxNoviProizvod";
            this.groupBoxNoviProizvod.Size = new System.Drawing.Size(714, 191);
            this.groupBoxNoviProizvod.TabIndex = 25;
            this.groupBoxNoviProizvod.TabStop = false;
            this.groupBoxNoviProizvod.Text = "Dodaj novi prozvod";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(89, 115);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(62, 22);
            this.txtCijena.TabIndex = 17;
            this.txtCijena.Validating += new System.ComponentModel.CancelEventHandler(this.txtCijena_Validating);
            // 
            // frm_Proizvodi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 522);
            this.Controls.Add(this.jedinicaMjereList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.vrsteList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSifra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBoxPretraga);
            this.Controls.Add(this.groupBoxNoviProizvod);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_Proizvodi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proizvodi";
            this.Load += new System.EventHandler(this.frm_Proizvodi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.slikaBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProizvodi)).EndInit();
            this.groupBoxPretraga.ResumeLayout(false);
            this.groupBoxPretraga.PerformLayout();
            this.groupBoxNoviProizvod.ResumeLayout(false);
            this.groupBoxNoviProizvod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSifra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox vrsteList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox jedinicaMjereList;
        private System.Windows.Forms.PictureBox slikaBox;
        private System.Windows.Forms.TextBox txtSlika;
        private System.Windows.Forms.Button btnDodajSliku;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.DataGridView dgProizvodi;
        private System.Windows.Forms.CheckBox cbxAktivan;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNazivSifra;
        private System.Windows.Forms.GroupBox groupBoxPretraga;
        private System.Windows.Forms.Button btnTrazi;
        private System.Windows.Forms.GroupBox groupBoxNoviProizvod;
        private System.Windows.Forms.ComboBox vrstePretragaList;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProizvodID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sifra;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrstaProizvoda;
        private System.Windows.Forms.DataGridViewTextBoxColumn JedinicaMjere;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Aktivan;
        private System.Windows.Forms.DataGridViewImageColumn Slika;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox txtCijena;
    }
}