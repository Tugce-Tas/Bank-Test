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

namespace Banka_Test
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-T00O72S;Initial Catalog=DbBankTest;Integrated Security=True");
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO TBLKİŞİLER (AD, SOYAD, TC, TELEFON, HESAPNO, SIFRE) VALUES (@p1, @p2, @p3, @p4, @p5, @p6)", conn);
            cmd.Parameters.AddWithValue("@p1", TxtAd.Text);
            cmd.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            cmd.Parameters.AddWithValue("@p3", MskTC.Text);
            cmd.Parameters.AddWithValue("@p4", MskTel.Text);
            cmd.Parameters.AddWithValue("@p5", MskHesapNo.Text);
            cmd.Parameters.AddWithValue("@p6", MskSifre.Text);
            cmd.ExecuteNonQuery();

            SqlCommand cmd2 = new SqlCommand("INSERT INTO TBLHESAP (HESAPNO,BAKIYE) VALUES (@t1, @t2)", conn);
            cmd2.Parameters.AddWithValue("@t1", MskHesapNo.Text);
            decimal bakiye = string.IsNullOrWhiteSpace(TxtBakiye.Text) ? 0.0m : decimal.Parse(TxtBakiye.Text.Replace(".", ","));
            cmd2.Parameters.AddWithValue("@t2", bakiye);
            cmd2.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Müşteri bilgileri sisteme kaydedildi");
            
        }

        private void BtnHesapNo_Click(object sender, EventArgs e)
        {
            Random randomNum = new Random();
            int hspNo = randomNum.Next(100000000, 1000000000);
            MskHesapNo.Text = hspNo.ToString();

        }
    }
}
