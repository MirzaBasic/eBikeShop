namespace PeP_UI.Suppliers
{
    partial class frm_DobavljaciUredi
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
            this.txtFax = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxStatus = new System.Windows.Forms.CheckBox();
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
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNapomena = new System.Windows.Forms.RichTextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtTelefon = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(73, 157);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(120, 20);
            this.txtFax.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(40, 160);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "Fax:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(301, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "Aktivan:";
            // 
            // cbxStatus
            // 
            this.cbxStatus.AutoSize = true;
            this.cbxStatus.Location = new System.Drawing.Point(353, 126);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(15, 14);
            this.cbxStatus.TabIndex = 34;
            this.cbxStatus.UseVisualStyleBackColor = true;
            // 
            // txtBrojRacuna
            // 
            this.txtBrojRacuna.Location = new System.Drawing.Point(353, 90);
            this.txtBrojRacuna.Name = "txtBrojRacuna";
            this.txtBrojRacuna.Size = new System.Drawing.Size(143, 20);
            this.txtBrojRacuna.TabIndex = 33;
            this.txtBrojRacuna.Validating += new System.ComponentModel.CancelEventHandler(this.txtZR_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(283, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Broj racuna:";
            // 
            // txtWeb
            // 
            this.txtWeb.Location = new System.Drawing.Point(353, 58);
            this.txtWeb.Name = "txtWeb";
            this.txtWeb.Size = new System.Drawing.Size(143, 20);
            this.txtWeb.TabIndex = 31;
            this.txtWeb.Validating += new System.ComponentModel.CancelEventHandler(this.txtWeb_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(314, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Web:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(353, 28);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(143, 20);
            this.txtEmail.TabIndex = 29;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(312, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Telefon:";
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(73, 90);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(167, 20);
            this.txtAdresa.TabIndex = 25;
            this.txtAdresa.Validating += new System.ComponentModel.CancelEventHandler(this.txtAdresa_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Adresa:";
            // 
            // txtKontakt
            // 
            this.txtKontakt.Location = new System.Drawing.Point(73, 58);
            this.txtKontakt.Name = "txtKontakt";
            this.txtKontakt.Size = new System.Drawing.Size(167, 20);
            this.txtKontakt.TabIndex = 23;
            this.txtKontakt.Validating += new System.ComponentModel.CancelEventHandler(this.txtKontaktOsoba_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Kontakt:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(73, 28);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(167, 20);
            this.txtNaziv.TabIndex = 21;
            this.txtNaziv.Validating += new System.ComponentModel.CancelEventHandler(this.txtNaziv_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Naziv:";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(411, 298);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(85, 42);
            this.btnSacuvaj.TabIndex = 38;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(73, 298);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(85, 42);
            this.btnOdustani.TabIndex = 39;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "Napomena:";
            // 
            // txtNapomena
            // 
            this.txtNapomena.Location = new System.Drawing.Point(73, 193);
            this.txtNapomena.Name = "txtNapomena";
            this.txtNapomena.Size = new System.Drawing.Size(423, 94);
            this.txtNapomena.TabIndex = 40;
            this.txtNapomena.Text = "";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(73, 123);
            this.txtTelefon.Mask = "(999) 000-000";
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(120, 20);
            this.txtTelefon.TabIndex = 42;
            this.txtTelefon.Validating += new System.ComponentModel.CancelEventHandler(this.txtTelefon_Validating);
            // 
            // frm_DobavljaciUredi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 352);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNapomena);
            this.Controls.Add(this.txtFax);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbxStatus);
            this.Controls.Add(this.txtBrojRacuna);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtWeb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKontakt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_DobavljaciUredi";
            this.Text = "Uredi dobavljača";
            this.Load += new System.EventHandler(this.frm_DobavljaciUredi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox cbxStatus;
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
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox txtNapomena;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.MaskedTextBox txtTelefon;
    }
}