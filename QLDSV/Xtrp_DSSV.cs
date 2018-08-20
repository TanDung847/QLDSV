using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV
{
    public partial class Xtrp_DSSV : DevExpress.XtraReports.UI.XtraReport
    {
        public Xtrp_DSSV(String makhoa, String malop)
        {
            InitializeComponent();
            dS_QLDSV1.EnforceConstraints = false;
            this.sP_DSSVTableAdapter1.Fill(this.dS_QLDSV1.SP_DSSV, makhoa, malop);
        }
        public void setLabel(String tenlop)
        {
            this.lbLop.Text = "Lớp: " + tenlop;
        }

    }
}
