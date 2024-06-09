
namespace Hastane_Proje
{
    partial class FrmHastaKayit
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
            this.txtsifree = new System.Windows.Forms.TextBox();
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            this.msktel = new System.Windows.Forms.MaskedTextBox();
            this.txtadd = new System.Windows.Forms.TextBox();
            this.txtsoyadd = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.Label();
            this.txttc = new System.Windows.Forms.Label();
            this.txttel = new System.Windows.Forms.Label();
            this.txtsifre = new System.Windows.Forms.Label();
            this.txtcinsiyet = new System.Windows.Forms.Label();
            this.btnkyt = new System.Windows.Forms.Button();
            this.cmbcinsiyet = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtsifree
            // 
            this.txtsifree.Location = new System.Drawing.Point(176, 280);
            this.txtsifree.Name = "txtsifree";
            this.txtsifree.Size = new System.Drawing.Size(126, 22);
            this.txtsifree.TabIndex = 5;
            // 
            // msktc
            // 
            this.msktc.Location = new System.Drawing.Point(176, 191);
            this.msktc.Mask = "00000000000";
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(126, 22);
            this.msktc.TabIndex = 3;
            this.msktc.ValidatingType = typeof(int);
            // 
            // msktel
            // 
            this.msktel.Location = new System.Drawing.Point(176, 236);
            this.msktel.Mask = "(999) 000-0000";
            this.msktel.Name = "msktel";
            this.msktel.Size = new System.Drawing.Size(126, 22);
            this.msktel.TabIndex = 4;
            // 
            // txtadd
            // 
            this.txtadd.Location = new System.Drawing.Point(176, 100);
            this.txtadd.Name = "txtadd";
            this.txtadd.Size = new System.Drawing.Size(126, 22);
            this.txtadd.TabIndex = 1;
            // 
            // txtsoyadd
            // 
            this.txtsoyadd.Location = new System.Drawing.Point(176, 144);
            this.txtsoyadd.Name = "txtsoyadd";
            this.txtsoyadd.Size = new System.Drawing.Size(126, 22);
            this.txtsoyadd.TabIndex = 2;
            // 
            // txtAd
            // 
            this.txtAd.AutoSize = true;
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(98, 97);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(52, 25);
            this.txtAd.TabIndex = 13;
            this.txtAd.Text = "Ad :";
            // 
            // txtSoyad
            // 
            this.txtSoyad.AutoSize = true;
            this.txtSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Location = new System.Drawing.Point(63, 140);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(87, 25);
            this.txtSoyad.TabIndex = 14;
            this.txtSoyad.Text = "Soyad :";
            // 
            // txttc
            // 
            this.txttc.AutoSize = true;
            this.txttc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txttc.Location = new System.Drawing.Point(95, 188);
            this.txttc.Name = "txttc";
            this.txttc.Size = new System.Drawing.Size(55, 25);
            this.txttc.TabIndex = 15;
            this.txttc.Text = "TC :";
            // 
            // txttel
            // 
            this.txttel.AutoSize = true;
            this.txttel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txttel.Location = new System.Drawing.Point(52, 232);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(98, 25);
            this.txttel.TabIndex = 16;
            this.txttel.Text = "Telefon :";
            // 
            // txtsifre
            // 
            this.txtsifre.AutoSize = true;
            this.txtsifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsifre.Location = new System.Drawing.Point(80, 277);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(70, 25);
            this.txtsifre.TabIndex = 17;
            this.txtsifre.Text = "Sifre :";
            // 
            // txtcinsiyet
            // 
            this.txtcinsiyet.AutoSize = true;
            this.txtcinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtcinsiyet.Location = new System.Drawing.Point(52, 323);
            this.txtcinsiyet.Name = "txtcinsiyet";
            this.txtcinsiyet.Size = new System.Drawing.Size(103, 25);
            this.txtcinsiyet.TabIndex = 18;
            this.txtcinsiyet.Text = "Cinsiyet :";
            // 
            // btnkyt
            // 
            this.btnkyt.Location = new System.Drawing.Point(176, 372);
            this.btnkyt.Name = "btnkyt";
            this.btnkyt.Size = new System.Drawing.Size(126, 33);
            this.btnkyt.TabIndex = 19;
            this.btnkyt.Text = "Kayıt Yap";
            this.btnkyt.UseVisualStyleBackColor = true;
            this.btnkyt.Click += new System.EventHandler(this.btnkyt_Click);
            // 
            // cmbcinsiyet
            // 
            this.cmbcinsiyet.FormattingEnabled = true;
            this.cmbcinsiyet.ItemHeight = 16;
            this.cmbcinsiyet.Items.AddRange(new object[] {
            "Erkek ",
            "Kadın"});
            this.cmbcinsiyet.Location = new System.Drawing.Point(176, 327);
            this.cmbcinsiyet.Name = "cmbcinsiyet";
            this.cmbcinsiyet.Size = new System.Drawing.Size(126, 24);
            this.cmbcinsiyet.TabIndex = 20;
            // 
            // FrmHastaKayit
            // 
            this.AcceptButton = this.btnkyt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(422, 434);
            this.Controls.Add(this.cmbcinsiyet);
            this.Controls.Add(this.btnkyt);
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
            this.Name = "FrmHastaKayit";
            this.Text = "FrmHastaKayit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsifree;
        private System.Windows.Forms.MaskedTextBox msktc;
        private System.Windows.Forms.MaskedTextBox msktel;
        private System.Windows.Forms.TextBox txtadd;
        private System.Windows.Forms.TextBox txtsoyadd;
        private System.Windows.Forms.Label txtAd;
        private System.Windows.Forms.Label txtSoyad;
        private System.Windows.Forms.Label txttc;
        private System.Windows.Forms.Label txttel;
        private System.Windows.Forms.Label txtsifre;
        private System.Windows.Forms.Label txtcinsiyet;
        private System.Windows.Forms.Button btnkyt;
        private System.Windows.Forms.ComboBox cmbcinsiyet;
    }
}