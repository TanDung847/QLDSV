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
            // TODO: This line of code loads data into the 'dS_DSPM.V_DSPM' table. You can move, or remove it, as needed.
            this.v_DSPMTableAdapter.Fill(this.dS_DSPM.V_DSPM);
            // TODO: This line of code loads data into the 'dS_QLDSV.v_dsmh' table. You can move, or remove it, as needed.
            this.dS_QLDSV.EnforceConstraints = false;

            this.v_dsmhTableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_dsmhTableAdapter.Fill(this.dS_QLDSV.v_dsmh);
            // TODO: This line of code loads data into the 'dS_QLDSV.v_dslop' table. You can move, or remove it, as needed.
            
            this.v_dslopTableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_dslopTableAdapter.Fill(this.dS_QLDSV.v_dslop);
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.mKhoa = cmbKhoa.SelectedIndex;
            try
            {
                if (Program.KetNoiBySupport(cmbKhoa.SelectedValue.ToString()) == 1)
                {
                    this.v_dslopTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.v_dslopTableAdapter.Fill(this.dS_QLDSV.v_dslop);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
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

        private void XfrmPhieuDiemThi_Activated(object sender, EventArgs e)
        {
            cmbKhoa.SelectedIndex = Program.mKhoa;

            if (Program.mGroup == "KHOA")
            {
                panel1.Dispose();
            }
        }
    }
}