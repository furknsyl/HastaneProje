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
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }
        public string TCnumara;
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            lbltc.Text = TCnumara;

            //AD SOYAD
            SqlCommand komut = new SqlCommand("Select SekreterAdSoyad From Tbl_Sekreter where SekreterTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lbltc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbladsoyad.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();

            //BRANSLARI AKTARMA
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Branslar", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //DOKTORLARI AKTARMA
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select (DoktorAd + ' ' + DoktorSoyad) as 'Doktorlar',DoktorBrans From Tbl_Doktorlar", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView2.DataSource = dt1;

            //BRANŞLARI CMBYE AKTARMA   
            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr3 = komut2.ExecuteReader();
            while (dr3.Read())
            {
                cmbbrans.Items.Add(dr3[0]);
            }
            

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutkyt = new SqlCommand("insert into Tbl_Randevular(RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values (@p1,@p2,@p3,@p4)", bgl.baglanti());
            komutkyt.Parameters.AddWithValue("@p1", msktarih.Text);
            komutkyt.Parameters.AddWithValue("@p2", msksaat.Text);
            komutkyt.Parameters.AddWithValue("@p3", cmbbrans.Text);
            komutkyt.Parameters.AddWithValue("@p4", cmbdoktor.Text);
            komutkyt.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu oluşturuldu.");

        }

        private void cmbbrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbdoktor.Items.Clear();

            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar Where DoktorBrans=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbbrans.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbdoktor.Items.Add(dr[0] + " "+dr[1]);
            }
            bgl.baglanti().Close();

        }

        private void btnduyuruolustur_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("insert into Tbl_Duyurular (Duyuru) values (@d1)", bgl.baglanti());
            kmt.Parameters.AddWithValue("@d1", rchduyuru.Text);
            kmt.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru oluşturuldu.");
        }

        private void btndoktorpanel_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli fdp = new FrmDoktorPaneli();
            fdp.Show();
        }

        private void btnbranspanel_Click(object sender, EventArgs e)
        {
            FrmBransPaneli fb = new FrmBransPaneli();
            fb.Show();
        }

        private void btnrandevuliste_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi frl = new FrmRandevuListesi();
            frl.Show();
        }

        private void txtduyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurularcs fr = new FrmDuyurularcs();
            fr.Show();
        }
    }
}
