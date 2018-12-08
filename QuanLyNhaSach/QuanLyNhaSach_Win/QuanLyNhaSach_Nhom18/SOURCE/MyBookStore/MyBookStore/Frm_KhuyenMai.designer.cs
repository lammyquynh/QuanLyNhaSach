namespace MyBookStore
{
    partial class Frm_KhuyenMai
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
            this.colTILEGIAMGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_tilegiamgia = new DevExpress.XtraEditors.TextEdit();
            this.btn_luukm = new DevExpress.XtraEditors.SimpleButton();
            this.btn_huykm = new DevExpress.XtraEditors.SimpleButton();
            this.btn_suakm = new DevExpress.XtraEditors.SimpleButton();
            this.btn_xoakm = new DevExpress.XtraEditors.SimpleButton();
            this.btn_themkm = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.colMAKHUYENMAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTENKHUYENMAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grid_khuyenmai = new DevExpress.XtraGrid.GridControl();
            this.kHUYENMAIBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qL_NHASACH = new MyBookStore.QL_NHASACH();
            this.kHUYENMAIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_makhuyenmai = new DevExpress.XtraEditors.TextEdit();
            this.txt_tenkhuyenmai = new DevExpress.XtraEditors.TextEdit();
            this.gb_khuyenmai = new DevExpress.XtraEditors.GroupControl();
            this.kHUYENMAITableAdapter = new MyBookStore.QL_NHASACHTableAdapters.KHUYENMAITableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tilegiamgia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_khuyenmai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHUYENMAIBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NHASACH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHUYENMAIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_makhuyenmai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tenkhuyenmai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gb_khuyenmai)).BeginInit();
            this.gb_khuyenmai.SuspendLayout();
            this.SuspendLayout();
            // 
            // colTILEGIAMGIA
            // 
            this.colTILEGIAMGIA.FieldName = "TILEGIAMGIA";
            this.colTILEGIAMGIA.Name = "colTILEGIAMGIA";
            this.colTILEGIAMGIA.Visible = true;
            this.colTILEGIAMGIA.VisibleIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(366, 59);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(66, 13);
            this.labelControl3.TabIndex = 25;
            this.labelControl3.Text = "Tỉ Lệ Giảm Giá";
            // 
            // txt_tilegiamgia
            // 
            this.txt_tilegiamgia.Location = new System.Drawing.Point(458, 52);
            this.txt_tilegiamgia.Name = "txt_tilegiamgia";
            this.txt_tilegiamgia.Size = new System.Drawing.Size(193, 20);
            this.txt_tilegiamgia.TabIndex = 24;
            // 
            // btn_luukm
            // 
            this.btn_luukm.Location = new System.Drawing.Point(424, 151);
            this.btn_luukm.Name = "btn_luukm";
            this.btn_luukm.Size = new System.Drawing.Size(75, 23);
            this.btn_luukm.TabIndex = 23;
            this.btn_luukm.Text = "Lưu";
            this.btn_luukm.Click += new System.EventHandler(this.btn_luukm_Click);
            // 
            // btn_huykm
            // 
            this.btn_huykm.Location = new System.Drawing.Point(553, 151);
            this.btn_huykm.Name = "btn_huykm";
            this.btn_huykm.Size = new System.Drawing.Size(75, 23);
            this.btn_huykm.TabIndex = 22;
            this.btn_huykm.Text = "Hủy";
            this.btn_huykm.Click += new System.EventHandler(this.btn_huykm_Click);
            // 
            // btn_suakm
            // 
            this.btn_suakm.Location = new System.Drawing.Point(295, 151);
            this.btn_suakm.Name = "btn_suakm";
            this.btn_suakm.Size = new System.Drawing.Size(75, 23);
            this.btn_suakm.TabIndex = 21;
            this.btn_suakm.Text = "Sửa";
            this.btn_suakm.Click += new System.EventHandler(this.btn_suakm_Click);
            // 
            // btn_xoakm
            // 
            this.btn_xoakm.Location = new System.Drawing.Point(166, 151);
            this.btn_xoakm.Name = "btn_xoakm";
            this.btn_xoakm.Size = new System.Drawing.Size(75, 23);
            this.btn_xoakm.TabIndex = 20;
            this.btn_xoakm.Text = "Xóa";
            this.btn_xoakm.Click += new System.EventHandler(this.btn_xoakm_Click);
            // 
            // btn_themkm
            // 
            this.btn_themkm.Location = new System.Drawing.Point(37, 151);
            this.btn_themkm.Name = "btn_themkm";
            this.btn_themkm.Size = new System.Drawing.Size(75, 23);
            this.btn_themkm.TabIndex = 19;
            this.btn_themkm.Text = "Thêm";
            this.btn_themkm.Click += new System.EventHandler(this.btn_themkm_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(37, 59);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(72, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Mã Khuyến Mãi";
            // 
            // colMAKHUYENMAI
            // 
            this.colMAKHUYENMAI.FieldName = "MAKHUYENMAI";
            this.colMAKHUYENMAI.Name = "colMAKHUYENMAI";
            this.colMAKHUYENMAI.Visible = true;
            this.colMAKHUYENMAI.VisibleIndex = 0;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAKHUYENMAI,
            this.colTENKHUYENMAI,
            this.colTILEGIAMGIA});
            this.gridView1.GridControl = this.grid_khuyenmai;
            this.gridView1.Name = "gridView1";
            // 
            // colTENKHUYENMAI
            // 
            this.colTENKHUYENMAI.FieldName = "TENKHUYENMAI";
            this.colTENKHUYENMAI.Name = "colTENKHUYENMAI";
            this.colTENKHUYENMAI.Visible = true;
            this.colTENKHUYENMAI.VisibleIndex = 1;
            // 
            // grid_khuyenmai
            // 
            this.grid_khuyenmai.DataSource = this.kHUYENMAIBindingSource1;
            this.grid_khuyenmai.Location = new System.Drawing.Point(12, 221);
            this.grid_khuyenmai.MainView = this.gridView1;
            this.grid_khuyenmai.Name = "grid_khuyenmai";
            this.grid_khuyenmai.Size = new System.Drawing.Size(704, 200);
            this.grid_khuyenmai.TabIndex = 9;
            this.grid_khuyenmai.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // kHUYENMAIBindingSource1
            // 
            this.kHUYENMAIBindingSource1.DataMember = "KHUYENMAI";
            this.kHUYENMAIBindingSource1.DataSource = this.qL_NHASACH;
            // 
            // qL_NHASACH
            // 
            this.qL_NHASACH.DataSetName = "QL_NHASACH";
            this.qL_NHASACH.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kHUYENMAIBindingSource
            // 
            this.kHUYENMAIBindingSource.DataMember = "KHUYENMAI";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(37, 110);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(76, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Tên Khuyến Mãi";
            // 
            // txt_makhuyenmai
            // 
            this.txt_makhuyenmai.Location = new System.Drawing.Point(140, 52);
            this.txt_makhuyenmai.Name = "txt_makhuyenmai";
            this.txt_makhuyenmai.Size = new System.Drawing.Size(193, 20);
            this.txt_makhuyenmai.TabIndex = 1;
            // 
            // txt_tenkhuyenmai
            // 
            this.txt_tenkhuyenmai.Location = new System.Drawing.Point(140, 103);
            this.txt_tenkhuyenmai.Name = "txt_tenkhuyenmai";
            this.txt_tenkhuyenmai.Size = new System.Drawing.Size(193, 20);
            this.txt_tenkhuyenmai.TabIndex = 0;
            // 
            // gb_khuyenmai
            // 
            this.gb_khuyenmai.Controls.Add(this.labelControl3);
            this.gb_khuyenmai.Controls.Add(this.txt_tilegiamgia);
            this.gb_khuyenmai.Controls.Add(this.btn_luukm);
            this.gb_khuyenmai.Controls.Add(this.btn_huykm);
            this.gb_khuyenmai.Controls.Add(this.btn_suakm);
            this.gb_khuyenmai.Controls.Add(this.btn_xoakm);
            this.gb_khuyenmai.Controls.Add(this.btn_themkm);
            this.gb_khuyenmai.Controls.Add(this.labelControl2);
            this.gb_khuyenmai.Controls.Add(this.labelControl1);
            this.gb_khuyenmai.Controls.Add(this.txt_makhuyenmai);
            this.gb_khuyenmai.Controls.Add(this.txt_tenkhuyenmai);
            this.gb_khuyenmai.Location = new System.Drawing.Point(12, 12);
            this.gb_khuyenmai.Name = "gb_khuyenmai";
            this.gb_khuyenmai.Size = new System.Drawing.Size(704, 202);
            this.gb_khuyenmai.TabIndex = 8;
            this.gb_khuyenmai.Text = "Quản Lý Khuyến Mãi";
            // 
            // kHUYENMAITableAdapter
            // 
            this.kHUYENMAITableAdapter.ClearBeforeFill = true;
            // 
            // Frm_KhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 433);
            this.Controls.Add(this.grid_khuyenmai);
            this.Controls.Add(this.gb_khuyenmai);
            this.Name = "Frm_KhuyenMai";
            this.Text = "Frm_KhuyenMai";
            this.Load += new System.EventHandler(this.Frm_KhuyenMai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_tilegiamgia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_khuyenmai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHUYENMAIBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NHASACH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHUYENMAIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_makhuyenmai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tenkhuyenmai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gb_khuyenmai)).EndInit();
            this.gb_khuyenmai.ResumeLayout(false);
            this.gb_khuyenmai.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn colTILEGIAMGIA;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_tilegiamgia;
        private DevExpress.XtraEditors.SimpleButton btn_luukm;
        private DevExpress.XtraEditors.SimpleButton btn_huykm;
        private DevExpress.XtraEditors.SimpleButton btn_suakm;
        private DevExpress.XtraEditors.SimpleButton btn_xoakm;
        private DevExpress.XtraEditors.SimpleButton btn_themkm;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHUYENMAI;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colTENKHUYENMAI;
        private DevExpress.XtraGrid.GridControl grid_khuyenmai;
        private System.Windows.Forms.BindingSource kHUYENMAIBindingSource;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_makhuyenmai;
        private DevExpress.XtraEditors.TextEdit txt_tenkhuyenmai;
        private DevExpress.XtraEditors.GroupControl gb_khuyenmai;
        private QL_NHASACH qL_NHASACH;
        private System.Windows.Forms.BindingSource kHUYENMAIBindingSource1;
        private QL_NHASACHTableAdapters.KHUYENMAITableAdapter kHUYENMAITableAdapter;
    }
}