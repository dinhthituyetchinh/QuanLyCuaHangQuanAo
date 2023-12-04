using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using DoAn.Models;

namespace DoAn.Service
{
    public class ProductService
    {
        SqlConnection connection = new SqlConnection(DBConnect.conStr);
        SqlDataAdapter daSP;
        DataSet dsSP;
        DataTable dtSP;
        DataColumn[] key = new DataColumn[1];

        public void loadDSSP(DataGridView dataGridView)
        {          
            try
            {
                string selectStr = "SELECT SANPHAM.MASP, TENSP, CHATLIEU.TENCHATLIEU, MAUSAC.TENMAU, KICHTHUOC, SOLUONG, DONGIANHAP, DONGIABAN, MOTA, HINH " +
                    "FROM SANPHAM JOIN SANPHAM_MAU_CHATLIEU ON SANPHAM.MASP = SANPHAM_MAU_CHATLIEU.MASP " +
                    "JOIN CHATLIEU ON CHATLIEU.MACHATLIEU = SANPHAM_MAU_CHATLIEU.MACHATLIEU " +
                    "JOIN MAUSAC ON MAUSAC.MAMAU = SANPHAM_MAU_CHATLIEU.MAMAU";
                daSP = new SqlDataAdapter(selectStr, connection);
                dsSP = new DataSet();
                dtSP = new DataTable();
                daSP.Fill(dsSP, "DSSP");
                dtSP = dsSP.Tables["DSSP"];
                dataGridView.DataSource = dtSP;
                key[0] = dsSP.Tables["DSSP"].Columns[0];
                dsSP.Tables["DSSP"].PrimaryKey = key;
            }
            catch(Exception ex)
            {
               MessageBox.Show("Losed, " +ex.Message);
            }
        }

        public void FilterData(DataGridView dataGridView, string query, int? maMau, string maCl)
        {
            
            try
            {
                if (maMau == 0 || maCl == "0")
                {

                    this.loadDSSP(dataGridView);
                    return;
                }
                string selectStr = "SELECT SANPHAM.MASP, TENSP, CHATLIEU.TENCHATLIEU, MAUSAC.TENMAU, KICHTHUOC, SOLUONG, DONGIANHAP, DONGIABAN, MOTA, HINH " +
                    "FROM SANPHAM JOIN SANPHAM_MAU_CHATLIEU ON SANPHAM.MASP = SANPHAM_MAU_CHATLIEU.MASP " +
                    "JOIN CHATLIEU ON CHATLIEU.MACHATLIEU = SANPHAM_MAU_CHATLIEU.MACHATLIEU " +
                    "JOIN MAUSAC ON MAUSAC.MAMAU = SANPHAM_MAU_CHATLIEU.MAMAU WHERE  " + query;

                daSP = new SqlDataAdapter(selectStr, connection);
                dsSP = new DataSet();
                dtSP = new DataTable();
                daSP.Fill(dsSP, "DSSP");
                dtSP = dsSP.Tables["DSSP"];
                dataGridView.DataSource = dtSP;
                key[0] = dsSP.Tables["DSSP"].Columns[0];
                dsSP.Tables["DSSP"].PrimaryKey = key;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Losed, " + ex.Message);
            }
        }

        public Product GetProductByMaSP(string maSanPham)
        {
            string selectStr = "SELECT SANPHAM.MASP, TENSP, CHATLIEU.TENCHATLIEU, MAUSAC.TENMAU, KICHTHUOC, SOLUONG, DONGIANHAP, DONGIABAN, MOTA, HINH " +
                                "FROM SANPHAM JOIN SANPHAM_MAU_CHATLIEU ON SANPHAM.MASP = SANPHAM_MAU_CHATLIEU.MASP " +
                                "JOIN CHATLIEU ON CHATLIEU.MACHATLIEU = SANPHAM_MAU_CHATLIEU.MACHATLIEU " +
                                "JOIN MAUSAC ON MAUSAC.MAMAU = SANPHAM_MAU_CHATLIEU.MAMAU " +
                                "WHERE SANPHAM.MASP = @MaSanPham";


            DBConnect.open(connection);

                using (SqlCommand command = new SqlCommand(selectStr, connection))
                {
                    command.Parameters.AddWithValue("@MaSanPham", maSanPham);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Product
                            {
                                MaSanPham = reader["MASP"].ToString(),
                                TenSanPham = reader["TENSP"].ToString(),
                                KichThuoc = reader["KICHTHUOC"].ToString(),
                                SoLuong = Convert.ToInt32(reader["SOLUONG"]),
                                DonGiaNhap = Convert.ToSingle(reader["DONGIANHAP"]),
                                DonGiaBan = Convert.ToSingle(reader["DONGIABAN"]),
                                MoTa = reader["MOTA"].ToString(),
                                HinhAnh = reader["HINH"].ToString()
                            };
                        }
                    }
                }
            DBConnect.close(connection);

            // Return null if the product with the given ID is not found
            return null;
        }

        public bool UpdateProductByMaSP(Product updatedProduct)
        {
            string updateStr = "UPDATE SANPHAM " +
                               "SET TENSP = @TenSanPham, KICHTHUOC = @KichThuoc, SOLUONG = @SoLuong, " +
                               "DONGIANHAP = @DonGiaNhap, DONGIABAN = @DonGiaBan, MOTA = @MoTa, HINH = @HinhAnh " +
                               "WHERE MASP = @MaSanPham";


            DBConnect.open(connection);

            using (SqlCommand command = new SqlCommand(updateStr, connection))
                {
                    command.Parameters.AddWithValue("@TenSanPham", updatedProduct.TenSanPham);
                    command.Parameters.AddWithValue("@KichThuoc", updatedProduct.KichThuoc);
                    command.Parameters.AddWithValue("@SoLuong", updatedProduct.SoLuong);
                    command.Parameters.AddWithValue("@DonGiaNhap", updatedProduct.DonGiaNhap);
                    command.Parameters.AddWithValue("@DonGiaBan", updatedProduct.DonGiaBan);
                    command.Parameters.AddWithValue("@MoTa", updatedProduct.MoTa);
                    command.Parameters.AddWithValue("@HinhAnh", updatedProduct.HinhAnh);
                    command.Parameters.AddWithValue("@MaSanPham", updatedProduct.MaSanPham);

                    int rowsAffected = command.ExecuteNonQuery();

                DBConnect.close(connection);

                return rowsAffected > 0;
                }

            
            }

        public bool UpdateProductColor(string maSanPham, int maMau, string maChatLieu)
        {
            string updateStr = "UPDATE SANPHAM_MAU_CHATLIEU " +
                               "SET MAMAU = @MaMau, MACHATLIEU = @MaChatLieu " +
                               "WHERE MASP = @MaSanPham";


            DBConnect.open(connection);

                using (SqlCommand command = new SqlCommand(updateStr, connection))
                {
                    command.Parameters.AddWithValue("@MaMau", maMau);
                    command.Parameters.AddWithValue("@MaChatLieu", maChatLieu);
                    command.Parameters.AddWithValue("@MaSanPham", maSanPham);

                    int rowsAffected = command.ExecuteNonQuery();

                DBConnect.close(connection);

                    return rowsAffected > 0;
                }
            }
        


        public void loadChatLieu(ComboBox cmb)
        {
            string selectStr = "SELECT * FROM CHATLIEU";
            SqlDataAdapter da_ChatLieu = new SqlDataAdapter(selectStr, connection);
            DataSet dsChatLieu = new DataSet();
            da_ChatLieu.Fill(dsChatLieu, "DSCHATLIEU");

            DataRow allRow = dsChatLieu.Tables["DSCHATLIEU"].NewRow();
            allRow["MACHATLIEU"] = 0;
            allRow["TENCHATLIEU"] = "All";
            dsChatLieu.Tables["DSCHATLIEU"].Rows.InsertAt(allRow, 0);


            cmb.DataSource = dsChatLieu.Tables["DSCHATLIEU"];
            cmb.DisplayMember = "TENCHATLIEU";
            cmb.ValueMember = "MACHATLIEU";
        }

        public void loadMau(ComboBox cmb)
        {
            string selectStr = "SELECT * FROM MAUSAC";
            SqlDataAdapter da_Mau = new SqlDataAdapter(selectStr, connection);
            DataSet dsMau = new DataSet();

            da_Mau.Fill(dsMau, "DSMAU");
            DataRow allRow = dsMau.Tables["DSMAU"].NewRow();
            allRow["MAMAU"] = 0;
            allRow["TENMAU"] = "All";
            dsMau.Tables["DSMAU"].Rows.InsertAt(allRow, 0);


            cmb.DataSource = dsMau.Tables["DSMAU"];
            cmb.DisplayMember = "TENMAU";
            cmb.ValueMember = "MAMAU";
        }

        public string getNew()
        {
                 List<string> dsLoai = new List<string>();
                string selectStr = "SELECT TOP 1 MASP FROM SANPHAM ORDER BY MASP DESC";
                SqlDataAdapter da = new SqlDataAdapter(selectStr, connection);
                DataSet ds = new DataSet();
                da.Fill(ds, "CTSP");
                DataTable dt = ds.Tables["CTSP"];

                foreach (DataRow dr in dt.Rows)
                {
                    string maSP = dr["MASP"].ToString();
                
                    dsLoai.Add(maSP);
                }           
            return dsLoai[0];
        }

        public string xuLyMaLoai()
        {
            string layMaSP = this.getNew().Trim();
            string chuoiSo = layMaSP.Substring(2);
            int so = int.Parse(chuoiSo) + 1;
            if (so < 10)
            {
                return "SP00" + so;
            }
            else
                return "SP0" + so;

        }

        public void delete(string masp)
        {
            DBConnect.open(connection);

            string query1 = $"DELETE FROM SANPHAM_MAU_CHATLIEU WHERE MASP = '{masp}'";
            string query2 = $"DELETE FROM SANPHAM WHERE MASP = '{masp}'" ;

            SqlCommand cmd = new SqlCommand(query1, connection);
            SqlCommand cmd2 = new SqlCommand(query2, connection);
            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();

            DBConnect.close(connection);
        }


       
    }
}
