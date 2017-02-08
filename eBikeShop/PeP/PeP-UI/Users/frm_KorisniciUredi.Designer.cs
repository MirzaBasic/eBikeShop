namespace PeP_UI.Users
{
    partial class frm_KorisniciUredi
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
            this.btnOdustani = new System.Windows.Forms.Button();
            this.txtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
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
            this.ulogeList = new System.Windows.Forms.CheckedListBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(73, 274);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(116, 48);
            this.btnOdustani.TabIndex = 29;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(73, 140);
            this.txtTelefon.Mask = "(999) 000-000";
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(116, 20);
            this.txtTelefon.TabIndex = 28;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(73, 177);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(116, 20);
            this.txtEmail.TabIndex = 25;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Location = new System.Drawing.Point(329, 64);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(114, 20);
            this.txtKorisnickoIme.TabIndex = 26;
            this.txtKorisnickoIme.Validating += new System.ComponentModel.CancelEventHandler(this.txtKorisnickoIme_Validating);
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(329, 99);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.PasswordChar = '*';
            this.txtLozinka.Size = new System.Drawing.Size(114, 20);
            this.txtLozinka.TabIndex = 27;
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.AutoSize = true;
            this.lblKorisnickoIme.Location = new System.Drawing.Point(248, 67);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(75, 13);
            this.lblKorisnickoIme.TabIndex = 22;
            this.lblKorisnickoIme.Text = "Korisnicko ime";
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.Location = new System.Drawing.Point(248, 102);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(69, 13);
            this.lblLozinka.TabIndex = 23;
            this.lblLozinka.Text = "Nova lozinka";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(20, 180);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 24;
            this.lblEmail.Text = "Email";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(20, 143);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(43, 13);
            this.lblTelefon.TabIndex = 21;
            this.lblTelefon.Text = "Telefon";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(73, 105);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(116, 20);
            this.txtPrezime.TabIndex = 20;
            this.txtPrezime.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrezime_Validating);
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(20, 108);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(44, 13);
            this.lblPrezime.TabIndex = 19;
            this.lblPrezime.Text = "Prezime";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(329, 274);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(114, 48);
            this.btnSacuvaj.TabIndex = 18;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(73, 67);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(116, 20);
            this.txtIme.TabIndex = 17;
            this.txtIme.Validating += new System.ComponentModel.CancelEventHandler(this.txtIme_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ime";
            // 
            // ulogeList
            // 
            this.ulogeList.FormattingEnabled = true;
            this.ulogeList.Location = new System.Drawing.Point(329, 140);
            this.ulogeList.Name = "ulogeList";
            this.ulogeList.Size = new System.Drawing.Size(114, 64);
            this.ulogeList.TabIndex = 30;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frm_KorisniciUredi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 355);
            this.Controls.Add(this.ulogeList);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtKorisnickoIme);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.lblKorisnickoIme);
            this.Controls.Add(this.lblLozinka);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label1);
            this.Name = "frm_KorisniciUredi";
            this.Text = "Uredi korisnika";
            this.Load += new System.EventHandler(this.frm_KorisniciUredi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.MaskedTextBox txtTelefon;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
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
        private System.Windows.Forms.CheckedListBox ulogeList;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}