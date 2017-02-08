namespace PeP_UI.Products
{
    partial class frm_ProizvodiUredi
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
            this.label6 = new System.Windows.Forms.Label();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnDodajSliku = new System.Windows.Forms.Button();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.jedinicaMjereList = new System.Windows.Forms.ComboBox();
            this.slikaBox = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxAktivan = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.vrsteList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSlika = new System.Windows.Forms.TextBox();
            this.txtSifra = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtCijena = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.slikaBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Slika:";
            // 
            // btnOdustani
            // 
            this.btnOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdustani.Location = new System.Drawing.Point(379, 165);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 41);
            this.btnOdustani.TabIndex = 29;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnDodajSliku
            // 
            this.btnDodajSliku.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajSliku.Location = new System.Drawing.Point(219, 152);
            this.btnDodajSliku.Name = "btnDodajSliku";
            this.btnDodajSliku.Size = new System.Drawing.Size(56, 22);
            this.btnDodajSliku.TabIndex = 27;
            this.btnDodajSliku.Text = "Dodaj";
            this.btnDodajSliku.UseVisualStyleBackColor = true;
            this.btnDodajSliku.Click += new System.EventHandler(this.btnDodajSliku_Click);
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvaj.Location = new System.Drawing.Point(480, 165);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(75, 41);
            this.btnSacuvaj.TabIndex = 30;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // jedinicaMjereList
            // 
            this.jedinicaMjereList.FormattingEnabled = true;
            this.jedinicaMjereList.Location = new System.Drawing.Point(218, 121);
            this.jedinicaMjereList.Name = "jedinicaMjereList";
            this.jedinicaMjereList.Size = new System.Drawing.Size(54, 21);
            this.jedinicaMjereList.TabIndex = 23;
            this.jedinicaMjereList.Validating += new System.ComponentModel.CancelEventHandler(this.jedinicaMjereList_Validating);
            // 
            // slikaBox
            // 
            this.slikaBox.BackColor = System.Drawing.Color.White;
            this.slikaBox.Location = new System.Drawing.Point(428, 25);
            this.slikaBox.Name = "slikaBox";
            this.slikaBox.Size = new System.Drawing.Size(126, 118);
            this.slikaBox.TabIndex = 32;
            this.slikaBox.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Vrsta:";
            // 
            // cbxAktivan
            // 
            this.cbxAktivan.AutoSize = true;
            this.cbxAktivan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAktivan.Location = new System.Drawing.Point(278, 124);
            this.cbxAktivan.Name = "cbxAktivan";
            this.cbxAktivan.Size = new System.Drawing.Size(62, 17);
            this.cbxAktivan.TabIndex = 24;
            this.cbxAktivan.Text = "Aktivan";
            this.cbxAktivan.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Jed. mjere:";
            // 
            // vrsteList
            // 
            this.vrsteList.FormattingEnabled = true;
            this.vrsteList.Location = new System.Drawing.Point(69, 25);
            this.vrsteList.Name = "vrsteList";
            this.vrsteList.Size = new System.Drawing.Size(264, 21);
            this.vrsteList.TabIndex = 17;
            this.vrsteList.Validating += new System.ComponentModel.CancelEventHandler(this.vrsteList_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Cijena:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(69, 90);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(264, 20);
            this.txtNaziv.TabIndex = 20;
            this.txtNaziv.Validating += new System.ComponentModel.CancelEventHandler(this.txtNaziv_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Naziv:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Šifra:";
            // 
            // txtSlika
            // 
            this.txtSlika.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSlika.Location = new System.Drawing.Point(69, 153);
            this.txtSlika.Name = "txtSlika";
            this.txtSlika.Size = new System.Drawing.Size(136, 20);
            this.txtSlika.TabIndex = 25;
            // 
            // txtSifra
            // 
            this.txtSifra.Location = new System.Drawing.Point(69, 57);
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.Size = new System.Drawing.Size(264, 20);
            this.txtSifra.TabIndex = 18;
            this.txtSifra.Validating += new System.ComponentModel.CancelEventHandler(this.txtSifra_Validating);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(69, 121);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(80, 20);
            this.txtCijena.TabIndex = 34;
            // 
            // frm_ProizvodiUredi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 218);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnDodajSliku);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.jedinicaMjereList);
            this.Controls.Add(this.slikaBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxAktivan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.vrsteList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSlika);
            this.Controls.Add(this.txtSifra);
            this.Name = "frm_ProizvodiUredi";
            this.Text = "Uredi proizvod";
            this.Load += new System.EventHandler(this.frm_ProizvodiUredi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.slikaBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

     

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnDodajSliku;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.ComboBox jedinicaMjereList;
        private System.Windows.Forms.PictureBox slikaBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbxAktivan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox vrsteList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSlika;
        private System.Windows.Forms.TextBox txtSifra;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox txtCijena;
    }
}