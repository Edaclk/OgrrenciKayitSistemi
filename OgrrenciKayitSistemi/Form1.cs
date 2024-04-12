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

namespace OgrrenciKayitSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(" Data Source = DESKTOP-A9IP5ML\\SQLEXPRESS; Initial Catalog = OgrenciVeriTabani; Integrated Security = True");

        void temizle()
        {
            txtNo.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtMail.Text = "";
            dtimeDogum.Value = DateTime.Now;
            txtBolum.Text = "";
            cmbSinif.Text = "";
            dtimeKayit.Value = DateTime.Now;
            txtAd.Focus();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.tbl_OgrenciKayitTableAdapter.Fill(this.ogrenciVeriTabaniDataSet1.Tbl_OgrenciKayit);

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            this.tbl_OgrenciKayitTableAdapter.Fill(this.ogrenciVeriTabaniDataSet1.Tbl_OgrenciKayit);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_OgrenciKayit (OgrenciAd,OgrenciSoyad,OgrenciMail,OgrenciDog,OgrenciBolum,OgrenciSinif,OgrenciKayit) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", txtMail.Text);
            komut.Parameters.AddWithValue("@p4", dtimeDogum.Value);
            komut.Parameters.AddWithValue("@p5", txtBolum.Text);
            komut.Parameters.AddWithValue("@p6", cmbSinif.Text);
            komut.Parameters.AddWithValue("@p7", dtimeKayit.Value);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci Eklendi");
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtNo.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtMail.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            // DataGridView hücresinden alınan tarih değerini DateTime tipine dönüştürerek DateTimePicker'a atayın
            if (DateTime.TryParse(dataGridView1.Rows[secilen].Cells[4].Value.ToString(), out DateTime tarih))
            {
                dtimeDogum.Value = tarih;
            }
            else
            {
                // Dönüştürme başarısız olursa, DateTimePicker'ı temizleyin veya varsayılan bir tarih değeri atayın
                dtimeDogum.Value = DateTime.Now; // Varsayılan olarak geçerli tarih ve saat değerini kullanabilirsiniz.
            }
            txtBolum.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            cmbSinif.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            // DataGridView hücresinden alınan tarih değerini DateTime tipine dönüştürerek DateTimePicker'a atayın
            if (DateTime.TryParse(dataGridView1.Rows[secilen].Cells[7].Value.ToString(), out DateTime tarih1))
            {
                dtimeKayit.Value = tarih1;
            }
            else
            {
                // Dönüştürme başarısız olursa, DateTimePicker'ı temizleyin veya varsayılan bir tarih değeri atayın
                dtimeKayit.Value = DateTime.Now; // Varsayılan olarak geçerli tarih ve saat değerini kullanabilirsiniz.
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("Delete From Tbl_OgrenciKayit Where OgrenciNo=@k1", baglanti);
            komutsil.Parameters.AddWithValue("@k1", txtNo.Text);
            komutsil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Silindi");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutguncelle = new SqlCommand("Update Tbl_OgrenciKayit Set OgrenciAd=@a1,OgrenciSoyad=@a2,OgrenciMail=@a3,OgrenciDog=@a4,OgrenciBolum=@a5,OgrenciSinif=@a6,OgrenciKayit=@a7 where OgrenciNo=@a8", baglanti);
            komutguncelle.Parameters.AddWithValue("@a1", txtAd.Text);
            komutguncelle.Parameters.AddWithValue("@a2", txtSoyad.Text);
            komutguncelle.Parameters.AddWithValue("@a3", txtMail.Text);
            komutguncelle.Parameters.AddWithValue("@a4", dtimeDogum.Value);
            komutguncelle.Parameters.AddWithValue("@a5", txtBolum.Text);
            komutguncelle.Parameters.AddWithValue("@a6", cmbSinif.Text);
            komutguncelle.Parameters.AddWithValue("@a7",dtimeKayit.Value);
            komutguncelle.Parameters.AddWithValue("@a8", txtNo.Text);
            komutguncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci Bilgileri Güncellendi");

        }
    }
}
