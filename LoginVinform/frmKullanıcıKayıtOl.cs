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
    public partial class frmKullanıcıKayıtOl : Form
    {
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

      
    }
}
