using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!");

            lblMessage.Text = DateTime.Now.ToString();

        }

        public void MesajGoster()
        { 
            
        
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Hoşçakalın...");
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            int x = 0, y = 0;

            Random rnd = new Random();

            x = rnd.Next(0, this.Width - button1.Width);
            y = rnd.Next(0, this.Height - button1.Height);

            button1.Location = new Point(x, y);


            //button1.Visible = false;

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1_MouseHover(sender, e);
        }
    }
}
