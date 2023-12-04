using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn.Form_Boss
{
    public partial class frm_QL_NV : Form
    {
        DBConnect dbc = new DBConnect();
        DataSet ds = new DataSet();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt_NV = new DataTable();

        public frm_QL_NV()
        {
            InitializeComponent();
        }

        private void btn_Add_Empl_Click(object sender, EventArgs e)
        {
            frm_Empl_Function frm_emp = new frm_Empl_Function();
            frm_emp.ShowDialog();
        }

        private void frm_QL_NV_Load(object sender, EventArgs e)
        {
            string sql = "select * from NGUOIDUNG order by MAQUYEN";
            dt_NV = dbc.getDatatable(sql);
            dt_NV.Columns[2].ToString();
            dgvNV.DataSource = dt_NV;
            dgvNV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void dgvNV_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frm_Empl_Function f2 = new frm_Empl_Function();
            f2.txtMaNV.Text = this.dgvNV.CurrentRow.Cells[0].Value.ToString();
            f2.txtPass.Text = this.dgvNV.CurrentRow.Cells[1].Value.ToString();
            f2.txtHoTenNV.Text = this.dgvNV.CurrentRow.Cells[2].Value.ToString();
            f2.txtAddress.Text = this.dgvNV.CurrentRow.Cells[3].Value.ToString();
            f2.txtMaQuyen.Text = this.dgvNV.CurrentRow.Cells[4].Value.ToString();

            f2.txtMaNV.Enabled = false;

            object imageDataObj = this.dgvNV.CurrentRow.Cells[5].Value;

            if (imageDataObj != DBNull.Value && imageDataObj is byte[] imageData)
            {
                // Pass the image data directly to picBox_Empl in frm_Empl_Function
                f2.picBox_Empl.Image = Image.FromStream(new MemoryStream(imageData));

            }
            else
            {

            }
            f2.ShowDialog();
        }

        private void btn_Search_Empl_Click(object sender, EventArgs e)
        {
            try
            {
                dbc.open();
                string username = txtSearchIDNV.Text.Trim();
                string hoten = txtSearchNameNV.Text.Trim();

                DataView dv = dt_NV.DefaultView;

                // Using AND operator to search for both conditions
                dv.RowFilter = $"USERNAME LIKE '%{username}%' AND HOTEN LIKE '%{hoten}%'";

                dgvNV.DataSource = dv.ToTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                dbc.close();
            }
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            string sql = "select * from NGUOIDUNG order by MAQUYEN";
            dt_NV = dbc.getDatatable(sql);
            dt_NV.Columns[2].ToString();
            dgvNV.DataSource = dt_NV;
            dgvNV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            frm_Empl_Function f2 = new frm_Empl_Function();
            f2.txtMaNV.Text = this.dgvNV.CurrentRow.Cells[0].Value.ToString();
            f2.txtPass.Text = this.dgvNV.CurrentRow.Cells[1].Value.ToString();
            f2.txtHoTenNV.Text = this.dgvNV.CurrentRow.Cells[2].Value.ToString();
            f2.txtAddress.Text = this.dgvNV.CurrentRow.Cells[3].Value.ToString();
            f2.txtMaQuyen.Text = this.dgvNV.CurrentRow.Cells[4].Value.ToString();

            f2.txtMaNV.Enabled = false;

            object imageDataObj = this.dgvNV.CurrentRow.Cells[5].Value;

            if (imageDataObj != DBNull.Value && imageDataObj is byte[] imageData)
            {
                // Pass the image data directly to picBox_Empl in frm_Empl_Function
                f2.picBox_Empl.Image = Image.FromStream(new MemoryStream(imageData));

            }
            else
            {

            }
            f2.ShowDialog();
        }
    }
}
