using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormControls
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {



        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gbGender_Enter(object sender, EventArgs e)
        {

        }

        private void gbHobbies_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnClearPicture_Click(object sender, EventArgs e)
        {
            picPhoto.Image = null;
        }

        private void picPhoto_Click(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = pictureSelectionDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                //  picPhoto.ImageLocation = pictureSelectionDialog.FileName;

                picPhoto.Image = Image.FromFile(pictureSelectionDialog.FileName);
            }
            else
            {
                MessageBox.Show("Process Aborted");
            }

        }

        private void chkBook_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string surName = txtSurname.Text;
            DateTime recordDate = dtpBookDate.Value;
            string division = cmbDivision.SelectedText;
            string selectedClass = lbClasses.SelectedValue.ToString();
            string gender = "";

            //if (rbMale.Checked)
            //{
            //    gender = rbMale.Text;
            //}
            //else
            //{ 
            //    gender = rbFemale.Text;
            //}

            foreach (Control item in gbGender.Controls)
            {
                if (item.GetType() == typeof(RadioButton))
                {
                    RadioButton rb = (RadioButton)item;

                    if (rb.Checked)
                    {
                        gender = rb.Text;
                    }
                }
            }



        }

        private void cmbDivision_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
