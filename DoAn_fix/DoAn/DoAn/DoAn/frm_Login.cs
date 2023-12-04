using DoAn.form;
using DoAn.form_Admin;
using DoAn.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using DoAn.Service;
namespace DoAn
{
    public partial class frm_Login : Form
    {
        UserService userService = new UserService();
        SqlConnection conn = new SqlConnection(DBConnect.conStr);
        public frm_Login()
        {
            InitializeComponent();

        }
        private void linklbl_Forgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {         
            frm_forgot_Pass seconform = new frm_forgot_Pass();
            seconform.ShowDialog();
            if (frm_forgot_Pass.checkOpenLogin == true)
            {
                return;
            }
            this.Close();
        }

        public static int currentRole;
        private void btn_Login_Click(object sender, EventArgs e)

        {
            if (txt_UserName.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập username");
                return;
            }
            if (txt_Pass.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập password");
                return;
            }
            NguoiDung user = userService.getUser(txt_UserName.Text.Trim(), txt_Pass.Text);    
            if (user.roles == 1)
            {
                getUserInf.userID = txt_UserName.Text;
                string getName = "select HOTEN from NGUOIDUNG where UserName='" + txt_UserName.Text + "'";
                SqlCommand cmd = new SqlCommand(getName, conn);
                DBConnect.open(conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    getUserInf.userName = reader["HOTEN"].ToString();
                }
                DBConnect.close(conn);
                currentRole = 1;
                frm_Admin_Dash seconForm = new frm_Admin_Dash();
                seconForm.ShowDialog();
                this.Close();
            }

            else if (user.roles == 2)
            {
                currentRole = 2;
                frm_DashBoard secondForm = new frm_DashBoard();
                secondForm.ShowDialog();
                this.Close();
            }

        }
        private void linklbl_Exit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void frm_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (kq == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            txt_UserName.UseSystemPasswordChar = true;

        }

    
    }
}
