using DoAn.form;
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
    public partial class frm_Empl_Function : Form
    {
        frm_QL_NV frm = new frm_QL_NV();
        DBConnect dbc = new DBConnect();
        DataSet ds = new DataSet();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt_NV = new DataTable();
        public frm_Empl_Function()
        {
            InitializeComponent();
        }
        public void SetEmployeeImage(byte[] imageData)
        {
            if (imageData != null && imageData.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    picBox_Empl.Image = Image.FromStream(ms);
                }
            }
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        //Thêm Hình Ảnh Vào DataBase
        private void iconButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open Image";
            ofd.Filter = "Image Files(*.JPG;*.PNG;*GIF)|*.JPG;*.PNG;*GIF";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picBox_Empl.Image = Image.FromFile(ofd.FileName);
            }    
        }

        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
        //Lưu Thông Tin Vào DataBase

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Convert the image to byte array
                byte[] imageData = ImageToByteArray(picBox_Empl.Image);
                
                {
                    // Your SQL query to insert data into the database
                    string sql = "INSERT INTO NGUOIDUNG (USERNAME, PASSWORD, HOTEN, DIACHI, MAQUYEN, HINH) " +
                                 "VALUES (@USERNAME, @PASSWORD, @HOTEN, @DIACHI, @MAQUYEN, @HINH)";

                    using (SqlCommand cmd = new SqlCommand(sql, dbc.Connect))
                    {

                        cmd.Parameters.AddWithValue("@USERNAME", txtMaNV.Text);
                        cmd.Parameters.AddWithValue("@PASSWORD", txtPass.Text);
                        cmd.Parameters.AddWithValue("@HOTEN", txtHoTenNV.Text);
                        cmd.Parameters.AddWithValue("@DIACHI", txtAddress.Text);
                        cmd.Parameters.AddWithValue("@MAQUYEN", txtMaQuyen.Text);
                        cmd.Parameters.AddWithValue("@HINH", imageData);
                        dbc.open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        dbc.close();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thêm Thành Công!!!!");
                        }
                        else
                        {
                            MessageBox.Show("Failed to insert data.");
                        }
                    }


                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                {
                    byte[] imageData = ImageToByteArray(picBox_Empl.Image);
                    // Your SQL query to insert data into the database
                    string sql = "UPDATE NGUOIDUNG SET PASSWORD = @PASSWORD, HOTEN = @HOTEN, " +
                               "DIACHI = @DIACHI, MAQUYEN = @MAQUYEN, HINH = @HINH " +
                               "WHERE USERNAME = @USERNAME";

                    using (SqlCommand cmd = new SqlCommand(sql, dbc.Connect))
                    {

                        cmd.Parameters.AddWithValue("@USERNAME", txtMaNV.Text);
                        cmd.Parameters.AddWithValue("@PASSWORD", txtPass.Text);
                        cmd.Parameters.AddWithValue("@HOTEN", txtHoTenNV.Text);
                        cmd.Parameters.AddWithValue("@DIACHI", txtAddress.Text);
                        cmd.Parameters.AddWithValue("@MAQUYEN", txtMaQuyen.Text);
                        cmd.Parameters.AddWithValue("@HINH", imageData);
                        dbc.open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        dbc.close();

                        if (rowsAffected > 0)
                        {

                            MessageBox.Show("Thêm Thành Công!!!!");
                        }
                        else
                        {
                            MessageBox.Show("Failed to insert data.");
                        }
                    }
                    DataRow existingRow = dt_NV.AsEnumerable().FirstOrDefault(row => row["USERNAME"].ToString() == txtMaNV.Text);
                }



                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
