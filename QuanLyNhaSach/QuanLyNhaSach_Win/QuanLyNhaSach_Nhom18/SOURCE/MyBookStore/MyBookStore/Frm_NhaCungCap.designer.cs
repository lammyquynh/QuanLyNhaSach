namespace MyBookStore
{
    partial class Frm_NhaCungCap
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
            this.btn_luuncc = new DevExpress.XtraEditors.SimpleButton();
            this.btn_huyncc = new DevExpress.XtraEditors.SimpleButton();
            this.btn_suancc = new DevExpress.XtraEditors.SimpleButton();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMANCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENNCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI_NCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSDT_NCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grid_nhacungcap = new DevExpress.XtraGrid.GridControl();
            this.nHACUNGCAPBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qL_NHASACH = new MyBookStore.QL_NHASACH();
            this.nHACUNGCAPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_xoancc = new DevExpress.XtraEditors.SimpleButton();
            this.btn_themncc = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_diachi = new DevExpress.XtraEditors.TextEdit();
            this.txt_tenncc = new DevExpress.XtraEditors.TextEdit();
            this.txt_sdt = new DevExpress.XtraEditors.TextEdit();
            this.txt_mancc = new DevExpress.XtraEditors.TextEdit();
            this.gb_quanlynhacungcap = new DevExpress.XtraEditors.GroupControl();
            this.qLNHASACHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nHACUNGCAPTableAdapter = new MyBookStore.QL_NHASACHTableAdapters.NHACUNGCAPTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_nhacungcap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHACUNGCAPBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NHASACH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHACUNGCAPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_diachi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tenncc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sdt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mancc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gb_quanlynhacungcap)).BeginInit();
            this.gb_quanlynhacungcap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLNHASACHBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_luuncc
            // 
            this.btn_luuncc.Location = new System.Drawing.Point(426, 135);
            this.btn_luuncc.Name = "btn_luuncc";
            this.btn_luuncc.Size = new System.Drawing.Size(75, 23);
            this.btn_luuncc.TabIndex = 28;
            this.btn_luuncc.Text = "Lưu";
            // 
            // btn_huyncc
            // 
            this.btn_huyncc.Location = new System.Drawing.Point(555, 135);
            this.btn_huyncc.Name = "btn_huyncc";
            this.btn_huyncc.Size = new System.Drawing.Size(75, 23);
            this.btn_huyncc.TabIndex = 27;
            this.btn_huyncc.Text = "Hủy";
            // 
            // btn_suancc
            // 
            this.btn_suancc.Location = new System.Drawing.Point(297, 135);
            this.btn_suancc.Name = "btn_suancc";
            this.btn_suancc.Size = new System.Drawing.Size(75, 23);
            this.btn_suancc.TabIndex = 26;
            this.btn_suancc.Text = "Sửa";
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMANCC,
            this.colTENNCC,
            this.colDIACHI_NCC,
            this.colSDT_NCC});
            this.gridView1.GridControl = this.grid_nhacungcap;
            this.gridView1.Name = "gridView1";
            // 
            // colMANCC
            // 
            this.colMANCC.FieldName = "MANCC";
            this.colMANCC.Name = "colMANCC";
            this.colMANCC.Visible = true;
            this.colMANCC.VisibleIndex = 0;
            // 
            // colTENNCC
            // 
            this.colTENNCC.FieldName = "TENNCC";
            this.colTENNCC.Name = "colTENNCC";
            this.colTENNCC.Visible = true;
            this.colTENNCC.VisibleIndex = 1;
            // 
            // colDIACHI_NCC
            // 
            this.colDIACHI_NCC.FieldName = "DIACHI_NCC";
            this.colDIACHI_NCC.Name = "colDIACHI_NCC";
            this.colDIACHI_NCC.Visible = true;
            this.colDIACHI_NCC.VisibleIndex = 2;
            // 
            // colSDT_NCC
            // 
            this.colSDT_NCC.FieldName = "SDT_NCC";
            this.colSDT_NCC.Name = "colSDT_NCC";
            this.colSDT_NCC.Visible = true;
            this.colSDT_NCC.VisibleIndex = 3;
            // 
            // grid_nhacungcap
            // 
            this.grid_nhacungcap.DataSource = this.nHACUNGCAPBindingSource1;
            this.grid_nhacungcap.Location = new System.Drawing.Point(12, 198);
            this.grid_nhacungcap.MainView = this.gridView1;
            this.grid_nhacungcap.Name = "grid_nhacungcap";
            this.grid_nhacungcap.Size = new System.Drawing.Size(723, 200);
            this.grid_nhacungcap.TabIndex = 2;
            this.grid_nhacungcap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // nHACUNGCAPBindingSource1
            // 
            this.nHACUNGCAPBindingSource1.DataMember = "NHACUNGCAP";
            this.nHACUNGCAPBindingSource1.DataSource = this.qL_NHASACH;
            // 
            // qL_NHASACH
            // 
            this.qL_NHASACH.DataSetName = "QL_NHASACH";
            this.qL_NHASACH.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nHACUNGCAPBindingSource
            // 
            this.nHACUNGCAPBindingSource.DataMember = "NHACUNGCAP";
            // 
            // btn_xoancc
            // 
            this.btn_xoancc.Location = new System.Drawing.Point(168, 135);
            this.btn_xoancc.Name = "btn_xoancc";
            this.btn_xoancc.Size = new System.Drawing.Size(75, 23);
            this.btn_xoancc.TabIndex = 25;
            this.btn_xoancc.Text = "Xóa";
            this.btn_xoancc.Click += new System.EventHandler(this.btn_xoancc_Click);
            // 
            // btn_themncc
            // 
            this.btn_themncc.Location = new System.Drawing.Point(39, 135);
            this.btn_themncc.Name = "btn_themncc";
            this.btn_themncc.Size = new System.Drawing.Size(75, 23);
            this.btn_themncc.TabIndex = 24;
            this.btn_themncc.Text = "Thêm";
            this.btn_themncc.Click += new System.EventHandler(this.btn_themncc_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(362, 48);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(34, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Địa Chỉ";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(362, 101);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(66, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Số Điện Thoại";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(28, 101);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(90, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Tên Nhà Cung Cấp";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(28, 48);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(86, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Mã Nhà Cung Cấp";
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(436, 45);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(194, 20);
            this.txt_diachi.TabIndex = 3;
            // 
            // txt_tenncc
            // 
            this.txt_tenncc.Location = new System.Drawing.Point(138, 98);
            this.txt_tenncc.Name = "txt_tenncc";
            this.txt_tenncc.Size = new System.Drawing.Size(194, 20);
            this.txt_tenncc.TabIndex = 2;
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(436, 98);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(194, 20);
            this.txt_sdt.TabIndex = 1;
            // 
            // txt_mancc
            // 
            this.txt_mancc.Location = new System.Drawing.Point(138, 45);
            this.txt_mancc.Name = "txt_mancc";
            this.txt_mancc.Size = new System.Drawing.Size(194, 20);
            this.txt_mancc.TabIndex = 0;
            // 
            // gb_quanlynhacungcap
            // 
            this.gb_quanlynhacungcap.Controls.Add(this.btn_luuncc);
            this.gb_quanlynhacungcap.Controls.Add(this.btn_huyncc);
            this.gb_quanlynhacungcap.Controls.Add(this.btn_suancc);
            this.gb_quanlynhacungcap.Controls.Add(this.btn_xoancc);
            this.gb_quanlynhacungcap.Controls.Add(this.btn_themncc);
            this.gb_quanlynhacungcap.Controls.Add(this.labelControl4);
            this.gb_quanlynhacungcap.Controls.Add(this.labelControl3);
            this.gb_quanlynhacungcap.Controls.Add(this.labelControl2);
            this.gb_quanlynhacungcap.Controls.Add(this.labelControl1);
            this.gb_quanlynhacungcap.Controls.Add(this.txt_diachi);
            this.gb_quanlynhacungcap.Controls.Add(this.txt_tenncc);
            this.gb_quanlynhacungcap.Controls.Add(this.txt_sdt);
            this.gb_quanlynhacungcap.Controls.Add(this.txt_mancc);
            this.gb_quanlynhacungcap.Location = new System.Drawing.Point(12, 12);
            this.gb_quanlynhacungcap.Name = "gb_quanlynhacungcap";
            this.gb_quanlynhacungcap.Size = new System.Drawing.Size(723, 180);
            this.gb_quanlynhacungcap.TabIndex = 3;
            this.gb_quanlynhacungcap.Text = "Quản Lý Nhà Cung Cấp";
            // 
            // qLNHASACHBindingSource
            // 
            this.qLNHASACHBindingSource.DataSource = this.qL_NHASACH;
            this.qLNHASACHBindingSource.Position = 0;
            // 
            // nHACUNGCAPTableAdapter
            // 
            this.nHACUNGCAPTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_NhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 412);
            this.Controls.Add(this.grid_nhacungcap);
            this.Controls.Add(this.gb_quanlynhacungcap);
            this.Name = "Frm_NhaCungCap";
            this.Text = "Frm_NhaCungCap";
            this.Load += new System.EventHandler(this.Frm_NhaCungCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_nhacungcap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHACUNGCAPBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NHASACH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHACUNGCAPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_diachi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tenncc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sdt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mancc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gb_quanlynhacungcap)).EndInit();
            this.gb_quanlynhacungcap.ResumeLayout(false);
            this.gb_quanlynhacungcap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLNHASACHBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_luuncc;
        private DevExpress.XtraEditors.SimpleButton btn_huyncc;
        private DevExpress.XtraGrid.Columns.GridColumn colSDT_NCC;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI_NCC;
        private DevExpress.XtraGrid.Columns.GridColumn colTENNCC;
        private DevExpress.XtraEditors.SimpleButton btn_suancc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMANCC;
        private DevExpress.XtraGrid.GridControl grid_nhacungcap;
        private System.Windows.Forms.BindingSource nHACUNGCAPBindingSource;
        private DevExpress.XtraEditors.SimpleButton btn_xoancc;
        private DevExpress.XtraEditors.SimpleButton btn_themncc;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_diachi;
        private DevExpress.XtraEditors.TextEdit txt_tenncc;
        private DevExpress.XtraEditors.TextEdit txt_sdt;
        private DevExpress.XtraEditors.TextEdit txt_mancc;
        private DevExpress.XtraEditors.GroupControl gb_quanlynhacungcap;
        private System.Windows.Forms.BindingSource qLNHASACHBindingSource;
        private QL_NHASACH qL_NHASACH;
        private System.Windows.Forms.BindingSource nHACUNGCAPBindingSource1;
        private QL_NHASACHTableAdapters.NHACUNGCAPTableAdapter nHACUNGCAPTableAdapter;
    }
}