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
    public partial class XfrmBangDiemTongKet : DevExpress.XtraEditors.XtraForm
    {
        bool isPGV = false;
        public XfrmBangDiemTongKet()
        {
            InitializeComponent();
        }

        private void XfrmBangDiemTongKet_Load(object sender, EventArgs e)
        {
            isPGV = Program.mGroup.Equals("PGV");
            if (isPGV)
            {
                pnKhoa.Visible = true;
            }
            // TODO: This line of code loads data into the 'dS_DSPM.V_DSPM' table. You can move, or remove it, as needed.
            this.v_DSPMTableAdapter.Fill(this.dS_DSPM.V_DSPM);
            // TODO: This line of code loads data into the 'dS_QLDSV.v_dslop' table. You can move, or remove it, as needed.
            this.v_dslopTableAdapter.Fill(this.dS_QLDSV.v_dslop);

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            String malop = cbbMALOP.SelectedValue.ToString();
            String tenlop = cbbMALOP.Text.ToString();
            Xtrp_BangDiemTongKet xtrp_BangDiemTongKet = new Xtrp_BangDiemTongKet(malop, tenlop);
            ReportPrintTool print = new ReportPrintTool(xtrp_BangDiemTongKet);
            print.ShowPreviewDialog();
        }
    }
}