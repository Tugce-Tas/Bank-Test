using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Banka_Test
{
    public partial class AccountDetails : Form
    {
        public AccountDetails()
        {
            InitializeComponent();
        }
        public string hesap;

        private void label1_Click(object sender, EventArgs e)
        {

        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-T00O72S;Initial Catalog=DbBankTest;Integrated Security=True");
        private void Form2_Load(object sender, EventArgs e)
        {
            conn.Open();
            LblHesapNo.Text = hesap;
            SqlCommand cmd = new SqlCommand("SELECT * FROM TBLKİŞİLER WHERE HESAPNO = @p1", conn);
            cmd.Parameters.AddWithValue("@p1", hesap);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                LblAdSoyad.Text = rdr[1] + " " + rdr[2];
                LblTC.Text = rdr[3].ToString();
                LblTel.Text = rdr[4].ToString();
                LblHesapNo.Text = rdr[5].ToString();
            }
            conn.Close();

            conn.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM TBLHESAP WHERE HESAPNO = @t1", conn);
            cmd2.Parameters.AddWithValue("@t1", hesap);
            SqlDataReader dr = cmd2.ExecuteReader();
            if (dr.Read())
            {
                LbLBakiye.Text = dr[1] + " TL";
            }
            conn.Close();
        }

        private void BtnGönder_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("UPDATE TBLHESAP SET BAKIYE = BAKIYE+@P1 WHERE HESAPNO=@P2", conn);
            cmd.Parameters.AddWithValue("@P1", decimal.Parse(TxtTutar.Text) );
            cmd.Parameters.AddWithValue("@P2", MskAlici.Text);
            cmd.ExecuteNonQuery();

            SqlCommand cmd2 = new SqlCommand("UPDATE TBLHESAP SET BAKIYE = BAKIYE-@T1 WHERE HESAPNO=@T2", conn);
            cmd2.Parameters.AddWithValue("@T1", decimal.Parse(TxtTutar.Text));
            cmd2.Parameters.AddWithValue("@T2", hesap);
            cmd2.ExecuteNonQuery();

            SqlCommand cmd3 = new SqlCommand("INSERT INTO TBLHAREKET (GONDEREN, ALICI,TUTAR) VALUES (@P1, @P2, @P3)", conn);
            cmd3.Parameters.AddWithValue("@P1", LblAdSoyad.Text);
            cmd3.Parameters.AddWithValue("@P3", decimal.Parse(TxtTutar.Text));
            

            SqlCommand cmd4 = new SqlCommand("SELECT * FROM TBLKİŞİLER WHERE HESAPNO = @T1", conn);
            cmd4.Parameters.AddWithValue("@T1", MskAlici.Text);
            SqlDataReader dr = cmd4.ExecuteReader();
            if (dr.Read())
            {
                cmd3.Parameters.AddWithValue("@P2", dr[1] + " " + dr[2]);
            }
            dr.Close();
            cmd3.ExecuteNonQuery();

            SqlCommand cmd5 = new SqlCommand("SELECT * FROM TBLHESAP WHERE HESAPNO = @H1", conn);
            cmd5.Parameters.AddWithValue("@H1", hesap);
            SqlDataReader dr2 = cmd5.ExecuteReader();
            if (dr2.Read())
            {
                LbLBakiye.Text = dr2[1] + " TL";
            }
            dr2.Close();

            conn.Close();

            MessageBox.Show("İşlem gerçekleşti...");
        }


        private void BtnÇek_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("UPDATE TBLHESAP SET BAKIYE = BAKIYE-@T1 WHERE HESAPNO=@T2", conn);
            cmd.Parameters.AddWithValue("@T1", decimal.Parse(TxtTutar2.Text));
            cmd.Parameters.AddWithValue("@T2", hesap);
            cmd.ExecuteNonQuery();

            SqlCommand cmd2 = new SqlCommand("SELECT * FROM TBLHESAP WHERE HESAPNO = @t1", conn);
            cmd2.Parameters.AddWithValue("@t1", hesap);
            SqlDataReader dr = cmd2.ExecuteReader();
            if (dr.Read())
            {
                LbLBakiye.Text = dr[1] + " TL";
            }

            conn.Close();

            MessageBox.Show("Hesabınızdan " + TxtTutar2.Text + " TL çekildi...");
        }

        private void BtnYatir_Click_1(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("UPDATE TBLHESAP SET BAKIYE = BAKIYE+@T1 WHERE HESAPNO=@T2", conn);
            cmd.Parameters.AddWithValue("@T1", decimal.Parse(TxtTutar2.Text));
            cmd.Parameters.AddWithValue("@T2", hesap);
            cmd.ExecuteNonQuery();

            SqlCommand cmd2 = new SqlCommand("SELECT * FROM TBLHESAP WHERE HESAPNO = @t1", conn);
            cmd2.Parameters.AddWithValue("@t1", hesap);
            SqlDataReader dr = cmd2.ExecuteReader();
            if (dr.Read())
            {
                LbLBakiye.Text = dr[1] + " TL";
            }

            conn.Close();

            MessageBox.Show("Hesabınıza " + TxtTutar2.Text + " TL yatırıldı..." );
        }
    }
}
