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
    public partial class FrmCalc : Form
    {
        public FrmCalc()
        {
            InitializeComponent();
        }

        private void FrmCalc_Load(object sender, EventArgs e)
        {

        }

        private void NumericKeyPress(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0")
            {
                txtScreen.Text = string.Empty;
            }

            Button btn = (Button)sender;
            txtScreen.Text += btn.Text;
        }

        //NOT: Alttaki kodları kapattık. Çünkü butonların Click Event delegesine doğrudan NumericKeyPress metodunu bağladığımız için bunlara gerek kalmadı.

        //private void btn1_Click(object sender, EventArgs e)
        //{
        //    NumericKeyPress(sender, e);
        //}

        //private void btn2_Click(object sender, EventArgs e)
        //{
        //    NumericKeyPress(sender, e);
        //}

        //private void btn3_Click(object sender, EventArgs e)
        //{
        //    NumericKeyPress(sender, e);
        //}

        //private void btn4_Click(object sender, EventArgs e)
        //{
        //    NumericKeyPress(sender, e);
        //}

        //private void btn5_Click(object sender, EventArgs e)
        //{
        //    NumericKeyPress(sender, e);
        //}

        //private void btn6_Click(object sender, EventArgs e)
        //{
        //    NumericKeyPress(sender, e);
        //}

        //private void btn7_Click(object sender, EventArgs e)
        //{
        //    NumericKeyPress(sender, e);
        //}

        //private void btn8_Click(object sender, EventArgs e)
        //{
        //    NumericKeyPress(sender, e);
        //}

        //private void btn9_Click(object sender, EventArgs e)
        //{
        //    NumericKeyPress(sender, e);
        //}

        //private void btn0_Click(object sender, EventArgs e)
        //{
        //    NumericKeyPress(sender, e);
        //}
    }
}
