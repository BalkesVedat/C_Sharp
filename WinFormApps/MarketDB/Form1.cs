using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketDB
{
    public partial class frmProducts : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;User ID=sa;Password=1");
        SqlCommand cmd = new SqlCommand();

        SqlDataAdapter adapter;
        DataTable pdt = new DataTable();
        DataTable sdt = new DataTable();
        DataTable cdt = new DataTable();

        public string cmdText { get; set; }

        int productID = 0;
        string productName = string.Empty;
        int supplierID = 0;
        int categoryID = 0;
        string quantityPerUnit = string.Empty;
        decimal unitPrice = 0;
        bool discontinued = false;
        bool isIDNumeric = false;


        public frmProducts()
        {
            InitializeComponent();
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            RefreshProductList();
            RefreshSupplierList();
            RefreshCategoryList();
            ClearForm();
            CreateModeActivate();
        }

        private void CreateModeActivate()
        {
            btnCreate.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void RefreshSupplierList()
        {
            //cmdText = "SELECT SupplierID,CompanyName From Suppliers";
            cmd.Parameters.Clear();
            cmd.CommandText = "Sp_GetSupplierList";//cmdText;
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;

            adapter = new SqlDataAdapter(cmd);

            adapter.Fill(sdt);

            this.cmbSupplier.DataSource = sdt;
            cmbSupplier.DisplayMember = "CompanyName";
            cmbSupplier.ValueMember = "SupplierID";

        }

        private void RefreshCategoryList()
        {
            //cmdText = "SELECT CategoryID,CategoryName FROM Categories";
            cmd.Parameters.Clear();
            cmd.CommandText = "Sp_GetCategoryList"; //cmdText;
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;

            adapter = new SqlDataAdapter(cmd);

            adapter.Fill(cdt);

            this.cmbCategory.DataSource = cdt;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryID";

        }

        private void RefreshProductList()
        {
            //cmdText = "SELECT [ProductID],[ProductName],Products.[SupplierID],Suppliers.CompanyName As 'Supplier Name',Products.[CategoryID],CategoryName,[QuantityPerUnit],[UnitPrice],[Discontinued] FROM Products LEFT JOIN Suppliers ON Products.SupplierID  = Suppliers.SupplierID LEFT JOIN Categories ON Products.CategoryID = Categories.CategoryID";

            // cmdText = "Sp_GetProductList";
            cmd.Parameters.Clear();
            cmd.CommandText = "Sp_GetProductList";//cmdText;
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;

            adapter = new SqlDataAdapter(cmd);

            pdt.Clear();
            adapter.Fill(pdt);

            this.gridProducts.DataSource = pdt;
            // gridProducts.Refresh();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chkDiscontinued_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gridProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedValue == null || cmbCategory.SelectedValue is DataRowView)
            {
                imgPhoto.Image = null;
                return;
            }

            cmd.Parameters.Clear();
            cmd.CommandText = "Sp_GetCategoryImage";
            cmd.Parameters.AddWithValue("@CategoryID", cmbCategory.SelectedValue);
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;

            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

            byte[] imageBytes;
            try
            {
                imageBytes = (byte[])cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                imageBytes = null;
            }

            if (imageBytes != null)
            {
                using (MemoryStream ms = new MemoryStream(imageBytes, 78, imageBytes.Length - 78))
                {
                    imgPhoto.Image = Image.FromStream(ms);
                    imgPhoto.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            else
            {
                imgPhoto.Image = null;
            }

            if (conn.State != ConnectionState.Closed)
            {
                conn.Close();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ürünü eklemek istediğinize emin misiniz?", "Ürün Ekleme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                MessageBox.Show("Ürün ekleme işleminden vazgeçildi", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            try
            {
                GetFormData();

                // Metin birleştirerek sorgu oluşturma:
                //cmdText = "INSERT INTO Products (ProductName,UnitPrice) VALUE ('"+ productName + "'," + unitPrice +")";

                //cmd.CommandText = cmdText;

                //metin birleştirme yöntemi ile SP parmetrelerinin verilmesi
                //cmdText = "SP_InsertProduct '" + productName + "', " + unitPrice + "";

                //cmd.CommandText = cmdText;

                // SP parametrelerinin cmd.Paramters üzerinden oluşturulması
                cmd.Parameters.Clear();
                cmd.CommandText = "Sp_InsertProduct";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProductName", productName);
                cmd.Parameters.AddWithValue("@SupplierID", supplierID);
                cmd.Parameters.AddWithValue("@CategoryID", categoryID);
                cmd.Parameters.AddWithValue("@QuantityPerUnit", quantityPerUnit);
                cmd.Parameters.AddWithValue("@UnitPrice", unitPrice);
                cmd.Parameters.AddWithValue("@Discontinued", discontinued);

                cmd.Connection = conn;

                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                int affectedRecordCount = cmd.ExecuteNonQuery();

                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }

                if (affectedRecordCount > 0)
                {
                    MessageBox.Show("Ürün Eklendi.");
                    RefreshProductList();
                    ClearForm();
                    CreateModeActivate();
                }
                else
                    MessageBox.Show("Ürün Eklenemedi.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("* Hata oluştu: " + ex.Message);
            }

        }

        private void GetFormData()
        {
            isIDNumeric = int.TryParse(txtProductID.Text, out productID);
            productName = txtProductName.Text;
            supplierID = (int)cmbSupplier.SelectedValue;
            categoryID = (int)cmbCategory.SelectedValue;
            quantityPerUnit = txtQuantityPerUnit.Text;
            unitPrice = numUnitPrice.Value;
            discontinued = chkDiscontinued.Checked;
        }

        private void ClearForm()
        {
            txtProductID.Text = "";
            txtProductName.Text = "";
            cmbSupplier.SelectedIndex = -1;
            cmbCategory.SelectedIndex = -1;
            txtQuantityPerUnit.Text = "";
            numUnitPrice.Value = 0;
            chkDiscontinued.Checked = false;
            imgPhoto.Image = null;
        }

        private void gridProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // DataGridViewCell cell = (DataGridViewCell)sender;

            DataGridViewRow row = gridProducts.Rows[e.RowIndex];

            row.Selected = true;

            if (row.Cells[0].Value.ToString().Length == 0)
            {
                ClearForm();
                return;
            }

            int rowProductID = (int)row.Cells["ProductID"].Value;
            string rowProductName = (string)row.Cells["ProductName"].Value;

            int rowSupplierID = 0;
            if (row.Cells["SupplierID"].Value.ToString() != string.Empty)
            {
                rowSupplierID = (int)row.Cells["SupplierID"].Value;
            }

            int rowCategoryID = 0;

            if (row.Cells["CategoryID"].Value.ToString() != string.Empty)
            {
                rowCategoryID = (int)row.Cells["CategoryID"].Value;
            }

            string rowQuantityPerUnit = (string)row.Cells["QuantityPerUnit"].Value;
            decimal rowUnitPrice = (decimal)row.Cells["UnitPrice"].Value;
            bool rowDiscontinued = (bool)row.Cells["Discontinued"].Value;

            txtProductID.Text = rowProductID.ToString();
            txtProductName.Text = rowProductName;
            cmbSupplier.SelectedValue = rowSupplierID;
            cmbCategory.SelectedValue = rowCategoryID;
            txtQuantityPerUnit.Text = rowQuantityPerUnit;
            numUnitPrice.Value = rowUnitPrice;
            chkDiscontinued.Checked = rowDiscontinued;

            CreateModeDeactivate();
        }

        private void CreateModeDeactivate()
        {
            btnCreate.Enabled = false;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
        }

        private void cmbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNewRecord_Click(object sender, EventArgs e)
        {
            CreateModeActivate();
            ClearForm();
            gridProducts.ClearSelection();
            gridProducts.CurrentCell = null;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                MessageBox.Show("Silme işleminden vazgeçildi", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }


            try
            {
                GetFormData();

                cmd.Parameters.Clear();
                cmd.CommandText = "Sp_DeleteProduct";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProductID", productID);

                cmd.Connection = conn;

                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                int affectedRecordCount = cmd.ExecuteNonQuery();

                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }

                if (affectedRecordCount > 0)
                {
                    MessageBox.Show("Ürün Silindi.");
                    RefreshProductList();
                    ClearForm();
                    CreateModeActivate();
                }
                else
                    MessageBox.Show("Bu ürüne ait satış kayıtları olduğundan dolayı silinemedi.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("* Hata oluştu: " + ex.Message);
            }

        }

        private void frmProducts_Activated(object sender, EventArgs e)
        {
            gridProducts.ClearSelection();
            gridProducts.CurrentCell = null;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bu kaydı güncellemek istediğinize emin misiniz?", "Güncelleme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                MessageBox.Show("Güncelleme işleminden vazgeçildi", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            try
            {
                GetFormData();

                cmd.Parameters.Clear();
                cmd.CommandText = "Sp_UpdateProduct";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProductID", productID);
                cmd.Parameters.AddWithValue("@ProductName", productName);
                cmd.Parameters.AddWithValue("@SupplierID", supplierID);
                cmd.Parameters.AddWithValue("@CategoryID", categoryID);
                cmd.Parameters.AddWithValue("@QuantityPerUnit", quantityPerUnit);
                cmd.Parameters.AddWithValue("@UnitPrice", unitPrice);
                cmd.Parameters.AddWithValue("@Discontinued", discontinued);

                cmd.Connection = conn;

                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                int affectedRecordCount = cmd.ExecuteNonQuery();

                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }

                if (affectedRecordCount > 0)
                {
                    MessageBox.Show("Ürün Bilgileri Güncellendi.");
                    RefreshProductList();
                    ClearForm();
                    CreateModeActivate();
                }
                else
                    MessageBox.Show("Ürün Güncellenemedi.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("* Hata oluştu: " + ex.Message);
            }
        }
    }
}
