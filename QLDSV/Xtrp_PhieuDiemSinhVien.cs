using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV
{
    public partial class Xtrp_PhieuDiemSinhVien : DevExpress.XtraReports.UI.XtraReport
    {
        public Xtrp_PhieuDiemSinhVien(String masv)
        {
            InitializeComponent();
            dS_QLDSV1.EnforceConstraints = false;
            this.sP_PHIEUDIEMTableAdapter.Fill(this.dS_QLDSV1.SP_PHIEUDIEM, masv);
        }

    }
}
