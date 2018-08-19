namespace QLDSV.Forms
{
    partial class XfrmPhieuDiemSinhVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label ho_va_TenLabel;
            System.Windows.Forms.Label tENCNLabel;
            this.dS_QLDSV = new QLDSV.DS_QLDSV();
            this.v_dssvBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_dssvTableAdapter = new QLDSV.DS_QLDSVTableAdapters.V_dssvTableAdapter();
            this.tableAdapterManager = new QLDSV.DS_QLDSVTableAdapters.TableAdapterManager();
            this.cbbMASV = new System.Windows.Forms.ComboBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.pnKhoa = new System.Windows.Forms.Panel();
            this.dS_DSPM = new QLDSV.DS_DSPM();
            this.v_DSPMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_DSPMTableAdapter = new QLDSV.DS_DSPMTableAdapters.V_DSPMTableAdapter();
            this.tableAdapterManager1 = new QLDSV.DS_DSPMTableAdapters.TableAdapterManager();
            this.cbbKhoa = new System.Windows.Forms.ComboBox();
            ho_va_TenLabel = new System.Windows.Forms.Label();
            tENCNLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dS_QLDSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_dssvBindingSource)).BeginInit();
            this.pnKhoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DSPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DSPMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ho_va_TenLabel
            // 
            ho_va_TenLabel.AutoSize = true;
            ho_va_TenLabel.Location = new System.Drawing.Point(94, 104);
            ho_va_TenLabel.Name = "ho_va_TenLabel";
            ho_va_TenLabel.Size = new System.Drawing.Size(41, 13);
            ho_va_TenLabel.TabIndex = 0;
            ho_va_TenLabel.Text = "Họ Tên";
            // 
            // dS_QLDSV
            // 
            this.dS_QLDSV.DataSetName = "DS_QLDSV";
            this.dS_QLDSV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_dssvBindingSource
            // 
            this.v_dssvBindingSource.DataMember = "V_dssv";
            this.v_dssvBindingSource.DataSource = this.dS_QLDSV;
            // 
            // v_dssvTableAdapter
            // 
            this.v_dssvTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DIEMTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV.DS_QLDSVTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cbbMASV
            // 
            this.cbbMASV.DataSource = this.v_dssvBindingSource;
            this.cbbMASV.DisplayMember = "Ho va Ten";
            this.cbbMASV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMASV.FormattingEnabled = true;
            this.cbbMASV.Location = new System.Drawing.Point(160, 101);
            this.cbbMASV.Name = "cbbMASV";
            this.cbbMASV.Size = new System.Drawing.Size(224, 21);
            this.cbbMASV.TabIndex = 1;
            this.cbbMASV.ValueMember = "MASV";
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(206, 154);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(102, 24);
            this.btnIn.TabIndex = 2;
            this.btnIn.Text = "In Phiếu Điểm";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // pnKhoa
            // 
            this.pnKhoa.Controls.Add(tENCNLabel);
            this.pnKhoa.Controls.Add(this.cbbKhoa);
            this.pnKhoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnKhoa.Location = new System.Drawing.Point(0, 0);
            this.pnKhoa.Name = "pnKhoa";
            this.pnKhoa.Size = new System.Drawing.Size(534, 67);
            this.pnKhoa.TabIndex = 3;
            this.pnKhoa.Visible = false;
            // 
            // dS_DSPM
            // 
            this.dS_DSPM.DataSetName = "DS_DSPM";
            this.dS_DSPM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_DSPMBindingSource
            // 
            this.v_DSPMBindingSource.DataMember = "V_DSPM";
            this.v_DSPMBindingSource.DataSource = this.dS_DSPM;
            // 
            // v_DSPMTableAdapter
            // 
            this.v_DSPMTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = QLDSV.DS_DSPMTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tENCNLabel
            // 
            tENCNLabel.AutoSize = true;
            tENCNLabel.Location = new System.Drawing.Point(114, 29);
            tENCNLabel.Name = "tENCNLabel";
            tENCNLabel.Size = new System.Drawing.Size(44, 13);
            tENCNLabel.TabIndex = 0;
            tENCNLabel.Text = "TENCN:";
            // 
            // cbbKhoa
            // 
            this.cbbKhoa.DataSource = this.v_DSPMBindingSource;
            this.cbbKhoa.DisplayMember = "TENCN";
            this.cbbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbKhoa.FormattingEnabled = true;
            this.cbbKhoa.Location = new System.Drawing.Point(164, 26);
            this.cbbKhoa.Name = "cbbKhoa";
            this.cbbKhoa.Size = new System.Drawing.Size(220, 21);
            this.cbbKhoa.TabIndex = 1;
            this.cbbKhoa.ValueMember = "TENSERVER";
            this.cbbKhoa.SelectedIndexChanged += new System.EventHandler(this.cbbKhoa_SelectedIndexChanged);
            // 
            // XfrmPhieuDiemSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 211);
            this.Controls.Add(this.pnKhoa);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(ho_va_TenLabel);
            this.Controls.Add(this.cbbMASV);
            this.Name = "XfrmPhieuDiemSinhVien";
            this.Text = "XfrmPhieuDiem";
            this.Load += new System.EventHandler(this.XfrmPhieuDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS_QLDSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_dssvBindingSource)).EndInit();
            this.pnKhoa.ResumeLayout(false);
            this.pnKhoa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DSPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DSPMBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DS_QLDSV dS_QLDSV;
        private System.Windows.Forms.BindingSource v_dssvBindingSource;
        private DS_QLDSVTableAdapters.V_dssvTableAdapter v_dssvTableAdapter;
        private DS_QLDSVTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cbbMASV;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Panel pnKhoa;
        private DS_DSPM dS_DSPM;
        private System.Windows.Forms.BindingSource v_DSPMBindingSource;
        private DS_DSPMTableAdapters.V_DSPMTableAdapter v_DSPMTableAdapter;
        private DS_DSPMTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.ComboBox cbbKhoa;
    }
}