namespace prosjekOcjenaFormsKolekcije
{
    partial class Form1
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
            this.btnUnesi = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnIspisi = new System.Windows.Forms.Button();
            this.txtOcjena = new System.Windows.Forms.TextBox();
            this.txtIspis = new System.Windows.Forms.TextBox();
            this.cmbPredmeti = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUcitaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(560, 115);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(108, 23);
            this.btnUnesi.TabIndex = 0;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(500, 144);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(168, 93);
            this.btnSpremi.TabIndex = 1;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            // 
            // btnIspisi
            // 
            this.btnIspisi.Location = new System.Drawing.Point(500, 245);
            this.btnIspisi.Name = "btnIspisi";
            this.btnIspisi.Size = new System.Drawing.Size(168, 93);
            this.btnIspisi.TabIndex = 2;
            this.btnIspisi.Text = "Ispiši";
            this.btnIspisi.UseVisualStyleBackColor = true;
            this.btnIspisi.Click += new System.EventHandler(this.btnIspisi_Click);
            // 
            // txtOcjena
            // 
            this.txtOcjena.Location = new System.Drawing.Point(500, 116);
            this.txtOcjena.Name = "txtOcjena";
            this.txtOcjena.Size = new System.Drawing.Size(54, 22);
            this.txtOcjena.TabIndex = 3;
            // 
            // txtIspis
            // 
            this.txtIspis.Location = new System.Drawing.Point(12, 42);
            this.txtIspis.Multiline = true;
            this.txtIspis.Name = "txtIspis";
            this.txtIspis.Size = new System.Drawing.Size(482, 296);
            this.txtIspis.TabIndex = 4;
            // 
            // cmbPredmeti
            // 
            this.cmbPredmeti.FormattingEnabled = true;
            this.cmbPredmeti.Items.AddRange(new object[] {
            "Hrvatski jezik",
            "Matematika"});
            this.cmbPredmeti.Location = new System.Drawing.Point(12, 12);
            this.cmbPredmeti.Name = "cmbPredmeti";
            this.cmbPredmeti.Size = new System.Drawing.Size(482, 24);
            this.cmbPredmeti.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(500, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ocjena:";
            // 
            // btnUcitaj
            // 
            this.btnUcitaj.Location = new System.Drawing.Point(500, 12);
            this.btnUcitaj.Name = "btnUcitaj";
            this.btnUcitaj.Size = new System.Drawing.Size(168, 82);
            this.btnUcitaj.TabIndex = 7;
            this.btnUcitaj.Text = "Učitaj";
            this.btnUcitaj.UseVisualStyleBackColor = true;
            this.btnUcitaj.Click += new System.EventHandler(this.btnUcitaj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 356);
            this.Controls.Add(this.btnUcitaj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPredmeti);
            this.Controls.Add(this.txtIspis);
            this.Controls.Add(this.txtOcjena);
            this.Controls.Add(this.btnIspisi);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.btnUnesi);
            this.Name = "Form1";
            this.Text = "Prosjek ocjena";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnIspisi;
        private System.Windows.Forms.TextBox txtOcjena;
        private System.Windows.Forms.TextBox txtIspis;
        private System.Windows.Forms.ComboBox cmbPredmeti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUcitaj;
    }
}

