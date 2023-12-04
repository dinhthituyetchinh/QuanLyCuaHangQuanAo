using DoAn.form_Admin;
using DoAn.Form_Boss;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn.Service;
using DoAn.Models;
namespace DoAn.form
{
    public partial class frm_Product : Form
    {
        ProductService productService = new ProductService();
        public frm_Product()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnSure_Click(object sender, EventArgs e)
        {
            frm_add_Procd secondform = new frm_add_Procd(null);
            secondform.ShowDialog();
            if (frm_add_Procd.isClose == true)
            {
                frm_Product_Load(sender, e);
            }
            if(frm_add_Procd.isOpen == true)
            {
                return;
            }    
            this.Close();
        }

        private void btn_Close_Child_Sales_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void dataBinDings()
        {
            txtMaSP.DataBindings.Clear();
            txtTenSP.DataBindings.Clear();
            cmbMau.DataBindings.Clear();
            cmbChatLieu.DataBindings.Clear();

            txtMaSP.DataBindings.Add("Text", dgvDSSP.DataSource, "MASP");
            txtTenSP.DataBindings.Add("Text", dgvDSSP.DataSource, "TENSP");
            cmbMau.DataBindings.Add("Text", dgvDSSP.DataSource, "TENMAU");
            cmbChatLieu.DataBindings.Add("Text", dgvDSSP.DataSource, "TENCHATLIEU");
        }

        private void frm_Product_Load(object sender, EventArgs e)
        {
            txtMaSP.Enabled = false;

            productService.loadMau(cmbMau);

            productService.loadChatLieu(cmbChatLieu);
            if (frm_Login.currentRole == 1)
            {
                btnAddSP.Visible = btnEditSP.Visible = btnXoaSP.Visible = false;
            }
            productService.loadDSSP(dgvDSSP);

            cmbMau.SelectedIndex = 0;
            cmbChatLieu.SelectedIndex = 0;

            dgvDSSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSSP.Columns[0].HeaderText = "Mã sản phẩm";
            dgvDSSP.Columns[1].HeaderText = "Tên sản phẩm";
            dgvDSSP.Columns[2].HeaderText = "Mã chất liệu";
            dgvDSSP.Columns[3].HeaderText = "Mã màu";
            dgvDSSP.Columns[4].HeaderText = "Kích thước";
            dgvDSSP.Columns[5].HeaderText = "Số lượng";
            dgvDSSP.Columns[6].HeaderText = "Đơn giá nhập";
            dgvDSSP.Columns[7].HeaderText = "Đơn giá bán";
            dgvDSSP.Columns[8].HeaderText = "Mô tả";
            dgvDSSP.Columns[9].Visible = false;


            dataBinDings();

        }

        private void dgvDSSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDSSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string path = dgvDSSP.Rows[e.RowIndex].Cells[9].Value.ToString();
                /*rtbAnh.Text = path*/;

                pictureBox1.Image = Image.FromFile(path);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Err");
            }
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            productService.delete(txtMaSP.Text);
            frm_Product_Load(sender, e);
        }

        private void btnEditSP_Click(object sender, EventArgs e)
        {
            frm_add_Procd secondform = new frm_add_Procd(txtMaSP.Text);
            secondform.ShowDialog();

            if (frm_add_Procd.isClose == true)
            {
                frm_Product_Load(sender, e);
            }
            if (frm_add_Procd.isOpen == true)
            {
                return;
            }
            this.Close();
        }

        private void cmbMau_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isDigit = int.TryParse(cmbMau.SelectedValue.ToString(), out _);
           
            if (isDigit)
            {
                int maMau = int.Parse(cmbMau.SelectedValue.ToString().Trim());
                productService.FilterData(dgvDSSP, "MAUSAC.MAMAU = " + maMau, maMau, null);
            }

        }

        private void cmbChatLieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            productService.FilterData(dgvDSSP, "CHATLIEU.MACHATLIEU = " + "'" + cmbChatLieu.SelectedValue.ToString().Trim() + "'", null, cmbChatLieu.SelectedValue.ToString().Trim());
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            productService.FilterData(dgvDSSP, "SANPHAM.TENSP LIKE N'%" + txtTenSP.Text.Trim() + "%'", null, null);
        }
    }
}
