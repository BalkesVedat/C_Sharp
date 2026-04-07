using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
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

            adapter.Fill(pdt);

            this.gridProducts.DataSource = pdt;
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

        }




        private void btnCreate_Click(object sender, EventArgs e)
        {
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

                cmd.ExecuteNonQuery();

                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }

                MessageBox.Show("Ürün Eklendi.");
                ClearForm();
                RefreshProductList();

            }
            catch (Exception ex)
            {
                lblMessage.Text = "* Hata oluştu: " + ex.Message;
                MessageBox.Show(lblMessage.Text);
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
        }

        private void gridProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // DataGridViewCell cell = (DataGridViewCell)sender;

            DataGridViewRow row = gridProducts.Rows[e.RowIndex];

            int rowProductID = (int)row.Cells["ProductID"].Value;
            string rowProductName = (string)row.Cells["ProductName"].Value;
            int rowSupplierID = (int)row.Cells["SupplierID"].Value;

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


        }

        private void cmbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
