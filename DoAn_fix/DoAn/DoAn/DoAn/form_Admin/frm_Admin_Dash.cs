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
    
    public partial class frm_Admin_Dash : Form
    {
        DBConnect db = new DBConnect();
        SqlConnection conn;
        frm_Admin_Dash adminDash;
        public frm_Admin_Dash()
        {
            InitializeComponent();
            HideSubMenu();
            panelSideMenu.Show();
            showUserName();
        }
        private void showUserName()
        {
            lblMaNV.Text = getUserInf.userID;
            lblHoTen.Text = getUserInf.userName;
        }
        private void HideSubMenu()
        {
            
            panelProductSub.Visible = false;
            panelCustomerSub.Visible = false;
            panelSubBill.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            showSubMenu(panelProductSub);
            
        }
        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btn_Proc_List_Click(object sender, EventArgs e)
        {
            frm_Product secondform = new frm_Product();
            secondform.ShowDialog();
            HideSubMenu();
            
        }

        private void btn_Cus_List_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_Customer_Detail());
            HideSubMenu();
            
        }

        private void btn_LapHD_Click(object sender, EventArgs e)
        {
            frm_sales secondform = new frm_sales();
            secondform.ShowDialog();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubBill);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            showSubMenu(panelCustomerSub);
        }

        private void btn_HD_DaLap_Click(object sender, EventArgs e)
        {
           openChildForm(new frm_Report_Sales());
            HideSubMenu();
        }



        private void frm_Admin_Dash_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc muốn đóng chương trình", "Thoát??", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (r == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Admin_Dash_Load(object sender, EventArgs e)
        {
            

            string sql = "select hd.SDT, HOTENKH, ct.MAHD, NGAYLAPHD, nd.HOTEN, SOLUONGDAMUA, TONGTIEN, MANVBH from HOADON hd, CHITIETHD ct , KHACHHANG kh, NGUOIDUNG nd where hd.MAHD = ct.MAHD and hd.SDT = kh.SDT and nd.USERNAME = MANVBH";
            DataTable dt_Report = new DataTable();
            dt_Report = db.getDatatable(sql);
            DataView dataView = new DataView(dt_Report);
            dgv_HoaDon.DataSource = dataView;
            dgv_HoaDon.Columns["NGAYLAPHD"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }
    }
}
