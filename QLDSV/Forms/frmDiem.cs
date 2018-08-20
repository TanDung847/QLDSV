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
using System.Data.SqlClient;
namespace QLDSV.Forms
{
    public partial class frmDiem : DevExpress.XtraEditors.XtraForm
    {
        int vitri = 0;
        int sttsv = 0;
        DataTable myDataTable;
        string mamh = "";
        string lan = "";
        public frmDiem()
        {
            InitializeComponent();
        }

        private void dIEMBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsDiem.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS_QLDSV);

        }

        private void frmDiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_DSPM.V_DSPM' table. You can move, or remove it, as needed.
            this.v_DSPMTableAdapter.Fill(this.dS_DSPM.V_DSPM);
            this.dS_QLDSV.EnforceConstraints = false;
            this.dIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dS_QLDSV.DIEM' table. You can move, or remove it, as needed.
            this.dIEMTableAdapter.Fill(this.dS_QLDSV.DIEM);
            // TODO: This line of code loads data into the 'dS_QLDSV.v_dsmh' table. You can move, or remove it, as needed.
            this.v_dsmhTableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_dsmhTableAdapter.Fill(this.dS_QLDSV.v_dsmh);
            // TODO: This line of code loads data into the 'dS_QLDSV.v_dslop' table. You can move, or remove it, as needed.
            this.v_dslopTableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_dslopTableAdapter.Fill(this.dS_QLDSV.v_dslop);
            // TODO: This line of code loads data into the 'dS_QLDSV.LOP' table. You can move, or remove it, as needed.
           
            groupBox1.Enabled = false;
            btnGhi.Enabled = false;
            
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            sttsv = 0;
            gcDiem.Enabled = false;
            vitri = bdsDiem.Position;
            groupBox1.Enabled = true;

            //bdsDiem.AddNew();
            cmbMaMH.DataSource = v_bdsDSMH;
            cmbMaMH.DisplayMember = "TENMH";
            cmbMaMH.ValueMember = "MAMH";
            cmbMaMH.SelectedIndex = 0;

            cmdLop.DataSource = v_bdsLop;
            cmdLop.DisplayMember = "TENLOP";
            cmdLop.ValueMember = "MALOP";
            cmdLop.SelectedIndex = 0;

            txtMaSV.Text = "";
            txtLan.Text = "1";
            txtDiem.EditValue = "";
            txtTenSV.Text = "";

            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            cmbMaMH.Enabled = true;
            txtLan.Enabled = true;
            //txtMaSV.Enabled = true;
            //txtTenSV.Enabled = true;
            cmdLop.Enabled = true;
            btnBatDau.Enabled = true;
            btnSau.Enabled = false;
            btnTruoc.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa mục này ?? ", "Xác nhận",
                       MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    // mamh = int.Parse(((DataRowView)bdsMonHoc[bdsMonHoc.Position])["MAMH"].ToString()); // giữ lại để khi xóa bij lỗi thì ta sẽ quay về lại
                    bdsDiem.RemoveCurrent();
                    this.dIEMTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.dIEMTableAdapter.Update(this.dS_QLDSV.DIEM);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa điểm. Bạn hãy xóa lại\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.dIEMTableAdapter.Fill(this.dS_QLDSV.DIEM);
                    //bds.Position = bdsMonHoc.Find("MAMH", mamh);
                    return;
                }
            }

        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gcDiem.Enabled = false;
            vitri = bdsDiem.Position;
            groupBox1.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            cmbMaMH.DataSource = v_bdsDSMH;
            cmbMaMH.DisplayMember = "TENMH";
            cmbMaMH.ValueMember = "MAMH";
            cmbMaMH.SelectedIndex = 0;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
       {
            if (txtDiem.Text.Trim() == "")
            {
                MessageBox.Show("Điểm không được trống", "", MessageBoxButtons.OK);
                txtDiem.Focus();
            }
           
            if (txtMaSV.Text.Trim() == "")
            {
                MessageBox.Show("Mã sinh viên không được trống", "", MessageBoxButtons.OK);
                txtMaSV.Focus();
            }
            if (txtLan.Text.Trim() == "")
            {
                MessageBox.Show("Lần thi không được trống", "", MessageBoxButtons.OK);
                txtMaSV.Focus();
            }
            if (cmbMaMH.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Mã môn học không được trống", "", MessageBoxButtons.OK);
                txtMaSV.Focus();
            }
            try
            {
                bdsDiem.EndEdit();
                bdsDiem.ResetCurrentItem();
                this.dIEMTableAdapter.Connection.ConnectionString = Program.connstr;
                this.dIEMTableAdapter.Update(dS_QLDSV.DIEM);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Lỗi ghi môn học"+ exc.Message,"", MessageBoxButtons.OK);
                return;
            }
            groupBox1.Enabled = false;
            btnPhucHoi.Enabled = btnSua.Enabled = btnThem.Enabled = btnXoa.Enabled = true;
            gcDiem.Enabled = true;
            cmbMaMH.DataSource = bdsDiem;
            cmbMaMH.DisplayMember = "MAMH";
            cmbMaMH.ValueMember = "MAMH";
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gcDiem.Enabled = true;
            groupBox1.Enabled = false;
            bdsDiem.CancelEdit();
            if (btnThem.Enabled == false) bdsDiem.Position = vitri;
            groupBox1.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            cmbMaMH.DataSource = bdsDiem;
            cmbMaMH.DisplayMember = "MAMH";
            cmbMaMH.ValueMember = "MAMH";

        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.mKhoa = cmbKhoa.SelectedIndex;
            try
            {
                if (Program.KetNoiBySupport(cmbKhoa.SelectedValue.ToString()) == 1)
                {
                    this.dIEMTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.dIEMTableAdapter.Fill(this.dS_QLDSV.DIEM);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.dIEMTableAdapter.Fill(this.dS_QLDSV.DIEM);
            groupBox1.Enabled = false;
            gcDiem.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            btnGhi.Enabled = false;
            cmbMaMH.DataSource = bdsDiem;
            cmbMaMH.DisplayMember = "MAMH";
            cmbMaMH.ValueMember = "MAMH";
        }

        private void cmbMaMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMaMH.SelectedIndex.ToString() == "System.Data.DataRowView")
            {
                mamh = cmbMaMH.SelectedValue.ToString();
            }
        }

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            if(txtLan.Text.ToString() == "" || int.Parse(txtLan.Text.ToString()) <1 || int.Parse(txtLan.Text.ToString()) > 2)
            {
                MessageBox.Show("Lần thi không hợp lệ", "", MessageBoxButtons.OK);
                return;
            }

            mamh = cmbMaMH.SelectedValue.ToString();
            lan = txtLan.Text.ToString();

            //cmbMaMH.DataSource = bdsDiem;
           // cmbMaMH.DisplayMember = "MAMH";
            //cmbMaMH.ValueMember = "MAMH";

            bdsDiem.AddNew();

            txtLan.Text = lan;
            cmbMaMH.SelectedValue = mamh;

            sttsv = 0;
            String strLenh = "exec SP_LOPSV '" + cmdLop.SelectedValue + "'";
            myDataTable = Program.ExecSqlDataTable(strLenh);
            if (myDataTable.Rows.Count == 0)
            {
                MessageBox.Show("Lớp không tồn tại sinh viên", "", MessageBoxButtons.OK);
                return;
            }

            txtMaSV.EditValue = myDataTable.Rows[sttsv][0].ToString().Trim();
            txtTenSV.Text = myDataTable.Rows[sttsv][1].ToString().Trim();

            cmbMaMH.Enabled = false;
            txtLan.Enabled = false;
            //txtMaSV.Enabled = false;
            txtTenSV.Enabled = false;
            cmdLop.Enabled = false;
            
            

            btnTruoc.Enabled = false;
            btnBatDau.Enabled = false;
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            //txtLan.Text = lan;
            cmbMaMH.SelectedValue = mamh;
            txtMaSV.EditValue = myDataTable.Rows[sttsv][0].ToString();
            bdsDiem.EndEdit();
            bdsDiem.AddNew();
            sttsv = sttsv - 1;
            if(sttsv == 0)
            {
                btnTruoc.Enabled = false;
                return;
            }
            btnSau.Enabled = true;
            cmbMaMH.SelectedValue = mamh;
            txtMaSV.EditValue = myDataTable.Rows[sttsv][0].ToString();
            txtTenSV.Text = myDataTable.Rows[sttsv][1].ToString();
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
           // txtLan.Text = lan;
            cmbMaMH.SelectedValue = mamh;
            txtMaSV.EditValue = myDataTable.Rows[sttsv][0].ToString();
            bdsDiem.EndEdit();
            bdsDiem.AddNew();

            txtLan.Text = lan;
            cmbMaMH.SelectedValue = mamh;


            sttsv = sttsv + 1;
            if (sttsv == myDataTable.Rows.Count)
            {
                btnSau.Enabled = false;
                return;
            }
            btnTruoc.Enabled = true;
            cmbMaMH.SelectedValue = mamh;
            txtMaSV.EditValue = myDataTable.Rows[sttsv][0].ToString();
            txtTenSV.Text = myDataTable.Rows[sttsv][1].ToString();
        }

        private void cmdLop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmDiem_Activated(object sender, EventArgs e)
        {
            if (Program.mGroup == "PGV")
            {
                cmbKhoa.Enabled = true;
                bar2.Dispose();
                groupBox1.Dispose();
                cmbKhoa.SelectedIndex = Program.mKhoa;
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