namespace PeP_UI.Warehouses
{
    partial class frm_Skladista
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
            this.dgSkladista = new System.Windows.Forms.DataGridView();
            this.SkladisteID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNazivAdresaPretraga = new System.Windows.Forms.TextBox();
            this.btnTrazi = new System.Windows.Forms.Button();
            this.groutPretraga = new System.Windows.Forms.GroupBox();
            this.btnUredi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.btnPonisti = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgSkladista)).BeginInit();
            this.groutPretraga.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // dgSkladista
            // 
            this.dgSkladista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSkladista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SkladisteID,
            this.Naziv,
            this.Adresa,
            this.Opis});
            this.dgSkladista.Location = new System.Drawing.Point(15, 53);
            this.dgSkladista.Name = "dgSkladista";
            this.dgSkladista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSkladista.Size = new System.Drawing.Size(616, 139);
            this.dgSkladista.TabIndex = 0;
            // 
            // SkladisteID
            // 
            this.SkladisteID.DataPropertyName = "SkladisteID";
            this.SkladisteID.HeaderText = "SkladisteID";
            this.SkladisteID.Name = "SkladisteID";
            this.SkladisteID.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.Width = 120;
            // 
            // Adresa
            // 
            this.Adresa.DataPropertyName = "Adresa";
            this.Adresa.HeaderText = "Adresa";
            this.Adresa.Name = "Adresa";
            this.Adresa.Width = 120;
            // 
            // Opis
            // 
            this.Opis.DataPropertyName = "Opis";
            this.Opis.HeaderText = "Opis";
            this.Opis.Name = "Opis";
            this.Opis.Width = 333;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naziv/Adresa:";
            // 
            // txtNazivAdresaPretraga
            // 
            this.txtNazivAdresaPretraga.Location = new System.Drawing.Point(106, 23);
            this.txtNazivAdresaPretraga.Name = "txtNazivAdresaPretraga";
            this.txtNazivAdresaPretraga.Size = new System.Drawing.Size(100, 20);
            this.txtNazivAdresaPretraga.TabIndex = 2;
            // 
            // btnTrazi
            // 
            this.btnTrazi.Location = new System.Drawing.Point(556, 11);
            this.btnTrazi.Name = "btnTrazi";
            this.btnTrazi.Size = new System.Drawing.Size(75, 39);
            this.btnTrazi.TabIndex = 3;
            this.btnTrazi.Text = "Traži";
            this.btnTrazi.UseVisualStyleBackColor = true;
            this.btnTrazi.Click += new System.EventHandler(this.btnTrazi_Click);
            // 
            // groutPretraga
            // 
            this.groutPretraga.Controls.Add(this.btnUredi);
            this.groutPretraga.Controls.Add(this.dgSkladista);
            this.groutPretraga.Controls.Add(this.btnTrazi);
            this.groutPretraga.Controls.Add(this.label1);
            this.groutPretraga.Controls.Add(this.txtNazivAdresaPretraga);
            this.groutPretraga.Location = new System.Drawing.Point(12, 12);
            this.groutPretraga.Name = "groutPretraga";
            this.groutPretraga.Size = new System.Drawing.Size(646, 230);
            this.groutPretraga.TabIndex = 4;
            this.groutPretraga.TabStop = false;
            this.groutPretraga.Text = "Pretraga skladišta";
            // 
            // btnUredi
            // 
            this.btnUredi.Location = new System.Drawing.Point(556, 198);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(75, 26);
            this.btnUredi.TabIndex = 4;
            this.btnUredi.Text = "Uredi";
            this.btnUredi.UseVisualStyleBackColor = true;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSacuvaj);
            this.groupBox1.Controls.Add(this.btnPonisti);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtAdresa);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtOpis);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNaziv);
            this.groupBox1.Location = new System.Drawing.Point(12, 248);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(646, 149);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Novo skladište";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(556, 95);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(75, 39);
            this.btnSacuvaj.TabIndex = 5;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // btnPonisti
            // 
            this.btnPonisti.Location = new System.Drawing.Point(349, 95);
            this.btnPonisti.Name = "btnPonisti";
            this.btnPonisti.Size = new System.Drawing.Size(75, 39);
            this.btnPonisti.TabIndex = 6;
            this.btnPonisti.Text = "Poništi";
            this.btnPonisti.UseVisualStyleBackColor = true;
            this.btnPonisti.Click += new System.EventHandler(this.btnPonisti_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Adresa:";
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(68, 69);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(194, 20);
            this.txtAdresa.TabIndex = 8;
            this.txtAdresa.Validating += new System.ComponentModel.CancelEventHandler(this.txtAdresa_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Opis:";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(349, 32);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(282, 57);
            this.txtOpis.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Naziv:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(68, 32);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(194, 20);
            this.txtNaziv.TabIndex = 4;
            this.txtNaziv.Validating += new System.ComponentModel.CancelEventHandler(this.txtNazivSkladista_Validating);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // frm_Skladista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 409);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groutPretraga);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_Skladista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Skladišta";
            this.Load += new System.EventHandler(this.frm_Skladista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSkladista)).EndInit();
            this.groutPretraga.ResumeLayout(false);
            this.groutPretraga.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgSkladista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNazivAdresaPretraga;
        private System.Windows.Forms.Button btnTrazi;
        private System.Windows.Forms.GroupBox groutPretraga;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnPonisti;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn SkladisteID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}