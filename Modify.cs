using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyLop
{
    internal class Modify
    {
        SqlDataAdapter dataAdapter;
        SqlCommand sqlCommand;
        SqlDataReader dataReader;
        public Modify() { }

        public DataTable getLop()
        {
            DataTable dataTable = new DataTable();
            string query = "select * from  Lop";
            using (SqlConnection sqlConnection = Connection.GetConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }

        public DataTable getAllHocSinh()
        {
            DataTable dataTable = new DataTable();
            string query = "select * from  HocSinh";
            using (SqlConnection sqlConnection = Connection.GetConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }

        public bool insertLop(Lop lop)
        {
            SqlConnection sqlConnection = Connection.GetConnection();
            string query = "insert into Lop values (@MaLop,@TenLop,@TenGV,@SLuongHS)";

            try
            {
                sqlConnection.Open();

                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@MaLop", SqlDbType.Int).Value = lop.MaLop;
                sqlCommand.Parameters.Add("@TenLop", SqlDbType.NVarChar).Value = lop.TenLop;
                sqlCommand.Parameters.Add("@TenGV", SqlDbType.NVarChar).Value = lop.TenGV;
                sqlCommand.Parameters.Add("@SLuongHS", SqlDbType.Int).Value = lop.SoLuongHocSinh;
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return false;
            }

            finally
            { sqlConnection.Close(); }

            return true;

        }

        public bool insertHS(HocSinh hocsinh)
        {
            SqlConnection sqlConnection = Connection.GetConnection();
            string query = "insert into HocSinh values (@MaHS,@TenHS,@HoHS,@GioiTinh,@NgaySinh,@MaLop)";

            try
            {
                sqlConnection.Open();

                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@MaHS", SqlDbType.Int).Value = hocsinh.MaHS;
                sqlCommand.Parameters.Add("@TenHS", SqlDbType.NVarChar).Value = hocsinh.TenHS;
                sqlCommand.Parameters.Add("@HoHS", SqlDbType.NVarChar).Value = hocsinh.HoHS;
                sqlCommand.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = hocsinh.GioiTinh;
                sqlCommand.Parameters.Add("@NgaySinh", SqlDbType.DateTime).Value = hocsinh.NgaySinh.ToShortDateString();
                sqlCommand.Parameters.Add("@MaLop", SqlDbType.Int).Value = hocsinh.MaLop;
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return false;
            }

            finally
            { sqlConnection.Close(); }

            return true;

        }

        public bool updateLop(Lop lop)
        {
            SqlConnection sqlConnection = Connection.GetConnection();
            string query = "update Lop set TenLop = @TenLop, TenGV = @TenGV,SLuongHS = @SLuongHS where MaLop = @MaLop";

            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);

                sqlCommand.Parameters.Add("@MaLop", SqlDbType.Int).Value = lop.MaLop;
                sqlCommand.Parameters.Add("@TenLop", SqlDbType.NVarChar).Value = lop.TenLop;
                sqlCommand.Parameters.Add("@TenGV", SqlDbType.NVarChar).Value = lop.TenGV;
                sqlCommand.Parameters.Add("@SLuongHS", SqlDbType.Int).Value = lop.SoLuongHocSinh;
                sqlCommand.ExecuteNonQuery();

            }
            catch (Exception ex) { return false; }
            finally { sqlConnection.Close(); }
            return true;
        }

        public bool updateHS(HocSinh hocsinh)
        {
            SqlConnection sqlConnection = Connection.GetConnection();
            string query = "update HocSinh set TenHS = @TenHS, HoHS = @HoHS,GioiTinh = @GioiTinh,NgaySinh = @NgaySinh,MaLop = @MaLop WHERE MaHS = @MaHS";

            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);

                sqlCommand.Parameters.Add("@MaHS", SqlDbType.Int).Value = hocsinh.MaHS;
                sqlCommand.Parameters.Add("@TenHS", SqlDbType.NVarChar).Value = hocsinh.TenHS;
                sqlCommand.Parameters.Add("@HoHS", SqlDbType.NVarChar).Value = hocsinh.HoHS;
                sqlCommand.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = hocsinh.GioiTinh;
                sqlCommand.Parameters.Add("@NgaySinh", SqlDbType.DateTime).Value = hocsinh.NgaySinh.ToShortTimeString();
                sqlCommand.Parameters.Add("@MaLop", SqlDbType.Int).Value = hocsinh.MaLop;
                sqlCommand.ExecuteNonQuery();

            }
            catch (Exception ex) { return false; }
            finally { sqlConnection.Close(); }
            return true;
        }

        public bool deleteLop(int lop)
        {
            SqlConnection sqlConnection = Connection.GetConnection();
            string query = "delete Lop Where MaLop = @MaLop";

            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@MaLop", SqlDbType.Int).Value = lop;
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex) { return false; }
            finally { sqlConnection.Close(); }
            return true;
        }

        public bool deleteHS(int hocsinh)
        {
            SqlConnection sqlConnection = Connection.GetConnection();
            string query = "delete HocSinh Where MaHS = @MaHS";

            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@MaHS", SqlDbType.Int).Value = hocsinh;
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex) { return false; }
            finally { sqlConnection.Close(); }
            return true;
        }
    }
}
