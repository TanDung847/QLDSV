namespace QLDSV.Forms
{
    partial class XfrmDSSV
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
            System.Windows.Forms.Label tenlopLabel1;
            System.Windows.Forms.Label tENKHLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.v_DSPMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_DSPM = new QLDSV.DS_DSPM();
            this.v_DSPMTableAdapter = new QLDSV.DS_DSPMTableAdapters.V_DSPMTableAdapter();
            this.tableAdapterManager = new QLDSV.DS_DSPMTableAdapters.TableAdapterManager();
            this.dS_QLDSV = new QLDSV.DS_QLDSV();
            this.v_dslopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_dslopTableAdapter = new QLDSV.DS_QLDSVTableAdapters.v_dslopTableAdapter();
            this.tableAdapterManager1 = new QLDSV.DS_QLDSVTableAdapters.TableAdapterManager();
            this.cbbMALOP = new System.Windows.Forms.ComboBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.v_dskhoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_dskhoaTableAdapter = new QLDSV.DS_QLDSVTableAdapters.v_dskhoaTableAdapter();
            this.cbbMAKHOA = new System.Windows.Forms.ComboBox();
            tenlopLabel1 = new System.Windows.Forms.Label();
            tENKHLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DSPMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DSPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_QLDSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_dslopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_dskhoaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tenlopLabel1
            // 
            tenlopLabel1.AutoSize = true;
            tenlopLabel1.Location = new System.Drawing.Point(147, 100);
            tenlopLabel1.Name = "tenlopLabel1";
            tenlopLabel1.Size = new System.Drawing.Size(41, 13);
            tenlopLabel1.TabIndex = 2;
            tenlopLabel1.Text = "tenlop:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(tENKHLabel);
            this.panel1.Controls.Add(this.cbbMAKHOA);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 77);
            this.panel1.TabIndex = 0;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = QLDSV.DS_DSPMTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.DIEMTableAdapter = null;
            this.tableAdapterManager1.GIANGVIENTableAdapter = null;
            this.tableAdapterManager1.KHOATableAdapter = null;
            this.tableAdapterManager1.LOPTableAdapter = null;
            this.tableAdapterManager1.MONHOCTableAdapter = null;
            this.tableAdapterManager1.SINHVIENTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = QLDSV.DS_QLDSVTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cbbMALOP
            // 
            this.cbbMALOP.DataSource = this.v_dslopBindingSource;
            this.cbbMALOP.DisplayMember = "tenlop";
            this.cbbMALOP.FormattingEnabled = true;
            this.cbbMALOP.Location = new System.Drawing.Point(194, 97);
            this.cbbMALOP.Name = "cbbMALOP";
            this.cbbMALOP.Size = new System.Drawing.Size(121, 21);
            this.cbbMALOP.TabIndex = 3;
            this.cbbMALOP.ValueMember = "malop";
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(126, 157);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(131, 23);
            this.btnIn.TabIndex = 4;
            this.btnIn.Text = "In Danh Sách";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // v_dskhoaBindingSource
            // 
            this.v_dskhoaBindingSource.DataMember = "v_dskhoa";
            this.v_dskhoaBindingSource.DataSource = this.dS_QLDSV;
            // 
            // v_dskhoaTableAdapter
            // 
            this.v_dskhoaTableAdapter.ClearBeforeFill = true;
            // 
            // tENKHLabel
            // 
            tENKHLabel.AutoSize = true;
            tENKHLabel.Location = new System.Drawing.Point(209, 39);
            tENKHLabel.Name = "tENKHLabel";
            tENKHLabel.Size = new System.Drawing.Size(43, 13);
            tENKHLabel.TabIndex = 0;
            tENKHLabel.Text = "TENKH:";
            // 
            // cbbMAKHOA
            // 
            this.cbbMAKHOA.DataSource = this.v_dskhoaBindingSource;
            this.cbbMAKHOA.DisplayMember = "TENKH";
            this.cbbMAKHOA.FormattingEnabled = true;
            this.cbbMAKHOA.Location = new System.Drawing.Point(258, 36);
            this.cbbMAKHOA.Name = "cbbMAKHOA";
            this.cbbMAKHOA.Size = new System.Drawing.Size(121, 21);
            this.cbbMAKHOA.TabIndex = 1;
            this.cbbMAKHOA.ValueMember = "MAKH";
            // 
            // XfrmDSSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(tenlopLabel1);
            this.Controls.Add(this.cbbMALOP);
            this.Controls.Add(this.panel1);
            this.Name = "XfrmDSSV";
            this.Text = "XfrmDSSV";
            this.Load += new System.EventHandler(this.XfrmDSSV_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DSPMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DSPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_QLDSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_dslopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_dskhoaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DS_DSPM dS_DSPM;
        private System.Windows.Forms.BindingSource v_DSPMBindingSource;
        private DS_DSPMTableAdapters.V_DSPMTableAdapter v_DSPMTableAdapter;
        private DS_DSPMTableAdapters.TableAdapterManager tableAdapterManager;
        private DS_QLDSV dS_QLDSV;
        private System.Windows.Forms.BindingSource v_dslopBindingSource;
        private DS_QLDSVTableAdapters.v_dslopTableAdapter v_dslopTableAdapter;
        private DS_QLDSVTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.ComboBox cbbMALOP;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.BindingSource v_dskhoaBindingSource;
        private DS_QLDSVTableAdapters.v_dskhoaTableAdapter v_dskhoaTableAdapter;
        private System.Windows.Forms.ComboBox cbbMAKHOA;
    }
}