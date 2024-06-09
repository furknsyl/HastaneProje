
namespace Hastane_Proje
{
    partial class FrmDoktorBilgiDüzenle
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
            this.txttc = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.Label();
            this.txtsoyadd = new System.Windows.Forms.TextBox();
            this.txtadd = new System.Windows.Forms.TextBox();
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            this.txtsifre = new System.Windows.Forms.Label();
            this.txtsifree = new System.Windows.Forms.TextBox();
            this.btnbilgigüncelle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbbrans = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txttc
            // 
            this.txttc.AutoSize = true;
            this.txttc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txttc.Location = new System.Drawing.Point(78, 134);
            this.txttc.Name = "txttc";
            this.txttc.Size = new System.Drawing.Size(55, 25);
            this.txttc.TabIndex = 34;
            this.txttc.Text = "TC :";
            // 
            // txtSoyad
            // 
            this.txtSoyad.AutoSize = true;
            this.txtSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Location = new System.Drawing.Point(46, 86);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(87, 25);
            this.txtSoyad.TabIndex = 33;
            this.txtSoyad.Text = "Soyad :";
            // 
            // txtAd
            // 
            this.txtAd.AutoSize = true;
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(81, 43);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(52, 25);
            this.txtAd.TabIndex = 32;
            this.txtAd.Text = "Ad :";
            // 
            // txtsoyadd
            // 
            this.txtsoyadd.Location = new System.Drawing.Point(165, 90);
            this.txtsoyadd.Name = "txtsoyadd";
            this.txtsoyadd.Size = new System.Drawing.Size(126, 22);
            this.txtsoyadd.TabIndex = 31;
            // 
            // txtadd
            // 
            this.txtadd.Location = new System.Drawing.Point(165, 46);
            this.txtadd.Name = "txtadd";
            this.txtadd.Size = new System.Drawing.Size(126, 22);
            this.txtadd.TabIndex = 30;
            // 
            // msktc
            // 
            this.msktc.Location = new System.Drawing.Point(165, 137);
            this.msktc.Mask = "00000000000";
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(126, 22);
            this.msktc.TabIndex = 29;
            this.msktc.ValidatingType = typeof(int);
            // 
            // txtsifre
            // 
            this.txtsifre.AutoSize = true;
            this.txtsifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsifre.Location = new System.Drawing.Point(63, 233);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(70, 25);
            this.txtsifre.TabIndex = 36;
            this.txtsifre.Text = "Sifre :";
            // 
            // txtsifree
            // 
            this.txtsifree.Location = new System.Drawing.Point(165, 236);
            this.txtsifree.Name = "txtsifree";
            this.txtsifree.Size = new System.Drawing.Size(126, 22);
            this.txtsifree.TabIndex = 35;
            // 
            // btnbilgigüncelle
            // 
            this.btnbilgigüncelle.Location = new System.Drawing.Point(165, 282);
            this.btnbilgigüncelle.Name = "btnbilgigüncelle";
            this.btnbilgigüncelle.Size = new System.Drawing.Size(126, 33);
            this.btnbilgigüncelle.TabIndex = 37;
            this.btnbilgigüncelle.Text = "Güncelle";
            this.btnbilgigüncelle.UseVisualStyleBackColor = true;
            this.btnbilgigüncelle.Click += new System.EventHandler(this.btnbilgigüncelle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(52, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 38;
            this.label1.Text = "Brans :";
            // 
            // cmbbrans
            // 
            this.cmbbrans.FormattingEnabled = true;
            this.cmbbrans.Location = new System.Drawing.Point(165, 183);
            this.cmbbrans.Name = "cmbbrans";
            this.cmbbrans.Size = new System.Drawing.Size(121, 24);
            this.cmbbrans.TabIndex = 39;
            // 
            // FrmDoktorBilgiDüzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(420, 450);
            this.Controls.Add(this.cmbbrans);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnbilgigüncelle);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.txtsifree);
            this.Controls.Add(this.txttc);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtsoyadd);
            this.Controls.Add(this.txtadd);
            this.Controls.Add(this.msktc);
            this.Name = "FrmDoktorBilgiDüzenle";
            this.Text = "FrmDoktorBilgiDüzenle";
            this.Load += new System.EventHandler(this.FrmDoktorBilgiDüzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txttc;
        private System.Windows.Forms.Label txtSoyad;
        private System.Windows.Forms.Label txtAd;
        private System.Windows.Forms.TextBox txtsoyadd;
        private System.Windows.Forms.TextBox txtadd;
        private System.Windows.Forms.MaskedTextBox msktc;
        private System.Windows.Forms.Label txtsifre;
        private System.Windows.Forms.TextBox txtsifree;
        private System.Windows.Forms.Button btnbilgigüncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbbrans;
    }
}