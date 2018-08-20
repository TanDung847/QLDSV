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
    public partial class frmMonHoc : DevExpress.XtraEditors.XtraForm
    {
        int vitri = 0;
        string makh = "";
        public frmMonHoc()
        {
            InitializeComponent();
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Program.mKhoa = cmbKhoa.SelectedIndex;
            Program.mKhoa = cmbKhoa.SelectedIndex;
            try
            {
                if (Program.KetNoiBySupport(cmbKhoa.SelectedValue.ToString()) == 1)
                {
                    this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.mONHOCTableAdapter.Fill(this.dS_QLDSV.MONHOC);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }


        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsMonHoc.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS_QLDSV);

        }

        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_DSPM.V_DSPM' table. You can move, or remove it, as needed.
            this.v_DSPMTableAdapter.Fill(this.dS_DSPM.V_DSPM);
            this.dS_QLDSV.EnforceConstraints = false;
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS_QLDSV.MONHOC);
            // TODO: This line of code loads data into the 'dS_QLDSV.DIEM' table. You can move, or remove it, as needed.
            this.dIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dIEMTableAdapter.Fill(this.dS_QLDSV.DIEM);

            // TODO: This line of code loads data into the 'dS_DSPM.V_DSPM' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'dS_QLDSV.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS_QLDSV.MONHOC);
            groupBox1.Enabled = false;
            btnSave.Enabled = false;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gcMonHoc.Enabled = false;
            vitri = bdsMonHoc.Position;
            groupBox1.Enabled = true;
            bdsMonHoc.AddNew();
            txtMaMH.Text = "";
            txtTenMH.Text = "";
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = false;
            btnSave.Enabled = btnPhucHoi.Enabled = true;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gcMonHoc.Enabled = false;
            vitri = bdsMonHoc.Position;
            groupBox1.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = false;
            btnSave.Enabled = btnPhucHoi.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Int32 mamh = 0;
            if (bdsDiem.Count > 0)
            {
                MessageBox.Show("Không thể xóa môn học này vì có tồn tại bảng điểm", "",
                       MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xóa môn học này ?? ", "Xác nhận",
                       MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                   // mamh = int.Parse(((DataRowView)bdsMonHoc[bdsMonHoc.Position])["MAMH"].ToString()); // giữ lại để khi xóa bij lỗi thì ta sẽ quay về lại
                    bdsMonHoc.RemoveCurrent();
                    this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.mONHOCTableAdapter.Update(this.dS_QLDSV.MONHOC);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa môn học. Bạn hãy xóa lại\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.mONHOCTableAdapter.Fill(this.dS_QLDSV.MONHOC);
                    bdsMonHoc.Position = bdsMonHoc.Find("MAMH", mamh);
                    return;
                }
            }

            if (bdsMonHoc.Count == 0) btnXoa.Enabled = false;

        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(txtMaMH.Text.Trim() == "")
            {
                MessageBox.Show("Mã môn học không được trống", "", MessageBoxButtons.OK);
                txtMaMH.Focus();
            }
            if (txtTenMH.Text.Trim() == "")
            {
                MessageBox.Show("Tên môn học không được trống", "", MessageBoxButtons.OK);
                txtTenMH.Focus();
            }
            try
            {
                bdsMonHoc.EndEdit();
                bdsMonHoc.ResetCurrentItem();
                this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.mONHOCTableAdapter.Update(dS_QLDSV.MONHOC);
            }
            catch(Exception exc)
            {
                MessageBox.Show("Lỗi ghi môn học", exc.Message , MessageBoxButtons.OK);
                return;
            }
            groupBox1.Enabled = false;
            btnPhucHoi.Enabled = btnSua.Enabled = btnThem.Enabled = btnXoa.Enabled = true;
            gcMonHoc.Enabled = true;

        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gcMonHoc.Enabled = true;
            groupBox1.Enabled = false;
            bdsMonHoc.CancelEdit();
            if (btnThem.Enabled == false) bdsMonHoc.Position = vitri;
            groupBox1.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            btnSave.Enabled = btnPhucHoi.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.mONHOCTableAdapter.Fill(this.dS_QLDSV.MONHOC);
            groupBox1.Enabled = false;
            gcMonHoc.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            btnSave.Enabled = false;
        }

        private void frmMonHoc_Activated(object sender, EventArgs e)
        {
            cmbKhoa.SelectedIndex = Program.mKhoa;
            if (Program.mGroup == "PGV")
            {
                cmbKhoa.Enabled = true;
                bar2.Dispose();
                groupBox1.Dispose();
            }
            else if (Program.mGroup == "KHOA")
            {
                panel1.Dispose();
                bar2.Dispose();
                groupBox1.Dispose();
            }
            else
            {
                panel1.Dispose();
            }
        }
    }
}