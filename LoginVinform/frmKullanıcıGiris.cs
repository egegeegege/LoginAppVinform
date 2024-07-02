using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginVinform.ROM.Context;
using LoginVinform.ROM.Entity;

namespace LoginVinform
{
    public partial class frmKullanıcıGiris : Form
    {
        ProjectDbContext db = new ProjectDbContext();
        string Sifre = "";
        string Email = "";
        int id;

        public frmKullanıcıGiris()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            List<UserItem> users = new List<UserItem>();
            users = db.UserItems.Where(y => y.Email == txt_email.Text).ToList();

            foreach (UserItem ıtem in users)
            {

                Sifre = ıtem.Sifre.ToString();
                Email = ıtem.Email.ToString();
                id = ıtem.ID;
            }
           
                if (Sifre == txt_password.Text)
                {
                    if (Email == txt_email.Text)
                    {
                        MessageBox.Show("Başarılı bir şekilde giriş yaptınız");
                    }
                    else
                    {
                        MessageBox.Show("Email Hatalı");
                    }
                }
                else
                {
                    MessageBox.Show("Şifre Hatalı");
                }   
           
        }

        private void Cb_Created_CheckedChanged(object sender, EventArgs e)
        {
            txt_password.PasswordChar = Cb_Created.Checked ? '\0' : '*';
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmKullanıcıKayıtOl frmKullanıcıKayıtOl = new frmKullanıcıKayıtOl();
            frmKullanıcıKayıtOl.Show();
            this.Hide();
        }
    }
}
