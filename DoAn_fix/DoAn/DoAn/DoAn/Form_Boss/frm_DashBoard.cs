using DoAn.Form_Boss;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn.form
{
    public partial class frm_DashBoard : Form
    {
        frm_Empl_Function empl = new frm_Empl_Function();
        DBConnect dbc = new DBConnect();
        DataSet ds = new DataSet();
        SqlDataAdapter adapt;
        DataTable dt_Boss = new DataTable();
        DataTable dt_NV = new DataTable();
        public frm_DashBoard()
        {
            InitializeComponent();
            hideSubMenu();

            
        }
        private void hideSubMenu()
        {
            panelBill.Visible = false;
            panelProductSub.Visible = false;
            panelCustomerSub.Visible = false;
            panel_Sub_Employees.Visible = false;
           
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        

        private void btnProduct_Click(object sender, EventArgs e)
        {       
                showSubMenu(panelProductSub);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            showSubMenu(panelCustomerSub);
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            showSubMenu(panelBill);
        }

        
        private void btn_Employees_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_Sub_Employees);
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
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

        private void btn_HD_DaLap_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_Report_Sales());
            hideSubMenu(); 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Login secondForm = new frm_Login();
            secondForm.ShowDialog();
            this.Close();
        }

        private void btn_Proc_List_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_Product());
            hideSubMenu();
        }

        private void btn_Cus_List_Click(object sender, EventArgs e)
        {
            //openChildForm(new frm_)
            //hideSubMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_Profit());   
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_QL_NV());
            hideSubMenu();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_DashBoard returnForm = new frm_DashBoard();            
            returnForm.ShowDialog();
            this.Close();
        }

        private void btn_LapHD_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_sales());
            hideSubMenu();
        }

        private void frm_DashBoard_Load(object sender, EventArgs e)
        {
            string sql = "SELECT CHITIETHD.MAHD, TONGTIEN, NGAYLAPHD\r\nFROM CHITIETHD\r\nJOIN HOADON ON CHITIETHD.MAHD = HOADON.MAHD;\r\n\r\n";
            dt_Boss = dbc.getDatatable(sql);
            dt_Boss.Columns[2].ToString();
            dgvBoss_Dash.DataSource = dt_Boss;
            dgvBoss_Dash.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            string sql_NV = "select * from NGUOIDUNG order by MAQUYEN";
            dt_NV = dbc.getDatatable(sql_NV);
            dt_NV.Columns[2].ToString();
            dgv_DS_NV.DataSource = dt_NV;
            dgv_DS_NV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void dgv_DS_NV_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
 

        
            frm_Empl_Function f2 = new frm_Empl_Function();
            f2.txtMaNV.Text = this.dgv_DS_NV.CurrentRow.Cells[0].Value.ToString();
            f2.txtPass.Text = this.dgv_DS_NV.CurrentRow.Cells[1].Value.ToString();
            f2.txtHoTenNV.Text = this.dgv_DS_NV.CurrentRow.Cells[2].Value.ToString();
            f2.txtAddress.Text = this.dgv_DS_NV.CurrentRow.Cells[3].Value.ToString();
            f2.txtMaQuyen.Text = this.dgv_DS_NV.CurrentRow.Cells[4].Value.ToString();
            f2.btn_Add.Enabled = false;
            f2.iconButton1.Enabled = false;
            f2.button2.Enabled = false;
            f2.txtAddress.Enabled = false;
            f2.txtHoTenNV.Enabled = false;
            f2.txtMaNV.Enabled = false;
            f2.txtMaQuyen.Enabled = false;
            f2.txtPass.Enabled = false;

            object imageDataObj = this.dgv_DS_NV.CurrentRow.Cells[5].Value;

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
