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

        }

        private void cmbTenCN_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.servername = cmbTenCN.SelectedValue.ToString();
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
            MessageBox.Show("Thành công", "", MessageBoxButtons.OK);
        }
    }
}