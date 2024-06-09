
namespace Hastane_Proje
{
    partial class FrmBilgiDüzenle
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
            this.cmbcinsiyet = new System.Windows.Forms.ComboBox();
            this.btnkytgüncelle = new System.Windows.Forms.Button();
            this.txtcinsiyet = new System.Windows.Forms.Label();
            this.txtsifre = new System.Windows.Forms.Label();
            this.txttel = new System.Windows.Forms.Label();
            this.txttc = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.Label();
            this.txtsoyadd = new System.Windows.Forms.TextBox();
            this.txtadd = new System.Windows.Forms.TextBox();
            this.msktel = new System.Windows.Forms.MaskedTextBox();
            this.txtsifree = new System.Windows.Forms.TextBox();
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // cmbcinsiyet
            // 
            this.cmbcinsiyet.FormattingEnabled = true;
            this.cmbcinsiyet.Items.AddRange(new object[] {
            "Erkek ",
            "Kadın"});
            this.cmbcinsiyet.Location = new System.Drawing.Point(174, 261);
            this.cmbcinsiyet.Name = "cmbcinsiyet";
            this.cmbcinsiyet.Size = new System.Drawing.Size(126, 24);
            this.cmbcinsiyet.TabIndex = 6;
            // 
            // btnkytgüncelle
            // 
            this.btnkytgüncelle.Location = new System.Drawing.Point(174, 306);
            this.btnkytgüncelle.Name = "btnkytgüncelle";
            this.btnkytgüncelle.Size = new System.Drawing.Size(126, 33);
            this.btnkytgüncelle.TabIndex = 7;
            this.btnkytgüncelle.Text = "Güncelle";
            this.btnkytgüncelle.UseVisualStyleBackColor = true;
            this.btnkytgüncelle.Click += new System.EventHandler(this.btnkytgüncelle_Click);
            // 
            // txtcinsiyet
            // 
            this.txtcinsiyet.AutoSize = true;
            this.txtcinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtcinsiyet.Location = new System.Drawing.Point(50, 257);
            this.txtcinsiyet.Name = "txtcinsiyet";
            this.txtcinsiyet.Size = new System.Drawing.Size(103, 25);
            this.txtcinsiyet.TabIndex = 31;
            this.txtcinsiyet.Text = "Cinsiyet :";
            // 
            // txtsifre
            // 
            this.txtsifre.AutoSize = true;
            this.txtsifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsifre.Location = new System.Drawing.Point(78, 211);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(70, 25);
            this.txtsifre.TabIndex = 30;
            this.txtsifre.Text = "Sifre :";
            // 
            // txttel
            // 
            this.txttel.AutoSize = true;
            this.txttel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txttel.Location = new System.Drawing.Point(50, 166);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(98, 25);
            this.txttel.TabIndex = 29;
            this.txttel.Text = "Telefon :";
            // 
            // txttc
            // 
            this.txttc.AutoSize = true;
            this.txttc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txttc.Location = new System.Drawing.Point(93, 122);
            this.txttc.Name = "txttc";
            this.txttc.Size = new System.Drawing.Size(55, 25);
            this.txttc.TabIndex = 28;
            this.txttc.Text = "TC :";
            // 
            // txtSoyad
            // 
            this.txtSoyad.AutoSize = true;
            this.txtSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Location = new System.Drawing.Point(61, 74);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(87, 25);
            this.txtSoyad.TabIndex = 27;
            this.txtSoyad.Text = "Soyad :";
            // 
            // txtAd
            // 
            this.txtAd.AutoSize = true;
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(96, 31);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(52, 25);
            this.txtAd.TabIndex = 26;
            this.txtAd.Text = "Ad :";
            // 
            // txtsoyadd
            // 
            this.txtsoyadd.Location = new System.Drawing.Point(174, 78);
            this.txtsoyadd.Name = "txtsoyadd";
            this.txtsoyadd.Size = new System.Drawing.Size(126, 22);
            this.txtsoyadd.TabIndex = 2;
            // 
            // txtadd
            // 
            this.txtadd.Location = new System.Drawing.Point(174, 34);
            this.txtadd.Name = "txtadd";
            this.txtadd.Size = new System.Drawing.Size(126, 22);
            this.txtadd.TabIndex = 1;
            // 
            // msktel
            // 
            this.msktel.Location = new System.Drawing.Point(174, 170);
            this.msktel.Mask = "(999) 000-0000";
            this.msktel.Name = "msktel";
            this.msktel.Size = new System.Drawing.Size(126, 22);
            this.msktel.TabIndex = 4;
            // 
            // txtsifree
            // 
            this.txtsifree.Location = new System.Drawing.Point(174, 214);
            this.txtsifree.Name = "txtsifree";
            this.txtsifree.Size = new System.Drawing.Size(126, 22);
            this.txtsifree.TabIndex = 5;
            // 
            // msktc
            // 
            this.msktc.Location = new System.Drawing.Point(174, 125);
            this.msktc.Mask = "00000000000";
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(126, 22);
            this.msktc.TabIndex = 3;
            this.msktc.ValidatingType = typeof(int);
            // 
            // FrmBilgiDüzenle
            // 
            this.AcceptButton = this.btnkytgüncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(400, 369);
            this.Controls.Add(this.cmbcinsiyet);
            this.Controls.Add(this.btnkytgüncelle);
            this.Controls.Add(this.txtcinsiyet);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.txttc);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtsoyadd);
            this.Controls.Add(this.txtadd);
            this.Controls.Add(this.msktel);
            this.Controls.Add(this.txtsifree);
            this.Controls.Add(this.msktc);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FrmBilgiDüzenle";
            this.Text = "FrmBilgiDüzenle";
            this.Load += new System.EventHandler(this.FrmBilgiDüzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbcinsiyet;
        private System.Windows.Forms.Button btnkytgüncelle;
        private System.Windows.Forms.Label txtcinsiyet;
        private System.Windows.Forms.Label txtsifre;
        private System.Windows.Forms.Label txttel;
        private System.Windows.Forms.Label txttc;
        private System.Windows.Forms.Label txtSoyad;
        private System.Windows.Forms.Label txtAd;
        private System.Windows.Forms.TextBox txtsoyadd;
        private System.Windows.Forms.TextBox txtadd;
        private System.Windows.Forms.MaskedTextBox msktel;
        private System.Windows.Forms.TextBox txtsifree;
        private System.Windows.Forms.MaskedTextBox msktc;
    }
}