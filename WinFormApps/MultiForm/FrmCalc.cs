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
        //string oprt = "";
        //double number1, number2, result;

        public string oprt { get; set; }
        public double number1 { get; set; }
        public double number2 { get; set; }
        public double result { get; set; }

        public bool isComputed { get; set; }


        public FrmCalc()
        {
            InitializeComponent();
        }

        private void FrmCalc_Load(object sender, EventArgs e)
        {

        }

        private void NumericKeyPress(object sender, EventArgs e)
        {
            if (isComputed)
            {
                txtScreen.Text = "0";
                isComputed = false;
            }

            if (txtScreen.Text == "0")
            {
                txtScreen.Text = string.Empty;
            }

            Button btn = (Button)sender;
            txtScreen.Text += btn.Text;
        }

        private void OperatorKeyPress(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            oprt = btn.Text;
            number1 = Convert.ToDouble(txtScreen.Text);
            txtScreen.Text = "0";
            txtControl.Text = number1 + " " + oprt;
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            number2 = Convert.ToDouble(txtScreen.Text);

            switch (oprt)
            {
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                case "/":
                    if (number2 == 0)
                        result = 0;
                    else
                        result = number1 / number2;

                    break;
                default:
                    //result = 0;
                    break;
            }

            txtScreen.Text = result.ToString();
            txtControl.Text = number1 + " " + oprt + " " + number2 + " = ";
            number1 = result;
            isComputed = true;      
        }

        private void btnComma_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text.Contains(",") == false)  // if (!txtScreen.Text.Contains(","))
            {
                Button btn = (Button)sender;
                txtScreen.Text += btn.Text;
            }
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            string value = txtScreen.Text;
            int len = value.Length;

            if (len == 1)
                txtScreen.Text = "0";
            else
                txtScreen.Text = value.Substring(0, len - 1);

            //-----------------------------------------------------------------------------
            //if (txtScreen.Text.Length == 1)
            //    txtScreen.Text = "0";
            //else
            //    txtScreen.Text = txtScreen.Text.Substring(0, txtScreen.Text.Length - 1);

        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text.Substring(0,1) == "-")
            {
                txtScreen.Text.Remove(0, 1);
                //txtScreen.Text = txtScreen.Text.Substring(1, txtScreen.Text.Length-1);
            }
            else 
            { 
                txtScreen.Text = "-" + txtScreen.Text;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtScreen.Text = "0";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtScreen.Text = "0";
            number1 = 0;
            number2 = 0;
            result = 0;
            oprt = "";
            isComputed = false;
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
