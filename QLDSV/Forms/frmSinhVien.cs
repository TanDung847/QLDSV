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
using System.Data.SqlClient;

namespace QLDSV.Forms
{
    public partial class frmSinhVien : DevExpress.XtraEditors.XtraForm
    {
        bool isPGV = false;
        int viTri = 0;
        bool editMode = false;
        String currentMaSv;
        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void sINHVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sINHVIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS_QLDSV);

        }
        private void reload()
        {
            sINHVIENBindingSource.CancelEdit();
            groupBox1.Enabled = false;
            setButtonBarState(true);
        }

        private void setButtonBarState(bool state)
        {
            btnAdd.Enabled = state;
            btnEdit.Enabled = state;
            btnDelete.Enabled = state;
            btnUndo.Enabled = state;
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_DSPM.V_DSPM' table. You can move, or remove it, as needed.
            this.v_DSPMTableAdapter.Fill(this.dS_DSPM.V_DSPM);
            // TODO: This line of code loads data into the 'dS_QLDSV.v_dslop' table. You can move, or remove it, as needed.
            this.v_dslopTableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_dslopTableAdapter.Fill(this.dS_QLDSV.v_dslop);
            // TODO: This line of code loads data into the 'dS_QLDSV.SINHVIEN' table. You can move, or remove it, as needed.
            this.dS_QLDSV.EnforceConstraints = false;
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.dS_QLDSV.SINHVIEN);
            
        }

        private void pHAILabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            setButtonBarState(false);
            viTri = sINHVIENBindingSource.Position;
            groupBox1.Enabled = true;
            sINHVIENBindingSource.AddNew();
            this.v_dslopTableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_dslopTableAdapter.Fill(this.dS_QLDSV.v_dslop);
            cbbMaLop.DataSource = v_dslopBindingSource;
            cbbMaLop.SelectedIndex = 0;
        }

        private void cbbMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            //System.Diagnostics.Debug.WriteLine(cbbMaLop.SelectedValue);
            //String malop = cbbMaLop.SelectedValue.ToString();
            
            //cbbMaLop.ValueMember = malop;
            //cbbMaLop.DataSource = v_dslopBindingSource;
            //cbbMaLop.DisplayMember = v_dslopBindingSource.get

        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            setButtonBarState(false);
            editMode = true;
            viTri = sINHVIENBindingSource.Position;
            groupBox1.Enabled = true;
            String maLop = cbbMaLop.SelectedValue.ToString();
            this.v_dslopTableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_dslopTableAdapter.Fill(this.dS_QLDSV.v_dslop);
            cbbMaLop.DataSource = v_dslopBindingSource;
            cbbMaLop.SelectedValue = maLop;

            //btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnPrint.Enabled = false;
            //btnGhi.Enabled = btnUndo.Enabled = true;
            //gcSV.Enabled = false;
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (txtMASV.Text.Trim() == "")
            //{
            //    MessageBox.Show("Mã sinh viên không được phép rỗng", "", MessageBoxButtons.OK);
            //    txtMASV.Focus();
            //    return;
            //}
            //if (txtHO.Text.Trim() == "")
            //{
            //    MessageBox.Show("Họ không được phép rỗng", "", MessageBoxButtons.OK);
            //    txtHO.Focus();
            //    return;
            //}
            //if (txtTEN.Text.Trim() == "")
            //{
            //    MessageBox.Show("Tên không được phép rỗng", "", MessageBoxButtons.OK);
            //    txtTEN.Focus();
            //    return;
            //}
            //if (txtDIACHI.Text.Trim() == "")
            //{
            //    MessageBox.Show("Địa chỉ không được phép rỗng", "", MessageBoxButtons.OK);
            //    txtDIACHI.Focus();
            //    return;
            //}
            //if (dateNGAYSINH.Text.Trim() == "")
            //{
            //    MessageBox.Show("Ngày sinh không được phép rỗng", "", MessageBoxButtons.OK);
            //    dateNGAYSINH.Focus();
            //    return;
            //}

            ////((DataRowView)bdsSV[0])["MALOP"] = cmbMALOP.SelectedText.ToString().Trim();
            //if (!isExists())
            //{
            //    try
            //    {
            //        sINHVIENBindingSource.EndEdit();
            //        sINHVIENBindingSource.ResetCurrentItem();
            //        this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            //        this.sINHVIENTableAdapter.Update(this.dS_QLDSV.SINHVIEN);
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Lỗi ghi sinh viên.\n" + ex.Message, "", MessageBoxButtons.OK);
            //        return;
            //    }
            //    //gcSV.Enabled = true;
            //    //btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnPrint.Enabled = true;
            //    //btnGhi.Enabled = btnUndo.Enabled = false;

            //    groupBox1.Enabled = false;
            //    editMode = false;
            //}
        }
        private bool isExists()
        {
            Console.WriteLine(currentMaSv);
            if (editMode && txtMASV.Text.Trim() == currentMaSv)
            {
                return false;
            }
            string cmd = "declare @ret int; \r\nexec sp_KiemTraSinhVien N'" + txtMASV.Text.Trim() + "', @ret OUTPUT\r\nselect @ret";
            SqlDataReader reader = Program.ExecSqlDataReader(cmd);
            if (reader != null && reader.HasRows)
            {
                while (reader.Read())
                {
                    int ret = reader.GetInt32(0);
                    if (ret == 1)
                    {
                        MessageBox.Show("Mã sinh viên đã tồn tại", "Đóng");
                        reader.Close();
                        return true;
                    }
                    else if (ret == 2)
                    {
                        reader.Close();
                        MessageBox.Show("Mã sinh viên đã tồn tại trên khoa khác", "Đóng");
                        return true;
                    }
                }
            }
            reader.Close();
            return false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            reload();
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String masv = "";

            if (MessageBox.Show("Bạn có thật sự muốn xóa sinh viên này ?? ", "Xác nhận",
                       MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    masv = ((DataRowView)sINHVIENBindingSource[sINHVIENBindingSource.Position])["MASV"].ToString(); // giữ lại để khi xóa bij lỗi thì ta sẽ quay về lại
                    sINHVIENBindingSource.RemoveCurrent();
                    this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sINHVIENTableAdapter.Update(this.dS_QLDSV.SINHVIEN);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa sinh viên. Bạn hãy xóa lại\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.sINHVIENTableAdapter.Fill(this.dS_QLDSV.SINHVIEN);
                    sINHVIENBindingSource.Position = sINHVIENBindingSource.Find("MASV", masv);
                    return;
                }
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.mKhoa = cbbKhoa.SelectedIndex;
            try
            {
                if (Program.KetNoiBySupport(cbbKhoa.SelectedValue.ToString()) == 1)
                {
                    this.v_dslopTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.v_dslopTableAdapter.Fill(this.dS_QLDSV.v_dslop);
                    this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.dS_QLDSV.EnforceConstraints = false;
                    this.sINHVIENTableAdapter.Fill(this.dS_QLDSV.SINHVIEN);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
           
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            if (txtMASV.Text.Trim() == "")
            {
                MessageBox.Show("Mã sinh viên không được phép rỗng", "", MessageBoxButtons.OK);
                txtMASV.Focus();
                return;
            }
            if (txtHO.Text.Trim() == "")
            {
                MessageBox.Show("Họ không được phép rỗng", "", MessageBoxButtons.OK);
                txtHO.Focus();
                return;
            }
            if (txtTEN.Text.Trim() == "")
            {
                MessageBox.Show("Tên không được phép rỗng", "", MessageBoxButtons.OK);
                txtTEN.Focus();
                return;
            }
            if (txtDIACHI.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ không được phép rỗng", "", MessageBoxButtons.OK);
                txtDIACHI.Focus();
                return;
            }
            if (dateNGAYSINH.Text.Trim() == "")
            {
                MessageBox.Show("Ngày sinh không được phép rỗng", "", MessageBoxButtons.OK);
                dateNGAYSINH.Focus();
                return;
            }
            if (dateNGAYSINH.DateTime.Date > DateTime.Today)
            {
                MessageBox.Show("Ngày sinh không được phép lớn hơn ngày hiện tại", "", MessageBoxButtons.OK);
                dateNGAYSINH.Focus();
                return;
            }
            TimeSpan years = DateTime.Today.Subtract(dateNGAYSINH.DateTime);
            if (dateNGAYSINH.DateTime > DateTime.Now.AddYears(-16))
            {
                MessageBox.Show("Sinh viên phải lớn hơn 16 tuổi", "", MessageBoxButtons.OK);
                dateNGAYSINH.Focus();
                return;
            }

            //((DataRowView)bdsSV[0])["MALOP"] = cmbMALOP.SelectedText.ToString().Trim();
            if (!isExists())
            {
                updateDataSource();
            }
            }

        private void btnDelete_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa sinh viên có mã " + ((DataRowView)sINHVIENBindingSource[viTri])["MASV"].ToString().Trim() + " không?", "Xác nhận",
                       MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                sINHVIENBindingSource.RemoveAt(viTri);
                updateDataSource();
            }
        }
        private void updateDataSource()
        {
            try
            {
                sINHVIENBindingSource.EndEdit();
                sINHVIENBindingSource.ResetCurrentItem();
                btnUndo.Enabled = true;
                reload();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi sinh viên.\n" + ex.Message, "", MessageBoxButtons.OK);
                reload();
                return;
            }
            //gcSV.Enabled = true;
            //btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnPrint.Enabled = true;
            //btnGhi.Enabled = btnUndo.Enabled = false;

            groupBox1.Enabled = false;
            editMode = false;
        }

        private void sINHVIENGridControl_MouseClick(object sender, MouseEventArgs e)
        {
            this.viTri = sINHVIENBindingSource.Position;
            this.currentMaSv = ((DataRowView)sINHVIENBindingSource[viTri])["MASV"].ToString().Trim();
        }

        private void frmSinhVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            saveToDatabase();
        }

        private void frmSinhVien_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            saveToDatabase();
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.sINHVIENTableAdapter.Fill(this.dS_QLDSV.SINHVIEN);
            reload();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            reload();
        }

        private void frmSinhVien_Activated(object sender, EventArgs e)
        {
            //frmSinhVien_Load(sender, e);
            isPGV = Program.mGroup.Equals("PGV");
            if (isPGV)
            {
                pnKhoa.Visible = true;
                cbbKhoa.SelectedIndex = Program.mKhoa;
            }
            if (Program.mGroup.Equals("USER"))
            {
                groupBox1.Visible = true;
                barChucNang.Visible = true;
            }
        }

        private void saveToDatabase()
        {
            btnUndo.Enabled = false;
            try
            {
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Update(this.dS_QLDSV.SINHVIEN);
            }
            catch (Exception ex)
            {

            }
        }

        private void frmSinhVien_Deactivate(object sender, EventArgs e)
        {
            saveToDatabase();
        }

        private void sINHVIENGridControl_Click(object sender, EventArgs e)
        {

        }
    }
}