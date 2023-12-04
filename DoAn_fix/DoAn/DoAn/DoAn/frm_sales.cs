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

namespace DoAn
{
    public partial class frm_sales : Form
    {
        DBConnect db = new DBConnect();
        DataTable load_dt;
        public frm_sales()
        {
            InitializeComponent();
            load_dt = new DataTable();
            load_dt.Columns.Add("MaSP");
            load_dt.Columns.Add("TenSP");
            load_dt.Columns.Add("SoLuong");
            load_dt.Columns.Add("SoLuongTon");
            load_dt.Columns.Add("DonGia");
            load_dt.Columns.Add("ThanhTien");
            load_dt.Columns.Add("GhiChu");

            // Gán DataTable cho DataGridView
            dgv_LapHoaDon.DataSource = load_dt;

        }



        private void frm_sales_Load(object sender, EventArgs e)
        {
            txt_SoLuong.Enabled = false;

        }

        private void btn_LapHoaDon_Click(object sender, EventArgs e)
        {
            // Tạo mã hóa đơn tự động
            string maHD = GetNewMaHoaDon();

            // Thêm hóa đơn (HoaDon) vào CSDL
            string ngayLapHD = DateTime.Now.ToString("yyyy-MM-dd");
            string username = getUserInf.userID;
            
            string sdt = txt_SdtKH.Text.Trim();
            string insertHoaDon = $"INSERT INTO HOADON(MAHD, NGAYLAPHD, USERNAME, SDT) VALUES ('{maHD}', '{ngayLapHD}', '{username}', '{sdt}');";
            db.getNonQuery(insertHoaDon);

            // Kiểm tra xem mã hóa đơn đã tồn tại trong bảng HOADON chưa
            string checkHoaDon = $"SELECT COUNT(*) FROM HOADON WHERE MAHD = '{maHD}';";
            int hoaDonCount = Convert.ToInt32(db.getScalar(checkHoaDon));

            if (hoaDonCount > 0)
            {
                // Lặp qua từng dòng trong DataGridView để thêm chi tiết hóa đơn (ChiTietHD)
                foreach (DataGridViewRow row in dgv_LapHoaDon.Rows)
                {
                    // Lấy thông tin từ từng dòng
                    string maSP = (row.Cells["MaSP"].Value != null) ? row.Cells["MaSP"].Value.ToString() : string.Empty;

                    // Kiểm tra xem giá trị maSP có tồn tại trong bảng SANPHAM hay không
                    string checkSanPham = $"SELECT COUNT(*) FROM SANPHAM WHERE MASP = '{maSP}';";
                    int sanPhamCount = Convert.ToInt32(db.getScalar(checkSanPham));

                    // Kiểm tra giá trị có phải là null hay không
                    if (!string.IsNullOrEmpty(maSP) && sanPhamCount > 0)
                    {
                        // Lấy giá trị số lượng từ cột "SoLuong" của dòng đang xử lý trong DataGridView
                        int soLuong = (row.Cells["SoLuong"].Value != null) ? Convert.ToInt32(row.Cells["SoLuong"].Value) : 0;
                        float donGia = (row.Cells["DonGia"].Value != null) ? Convert.ToSingle(row.Cells["DonGia"].Value) : 0;
                        float tongTien = (row.Cells["ThanhTien"].Value != null) ? Convert.ToSingle(row.Cells["ThanhTien"].Value) : 0;

                        // Lấy thông tin người bán (NVBH)
                        string maNVBH = username;

                        // Thêm chi tiết hóa đơn (ChiTietHD) vào CSDL
                        string insertChiTietHD = $"INSERT INTO CHITIETHD(MAHD, MASP, MANVBH, SOLUONGDAMUA, DONGIA, TONGTIEN) " +
                                                $"VALUES ('{maHD}', '{maSP}', '{maNVBH}', {soLuong}, {donGia}, {tongTien});";
                        db.getNonQuery(insertChiTietHD);
                    }
                }
                // Thông báo lập hóa đơn thành công
                MessageBox.Show("Lập hóa đơn thành công!");
            }
            else
            {
                MessageBox.Show("Mã hóa đơn không tồn tại trong bảng HOADON.");
            }
            //sau khi hoàn thành thêm hóa đơn tất cả các textbox rỗng
            txt_DiaChi.Clear();
            txt_HoTenKH.Clear();
            txt_SdtKH.Clear();
            txt_MaSP.Clear();
            txt_TenSP.Clear();
            txt_SoLuong.Clear();


            //// Ví dụ nếu DataGridView được liên kết với BindingSource
            //dgv_LapHoaDon.DataSource = load_dt.Rows.Clear();

        }

        public string GetNewMaHoaDon()
        {
            DBConnect db = new DBConnect();

            using (SqlConnection connect = new SqlConnection(db.GetConnectionString()))
            {
                connect.Open(); // Mở kết nối

                // Chuỗi truy vấn SQL để lấy maHD lớn nhất hiện tại
                string maHD_Max_now = "SELECT ISNULL(MAX(CAST(SUBSTRING(MaHD, 3, LEN(MaHD) - 2) AS INT)), 0) FROM HoaDon";

                // Tạo đối tượng SqlCommand
                using (SqlCommand cmd = new SqlCommand(maHD_Max_now, connect))
                {
                    // Thực hiện truy vấn và lấy giá trị
                    object result = cmd.ExecuteScalar();
                    int soThuTu = Convert.ToInt32(result);
                    string maHD_new = "HD" + (soThuTu + 1).ToString().PadLeft(3, '0');

                    return maHD_new;
                } // Kết thúc đối tượng SqlCommand, đồng thời đảm bảo kết nối được đóng
            } // Kết thúc kết nối (đảm bảo kết nối được đóng sau khi hoàn thành công việc)
        }




        private string GetLoggedInUsername()
        {
            // Hàm để lấy tên đăng nhập của người dùng đã đăng nhập
            // Bạn cần thay thế nó bằng cách lấy thông tin tên đăng nhập từ tài khoản đăng nhập
            // Ví dụ: return currentUser.Username;
            return "Tên Đăng Nhập";

        }

        //kiểm tra sdt có tồn tại trong sql hay không
        private bool KiemTraTonTaiSDT(string sdt)
        {
            string query = $"SELECT COUNT(*) FROM KHACHHANG WHERE SDT = '{sdt}'";
            int count = Convert.ToInt32(db.getScalar(query));

            return count > 0;
        }
        //lấy thông tin khách hàng từ sdt đưa lên các txt còn lại
        private void LayThongTinKhachHang(string sdt)
        {
            string query = $"SELECT HOTENKH, DIACHI FROM KHACHHANG WHERE SDT = '{sdt}'";
            DataTable dt = db.getDatatable(query);

            if (dt.Rows.Count > 0)
            {
                // Hiển thị thông tin trong các ô textbox
                txt_HoTenKH.Text = dt.Rows[0]["HOTENKH"].ToString();
                txt_DiaChi.Text = dt.Rows[0]["DIACHI"].ToString();
            }
        }

        private void btnTimKH_Click(object sender, EventArgs e)
        {
            string sdtCanTim = txt_SdtKH.Text.Trim();

            if (!string.IsNullOrEmpty(sdtCanTim))
            {
                // Kiểm tra xem SDT có tồn tại trong CSDL không
                if (KiemTraTonTaiSDT(sdtCanTim))
                {
                    // Lấy thông tin khách hàng dựa trên SDT
                    LayThongTinKhachHang(sdtCanTim);
                }
                else
                {
                    // Nếu SDT không tồn tại, mở form frm_ThemKH
                    btn_ThemKH_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập SDT trước khi tìm kiếm.");
            }
        }

        private void btn_ThemKH_Click(object sender, EventArgs e)
        {
            //mở frm Thêm KH
            frm_Customer secondform = new frm_Customer();
            secondform.ShowDialog();
        }

        //nhập maSP rồi bấm enter trên bàn phím để tìm kiếm MaSP trong csdl, nếu có maSP trong bảng sanpham thì
        //hiện tênSP lên txt_TenSP và cho người dùng nhập số lượng bán vào txt_Soluong

        private void txt_MaSP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string maSP = txt_MaSP.Text.Trim();

                if (!string.IsNullOrEmpty(maSP))
                {
                    // Kiểm tra xem sản phẩm có tồn tại trong CSDL không
                    if (KiemTraTonTaiSanPham(maSP))
                    {
                        // Nếu sản phẩm tồn tại, hiển thị thông tin sản phẩm
                        HienThiThongTinSanPham(maSP);
                        txt_SoLuong.Enabled = true;
                    }
                    else
                    {
                        // Nếu sản phẩm không tồn tại, hiển thị thông báo
                        MessageBox.Show("Không có sản phẩm với mã hàng này.");
                    }
                }
                else
                {
                    // Nếu mã sản phẩm trống, hiển thị thông báo
                    MessageBox.Show("Vui lòng nhập mã sản phẩm.");
                }
            }
        }

        //kiểm tra xem MaSP mới nhập vào txt_MaSP có trong csdl hay không
        private bool KiemTraTonTaiSanPham(string maSP)
        {
            // Thực hiện kiểm tra xem sản phẩm có tồn tại trong CSDL không
            // Sử dụng SQLCommand hoặc thư viện ORM tùy thuộc vào cách bạn thao tác với CSDL
            string query = $"SELECT COUNT(*) FROM SANPHAM WHERE MASP = '{maSP}'";
            int count = Convert.ToInt32(db.getScalar(query));

            return count > 0;
        }

        //hiển thị thông tin SP lên textbox
        private void HienThiThongTinSanPham(string maSP)
        {
            // Lấy thông tin sản phẩm từ CSDL và hiển thị lên các TextBox
            string query = $"SELECT TENSP FROM SANPHAM WHERE MASP = '{maSP}'";
            string tenSP = db.getScalar(query).ToString();

            // Gán tên sản phẩm vào TextBox
            txt_TenSP.Text = tenSP;

        }

        private void bth_ThemSP_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các TextBox
            string maSP = txt_MaSP.Text.Trim();
            string tenSP = txt_TenSP.Text.Trim();
            string soLuong = txt_SoLuong.Text.Trim();

            // Kiểm tra xem các thông tin cần thiết đã nhập hay chưa
            if (string.IsNullOrEmpty(maSP) || string.IsNullOrEmpty(tenSP) || string.IsNullOrEmpty(soLuong))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sản phẩm.");
                return;
            }

            // Chuyển đổi số lượng từ chuỗi sang kiểu số nguyên
            if (!int.TryParse(txt_SoLuong.Text, out int SoLuong))
            {
                MessageBox.Show("Số lượng không hợp lệ.");
                return;
            }

            // Thực hiện truy vấn để lấy thông tin từ bảng SanPham
            string query = $"SELECT SoLuong, DONGIABAN FROM SANPHAM WHERE MASP = '{maSP}'";
            DataTable sanPhamInfo = db.getDatatable(query);

            if (sanPhamInfo.Rows.Count > 0)
            {
                DataRow sanPhamRow = sanPhamInfo.Rows[0];

                // Lấy thông tin từ kết quả truy vấn
                int SoLuongTon = Convert.ToInt32(sanPhamRow["SoLuong"]);
                float DonGia = Convert.ToSingle(sanPhamRow["DONGIABAN"]);
                float ThanhTien = SoLuong * DonGia;

                // Thêm hàng mới vào DataTable và cập nhật thông tin
                DataRow newRow = load_dt.NewRow();
                newRow["MaSP"] = maSP;
                newRow["TenSP"] = tenSP;
                newRow["SoLuong"] = soLuong;
                newRow["SoLuongTon"] = SoLuongTon;
                newRow["DonGia"] = DonGia;
                newRow["ThanhTien"] = ThanhTien;
                newRow["GhiChu"] = ""; // Có thể cập nhật thông tin ghi chú từ CSDL nếu cần
                load_dt.Rows.Add(newRow);

                // Xóa nội dung của TextBox sau khi thêm
                txt_MaSP.Clear();
                txt_TenSP.Clear();
                txt_SoLuong.Clear();
                //frm_sales_Load(sender, e);

            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin sản phẩm với mã này trong CSDL.");
            }

        }

        private void btn_XoaSP_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng được chọn hay không
            if (dgv_LapHoaDon.SelectedRows.Count > 0)
            {
                // Lấy dòng được chọn
                DataGridViewRow selectedRow = dgv_LapHoaDon.SelectedRows[0];

                // Lấy index của dòng được chọn trong DataTable
                int rowIndex = selectedRow.Index;

                // Xóa dòng khỏi DataTable
                load_dt.Rows.RemoveAt(rowIndex);

                // Cập nhật lại DataGridView
                dgv_LapHoaDon.DataSource = load_dt;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa.");
            }

        }
    }
}
