namespace PeP_UI.Warehouses
{
    partial class frm_SkladistaUredi
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
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.btnPonisti = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(183, 242);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(75, 39);
            this.btnSacuvaj.TabIndex = 12;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // btnPonisti
            // 
            this.btnPonisti.Location = new System.Drawing.Point(64, 242);
            this.btnPonisti.Name = "btnPonisti";
            this.btnPonisti.Size = new System.Drawing.Size(75, 39);
            this.btnPonisti.TabIndex = 14;
            this.btnPonisti.Text = "Poništi";
            this.btnPonisti.UseVisualStyleBackColor = true;
            this.btnPonisti.Click += new System.EventHandler(this.btnPonisti_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Adresa:";
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(64, 68);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(194, 20);
            this.txtAdresa.TabIndex = 17;
            this.txtAdresa.Validating += new System.ComponentModel.CancelEventHandler(this.txtAdresa_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Opis:";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(64, 104);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(194, 119);
            this.txtOpis.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Naziv:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(64, 31);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(194, 20);
            this.txtNaziv.TabIndex = 11;
            this.txtNaziv.Validating += new System.ComponentModel.CancelEventHandler(this.txtNazivSkladista_Validating);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // frm_SkladistaUredi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 321);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.btnPonisti);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNaziv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_SkladistaUredi";
            this.Text = "Uredi skladište";
            this.Load += new System.EventHandler(this.frm_SkladistaUredi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnPonisti;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}