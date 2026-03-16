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
            string division = cmbDivision.SelectedItem.ToString();
            string selectedClass = lbClasses.Text;
            string gender = "";
            string schText = "";

            string hobbies = "";
            List<string> hobbiesList = new List<string>();



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

            foreach (Control item in gbScholarship.Controls)
            {
                if (item.GetType() == typeof(RadioButton))
                {
                    RadioButton rb = (RadioButton)item;

                    if (rb.Checked)
                    {
                        schText = rb.Text;
                    }
                }
            }

            foreach (Control item in gbHobbies.Controls)
            {
                if (item.GetType() == typeof(CheckBox))
                {
                    CheckBox cb = (CheckBox)item;

                    if (cb.Checked)
                    {
                        hobbies += cb.Text + ",";
                        hobbiesList.Add(cb.Text);
                    }

                }


            }

            string info = name + " " + surName + "-" + recordDate.ToString() + "-" + division + "-" + selectedClass + "-" + gender + "-" + schText + "-" + numAvgScore.Value + "-" + txtAddress.Text + "-" + hobbies + "(" + hobbiesList.Count + ")";


            lbRecords.Items.Add(info);

            ResetForm();

            //MessageBox.Show(info);
        }

        private void ResetForm()
        {
            txtName.Text = string.Empty;
            txtSurname.Text = string.Empty;
            txtAddress.Text = string.Empty;

            numAvgScore.Value = 0;

            dtpBookDate.Value = DateTime.Now;

            cmbDivision.SelectedIndex = -1;
            lbClasses.SelectedIndex = -1;

            rb0.Checked = true;

            foreach (Control item in gbGender.Controls)
            {
                if (item.GetType() == typeof(RadioButton))
                {
                    RadioButton rb = (RadioButton)item;
                    rb.Checked = false;
                }

                //if (item.GetType() == typeof(RadioButton))
                //((RadioButton)item).Checked = false;
            }

            foreach (Control item in gbHobbies.Controls)
            {
                if (item.GetType() == typeof(CheckBox))
                {
                    CheckBox cb = (CheckBox)item;
                    cb.Checked = false;
                }
            }



            picPhoto.Image = null;
        }

        private void cmbDivision_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gbScholarship_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
