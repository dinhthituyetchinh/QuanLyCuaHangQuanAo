using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAn.Models;
using System.Data.SqlClient;
using System.Windows;

namespace DoAn.Service
{
    public class UserService
    {
        SqlConnection connection;
        public UserService()
        {
            connection = new SqlConnection(DBConnect.conStr);
        }
       
        public NguoiDung getUser(string username, string password)
        {
            NguoiDung user = new NguoiDung();
            try
            {
               DBConnect.open(connection);
                string selectString = "SELECT * FROM NGUOIDUNG WHERE USERNAME ='" + username + "' AND PASSWORD = '" + password + "'";
                SqlCommand cmd = new SqlCommand(selectString, connection);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    user.username = rdr["USERNAME"].ToString();
                    user.password = rdr["PASSWORD"].ToString();
                    user.fullName = rdr["HOTEN"].ToString();
                    user.address = rdr["DIACHI"].ToString();
                    user.roles = int.Parse(rdr["MAQUYEN"].ToString());
                }
                DBConnect.close(connection);

            }
            catch (Exception ex)
            {
                MessageBox.Show(" losed " + ex.Message);
            }
            return user;

        }

    }
}
