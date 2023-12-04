using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace DoAn
{
    public class DBConnect 
    {
        public static string conStr = "Data Source = ANVYNEHIHI; Initial Catalog = QL_CUAHANGQUANAO; User ID =sa; Password = 123";
        static SqlConnection conn = new SqlConnection(DBConnect.conStr);

        //kết nối CSDL
        public SqlConnection Connect
        {
            get { return conn; }
            set { conn = value; }
        }
        public DBConnect()
        {
            conn = new SqlConnection(conStr);
        }
        //lấy kết nối
        public string GetConnectionString()
        {
            return Connect.ConnectionString;
        }
        //mở 
        public void open()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }
        //đóng 
        public void close()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }


        public int getNonQuery(string sql)
        {
            open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            int kq = cmd.ExecuteNonQuery();
            close();
            return kq;
        }

        //đọc dữ liệu
        public SqlDataReader getDataReader(string sql)
        {
            open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader rd = cmd.ExecuteReader();
            //close();
            return rd;
        }
        //trả về giá trị duy nhất
        public object getScalar(string sql)
        {
            open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            object kq = cmd.ExecuteScalar();
            close();
            return kq;
        }
        //trả về kết quả dưới dạng DataTable
        public DataTable getDatatable(string sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            return dt;
        }
        //cập nhập CSDL
        public int updateDatabase(string sql, DataTable dt)
        {
            SqlDataAdapter da_lop = new SqlDataAdapter(sql, Connect);
            SqlCommandBuilder cb = new SqlCommandBuilder(da_lop);
            int kq = da_lop.Update(dt);
            return kq;
        }



        public static void open(SqlConnection connection)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public static void close(SqlConnection connection)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public static string formatString(string str)
        {
            string[] parts = str.Split(new[] { ", " }, StringSplitOptions.None);

            // Đặt các dấu nháy đơn xung quanh mỗi phần tử của mảng (nếu không phải là số)
            for (int i = 0; i < parts.Length; i++)
            {
                if (!int.TryParse(parts[i], out _))
                {
                    parts[i] = $"N'{parts[i]}'";
                }
                if (parts[i].EndsWith(".p'"))
                {
                    parts[i] = parts[i].Replace(".p", ".png");
                }
                else if (parts[i].EndsWith(".j'"))
                {
                    parts[i] = parts[i].Replace(".j", ".jpg");
                }
            }
            // Kết hợp các phần tử đã đặt dấu nháy đơn thành một chuỗi mới, cách nhau bởi dấu phẩy và khoảng trắng
            string resultString = string.Join(", ", parts);
            return resultString;
        }
        public static void addData(string tableName, params object[] values)
        {
            DBConnect.open(conn);
            string valueStr = string.Join(", ", values);
            string value = valueStr.Substring(0, valueStr.Length - 2);
            string result = formatString(value);
            string selectStr = "INSERT INTO " + tableName + " VALUES(" + result + ")";
            SqlCommand cmd = new SqlCommand(selectStr, conn);
            cmd.ExecuteNonQuery();
            DBConnect.close(conn);
        }

        
    }

}
