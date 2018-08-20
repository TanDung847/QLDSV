namespace QLDSV.Forms
{
    partial class XfrmPhieuDiemThi
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
            this.dS_QLDSV = new QLDSV.DS_QLDSV();
            this.bdsDSLOP = new System.Windows.Forms.BindingSource(this.components);
            this.v_dslopTableAdapter = new QLDSV.DS_QLDSVTableAdapters.v_dslopTableAdapter();
            this.tableAdapterManager = new QLDSV.DS_QLDSVTableAdapters.TableAdapterManager();
            this.bdsDSMH = new System.Windows.Forms.BindingSource(this.components);
            this.v_dsmhTableAdapter = new QLDSV.DS_QLDSVTableAdapters.v_dsmhTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numberLan = new System.Windows.Forms.NumericUpDown();
            this.btnIn = new System.Windows.Forms.Button();
            this.cmbMonHoc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbLop = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dS_DSPM = new QLDSV.DS_DSPM();
            this.v_DSPMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_DSPMTableAdapter = new QLDSV.DS_DSPMTableAdapters.V_DSPMTableAdapter();
            this.tableAdapterManager1 = new QLDSV.DS_DSPMTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dS_QLDSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSLOP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSMH)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberLan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DSPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DSPMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dS_QLDSV
            // 
            this.dS_QLDSV.DataSetName = "DS_QLDSV";
            this.dS_QLDSV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsDSLOP
            // 
            this.bdsDSLOP.DataMember = "v_dslop";
            this.bdsDSLOP.DataSource = this.dS_QLDSV;
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
            // bdsDSMH
            // 
            this.bdsDSMH.DataMember = "v_dsmh";
            this.bdsDSMH.DataSource = this.dS_QLDSV;
            // 
            // v_dsmhTableAdapter
            // 
            this.v_dsmhTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbKhoa);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(753, 92);
            this.panel1.TabIndex = 2;
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.DataSource = this.v_DSPMBindingSource;
            this.cmbKhoa.DisplayMember = "TENCN";
            this.cmbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(204, 29);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(253, 21);
            this.cmbKhoa.TabIndex = 1;
            this.cmbKhoa.ValueMember = "TENSERVER";
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "KHOA";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numberLan);
            this.groupBox1.Controls.Add(this.btnIn);
            this.groupBox1.Controls.Add(this.cmbMonHoc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbLop);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(753, 287);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "LẦN THI";
            // 
            // numberLan
            // 
            this.numberLan.Location = new System.Drawing.Point(204, 159);
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
            this.numberLan.TabIndex = 9;
            this.numberLan.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(382, 157);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(75, 23);
            this.btnIn.TabIndex = 8;
            this.btnIn.Text = "In Bảng Điểm";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // cmbMonHoc
            // 
            this.cmbMonHoc.DataSource = this.bdsDSMH;
            this.cmbMonHoc.DisplayMember = "TENMH";
            this.cmbMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonHoc.FormattingEnabled = true;
            this.cmbMonHoc.Location = new System.Drawing.Point(204, 93);
            this.cmbMonHoc.Name = "cmbMonHoc";
            this.cmbMonHoc.Size = new System.Drawing.Size(253, 21);
            this.cmbMonHoc.TabIndex = 4;
            this.cmbMonHoc.ValueMember = "MAMH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "MÔN HỌC";
            // 
            // cmbLop
            // 
            this.cmbLop.DataSource = this.bdsDSLOP;
            this.cmbLop.DisplayMember = "tenlop";
            this.cmbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLop.FormattingEnabled = true;
            this.cmbLop.Location = new System.Drawing.Point(204, 27);
            this.cmbLop.Name = "cmbLop";
            this.cmbLop.Size = new System.Drawing.Size(253, 21);
            this.cmbLop.TabIndex = 2;
            this.cmbLop.ValueMember = "malop";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "LỚP";
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
            // XfrmPhieuDiemThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 379);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "XfrmPhieuDiemThi";
            this.Text = "XfrmPhieuDiemThi";
            this.Activated += new System.EventHandler(this.XfrmPhieuDiemThi_Activated);
            this.Load += new System.EventHandler(this.XfrmPhieuDiemThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS_QLDSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSLOP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSMH)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberLan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DSPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DSPMBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DS_QLDSV dS_QLDSV;
        private System.Windows.Forms.BindingSource bdsDSLOP;
        private DS_QLDSVTableAdapters.v_dslopTableAdapter v_dslopTableAdapter;
        private DS_QLDSVTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource bdsDSMH;
        private DS_QLDSVTableAdapters.v_dsmhTableAdapter v_dsmhTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numberLan;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.ComboBox cmbMonHoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbLop;
        private System.Windows.Forms.Label label2;
        private DS_DSPM dS_DSPM;
        private System.Windows.Forms.BindingSource v_DSPMBindingSource;
        private DS_DSPMTableAdapters.V_DSPMTableAdapter v_DSPMTableAdapter;
        private DS_DSPMTableAdapters.TableAdapterManager tableAdapterManager1;
    }
}