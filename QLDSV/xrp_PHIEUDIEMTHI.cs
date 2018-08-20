using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV
{
    public partial class xrp_PHIEUDIEMTHI : DevExpress.XtraReports.UI.XtraReport
    {
        public xrp_PHIEUDIEMTHI(string makh, string malop)
        {
            InitializeComponent();
            this.dS_QLDSV1.EnforceConstraints = false;
            this.sP_DSSVTableAdapter1.Fill(this.dS_QLDSV1.SP_DSSV,makh,malop);
        }

        private void xrLabel3_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }
    }
}
