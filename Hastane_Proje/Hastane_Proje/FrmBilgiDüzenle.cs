using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hastane_Proje
{
    public partial class FrmBilgiDüzenle : Form
    {
        public FrmBilgiDüzenle()
        {
            InitializeComponent();
        }

        public string TCno;
        sqlbaglantisi bql = new sqlbaglantisi();
        private void FrmBilgiDüzenle_Load(object sender, EventArgs e)
        {
            msktc.Text = TCno;
            SqlCommand komut = new SqlCommand("Select * From Tbl_Hastalar where HastaTC=@p1", bql.baglanti());
            komut.Parameters.AddWithValue("@p1", msktc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtadd.Text = dr[1].ToString();
                txtsoyadd.Text = dr[2].ToString();
                msktel.Text = dr[4].ToString();
                txtsifree.Text = dr[5].ToString();
                cmbcinsiyet.Text = dr[6].ToString();
            }
            bql.baglanti().Close();
        }

        private void btnkytgüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("Update Tbl_Hastalar set HastaAd=@p1,HastaSoyad=@p2,HastaTelefon=@p3,HastaSifre=@p4,HastaCinsiyet=@p5 where HastaTC=@p6", bql.baglanti());
            komut2.Parameters.AddWithValue("@p1", txtadd.Text);
            komut2.Parameters.AddWithValue("@p2", txtsoyadd.Text);
            komut2.Parameters.AddWithValue("@p3", msktel.Text);
            komut2.Parameters.AddWithValue("@p4", txtsifree.Text);
            komut2.Parameters.AddWithValue("@p5",cmbcinsiyet.Text);
            komut2.Parameters.AddWithValue("@p6", msktc.Text);
            komut2.ExecuteNonQuery();
            bql.baglanti().Close();
            MessageBox.Show("Bilgileriniz güncellendi");

        }
    }
}
