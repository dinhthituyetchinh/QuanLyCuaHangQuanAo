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
    public partial class frm_Profit : Form
    {
        DBConnect db = new DBConnect();

        public frm_Profit()
        {
            InitializeComponent();
        }

        private void frm_Profit_Load(object sender, EventArgs e)
        {
            //định dạng dateTimePicker: Hiển thị ngày tháng năm (vd: "dd/MM/yyyy") 
            dateTimePickerStart.Format = DateTimePickerFormat.Custom;
            dateTimePickerStart.CustomFormat = "dd/MM/yyyy";

            dateTimePickerEnd.Format = DateTimePickerFormat.Custom;
            dateTimePickerEnd.CustomFormat = "dd/MM/yyyy";

            //hiển thị tất cả các hóa đơn
            string sql = $"SELECT ct.MAHD, hd.NGAYLAPHD, ct.MANVBH, SUM(ct.SOLUONGDAMUA) AS TONG_SOLUONG, SUM(ct.TONGTIEN) AS TONGTIEN, hd.SDT " +
                         $"FROM HOADON hd " +
                         $"JOIN CHITIETHD ct ON hd.MAHD = ct.MAHD " +
                         $"GROUP BY ct.MAHD, hd.NGAYLAPHD, ct.MANVBH, hd.SDT";

            DataTable dt_HD = new DataTable();
            dt_HD = db.getDatatable(sql);
            DataView dataView = new DataView(dt_HD);
            dgv_HoaDon.DataSource = dataView;
            dgv_HoaDon.Columns["NGAYLAPHD"].DefaultCellStyle.Format = "dd/MM/yyyy";


            txt_TongDoanhThu.Enabled = txt_LoiNhuan.Enabled = txt_ChiPhi.Enabled = false;


        }

        

        private void btn_Tinh_Click(object sender, EventArgs e)
        {
            //hiển thị danh sách các hóa đơn từ ngày ... đến ngày ...
            try
            {
                // Lấy giá trị ngày bắt đầu và ngày kết thúc
                DateTime startDate = dateTimePickerStart.Value;
                DateTime endDate = dateTimePickerEnd.Value;

                // Thực hiện truy vấn SQL để lấy hóa đơn trong khoảng thời gian
                string sql = $"SELECT ct.MAHD, hd.NGAYLAPHD, ct.MANVBH, SUM(ct.SOLUONGDAMUA) AS TONG_SOLUONG, SUM(ct.TONGTIEN) AS TONGTIEN, hd.SDT " +
                             $"FROM HOADON hd " +
                             $"JOIN CHITIETHD ct ON hd.MAHD = ct.MAHD " +
                             $"AND hd.NGAYLAPHD BETWEEN '{startDate:yyyy-MM-dd}' AND '{endDate:yyyy-MM-dd}' " +
                             $"GROUP BY ct.MAHD, hd.NGAYLAPHD, ct.MANVBH, hd.SDT";

                DataTable dt_Report1 = db.getDatatable(sql);

                if (dt_Report1.Rows.Count > 0)
                {
                    DataView dataView = new DataView(dt_Report1);
                    dgv_HoaDon.DataSource = dataView;
                }
                else
                {
                    dgv_HoaDon.DataSource = null; // Xóa DataGridView
                    MessageBox.Show("Không tìm thấy hóa đơn trong khoảng thời gian đã chọn.");
                }


                //tính tổng doanh thu và xuất ra trên txt_TongDoanhThu
                // Thực hiện truy vấn SQL để tính tổng tiền của tất cả hóa đơn trong khoảng thời gian
                string doanhThuSql = $"SELECT SUM(ct.TONGTIEN) AS TONGTIEN_HD_THEO_NGAY " +
                                     $"FROM CHITIETHD ct " +
                                     $"JOIN HOADON hd ON ct.MAHD = hd.MAHD " +
                                     $"WHERE hd.NGAYLAPHD BETWEEN '{startDate:yyyy-MM-dd}' AND '{endDate:yyyy-MM-dd}'";
                // Thực hiện truy vấn và nhận giá trị tổng tiền
                object resultDoanhThu = db.getScalar(doanhThuSql);

                // Kiểm tra xem kết quả có giá trị không
                if (resultDoanhThu != null && resultDoanhThu != DBNull.Value)
                {
                    // Hiển thị tổng tiền trong TextBox
                    txt_TongDoanhThu.Text = resultDoanhThu.ToString();
                }
                else
                {
                    txt_TongDoanhThu.Text = "0"; // Nếu không có hóa đơn, hiển thị 0
                }


                //tính tổng lợi nhuận và xuất ra trên txt_LoiNhuan
                // Thực hiện truy vấn SQL để tính tổng tiền nhập theo từng hóa đơn
                string tongTienNhapSql = $"SELECT SUM(sp.DONGIANHAP * ct.SOLUONGDAMUA) AS TONG_TIEN_NHAP_THEO_HDNgay " +
                                        $"FROM HOADON hd " +
                                        $"JOIN CHITIETHD ct ON hd.MAHD = ct.MAHD " +
                                        $"JOIN SANPHAM sp ON ct.MASP = sp.MASP " +
                                        $"WHERE hd.NGAYLAPHD BETWEEN '{startDate:yyyy-MM-dd}' AND '{endDate:yyyy-MM-dd}' ";

                object resultTongTienNhap = db.getScalar(tongTienNhapSql);


                // Kiểm tra xem kết quả có giá trị không
                if (resultDoanhThu != null && resultDoanhThu != DBNull.Value && resultTongTienNhap != null && resultTongTienNhap != DBNull.Value)
                {

                    //Tính lợi nhuận
                    double doanhThu = Convert.ToDouble(resultDoanhThu);
                    double tongTienNhap = Convert.ToDouble(resultTongTienNhap);
                    double loiNhuan = doanhThu - tongTienNhap;

                    txt_LoiNhuan.Text = loiNhuan.ToString();
                }
                else
                {
                    txt_LoiNhuan.Text = "0"; // Nếu không có dữ liệu, hiển thị 0
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");

            }

            txt_ChiPhi.Text = "0";

        }

        private void panel_Info_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_CTHD_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn không
            if (dgv_HoaDon.SelectedRows.Count > 0)
            {
                // Lấy giá trị của cột MAHD từ dòng được chọn
                string maHoaDonString = dgv_HoaDon.SelectedRows[0].Cells["MAHD"].Value.ToString();

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

        private void btn_Back_Click(object sender, EventArgs e)
        {

        }
    }
}
