using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyLop
{
    internal class Connection
    {
        private static string connec = @"Data Source=DESKTOP-IDR9C82;Initial Catalog=Quản lí Lớp và Học Sinh;Integrated Security=True;TrustServerCertificate=True";
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connec);
        }
    }
}
