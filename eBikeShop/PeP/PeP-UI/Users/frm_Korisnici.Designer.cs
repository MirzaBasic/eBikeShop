namespace PeP_UI.Users
{
    partial class frm_Korisnici
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
            this.btnUredi = new System.Windows.Forms.Button();
            this.dgKorisnici = new System.Windows.Forms.DataGridView();
            this.KorisnikID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aktivan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.KorisnickoIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.txtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.lblKorisnickoIme = new System.Windows.Forms.Label();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtImePrezimePretraga = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ulogeList = new System.Windows.Forms.CheckedListBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnTrazi = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnStatus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgKorisnici)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUredi
            // 
            this.btnUredi.Location = new System.Drawing.Point(621, 240);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(86, 26);
            this.btnUredi.TabIndex = 36;
            this.btnUredi.Text = "Uredi";
            this.btnUredi.UseVisualStyleBackColor = true;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // dgKorisnici
            // 
            this.dgKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKorisnici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KorisnikID,
            this.Ime,
            this.Prezime,
            this.Telefon,
            this.Email,
            this.Aktivan,
            this.KorisnickoIme});
            this.dgKorisnici.Location = new System.Drawing.Point(41, 274);
            this.dgKorisnici.Name = "dgKorisnici";
            this.dgKorisnici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgKorisnici.Size = new System.Drawing.Size(678, 168);
            this.dgKorisnici.TabIndex = 35;
            // 
            // KorisnikID
            // 
            this.KorisnikID.DataPropertyName = "KorisnikID";
            this.KorisnikID.HeaderText = "KorisnikID";
            this.KorisnikID.Name = "KorisnikID";
            this.KorisnikID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.KorisnikID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.KorisnikID.Visible = false;
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            // 
            // Prezime
            // 
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            // 
            // Telefon
            // 
            this.Telefon.DataPropertyName = "Telefon";
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.Name = "Telefon";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
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
            // KorisnickoIme
            // 
            this.KorisnickoIme.DataPropertyName = "KorisnickoIme";
            this.KorisnickoIme.HeaderText = "Korisnicko ime";
            this.KorisnickoIme.Name = "KorisnickoIme";
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(431, 116);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(97, 48);
            this.btnOdustani.TabIndex = 34;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click_1);
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(88, 109);
            this.txtTelefon.Mask = "(999) 000-000";
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(175, 20);
            this.txtTelefon.TabIndex = 33;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(146, -57);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 31;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(88, 146);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(175, 20);
            this.txtEmail.TabIndex = 30;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Location = new System.Drawing.Point(393, 36);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(163, 20);
            this.txtKorisnickoIme.TabIndex = 32;
            this.txtKorisnickoIme.Validating += new System.ComponentModel.CancelEventHandler(this.txtKorisnickoIme_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(105, -50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "label6";
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(393, 71);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.PasswordChar = '*';
            this.txtLozinka.Size = new System.Drawing.Size(163, 20);
            this.txtLozinka.TabIndex = 29;
            this.txtLozinka.Validating += new System.ComponentModel.CancelEventHandler(this.txtLozinka_Validating);
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.AutoSize = true;
            this.lblKorisnickoIme.Location = new System.Drawing.Point(312, 39);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(75, 13);
            this.lblKorisnickoIme.TabIndex = 28;
            this.lblKorisnickoIme.Text = "Korisnicko ime";
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.Location = new System.Drawing.Point(312, 74);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(44, 13);
            this.lblLozinka.TabIndex = 26;
            this.lblLozinka.Text = "Lozinka";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(35, 149);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 25;
            this.lblEmail.Text = "Email";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(35, 112);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(43, 13);
            this.lblTelefon.TabIndex = 24;
            this.lblTelefon.Text = "Telefon";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(88, 74);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(175, 20);
            this.txtPrezime.TabIndex = 23;
            this.txtPrezime.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrezime_Validating);
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(35, 77);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(44, 13);
            this.lblPrezime.TabIndex = 22;
            this.lblPrezime.Text = "Prezime";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(632, 116);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(75, 48);
            this.btnSacuvaj.TabIndex = 21;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click_1);
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(88, 36);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(175, 20);
            this.txtIme.TabIndex = 20;
            this.txtIme.Validating += new System.ComponentModel.CancelEventHandler(this.txtIme_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Ime i/ili Prezime";
            // 
            // txtImePrezimePretraga
            // 
            this.txtImePrezimePretraga.Location = new System.Drawing.Point(126, 36);
            this.txtImePrezimePretraga.Name = "txtImePrezimePretraga";
            this.txtImePrezimePretraga.Size = new System.Drawing.Size(146, 24);
            this.txtImePrezimePretraga.TabIndex = 38;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.btnOdustani);
            this.groupBox1.Controls.Add(this.btnSacuvaj);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(732, 190);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Novi korisnik";
            // 
            // ulogeList
            // 
            this.ulogeList.FormattingEnabled = true;
            this.ulogeList.Location = new System.Drawing.Point(599, 36);
            this.ulogeList.Name = "ulogeList";
            this.ulogeList.Size = new System.Drawing.Size(120, 64);
            this.ulogeList.TabIndex = 0;
            this.ulogeList.Validating += new System.ComponentModel.CancelEventHandler(this.ulogeList_Validating);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // btnTrazi
            // 
            this.btnTrazi.Location = new System.Drawing.Point(632, 19);
            this.btnTrazi.Name = "btnTrazi";
            this.btnTrazi.Size = new System.Drawing.Size(75, 41);
            this.btnTrazi.TabIndex = 40;
            this.btnTrazi.Text = "Traži";
            this.btnTrazi.UseVisualStyleBackColor = true;
            this.btnTrazi.Click += new System.EventHandler(this.btnTrazi_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.btnStatus);
            this.groupBox2.Controls.Add(this.btnTrazi);
            this.groupBox2.Controls.Add(this.txtImePrezimePretraga);
            this.groupBox2.Controls.Add(this.btnUredi);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 208);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(732, 277);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pretraga i uređivanje";
            // 
            // btnStatus
            // 
            this.btnStatus.Location = new System.Drawing.Point(26, 240);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(140, 26);
            this.btnStatus.TabIndex = 41;
            this.btnStatus.Text = "Promijeni status";
            this.btnStatus.UseVisualStyleBackColor = true;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // frm_Korisnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 496);
            this.Controls.Add(this.ulogeList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgKorisnici);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtKorisnickoIme);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.lblKorisnickoIme);
            this.Controls.Add(this.lblLozinka);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_Korisnici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Korisnici";
            this.Load += new System.EventHandler(this.KorisniciForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgKorisnici)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.DataGridView dgKorisnici;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.MaskedTextBox txtTelefon;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.Label lblKorisnickoIme;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtImePrezimePretraga;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox ulogeList;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button btnTrazi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.DataGridViewComboBoxColumn KorisnikID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Aktivan;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnickoIme;
    }
}

