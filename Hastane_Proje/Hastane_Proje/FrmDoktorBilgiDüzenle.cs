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
    public partial class FrmDoktorBilgiDüzenle : Form
    {
        public FrmDoktorBilgiDüzenle()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        public string TC;
        private void FrmDoktorBilgiDüzenle_Load(object sender, EventArgs e)
        {
            msktc.Text = TC;
            SqlCommand kmt = new SqlCommand("Select * From Tbl_Doktorlar where DoktorTC=@p1", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", msktc.Text);
            SqlDataReader dr = kmt.ExecuteReader();
            while (dr.Read())
            {
                txtadd.Text = dr[1].ToString();
                txtsoyadd.Text = dr[2].ToString();
                cmbbrans.Text = dr[3].ToString();
                txtsifree.Text = dr[5].ToString();
                    
            }
            bgl.baglanti().Close();    
        }

        private void btnbilgigüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("Update Tbl_Doktorlar set DoktorAd=@p1,DoktorSoyad=@p2,DoktorBrans=@p3,DoktorSifre=@p4 where DoktorTC=@p5", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", txtadd.Text);
            kmt.Parameters.AddWithValue("@p2", txtsoyadd.Text);
            kmt.Parameters.AddWithValue("@p3", cmbbrans.Text);
            kmt.Parameters.AddWithValue("@p4", txtsifree.Text);
            kmt.Parameters.AddWithValue("@p5", msktc.Text);
            kmt.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt güncellendi.");
            
        }
    }
}
