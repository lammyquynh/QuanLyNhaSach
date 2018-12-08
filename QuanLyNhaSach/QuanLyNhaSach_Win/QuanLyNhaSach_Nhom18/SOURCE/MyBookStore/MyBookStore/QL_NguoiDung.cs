using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.Sql;

namespace MyBookStore
{
    public partial class QL_NguoiDung
    {
        public int LoginResult = -2;
        public int Check_Config()
        {
            string strConection = System.Configuration.ConfigurationManager.ConnectionStrings["MyBookStore.Properties.Settings.QL_NHASACHConnectionString"].ToString();
            if (Properties.Settings.Default.QL_NHASACHConnectionString == string.Empty)
                return 1;// Chuỗi cấu hình không tồn tại
            SqlConnection _Sqlconn = new SqlConnection(Properties.Settings.Default.QL_NHASACHConnectionString);
            try
            {
                if (_Sqlconn.State == System.Data.ConnectionState.Closed)
                    _Sqlconn.Open();
                return 0;// Kết nối thành công chuỗi cấu hình hợp lệ
            }
            catch
            {
                return 2;// Chuỗi cấu hình không phù hợp.
            }
        }
        public int Check_User(string pUser, string pPass)
        {
            SqlDataAdapter daUser = new SqlDataAdapter("select * from NHANVIEN where MANV='" + pUser + "' and MATKHAU ='" + pPass + "'",Properties.Settings.Default.QL_NHASACHConnectionString);
            DataTable dt = new DataTable();
            daUser.Fill(dt);
            if (dt.Rows.Count == 0)
            {
            LoginResult = 0;// User không tồn tại
                 return LoginResult;
            }
            else if (dt.Rows[0][2] == null || dt.Rows[0][2].ToString() == "False")
            {
                 LoginResult = -1;
                 return LoginResult;// Không hoạt động
            }
            else{
                LoginResult = 1;
                User = pUser;
                return LoginResult;// Đăng nhập thành công
            }
        }
        public DataTable GetServerName()
        {
            SqlDataSourceEnumerator instance = SqlDataSourceEnumerator.Instance;
            System.Data.DataTable table = instance.GetDataSources();
            return table;
        }
        public List<string> GetDatabaseName(string pServerName, string pUser, string pPass)
        {
            List<string> _list = new List<string>();
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT name FROM sys.databases", "Data Source=" + pServerName + ";Initial Catalog=" + "master" + ";UserID=" + pUser + ";pwd = " + pPass + "");
                da.Fill(dt);
                foreach (System.Data.DataRow row in dt.Rows)
                {
                foreach (System.Data.DataColumn col in dt.Columns)
                {
                _list.Add(row[col].ToString());
                }
                }
            }
            catch
            {
            return null;
            }
            return _list;
        }
        public void ChangeConnectionString(string pServerName, string pDataBase, string pUser,string pPass)
        {
            //MyBookStore.Properties.Settings.Default.QL_NHASACHConnectionString = "Data Source=" + pServerName + ";Initial Catalog=" + pDataBase + ";User ID=" + pUser + ";pwd = " + pPass + "";
            //Properties.Settings.Default.Save();
        }

        public string User { get; set; }
    }
}
