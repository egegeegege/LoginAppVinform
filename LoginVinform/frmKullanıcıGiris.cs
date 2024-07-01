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
            List<UserItem> ynt = new List<UserItem>();
            // buradan devam et
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
