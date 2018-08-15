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
    public partial class frmLop : DevExpress.XtraEditors.XtraForm
    {
        int viTri = 0;
        bool editMode = false;
        public frmLop()
        {
            InitializeComponent();
        }

        private void reload()
        {
            this.lOPTableAdapter.Fill(this.dS_QLDSV.LOP);
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS_QLDSV);

        }

        private void frmLop_Load(object sender, EventArgs e)
        {
            this.v_DSPMTableAdapter.Fill(this.dS_DSPM.V_DSPM);
            // TODO: This line of code loads data into the 'dS_QLDSV.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dS_QLDSV.EnforceConstraints = false;
            this.lOPTableAdapter.Fill(this.dS_QLDSV.LOP);

        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupBox1.Enabled = true;
            lOPBindingSource.AddNew();
            txtMAKHOA.Text = "CNTT";
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            editMode = true;
            groupBox1.Enabled = true;
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa môn học có mã " + ((DataRowView)lOPBindingSource[viTri])["MALOP"].ToString().Trim() + " không?", "Xác nhận",
                       MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                lOPBindingSource.RemoveAt(viTri);
                updateDataSource();
            }
          
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMALOP.Text.Trim() == "")
            {
                MessageBox.Show("Mã lớp không được thiếu!", "", MessageBoxButtons.OK);
                txtMALOP.Focus();
                return;
            }

            if (txtTENLOP.Text.Trim() == "")
            {
                MessageBox.Show("Tên lớp không được thiếu!", "", MessageBoxButtons.OK);
                txtTENLOP.Focus();
                return;
            }
            if (!isExits())
            {
                updateDataSource();
            }
        }

        private void updateDataSource()
        {
            try
            {
                lOPBindingSource.EndEdit();
                lOPBindingSource.ResetCurrentItem();
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Update(this.dS_QLDSV);
                reload();
                groupBox1.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu môn học.\n" + ex.Message, "", MessageBoxButtons.OK);
                reload();
                return;
            }
        }
        private bool isExits()
        {
            if (editMode && (txtMALOP.Text == ((DataRowView)lOPBindingSource[viTri])["MALOP"].ToString().Trim() || txtTENLOP.Text == ((DataRowView)lOPBindingSource[viTri])["TENLOP"].ToString().Trim()))
            {
                return false;
            }

            string cmd = "SELECT * FROM LOP WHERE MALOP = '" + txtMALOP.Text.Trim() + "' OR TENLOP = '" + txtTENLOP.Text.Trim() + "'";
            SqlDataReader reader = Program.ExecSqlDataReader(cmd);
            if (reader != null && reader.HasRows)
            {
                MessageBox.Show("Mã hoặc tên lớp đã tồn tại", "Đóng");
                reader.Close();
                return true;
            }
            else if (Program.checkExistsAllSite(cmd))
            {
                reader.Close();
                MessageBox.Show("Mã hoặc tên lớp đã tồn tại trên chi nhánh khác", "Đóng");
                return true;
            }
            return false;
        }

        private void tENCNComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            reload();
        }

        private void lOPGridControl_MouseClick(object sender, MouseEventArgs e)
        {
            this.viTri = lOPBindingSource.Position;
        }
    }
}