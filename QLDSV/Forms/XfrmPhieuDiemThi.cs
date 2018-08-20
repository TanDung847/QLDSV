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
using DevExpress.XtraReports.UI;

namespace QLDSV.Forms
{
    public partial class XfrmPhieuDiemThi : DevExpress.XtraEditors.XtraForm
    {
        public XfrmPhieuDiemThi()
        {
            InitializeComponent();
        }

        private void XfrmPhieuDiemThi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_QLDSV.v_dsmh' table. You can move, or remove it, as needed.
            this.dS_QLDSV.EnforceConstraints = false;

            this.v_dsmhTableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_dsmhTableAdapter.Fill(this.dS_QLDSV.v_dsmh);
            // TODO: This line of code loads data into the 'dS_QLDSV.v_dslop' table. You can move, or remove it, as needed.
            
            cmbKhoa.DataSource = Program.bds_dspm;
            cmbKhoa.DisplayMember = "TENCN";
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.SelectedIndex = Program.mKhoa;

            this.v_dslopTableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_dslopTableAdapter.Fill(this.dS_QLDSV.v_dslop);

            if(Program.mGroup == "KHOA")
            {
                panel1.Dispose();
            }
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbKhoa.SelectedValue.ToString() != "System.Data.DataRowView")
                {
                    Program.servername = cmbKhoa.SelectedValue.ToString();
                }
            }catch(Exception exc)
            {

            }
            if (cmbKhoa.SelectedIndex != Program.mKhoa)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            }
            else
            {
                this.v_dslopTableAdapter.Connection.ConnectionString = Program.connstr;
                this.v_dslopTableAdapter.Fill(this.dS_QLDSV.v_dslop);

            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            String makhoa = cmbKhoa.SelectedValue.ToString();
            String malop = cmbLop.SelectedValue.ToString();
            xrp_PHIEUDIEMTHI xtrp_PHIEUDIEMTHI = new xrp_PHIEUDIEMTHI(makhoa, malop);
            xtrp_PHIEUDIEMTHI.xrpLop.Text = cmbLop.Text.ToString();
            xtrp_PHIEUDIEMTHI.xrpMonHoc.Text = cmbMonHoc.Text.ToString();
            xtrp_PHIEUDIEMTHI.xrpNgayThi.Text = "";
            ReportPrintTool print = new ReportPrintTool(xtrp_PHIEUDIEMTHI);
            print.ShowPreviewDialog();

        }
    }
}