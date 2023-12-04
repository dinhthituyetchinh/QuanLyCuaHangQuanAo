using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace DoAn.form
{
    public partial class frm_Customer : Form
    {
        SqlConnection conn;
        DataTable tableKhachHang;
        SqlDataAdapter adapt;
        public frm_Customer()
        {
            InitializeComponent();
            conn = new SqlConnection(DBConnect.conStr);

        }



        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Customer_Load(object sender, EventArgs e)
        {
            txtAddress.Enabled = true;
            txtID_Cus.Enabled = true;
            txtName.Enabled = true;
            //txt_Admin_Id.Enabled = true;
            //txt_DateOfBirth.Enabled = true;
            //txt_Day_Add.Enabled = true;
            txtName.Focus();
            LoadDatabase();
        }




        private void btn_Close_Child_Sales_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadDatabase()
        {
            tableKhachHang = new DataTable();
            adapt = new SqlDataAdapter("select * from KHACHHANG", conn);
            adapt.Fill(tableKhachHang);
            dgv_Customer.DataSource = tableKhachHang;
            dgv_Customer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void AddNewCustomer()
        {
            DataRow newRow = tableKhachHang.NewRow();
            newRow["HOTENKH"] = txtName.Text;
            newRow["DIACHI"] = txtAddress.Text;
            newRow["SDT"] = txtID_Cus.Text;

            tableKhachHang.Rows.Add(newRow);
            dgv_Customer.DataSource = tableKhachHang;
            SqlCommandBuilder builder = new SqlCommandBuilder(adapt);
            adapt.Update(tableKhachHang);
        }
        private void btnSure_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn lưu khách hàng mới???", "Lưu?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question); ;
            if (r == DialogResult.Cancel)
            {
                //không lưu vào database
            }
            else
            {
                AddNewCustomer();
                txtAddress.Clear();
                txtID_Cus.Clear();
                txtName.Clear();
                //Lưu vào database
            }
        }

        private void txtID_Cus_TextChanged(object sender, EventArgs e)
        {
            //string value =txtID_Cus.Text.Trim();
            //if(string.IsNullOrEmpty(value))
            //{
            //    LoadDatabase();
            //}
            //else
            //{
            //    DataView dv = tableKhachHang.DefaultView;
            //    dv.RowFilter = $"SDT LIKE '%{value}%'";
            //    dgv_Customer.DataSource=dv.ToTable();
            //}
        }

        private void btn_Close_Child_Sales_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
