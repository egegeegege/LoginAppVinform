using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design.WebControls;
using System.Windows.Forms;
using LoginVinform.UseControl;

namespace LoginVinform
{
    public partial class form2 : Form
    {
        public form2()
        {
            InitializeComponent();
            UC_Home uC_Home = new UC_Home();
            addUserControl(uC_Home);
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            Controls.Clear();
            Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UC_Home uc = new UC_Home();
            addUserControl(uc); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UC_Inbox uc = new UC_Inbox();
            addUserControl(uc);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UC_Sent uc = new UC_Sent();
            addUserControl(uc);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UC_Settings uc = new UC_Settings();
            addUserControl(uc);
        }
    }
}
