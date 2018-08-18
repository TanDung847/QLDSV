using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
namespace QLDSV.Forms
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_DSPM.V_DSPM' table. You can move, or remove it, as needed.
            this.v_DSPMTableAdapter.Fill(this.dS_DSPM.V_DSPM);
            cbbKhoa.SelectedIndex = 1;
            cbbKhoa.SelectedIndex = 0;
        }

        private void cmbTenCN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbKhoa.SelectedValue != null)
            {
                Program.servername = cbbKhoa.SelectedValue.ToString();
                Program.mKhoa = cbbKhoa.SelectedIndex;
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(txtLogin.Text.Trim() == "")
            {
                MessageBox.Show("Tài khoản đăng nhập không được trống", "Lỗi đăng nhập", MessageBoxButtons.OK);
                txtLogin.Focus();
                return;
            }
            Program.mlogin = txtLogin.Text;
            Program.password = txtPass.Text;
            if(Program.KetNoi() == 0)
            {
                return;
            }
            Program.mKhoa = cbbKhoa.SelectedIndex;
            Program.bds_dspm = bdsDSPM;
            SqlDataReader myReader;
            String strLenh = "exec SP_DANGNHAP '" + Program.mlogin + "'";
            myReader = Program.ExecSqlDataReader(strLenh);
            if(myReader == null)
            {
                return;
            }
            while (myReader.Read())
            {
                
                Program.username = myReader.GetString(0);
                if (Convert.IsDBNull(Program.username))
                {
                    MessageBox.Show("Login không có quyền truy cập CSDL\nBạn xem lại username và password.\n", "", MessageBoxButtons.OK);
                    return;
                }
                try
                {
                    Program.mHoten = myReader.GetString(1);
                    Program.mGroup = myReader.GetString(2);
                }
                catch (System.Data.SqlTypes.SqlNullValueException ex)
                {
                    Console.WriteLine("Test");
                }
                
            }
            myReader.Close();
            Program.conn.Close();
            Form frmMain = new frmMain();
            frmMain.Closed += (s, args) => this.Close();
            frmMain.Show();
            this.Hide();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap_Click(sender, e);
            }
        }
    }
}