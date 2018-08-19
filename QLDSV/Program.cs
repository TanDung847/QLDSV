using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using System.Data.SqlClient;
using System.Data;
using QLDSV.Forms;

namespace QLDSV
{
    static class Program
    {
        /// <summary>
        public static SqlConnection conn = new SqlConnection();
        public static String connstr;
        public static SqlDataReader myReader;
        public static String servername = "";
        public static String username = "";
        public static String mlogin = "";
        public static String password = "";

        public static String database = "QLDSV";
        public static String remotelogin = "SUPPORT_CONNECT";
        public static String remotepassword = "123";
        public static String mloginDN = "";
        public static String passwordDN = "";
        public static String mGroup = "";
        public static String mHoten = "";
        public static int mKhoa = 0;

        public static BindingSource bds_dspm = new BindingSource();  // giữ bdsPM khi đăng nhập
        public static frmMain frmChinh;

        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();
            try
            {
                Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog=" +
                      Program.database + ";User ID=" +
                      Program.mlogin + ";password=" + Program.password;
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }

        public static SqlConnection KiemTraKetNoi(String servername)
        {
            SqlConnection _conn = new SqlConnection();
            String _connstr = "Data Source=" + servername + ";Initial Catalog=" +
                       Program.database + ";User ID=" +
                      Program.remotelogin + ";password=" + Program.remotepassword;
            _conn.ConnectionString = _connstr;
            _conn.Open();
            return _conn;

        }

        public static int KetNoiBySupport(String _servername)
        {
            int ok = 1;
            String orgServername = Program.servername;
            String orgMLogin = Program.mlogin;
            String orgPassword = Program.password;
            Program.servername = _servername;
            Program.mlogin = Program.remotelogin;
            Program.password = Program.remotepassword;
            ok = Program.KetNoi();
            Program.servername = orgServername;
            Program.mlogin = orgMLogin;
            Program.password = orgPassword;
            return ok;
        }

        public static bool checkExistsAllSite(SqlDataReader myreader, String strLenh)
        {
            bool ok = false;
            String serverToCheck;
            
            for (int i = 0; i < bds_dspm.Count; i++)
            {
                serverToCheck = ((DataRowView)Program.bds_dspm[i])["TENSERVER"].ToString().Trim();
                SqlConnection _conn;
                try
                {
                    _conn = KiemTraKetNoi(serverToCheck);
                    if (!serverToCheck.Equals(servername))
                    {
                        myreader.Close();
                        SqlCommand sqlcmd = new SqlCommand(strLenh, _conn);
                        sqlcmd.CommandType = CommandType.Text;
                        try
                        {
                            myreader = sqlcmd.ExecuteReader();
                            if (myreader != null && myreader.HasRows) ok = true;
                        }
                        catch (SqlException ex)
                        {
                            _conn.Close();
                        }
                    }
                } catch (Exception e)
                {
                    ok = false;
                }
            }
           
            return ok;
        }

        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader(); return myreader;
            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static DataTable ExecSqlDataTable(String cmd)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public static int ExecSqlNonQuery(String strlenh)
        {
            SqlCommand Sqlcmd = new SqlCommand(strlenh, conn);
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandTimeout = 600;// 10 phut 
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sqlcmd.ExecuteNonQuery(); conn.Close();
                return 0;
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("Error converting data type varchar to int"))
                    MessageBox.Show("Bạn format Cell lại cột \"Ngày Thi\" qua kiểu Number hoặc mở File Excel.");
                else MessageBox.Show(ex.Message);
                conn.Close();
                return ex.State; // trang thai lỗi gởi từ RAISERROR trong SQL Server qua
            }
        }
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            frmChinh = new frmMain();

            Application.Run(new Forms.frmDangNhap());
            //Application.Run(mainForm: new frmSinhVien());
        }
    }
}
