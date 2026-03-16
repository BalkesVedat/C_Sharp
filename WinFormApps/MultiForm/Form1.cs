using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiForm
{
    public partial class frmLogin : Form
    {
        MainForm frmMain = new MainForm();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtPassword.Text=="1234" && txtUserName.Text.ToLower()=="vedat")
            {
                frmMain.Show();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
            }



        }
    }
}
