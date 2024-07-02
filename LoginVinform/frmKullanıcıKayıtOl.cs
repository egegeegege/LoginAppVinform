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
    public partial class frmKullanıcıKayıtOl : Form
    {
        ProjectDbContext db = new ProjectDbContext();
        public frmKullanıcıKayıtOl()
        {
            InitializeComponent();
        }

        private void Cb_Created_CheckedChanged(object sender, EventArgs e)
        {
            txt_password.PasswordChar = Cb_Created.Checked ? '\0' : '*';
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmKullanıcıGiris frmKullanıcıGiris = new frmKullanıcıGiris();
            frmKullanıcıGiris.Show();
            this.Hide();
        }

        private void btn_signUp_Click(object sender, EventArgs e)
        {
            List<UserItem> users = new List<UserItem>();
            users = db.UserItems.ToList();
            bool kullanıcıVar = false;

            foreach (var user in users)
            {
                if (user.TelefonNo == txt_phoneNumber.Text)
                {
                    kullanıcıVar = true;
                }
            }

            if (kullanıcıVar)
            {
                MessageBox.Show("bu telefon numarasına ait bir kullanıcı zaaten var");
            }
            else
            {
                UserItem user = new UserItem()
                {
                    TelefonNo = txt_phoneNumber.Text,
                    Email = txt_email.Text,
                    Adres = txt_adres.Text,
                    KullanıcıAdı = txt_Username.Text,
                    Sifre = txt_password.Text,
                    Aktifmi = true
                };
                db.UserItems.Add(user);
                db.SaveChanges();
                MessageBox.Show("kayıt oluşturuldu");
                frmKullanıcıGiris frmKullanıcıGiris = new frmKullanıcıGiris();
                frmKullanıcıGiris.Show();
                this.Hide();
            }
        }
    }
}
