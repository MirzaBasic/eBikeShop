namespace PeP_UI.Suppliers
{
    partial class frm_Dobavljaci
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
            this.dgDobavljaci = new System.Windows.Forms.DataGridView();
            this.DobavljacID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kontakt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Web = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojRacuna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aktivan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNazivPretraga = new System.Windows.Forms.TextBox();
            this.btnTrazi = new System.Windows.Forms.Button();
            this.btnUredi = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxStatus = new System.Windows.Forms.CheckBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNapomena = new System.Windows.Forms.RichTextBox();
            this.txtBrojRacuna = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtWeb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKontakt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDobavljaci)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgDobavljaci);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNazivPretraga);
            this.groupBox1.Controls.Add(this.btnTrazi);
            this.groupBox1.Controls.Add(this.btnUredi);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(947, 248);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pretraga dobavljača";
            // 
            // dgDobavljaci
            // 
            this.dgDobavljaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDobavljaci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DobavljacID,
            this.Naziv,
            this.Kontakt,
            this.Adresa,
            this.Telefon,
            this.Fax,
            this.Web,
            this.Email,
            this.BrojRacuna,
            this.Aktivan});
            this.dgDobavljaci.Location = new System.Drawing.Point(12, 52);
            this.dgDobavljaci.Name = "dgDobavljaci";
            this.dgDobavljaci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDobavljaci.Size = new System.Drawing.Size(925, 161);
            this.dgDobavljaci.TabIndex = 4;
            // 
            // DobavljacID
            // 
            this.DobavljacID.DataPropertyName = "DobavljacID";
            this.DobavljacID.HeaderText = "DobavljacID";
            this.DobavljacID.Name = "DobavljacID";
            this.DobavljacID.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            // 
            // Kontakt
            // 
            this.Kontakt.DataPropertyName = "KontaktOsoba";
            this.Kontakt.HeaderText = "Kontakt";
            this.Kontakt.Name = "Kontakt";
            // 
            // Adresa
            // 
            this.Adresa.DataPropertyName = "Adresa";
            this.Adresa.HeaderText = "Adresa";
            this.Adresa.Name = "Adresa";
            this.Adresa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Telefon
            // 
            this.Telefon.DataPropertyName = "Telefon";
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.Name = "Telefon";
            // 
            // Fax
            // 
            this.Fax.DataPropertyName = "Fax";
            this.Fax.HeaderText = "Fax";
            this.Fax.Name = "Fax";
            // 
            // Web
            // 
            this.Web.DataPropertyName = "Web";
            this.Web.HeaderText = "Web";
            this.Web.Name = "Web";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // BrojRacuna
            // 
            this.BrojRacuna.DataPropertyName = "ZiroRacuni";
            this.BrojRacuna.HeaderText = "Broj računa";
            this.BrojRacuna.Name = "BrojRacuna";
            // 
            // Aktivan
            // 
            this.Aktivan.DataPropertyName = "Status";
            this.Aktivan.HeaderText = "Aktivan";
            this.Aktivan.Name = "Aktivan";
            this.Aktivan.ReadOnly = true;
            this.Aktivan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Aktivan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Naziv:";
            // 
            // txtNazivPretraga
            // 
            this.txtNazivPretraga.Location = new System.Drawing.Point(53, 22);
            this.txtNazivPretraga.Name = "txtNazivPretraga";
            this.txtNazivPretraga.Size = new System.Drawing.Size(100, 20);
            this.txtNazivPretraga.TabIndex = 2;
            // 
            // btnTrazi
            // 
            this.btnTrazi.Location = new System.Drawing.Point(852, 10);
            this.btnTrazi.Name = "btnTrazi";
            this.btnTrazi.Size = new System.Drawing.Size(85, 36);
            this.btnTrazi.TabIndex = 0;
            this.btnTrazi.Text = "Traži";
            this.btnTrazi.UseVisualStyleBackColor = true;
            this.btnTrazi.Click += new System.EventHandler(this.btnTrazi_Click);
            // 
            // btnUredi
            // 
            this.btnUredi.Location = new System.Drawing.Point(852, 219);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(85, 23);
            this.btnUredi.TabIndex = 1;
            this.btnUredi.Text = "Uredi";
            this.btnUredi.UseVisualStyleBackColor = true;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTelefon);
            this.groupBox2.Controls.Add(this.txtFax);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cbxStatus);
            this.groupBox2.Controls.Add(this.btnSacuvaj);
            this.groupBox2.Controls.Add(this.btnOdustani);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtNapomena);
            this.groupBox2.Controls.Add(this.txtBrojRacuna);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtWeb);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtAdresa);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtKontakt);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtNaziv);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 266);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(947, 200);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Novi dobavljač";
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(67, 158);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(120, 20);
            this.txtFax.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(34, 161);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Fax:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(295, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Aktivan:";
            // 
            // cbxStatus
            // 
            this.cbxStatus.AutoSize = true;
            this.cbxStatus.Location = new System.Drawing.Point(347, 127);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(15, 14);
            this.cbxStatus.TabIndex = 16;
            this.cbxStatus.UseVisualStyleBackColor = true;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(852, 154);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(85, 40);
            this.btnSacuvaj.TabIndex = 2;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(709, 154);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(85, 40);
            this.btnOdustani.TabIndex = 3;
            this.btnOdustani.Text = "Poništi";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(555, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Napomena:";
            // 
            // txtNapomena
            // 
            this.txtNapomena.Location = new System.Drawing.Point(623, 29);
            this.txtNapomena.Name = "txtNapomena";
            this.txtNapomena.Size = new System.Drawing.Size(314, 119);
            this.txtNapomena.TabIndex = 14;
            this.txtNapomena.Text = "";
            // 
            // txtBrojRacuna
            // 
            this.txtBrojRacuna.Location = new System.Drawing.Point(347, 91);
            this.txtBrojRacuna.Name = "txtBrojRacuna";
            this.txtBrojRacuna.Size = new System.Drawing.Size(143, 20);
            this.txtBrojRacuna.TabIndex = 13;
            this.txtBrojRacuna.Validating += new System.ComponentModel.CancelEventHandler(this.txtZR_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(277, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Broj racuna:";
            // 
            // txtWeb
            // 
            this.txtWeb.Location = new System.Drawing.Point(347, 59);
            this.txtWeb.Name = "txtWeb";
            this.txtWeb.Size = new System.Drawing.Size(143, 20);
            this.txtWeb.TabIndex = 11;
            this.txtWeb.Validating += new System.ComponentModel.CancelEventHandler(this.txtWeb_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(308, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Web:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(347, 29);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(143, 20);
            this.txtEmail.TabIndex = 9;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(306, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Telefon:";
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(67, 91);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(167, 20);
            this.txtAdresa.TabIndex = 5;
            this.txtAdresa.Validating += new System.ComponentModel.CancelEventHandler(this.txtAdresa_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Adresa:";
            // 
            // txtKontakt
            // 
            this.txtKontakt.Location = new System.Drawing.Point(67, 59);
            this.txtKontakt.Name = "txtKontakt";
            this.txtKontakt.Size = new System.Drawing.Size(167, 20);
            this.txtKontakt.TabIndex = 3;
            this.txtKontakt.Validating += new System.ComponentModel.CancelEventHandler(this.txtKontaktOsoba_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kontakt:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(67, 29);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(167, 20);
            this.txtNaziv.TabIndex = 1;
            this.txtNaziv.Validating += new System.ComponentModel.CancelEventHandler(this.txtNaziv_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Naziv:";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(67, 124);
            this.txtTelefon.Mask = "(999) 000-000";
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(120, 20);
            this.txtTelefon.TabIndex = 20;
            this.txtTelefon.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.txtTelefon.Validating += new System.ComponentModel.CancelEventHandler(this.txtTelefon_Validating);
            // 
            // frm_Dobavljaci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 478);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_Dobavljaci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Dobavljaci";
            this.Load += new System.EventHandler(this.frm_Dobavljaci_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDobavljaci)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTrazi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.DataGridView dgDobavljaci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNazivPretraga;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox txtNapomena;
        private System.Windows.Forms.TextBox txtBrojRacuna;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtWeb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKontakt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DobavljacID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kontakt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fax;
        private System.Windows.Forms.DataGridViewTextBoxColumn Web;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojRacuna;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Aktivan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox cbxStatus;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.MaskedTextBox txtTelefon;
    }
}