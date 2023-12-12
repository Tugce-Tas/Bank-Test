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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-T00O72S;Initial Catalog=DbBankTest;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TxtSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MskHesapNo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        
        private void LinkKayit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
                RegistrationForm frm3 = new RegistrationForm();
            frm3.Show();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM TBLKİŞİLER WHERE HESAPNO = @p1 and SIFRE = @p2", conn);
            cmd.Parameters.AddWithValue("@p1", MskHesapNo.Text);
            cmd.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                AccountDetails accountDetails = new AccountDetails();
                accountDetails.hesap = MskHesapNo.Text;
                accountDetails.Show();
                
            }
            else
            {
                MessageBox.Show("Hatalı bilgi!");
            }
            conn.Close();
        }

        private void MskSifre_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
