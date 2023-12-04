using DoAn.form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn.form_Admin
{
    public partial class frm_Customer_Detail : Form
    {
        SqlConnection conn;
        DataTable tableKhachHang;
        SqlDataAdapter adapt;
        public frm_Customer_Detail()
        {
            InitializeComponent();
            conn = new SqlConnection(DBConnect.conStr);

        }
        private void LoadDatabase()
        {
            tableKhachHang = new DataTable();
            adapt = new SqlDataAdapter("select * from KHACHHANG", conn);
            adapt.Fill(tableKhachHang);
            dgvCustomer.DataSource = tableKhachHang;
            dgvCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void btnAdd_Customer_Click(object sender, EventArgs e)
        {
            frm_Customer secondform = new frm_Customer();
            secondform.ShowDialog();
        }


        private void frm_Customer_Detail_Load(object sender, EventArgs e)
        {
            LoadDatabase();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string value = txtSDT.Text.Trim();
            DataView dv = tableKhachHang.DefaultView;
            dv.RowFilter = $"SDT LIKE '%{value}%'";
            dgvCustomer.DataSource = dv.ToTable();

        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            string value = txtSDT.Text.Trim();
            if (string.IsNullOrEmpty(value))
            {
                LoadDatabase();
            }

        }
    }
}
