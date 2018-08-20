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
    public partial class XfrmDSSV : DevExpress.XtraEditors.XtraForm
    {
        public XfrmDSSV()
        {
            InitializeComponent();
        }

        private void XfrmDSSV_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'dS_QLDSV.v_dskhoa' table. You can move, or remove it, as needed.
            this.v_dskhoaTableAdapter.Fill(this.dS_QLDSV.v_dskhoa);
            // TODO: This line of code loads data into the 'dS_QLDSV.v_dslop' table. You can move, or remove it, as needed.
            this.v_dslopTableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_dslopTableAdapter.Fill(this.dS_QLDSV.v_dslop);
            // TODO: This line of code loads data into the 'dS_DSPM.V_DSPM' table. You can move, or remove it, as needed.
            this.v_DSPMTableAdapter.Fill(this.dS_DSPM.V_DSPM);
            

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            String makhoa = cbbKhoa.SelectedValue.ToString();
            Console.WriteLine("ma khoa: " + makhoa);
            String malop = cbbMALOP.SelectedValue.ToString();
            Console.WriteLine("ma lop: " + malop);
            Xtrp_DSSV xtrp_DSSV = new Xtrp_DSSV(makhoa, malop);
            xtrp_DSSV.setLabel(cbbMALOP.Text.Trim());
            ReportPrintTool print = new ReportPrintTool(xtrp_DSSV);
            print.ShowPreviewDialog();
        }

        private void cbbMAKHOA_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.mKhoa = cbbKhoa.SelectedIndex;
            try
            {
                if (Program.KetNoiBySupport(cbbKhoa.SelectedValue.ToString()) == 1)
                {
                    this.dS_QLDSV.EnforceConstraints = false;
                    this.v_dslopTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.v_dslopTableAdapter.Fill(this.dS_QLDSV.v_dslop);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void XfrmDSSV_Activated(object sender, EventArgs e)
        {
            if (Program.mGroup.Equals("PGV"))
            {
                pnKhoa.Visible = true;
                cbbKhoa.SelectedIndex = Program.mKhoa;
            }
        }
    }
}