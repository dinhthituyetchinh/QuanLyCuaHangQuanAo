using DoAn.form_Admin;
using DoAn.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn.form
{
    public partial class frm_Report_Sales : Form
    {
        DBConnect db = new DBConnect();
        public frm_Report_Sales()
        {
            InitializeComponent();
        }



        private void btn_Close_Child_Sales_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Admin_Dash secondForm = new frm_Admin_Dash();
            this.Close();              
        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Close_Child_Sales_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Report_Sales_Load(object sender, EventArgs e)
        {
            //định dạng dateTimePicker: Hiển thị ngày tháng năm (vd: "dd/MM/yyyy") 
            dateTimePickerStart.Format = DateTimePickerFormat.Custom;
            dateTimePickerStart.CustomFormat = "dd/MM/yyyy";

            dateTimePickerEnd.Format = DateTimePickerFormat.Custom;
            dateTimePickerEnd.CustomFormat = "dd/MM/yyyy";

            string sql = "select hd.SDT, HOTENKH, ct.MAHD, NGAYLAPHD, nd.HOTEN, SOLUONGDAMUA, TONGTIEN, MANVBH from HOADON hd, CHITIETHD ct , KHACHHANG kh, NGUOIDUNG nd where hd.MAHD = ct.MAHD and hd.SDT = kh.SDT and nd.USERNAME = MANVBH";
            DataTable dt_Report = new DataTable();
            dt_Report = db.getDatatable(sql);
            DataView dataView = new DataView(dt_Report);
            dgv_Report.DataSource = dataView;
            dgv_Report.Columns["NGAYLAPHD"].DefaultCellStyle.Format = "dd/MM/yyyy";

        }

        private void dgv_Report_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePickerEnd_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgv_Customer_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị ngày bắt đầu và ngày kết thúc
                DateTime startDate = dateTimePickerStart.Value;
                DateTime endDate = dateTimePickerEnd.Value;

                // Thực hiện truy vấn SQL để lấy hóa đơn trong khoảng thời gian
                string sql = $"SELECT hd.SDT, HOTENKH, ct.MAHD, NGAYLAPHD, nd.HOTEN, SOLUONGDAMUA, TONGTIEN, MANVBH " +
                             $"FROM HOADON hd, CHITIETHD ct, KHACHHANG kh, NGUOIDUNG nd " +
                             $"WHERE hd.MAHD = ct.MAHD AND hd.SDT = kh.SDT AND nd.USERNAME = MANVBH " +
                             $"AND NGAYLAPHD BETWEEN '{startDate:yyyy-MM-dd}' AND '{endDate:yyyy-MM-dd}'";

                DataTable dt_Report1 = db.getDatatable(sql);

                if (dt_Report1.Rows.Count > 0)
                {
                    DataView dataView = new DataView(dt_Report1);
                    dgv_Report.DataSource = dataView;
                }
                else
                {
                    dgv_Report.DataSource = null; // Xóa DataGridView
                    MessageBox.Show("Không tìm thấy hóa đơn trong khoảng thời gian đã chọn.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn không
            if (dgv_Report.SelectedRows.Count > 0)
            {
                // Lấy giá trị của cột MAHD từ dòng được chọn
                string maHoaDonString = dgv_Report.SelectedRows[0].Cells["MAHD"].Value.ToString();

                //Tạo và hiển thị form ReportChiTietHoaDon
                Frm_ChiTietHoaDon reportForm = new Frm_ChiTietHoaDon();

                // Truyền giá trị MaHD vào form
                reportForm.MaHoaDon = maHoaDonString;

                // Hiển thị form
                reportForm.Show();

            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn từ danh sách trước khi xem chi tiết.");
            }
        }

        private void btn_Close_Child_Sales_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
