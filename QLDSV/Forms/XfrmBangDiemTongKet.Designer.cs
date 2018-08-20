namespace QLDSV.Forms
{
    partial class XfrmBangDiemTongKet
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
            System.Windows.Forms.Label tenlopLabel;
            System.Windows.Forms.Label tENCNLabel;
            this.dS_QLDSV = new QLDSV.DS_QLDSV();
            this.v_dslopBindingSource = new System.Windows.Forms.BindingSource();
            this.v_dslopTableAdapter = new QLDSV.DS_QLDSVTableAdapters.v_dslopTableAdapter();
            this.tableAdapterManager = new QLDSV.DS_QLDSVTableAdapters.TableAdapterManager();
            this.cbbMALOP = new System.Windows.Forms.ComboBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.pnKhoa = new System.Windows.Forms.Panel();
            this.cbbKhoa = new System.Windows.Forms.ComboBox();
            this.v_DSPMBindingSource = new System.Windows.Forms.BindingSource();
            this.dS_DSPM = new QLDSV.DS_DSPM();
            this.v_DSPMTableAdapter = new QLDSV.DS_DSPMTableAdapters.V_DSPMTableAdapter();
            this.tableAdapterManager1 = new QLDSV.DS_DSPMTableAdapters.TableAdapterManager();
            tenlopLabel = new System.Windows.Forms.Label();
            tENCNLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dS_QLDSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_dslopBindingSource)).BeginInit();
            this.pnKhoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DSPMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DSPM)).BeginInit();
            this.SuspendLayout();
            // 
            // tenlopLabel
            // 
            tenlopLabel.AutoSize = true;
            tenlopLabel.Location = new System.Drawing.Point(46, 85);
            tenlopLabel.Name = "tenlopLabel";
            tenlopLabel.Size = new System.Drawing.Size(24, 13);
            tenlopLabel.TabIndex = 1;
            tenlopLabel.Text = "Lớp";
            // 
            // tENCNLabel
            // 
            tENCNLabel.AutoSize = true;
            tENCNLabel.Location = new System.Drawing.Point(39, 22);
            tENCNLabel.Name = "tENCNLabel";
            tENCNLabel.Size = new System.Drawing.Size(31, 13);
            tENCNLabel.TabIndex = 0;
            tENCNLabel.Text = "Khoa";
            // 
            // dS_QLDSV
            // 
            this.dS_QLDSV.DataSetName = "DS_QLDSV";
            this.dS_QLDSV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // cbbMALOP
            // 
            this.cbbMALOP.DataSource = this.v_dslopBindingSource;
            this.cbbMALOP.DisplayMember = "tenlop";
            this.cbbMALOP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMALOP.FormattingEnabled = true;
            this.cbbMALOP.Location = new System.Drawing.Point(91, 82);
            this.cbbMALOP.Name = "cbbMALOP";
            this.cbbMALOP.Size = new System.Drawing.Size(278, 21);
            this.cbbMALOP.TabIndex = 2;
            this.cbbMALOP.ValueMember = "malop";
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(386, 82);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(109, 21);
            this.btnIn.TabIndex = 3;
            this.btnIn.Text = "In Bảng Điểm";
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
            this.pnKhoa.Size = new System.Drawing.Size(548, 54);
            this.pnKhoa.TabIndex = 4;
            this.pnKhoa.Visible = false;
            // 
            // cbbKhoa
            // 
            this.cbbKhoa.DataSource = this.v_DSPMBindingSource;
            this.cbbKhoa.DisplayMember = "TENCN";
            this.cbbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbKhoa.FormattingEnabled = true;
            this.cbbKhoa.Location = new System.Drawing.Point(91, 19);
            this.cbbKhoa.Name = "cbbKhoa";
            this.cbbKhoa.Size = new System.Drawing.Size(278, 21);
            this.cbbKhoa.TabIndex = 1;
            this.cbbKhoa.ValueMember = "TENSERVER";
            this.cbbKhoa.SelectedIndexChanged += new System.EventHandler(this.cbbKhoa_SelectedIndexChanged);
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
            // XfrmBangDiemTongKet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 162);
            this.Controls.Add(this.pnKhoa);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(tenlopLabel);
            this.Controls.Add(this.cbbMALOP);
            this.Name = "XfrmBangDiemTongKet";
            this.Text = "XfrmBangDiemTongKet";
            this.Activated += new System.EventHandler(this.XfrmBangDiemTongKet_Activated);
            this.Load += new System.EventHandler(this.XfrmBangDiemTongKet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS_QLDSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_dslopBindingSource)).EndInit();
            this.pnKhoa.ResumeLayout(false);
            this.pnKhoa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DSPMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DSPM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DS_QLDSV dS_QLDSV;
        private System.Windows.Forms.BindingSource v_dslopBindingSource;
        private DS_QLDSVTableAdapters.v_dslopTableAdapter v_dslopTableAdapter;
        private DS_QLDSVTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cbbMALOP;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Panel pnKhoa;
        private DS_DSPM dS_DSPM;
        private System.Windows.Forms.BindingSource v_DSPMBindingSource;
        private DS_DSPMTableAdapters.V_DSPMTableAdapter v_DSPMTableAdapter;
        private DS_DSPMTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.ComboBox cbbKhoa;
    }
}