namespace PeP_UI.Inputs
{
    partial class frm_Ulazi
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtIznosRacuna = new System.Windows.Forms.TextBox();
            this.listDobavljac = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDodajDobavljaca = new System.Windows.Forms.Button();
            this.txtPDV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFaktura = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNapomena = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDatum = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.dgProizvodi = new System.Windows.Forms.DataGridView();
            this.UlazStavkaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sifra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIjena1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDodajStavku = new System.Windows.Forms.Button();
            this.btnTrazi = new System.Windows.Forms.Button();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.txtSifra = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnPonisti = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listSkladiste = new System.Windows.Forms.ComboBox();
            this.btnDodajSkladiste = new System.Windows.Forms.Button();
            this.btnProcesiraj = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProizvodi)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtIznosRacuna);
            this.groupBox2.Controls.Add(this.listDobavljac);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnDodajDobavljaca);
            this.groupBox2.Controls.Add(this.txtPDV);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtFaktura);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtNapomena);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtDatum);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(737, 189);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Faktura:";
            // 
            // txtIznosRacuna
            // 
            this.txtIznosRacuna.Location = new System.Drawing.Point(107, 87);
            this.txtIznosRacuna.Name = "txtIznosRacuna";
            this.txtIznosRacuna.ReadOnly = true;
            this.txtIznosRacuna.Size = new System.Drawing.Size(87, 20);
            this.txtIznosRacuna.TabIndex = 8;
            // 
            // listDobavljac
            // 
            this.listDobavljac.FormattingEnabled = true;
            this.listDobavljac.Location = new System.Drawing.Point(107, 18);
            this.listDobavljac.Name = "listDobavljac";
            this.listDobavljac.Size = new System.Drawing.Size(183, 21);
            this.listDobavljac.TabIndex = 1;
            this.listDobavljac.Validating += new System.ComponentModel.CancelEventHandler(this.listDobavljac_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "PDV:";
            // 
            // btnDodajDobavljaca
            // 
            this.btnDodajDobavljaca.Location = new System.Drawing.Point(296, 17);
            this.btnDodajDobavljaca.Name = "btnDodajDobavljaca";
            this.btnDodajDobavljaca.Size = new System.Drawing.Size(50, 23);
            this.btnDodajDobavljaca.TabIndex = 3;
            this.btnDodajDobavljaca.Text = "Dodaj";
            this.btnDodajDobavljaca.UseVisualStyleBackColor = true;
            this.btnDodajDobavljaca.Click += new System.EventHandler(this.btnDodajDobavljaca_Click);
            // 
            // txtPDV
            // 
            this.txtPDV.Location = new System.Drawing.Point(107, 121);
            this.txtPDV.Name = "txtPDV";
            this.txtPDV.ReadOnly = true;
            this.txtPDV.Size = new System.Drawing.Size(87, 20);
            this.txtPDV.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dobavljac:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(475, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Datum:";
            // 
            // txtFaktura
            // 
            this.txtFaktura.Location = new System.Drawing.Point(107, 53);
            this.txtFaktura.Name = "txtFaktura";
            this.txtFaktura.Size = new System.Drawing.Size(121, 20);
            this.txtFaktura.TabIndex = 6;
            this.txtFaktura.Validating += new System.ComponentModel.CancelEventHandler(this.txtFaktura_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(454, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Napomena:";
            // 
            // txtNapomena
            // 
            this.txtNapomena.Location = new System.Drawing.Point(524, 55);
            this.txtNapomena.Name = "txtNapomena";
            this.txtNapomena.Size = new System.Drawing.Size(199, 96);
            this.txtNapomena.TabIndex = 7;
            this.txtNapomena.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Iznos racuna:";
            // 
            // txtDatum
            // 
            this.txtDatum.Location = new System.Drawing.Point(524, 16);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(199, 20);
            this.txtDatum.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Broj fakture:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCijena);
            this.groupBox1.Controls.Add(this.dgProizvodi);
            this.groupBox1.Controls.Add(this.btnDodajStavku);
            this.groupBox1.Controls.Add(this.btnTrazi);
            this.groupBox1.Controls.Add(this.txtNaziv);
            this.groupBox1.Controls.Add(this.txtKolicina);
            this.groupBox1.Controls.Add(this.txtSifra);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(12, 207);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 269);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proizvodi";
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(213, 88);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.ReadOnly = true;
            this.txtCijena.Size = new System.Drawing.Size(58, 20);
            this.txtCijena.TabIndex = 41;
            // 
            // dgProizvodi
            // 
            this.dgProizvodi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProizvodi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UlazStavkaID,
            this.Sifra,
            this.Naziv,
            this.Kolicina,
            this.CIjena1});
            this.dgProizvodi.Location = new System.Drawing.Point(25, 125);
            this.dgProizvodi.Name = "dgProizvodi";
            this.dgProizvodi.Size = new System.Drawing.Size(383, 132);
            this.dgProizvodi.TabIndex = 40;
            // 
            // UlazStavkaID
            // 
            this.UlazStavkaID.DataPropertyName = "UlazStavkaID";
            this.UlazStavkaID.HeaderText = "UlazStavkaID";
            this.UlazStavkaID.Name = "UlazStavkaID";
            this.UlazStavkaID.Visible = false;
            // 
            // Sifra
            // 
            this.Sifra.DataPropertyName = "SifraProizvoda";
            this.Sifra.HeaderText = "Šifra";
            this.Sifra.Name = "Sifra";
            this.Sifra.Width = 70;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "NazivProizvoda";
            this.Naziv.HeaderText = "Proizvod";
            this.Naziv.Name = "Naziv";
            this.Naziv.Width = 120;
            // 
            // Kolicina
            // 
            this.Kolicina.DataPropertyName = "Kolicina";
            this.Kolicina.HeaderText = "Kolicina";
            this.Kolicina.Name = "Kolicina";
            this.Kolicina.Width = 50;
            // 
            // CIjena1
            // 
            this.CIjena1.DataPropertyName = "Cijena";
            this.CIjena1.HeaderText = "Cijena";
            this.CIjena1.Name = "CIjena1";
            // 
            // btnDodajStavku
            // 
            this.btnDodajStavku.Location = new System.Drawing.Point(287, 87);
            this.btnDodajStavku.Name = "btnDodajStavku";
            this.btnDodajStavku.Size = new System.Drawing.Size(83, 23);
            this.btnDodajStavku.TabIndex = 38;
            this.btnDodajStavku.Text = "Dodaj stavku";
            this.btnDodajStavku.UseVisualStyleBackColor = true;
            this.btnDodajStavku.Click += new System.EventHandler(this.btnDodajStavku_Click);
            // 
            // btnTrazi
            // 
            this.btnTrazi.Location = new System.Drawing.Point(255, 25);
            this.btnTrazi.Name = "btnTrazi";
            this.btnTrazi.Size = new System.Drawing.Size(44, 23);
            this.btnTrazi.TabIndex = 37;
            this.btnTrazi.Text = "Traži";
            this.btnTrazi.UseVisualStyleBackColor = true;
            this.btnTrazi.Click += new System.EventHandler(this.btnTrazi_Click);
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(107, 57);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.ReadOnly = true;
            this.txtNaziv.Size = new System.Drawing.Size(141, 20);
            this.txtNaziv.TabIndex = 36;
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(107, 88);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(58, 20);
            this.txtKolicina.TabIndex = 35;
            this.txtKolicina.Validating += new System.ComponentModel.CancelEventHandler(this.txtKolicina_Validating);
            // 
            // txtSifra
            // 
            this.txtSifra.Location = new System.Drawing.Point(107, 26);
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.Size = new System.Drawing.Size(141, 20);
            this.txtSifra.TabIndex = 34;
            this.txtSifra.Validating += new System.ComponentModel.CancelEventHandler(this.txtSifra_Validating);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(50, 91);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(47, 13);
            this.label.TabIndex = 32;
            this.label.Text = "Kolicina:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(60, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Naziv:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(171, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Cijena:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(66, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Sifra:";
            // 
            // btnPonisti
            // 
            this.btnPonisti.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.btnPonisti.Location = new System.Drawing.Point(453, 377);
            this.btnPonisti.Name = "btnPonisti";
            this.btnPonisti.Size = new System.Drawing.Size(114, 40);
            this.btnPonisti.TabIndex = 46;
            this.btnPonisti.Text = "Poništi";
            this.btnPonisti.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.listSkladiste);
            this.groupBox3.Controls.Add(this.btnDodajSkladiste);
            this.groupBox3.Location = new System.Drawing.Point(450, 207);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(299, 110);
            this.groupBox3.TabIndex = 45;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Skladiste";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Skladiste:";
            // 
            // listSkladiste
            // 
            this.listSkladiste.FormattingEnabled = true;
            this.listSkladiste.Location = new System.Drawing.Point(86, 28);
            this.listSkladiste.Name = "listSkladiste";
            this.listSkladiste.Size = new System.Drawing.Size(143, 21);
            this.listSkladiste.TabIndex = 0;
            this.listSkladiste.Validating += new System.ComponentModel.CancelEventHandler(this.listSkladiste_Validating);
            // 
            // btnDodajSkladiste
            // 
            this.btnDodajSkladiste.Location = new System.Drawing.Point(235, 27);
            this.btnDodajSkladiste.Name = "btnDodajSkladiste";
            this.btnDodajSkladiste.Size = new System.Drawing.Size(50, 23);
            this.btnDodajSkladiste.TabIndex = 2;
            this.btnDodajSkladiste.Text = "Dodaj";
            this.btnDodajSkladiste.UseVisualStyleBackColor = true;
            // 
            // btnProcesiraj
            // 
            this.btnProcesiraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.btnProcesiraj.Location = new System.Drawing.Point(631, 377);
            this.btnProcesiraj.Name = "btnProcesiraj";
            this.btnProcesiraj.Size = new System.Drawing.Size(119, 40);
            this.btnProcesiraj.TabIndex = 44;
            this.btnProcesiraj.Text = "Procesiraj";
            this.btnProcesiraj.UseVisualStyleBackColor = true;
            this.btnProcesiraj.Click += new System.EventHandler(this.btnProcesiraj_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // frm_Ulazi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 488);
            this.Controls.Add(this.btnPonisti);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnProcesiraj);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_Ulazi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ulazi";
            this.Load += new System.EventHandler(this.frm_Ulazi_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProizvodi)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtIznosRacuna;
        private System.Windows.Forms.ComboBox listDobavljac;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDodajDobavljaca;
        private System.Windows.Forms.TextBox txtPDV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFaktura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txtNapomena;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker txtDatum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.DataGridView dgProizvodi;
        private System.Windows.Forms.Button btnDodajStavku;
        private System.Windows.Forms.Button btnTrazi;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.TextBox txtSifra;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn UlazStavkaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sifra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIjena1;
        private System.Windows.Forms.Button btnPonisti;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox listSkladiste;
        private System.Windows.Forms.Button btnDodajSkladiste;
        private System.Windows.Forms.Button btnProcesiraj;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}