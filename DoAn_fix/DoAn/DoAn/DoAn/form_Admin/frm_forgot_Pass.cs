using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class frm_forgot_Pass : Form
    {
        public frm_forgot_Pass()
        {
            InitializeComponent();
        }
        public static bool checkOpenLogin = true;

        private void linklbl_Back_Login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void lblThoat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void frm_forgot_Pass_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn rời khỏi?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (kq == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if(txt_UserName.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập username vui lòng kiểm tra lại");
                return;
            }
            if (txt_sdt.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại vui lòng kiểm tra lại");
                return;
            }
            MessageBox.Show("Xin chào: "+txt_UserName.Text + Environment.NewLine+"Mật khẩu sẽ được gửi về số điện thoại: "+txt_sdt.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
