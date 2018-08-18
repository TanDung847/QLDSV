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
        bool isPGV = false;
        String currentMaLop;
        String currentTenLop;
        public frmLop()
        {
            InitializeComponent();
            
        }

        private void reload()
        {
            lOPBindingSource.CancelEdit();
            groupBox1.Enabled = false;
            setButtonBarState(true);
        }

        private void reloadWithoutFill()
        {
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

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS_QLDSV);

        }

        private void frmLop_Load(object sender, EventArgs e)
        {
            isPGV = Program.mGroup.Equals("PGV");
            if (isPGV)
            {
                pnKhoa.Visible = true;
            }
            this.v_DSPMTableAdapter.Fill(this.dS_DSPM.V_DSPM);
            // TODO: This line of code loads data into the 'dS_QLDSV.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dS_QLDSV.EnforceConstraints = false;
            this.lOPTableAdapter.Fill(this.dS_QLDSV.LOP);

        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupBox1.Enabled = true;
            setButtonBarState(false);
            lOPBindingSource.AddNew();
            
            if (isPGV)
            {
                if (cbbKhoa.SelectedIndex == 0)
                {
                    txtMAKHOA.Text = "CNTT";
                }
                else
                {
                    txtMAKHOA.Text = "VT";
                }
            }
            else
            {
                if (Program.mKhoa == 0)
                {
                    txtMAKHOA.Text = "CNTT";
                }
                else
                {
                    txtMAKHOA.Text = "VT";
                }
            }
            
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            setButtonBarState(false);
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
            //if (txtMALOP.Text.Trim() == "")
            //{
            //    MessageBox.Show("Mã lớp không được thiếu!", "", MessageBoxButtons.OK);
            //    txtMALOP.Focus();
            //    return;
            //}

            //if (txtTENLOP.Text.Trim() == "")
            //{
            //    MessageBox.Show("Tên lớp không được thiếu!", "", MessageBoxButtons.OK);
            //    txtTENLOP.Focus();
            //    return;
            //}
            //if (!isExits())
            //{
            //    updateDataSource();
            //}
        }

        private void updateDataSource()
        {
            try
            {
                lOPBindingSource.EndEdit();
                lOPBindingSource.ResetCurrentItem();
                //this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                //this.lOPTableAdapter.Update(this.dS_QLDSV);
                reloadWithoutFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu lớp.\n" + ex.Message, "", MessageBoxButtons.OK);
                reload();
                return;
            }
        }
        private bool isExits()
        {
            string cmd = "";
            if (editMode && (txtMALOP.Text.Trim().Equals(currentMaLop) && txtTENLOP.Text.Equals(currentTenLop)))
            {
                return false;
            } else if (editMode && (txtMALOP.Text.Trim().Equals(currentMaLop)))
            {
                cmd = "declare @ret int; \r\nexec sp_KiemTraLop null, N'" + txtTENLOP.Text.Trim() + "', @ret OUTPUT\r\nselect @ret";
            } else
            {
                cmd = "declare @ret int; \r\nexec sp_KiemTraLop N'" + txtMALOP.Text.Trim() + "', null, @ret OUTPUT\r\nselect @ret";
            }

            SqlDataReader reader = Program.ExecSqlDataReader(cmd);
            if (reader != null && reader.HasRows)
            {
                while (reader.Read())
                {
                    int ret = reader.GetInt32(0);
                    if (ret == 1)
                    {
                        reader.Close();
                        MessageBox.Show("Mã hoặc tên lớp đã tồn tại", "Đóng");
                        return true;
                    } else if (ret == 2)
                    {
                        reader.Close();
                        MessageBox.Show("Mã hoặc tên lớp đã tồn tại ở khoa khác", "Đóng");
                        return true;
                    }
                }
            }
            reader.Close();
            return false;
        }

        private void tENCNComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String orgServername = Program.servername;
                String orgMLogin = Program.mlogin;
                String orgPassword = Program.password;
                Program.servername = cbbKhoa.SelectedValue.ToString();
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
                if (Program.KetNoi() == 0)
                {
                    MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
                }
                else
                {
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.dS_QLDSV.EnforceConstraints = false;
                    this.lOPTableAdapter.Fill(this.dS_QLDSV.LOP);
                }
                Program.servername = orgServername;
                Program.mlogin = orgMLogin;
                Program.password = orgPassword;
            } catch (Exception ex)
            {

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            reload();
        }

        private void lOPGridControl_MouseClick(object sender, MouseEventArgs e)
        {
            this.viTri = lOPBindingSource.Position;
            this.currentTenLop = ((DataRowView)lOPBindingSource[viTri])["TENLOP"].ToString().Trim();
            this.currentMaLop = ((DataRowView)lOPBindingSource[viTri])["MALOP"].ToString().Trim();
        }

        private void btnGhi_Click(object sender, EventArgs e)
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

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.lOPTableAdapter.Fill(this.dS_QLDSV.LOP);
            reload();
        }

        private void frmLop_FormClosed(object sender, FormClosedEventArgs e)
        {
            Console.WriteLine("End ne");
            try
            {
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Update(this.dS_QLDSV);
            } catch (Exception ex)
            {

            }
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            reload();
        }
    }
}