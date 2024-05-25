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
<<<<<<< HEAD
        private static string connec = @"Data Source=DESKTOP-GGGCNOA;Initial Catalog=""Quản lí Lớp và Học Sinh"";Integrated Security=TrueData Source=DESKTOP-GGGCNOA;Initial Catalog=""Quản lí Lớp và Học Sinh"";Integrated Security=True";
=======
        private static string connec = @"Data Source=DESKTOP-IDR9C82;Initial Catalog=Quản lí Lớp và Học Sinh;Integrated Security=True;TrustServerCertificate=True";
>>>>>>> 55a3801209612dd5c142df2d4e0a3d0bcc8d1c48
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connec);
        }
    }
}
