namespace QLDSV.Forms
{
    partial class XfrmBangDiemMonHoc
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
            System.Windows.Forms.Label tenlopLabel;
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label tENCNLabel;
            this.pnKhoa = new System.Windows.Forms.Panel();
            this.v_DSPMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_DSPM = new QLDSV.DS_DSPM();
            this.v_dskhoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_QLDSV = new QLDSV.DS_QLDSV();
            this.v_dskhoaTableAdapter = new QLDSV.DS_QLDSVTableAdapters.v_dskhoaTableAdapter();
            this.tableAdapterManager = new QLDSV.DS_QLDSVTableAdapters.TableAdapterManager();
            this.v_dslopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_dslopTableAdapter = new QLDSV.DS_QLDSVTableAdapters.v_dslopTableAdapter();
            this.cbbMALOP = new System.Windows.Forms.ComboBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.v_dsmhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_dsmhTableAdapter = new QLDSV.DS_QLDSVTableAdapters.v_dsmhTableAdapter();
            this.cbbMAMH = new System.Windows.Forms.ComboBox();
            this.numberLan = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.dSDSPMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_DSPMTableAdapter = new QLDSV.DS_DSPMTableAdapters.V_DSPMTableAdapter();
            this.tableAdapterManager1 = new QLDSV.DS_DSPMTableAdapters.TableAdapterManager();
            this.cbbKhoa = new System.Windows.Forms.ComboBox();
            tenlopLabel = new System.Windows.Forms.Label();
            mAMHLabel = new System.Windows.Forms.Label();
            tENCNLabel = new System.Windows.Forms.Label();
            this.pnKhoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DSPMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DSPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_dskhoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_QLDSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_dslopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_dsmhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberLan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDSPMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tenlopLabel
            // 
            tenlopLabel.AutoSize = true;
            tenlopLabel.Location = new System.Drawing.Point(163, 69);
            tenlopLabel.Name = "tenlopLabel";
            tenlopLabel.Size = new System.Drawing.Size(24, 13);
            tenlopLabel.TabIndex = 1;
            tenlopLabel.Text = "Lớp";
            tenlopLabel.Click += new System.EventHandler(this.tenlopLabel_Click);
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(163, 111);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(48, 13);
            mAMHLabel.TabIndex = 4;
            mAMHLabel.Text = "Môn Học";
            mAMHLabel.Click += new System.EventHandler(this.mAMHLabel_Click);
            // 
            // pnKhoa
            // 
            this.pnKhoa.Controls.Add(tENCNLabel);
            this.pnKhoa.Controls.Add(this.cbbKhoa);
            this.pnKhoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnKhoa.Location = new System.Drawing.Point(0, 0);
            this.pnKhoa.Name = "pnKhoa";
            this.pnKhoa.Size = new System.Drawing.Size(680, 64);
            this.pnKhoa.TabIndex = 0;
            this.pnKhoa.Visible = false;
            // 
            // v_DSPMBindingSource
            // 
            this.v_DSPMBindingSource.DataMember = "V_DSPM";
            this.v_DSPMBindingSource.DataSource = this.dS_DSPM;
            // 
            // dS_DSPM
            // 
            this.dS_DSPM.DataSetName = "DS_DSPM";
            this.dS_DSPM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_dskhoaBindingSource
            // 
            this.v_dskhoaBindingSource.DataMember = "v_dskhoa";
            this.v_dskhoaBindingSource.DataSource = this.dS_QLDSV;
            // 
            // dS_QLDSV
            // 
            this.dS_QLDSV.DataSetName = "DS_QLDSV";
            this.dS_QLDSV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_dskhoaTableAdapter
            // 
            this.v_dskhoaTableAdapter.ClearBeforeFill = true;
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
            // v_dslopBindingSource
            // 
            this.v_dslopBindingSource.DataMember = "v_dslop";
            this.v_dslopBindingSource.DataSource = this.dS_QLDSV;
            // 
            // v_dslopTableAdapter
            // 
            this.v_dslopTableAdapter.ClearBeforeFill = true;
            // 
            // cbbMALOP
            // 
            this.cbbMALOP.DataSource = this.v_dslopBindingSource;
            this.cbbMALOP.DisplayMember = "tenlop";
            this.cbbMALOP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMALOP.FormattingEnabled = true;
            this.cbbMALOP.Location = new System.Drawing.Point(238, 66);
            this.cbbMALOP.Name = "cbbMALOP";
            this.cbbMALOP.Size = new System.Drawing.Size(258, 21);
            this.cbbMALOP.TabIndex = 2;
            this.cbbMALOP.ValueMember = "malop";
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(421, 148);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(75, 23);
            this.btnIn.TabIndex = 3;
            this.btnIn.Text = "In Bảng Điểm";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // v_dsmhBindingSource
            // 
            this.v_dsmhBindingSource.DataMember = "v_dsmh";
            this.v_dsmhBindingSource.DataSource = this.dS_QLDSV;
            // 
            // v_dsmhTableAdapter
            // 
            this.v_dsmhTableAdapter.ClearBeforeFill = true;
            // 
            // cbbMAMH
            // 
            this.cbbMAMH.DataSource = this.v_dsmhBindingSource;
            this.cbbMAMH.DisplayMember = "TENMH";
            this.cbbMAMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMAMH.FormattingEnabled = true;
            this.cbbMAMH.Location = new System.Drawing.Point(238, 108);
            this.cbbMAMH.Name = "cbbMAMH";
            this.cbbMAMH.Size = new System.Drawing.Size(258, 21);
            this.cbbMAMH.TabIndex = 5;
            this.cbbMAMH.ValueMember = "MAMH";
            // 
            // numberLan
            // 
            this.numberLan.Location = new System.Drawing.Point(238, 148);
            this.numberLan.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numberLan.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberLan.Name = "numberLan";
            this.numberLan.Size = new System.Drawing.Size(37, 21);
            this.numberLan.TabIndex = 6;
            this.numberLan.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Lần Thi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dSDSPMBindingSource
            // 
            this.dSDSPMBindingSource.DataSource = this.dS_DSPM;
            this.dSDSPMBindingSource.Position = 0;
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
            tENCNLabel.Location = new System.Drawing.Point(163, 26);
            tENCNLabel.Name = "tENCNLabel";
            tENCNLabel.Size = new System.Drawing.Size(31, 13);
            tENCNLabel.TabIndex = 0;
            tENCNLabel.Text = "Khoa";
            // 
            // cbbKhoa
            // 
            this.cbbKhoa.DataSource = this.v_DSPMBindingSource;
            this.cbbKhoa.DisplayMember = "TENCN";
            this.cbbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbKhoa.FormattingEnabled = true;
            this.cbbKhoa.Location = new System.Drawing.Point(238, 26);
            this.cbbKhoa.Name = "cbbKhoa";
            this.cbbKhoa.Size = new System.Drawing.Size(258, 21);
            this.cbbKhoa.TabIndex = 1;
            this.cbbKhoa.ValueMember = "TENSERVER";
            this.cbbKhoa.SelectedIndexChanged += new System.EventHandler(this.cbbKhoa_SelectedIndexChanged_1);
            // 
            // XfrmBangDiemMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 235);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberLan);
            this.Controls.Add(mAMHLabel);
            this.Controls.Add(this.cbbMAMH);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(tenlopLabel);
            this.Controls.Add(this.cbbMALOP);
            this.Controls.Add(this.pnKhoa);
            this.Name = "XfrmBangDiemMonHoc";
            this.Text = "XfrmBangDiemMonHoc";
            this.Load += new System.EventHandler(this.XfrmBangDiemMonHoc_Load);
            this.pnKhoa.ResumeLayout(false);
            this.pnKhoa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DSPMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DSPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_dskhoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_QLDSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_dslopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_dsmhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberLan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDSPMBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnKhoa;
        private DS_QLDSV dS_QLDSV;
        private System.Windows.Forms.BindingSource v_dskhoaBindingSource;
        private DS_QLDSVTableAdapters.v_dskhoaTableAdapter v_dskhoaTableAdapter;
        private DS_QLDSVTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource v_dslopBindingSource;
        private DS_QLDSVTableAdapters.v_dslopTableAdapter v_dslopTableAdapter;
        private System.Windows.Forms.ComboBox cbbMALOP;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.BindingSource v_dsmhBindingSource;
        private DS_QLDSVTableAdapters.v_dsmhTableAdapter v_dsmhTableAdapter;
        private System.Windows.Forms.ComboBox cbbMAMH;
        private System.Windows.Forms.NumericUpDown numberLan;
        private System.Windows.Forms.Label label1;
        private DS_DSPM dS_DSPM;
        private System.Windows.Forms.BindingSource dSDSPMBindingSource;
        private System.Windows.Forms.BindingSource v_DSPMBindingSource;
        private DS_DSPMTableAdapters.V_DSPMTableAdapter v_DSPMTableAdapter;
        private DS_DSPMTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.ComboBox cbbKhoa;
    }
}