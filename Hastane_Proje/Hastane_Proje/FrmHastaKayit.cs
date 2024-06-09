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
    public partial class FrmHastaKayit : Form
    {
        public FrmHastaKayit()
        {
            InitializeComponent();
        }

        sqlbaglantisi bql = new sqlbaglantisi();
        private void btnkyt_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Hastalar (HastaAd,HastaSoyad,HastaTC,HastaTelefon,HastaSifre,HastaCinsiyet) values(@p1,@p2,@p3,@p4,@p5,@p6)", bql.baglanti());
            komut.Parameters.AddWithValue("@p1", txtadd.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyadd.Text);
            komut.Parameters.AddWithValue("@p3", msktc.Text);
            komut.Parameters.AddWithValue("@p4", msktel.Text);
            komut.Parameters.AddWithValue("@p5", txtsifree.Text);
            komut.Parameters.AddWithValue("@p6", cmbcinsiyet.Text);
            komut.ExecuteNonQuery();
            bql.baglanti().Close();
            MessageBox.Show("Kaydınız gerçekleşti.", "Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
