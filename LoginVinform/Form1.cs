using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginVinform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string şifre = txt_password.Text;
            string gmail = txt_email.Text;

            try
            {
                if (şifre == "admin" && gmail == "admin@gmail.com")
                {
                    MessageBox.Show("Başarılı  bir şekilde giriş yaptınız");
                }
                else
                {
                    MessageBox.Show("malesef bilgileri hatalı girdiniz");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bölmeleri hatalı doldurdunuz");
            }

        }

        private void Cb_Created_CheckedChanged(object sender, EventArgs e)
        {
            txt_password.PasswordChar = Cb_Created.Checked ? '\0' : '*';
        }
    }
}
