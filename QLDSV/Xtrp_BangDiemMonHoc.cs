using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV
{
    public partial class Xtrp_BangDiemMonHoc : DevExpress.XtraReports.UI.XtraReport
    {
        public Xtrp_BangDiemMonHoc(String malop, String mamh, int lan)
        {
            InitializeComponent();
            dS_QLDSV1.EnforceConstraints = false;
            this.sP_BANGDIEMTableAdapter.Fill(this.dS_QLDSV1.SP_BANGDIEM, malop, mamh, lan);
        }
        public void setLabel(String tenlop, String tenmh, int lan)
        {
            this.lbLop.Text = "Lớp: " + tenlop;
            this.lbMonHoc.Text = "Môn học: " + tenmh;
            this.lbLan.Text = "Lần thi: " + lan.ToString();
        }


    }
}
