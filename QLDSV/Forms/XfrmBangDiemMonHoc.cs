﻿using System;
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
    public partial class XfrmBangDiemMonHoc : DevExpress.XtraEditors.XtraForm
    {
        public XfrmBangDiemMonHoc()
        {
            InitializeComponent();
        }

        private void XfrmBangDiemMonHoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_QLDSV.v_dsmh' table. You can move, or remove it, as needed.
            this.v_dsmhTableAdapter.Fill(this.dS_QLDSV.v_dsmh);
            // TODO: This line of code loads data into the 'dS_QLDSV.v_dslop' table. You can move, or remove it, as needed.
            this.v_dslopTableAdapter.Fill(this.dS_QLDSV.v_dslop);
            // TODO: This line of code loads data into the 'dS_QLDSV.v_dskhoa' table. You can move, or remove it, as needed.
            this.v_dskhoaTableAdapter.Fill(this.dS_QLDSV.v_dskhoa);

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            String malop = cbbMALOP.SelectedValue.ToString();
            String mamh = cbbMAMH.SelectedValue.ToString();
            int lan = Convert.ToInt32(numberLan.Value);

            Xtrp_BangDiemMonHoc xtrp_BangDiemMonHoc = new Xtrp_BangDiemMonHoc(malop, mamh, lan);
            ReportPrintTool print = new ReportPrintTool(xtrp_BangDiemMonHoc);
            print.ShowPreviewDialog();
        }

        private void mAMHLabel_Click(object sender, EventArgs e)
        {

        }

        private void tenlopLabel_Click(object sender, EventArgs e)
        {

        }

        private void tENKHLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}