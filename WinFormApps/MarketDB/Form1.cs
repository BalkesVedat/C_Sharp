using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
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

        public frmProducts()
        {
            InitializeComponent();
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            RefreshProductList();
            RefreshSupplierList();
            RefreshCategoryList();

        }

        private void RefreshSupplierList()
        {
            cmdText = "SELECT SupplierID,CompanyName From Suppliers";

            cmd.CommandText = cmdText;
            cmd.Connection = conn;

            adapter = new SqlDataAdapter(cmd);

            adapter.Fill(sdt);

           this.cmbSupplier.DataSource = sdt;
            cmbSupplier.DisplayMember = "CompanyName";
            cmbSupplier.ValueMember = "SupplierID";

        }

        private void RefreshCategoryList()
        {
            cmdText = "SELECT CategoryID,CategoryName FROM Categories";

            cmd.CommandText = cmdText;
            cmd.Connection = conn;

            adapter = new SqlDataAdapter(cmd);

            adapter.Fill(cdt);

            this.cmbCategory.DataSource = cdt;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryID";

        }

        private void RefreshProductList()
        {
            cmdText = "SELECT [ProductID],[ProductName],Products.[SupplierID],Suppliers.CompanyName As 'Supplier Name',Products.[CategoryID],CategoryName,[QuantityPerUnit],[UnitPrice],[Discontinued] FROM Products LEFT JOIN Suppliers ON Products.SupplierID  = Suppliers.SupplierID LEFT JOIN Categories ON Products.CategoryID = Categories.CategoryID";

            cmd.CommandText = cmdText;
            cmd.Connection = conn;

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
    }
}
