namespace MyBookStore
{
    partial class Frm_NhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_NhanVien));
            this.btn_luunv = new DevExpress.XtraEditors.SimpleButton();
            this.btn_huynv = new DevExpress.XtraEditors.SimpleButton();
            this.btn_suanv = new DevExpress.XtraEditors.SimpleButton();
            this.btn_xoanv = new DevExpress.XtraEditors.SimpleButton();
            this.btn_themnv = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_diachi = new DevExpress.XtraEditors.TextEdit();
            this.txt_sodt = new DevExpress.XtraEditors.TextEdit();
            this.txt_tennhanvien = new DevExpress.XtraEditors.TextEdit();
            this.txt_matkhau = new DevExpress.XtraEditors.TextEdit();
            this.txt_manhanvien = new DevExpress.XtraEditors.TextEdit();
            this.gb_quanlynhanvien = new DevExpress.XtraEditors.GroupControl();
            this.btn_themmoi = new DevExpress.XtraEditors.SimpleButton();
            this.comboCV = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.gridNhanVien = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMATKHAU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI_NV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSDT_NV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.nHANVIENBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qL_NHASACH1 = new MyBookStore.QL_NHASACH();
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_NHASACH = new MyBookStore.QL_NHASACH();
            this.nHANVIENTableAdapter = new MyBookStore.QL_NHASACHTableAdapters.NHANVIENTableAdapter();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txt_diachi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sodt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tennhanvien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_matkhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_manhanvien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gb_quanlynhanvien)).BeginInit();
            this.gb_quanlynhanvien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboCV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NHASACH1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NHASACH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_luunv
            // 
            this.btn_luunv.Enabled = false;
            this.btn_luunv.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_luunv.ImageOptions.Image")));
            this.btn_luunv.Location = new System.Drawing.Point(490, 155);
            this.btn_luunv.Name = "btn_luunv";
            this.btn_luunv.Size = new System.Drawing.Size(75, 39);
            this.btn_luunv.TabIndex = 48;
            this.btn_luunv.Text = "Lưu";
            this.btn_luunv.Click += new System.EventHandler(this.btn_luunv_Click);
            // 
            // btn_huynv
            // 
            this.btn_huynv.Enabled = false;
            this.btn_huynv.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_huynv.ImageOptions.Image")));
            this.btn_huynv.Location = new System.Drawing.Point(590, 155);
            this.btn_huynv.Name = "btn_huynv";
            this.btn_huynv.Size = new System.Drawing.Size(75, 39);
            this.btn_huynv.TabIndex = 47;
            this.btn_huynv.Text = "Hủy";
            this.btn_huynv.Click += new System.EventHandler(this.btn_huynv_Click);
            // 
            // btn_suanv
            // 
            this.btn_suanv.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_suanv.ImageOptions.Image")));
            this.btn_suanv.Location = new System.Drawing.Point(390, 155);
            this.btn_suanv.Name = "btn_suanv";
            this.btn_suanv.Size = new System.Drawing.Size(75, 39);
            this.btn_suanv.TabIndex = 46;
            this.btn_suanv.Text = "Sửa";
            this.btn_suanv.Click += new System.EventHandler(this.btn_suanv_Click);
            // 
            // btn_xoanv
            // 
            this.btn_xoanv.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoanv.ImageOptions.Image")));
            this.btn_xoanv.Location = new System.Drawing.Point(290, 155);
            this.btn_xoanv.Name = "btn_xoanv";
            this.btn_xoanv.Size = new System.Drawing.Size(75, 39);
            this.btn_xoanv.TabIndex = 45;
            this.btn_xoanv.Text = "Xóa";
            this.btn_xoanv.Click += new System.EventHandler(this.btn_xoanv_Click);
            // 
            // btn_themnv
            // 
            this.btn_themnv.Enabled = false;
            this.btn_themnv.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_themnv.ImageOptions.Image")));
            this.btn_themnv.Location = new System.Drawing.Point(190, 155);
            this.btn_themnv.Name = "btn_themnv";
            this.btn_themnv.Size = new System.Drawing.Size(75, 39);
            this.btn_themnv.TabIndex = 44;
            this.btn_themnv.Text = "Thêm";
            this.btn_themnv.Click += new System.EventHandler(this.btn_themnv_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(399, 81);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(66, 13);
            this.labelControl5.TabIndex = 43;
            this.labelControl5.Text = "Số Điện Thoại";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(399, 45);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(34, 13);
            this.labelControl4.TabIndex = 42;
            this.labelControl4.Text = "Địa Chỉ";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(90, 117);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(45, 13);
            this.labelControl3.TabIndex = 41;
            this.labelControl3.Text = "Mật Khẩu";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(90, 81);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(69, 13);
            this.labelControl2.TabIndex = 40;
            this.labelControl2.Text = "Tên Nhân Viên";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(90, 45);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 13);
            this.labelControl1.TabIndex = 39;
            this.labelControl1.Text = "Mã Nhân Viên";
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(486, 42);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(179, 20);
            this.txt_diachi.TabIndex = 38;
            // 
            // txt_sodt
            // 
            this.txt_sodt.Location = new System.Drawing.Point(486, 78);
            this.txt_sodt.Name = "txt_sodt";
            this.txt_sodt.Size = new System.Drawing.Size(179, 20);
            this.txt_sodt.TabIndex = 37;
            // 
            // txt_tennhanvien
            // 
            this.txt_tennhanvien.Location = new System.Drawing.Point(199, 78);
            this.txt_tennhanvien.Name = "txt_tennhanvien";
            this.txt_tennhanvien.Size = new System.Drawing.Size(179, 20);
            this.txt_tennhanvien.TabIndex = 36;
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.EditValue = "";
            this.txt_matkhau.Location = new System.Drawing.Point(199, 114);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.Size = new System.Drawing.Size(179, 20);
            this.txt_matkhau.TabIndex = 35;
            // 
            // txt_manhanvien
            // 
            this.txt_manhanvien.Location = new System.Drawing.Point(199, 42);
            this.txt_manhanvien.Name = "txt_manhanvien";
            this.txt_manhanvien.Size = new System.Drawing.Size(179, 20);
            this.txt_manhanvien.TabIndex = 34;
            // 
            // gb_quanlynhanvien
            // 
            this.gb_quanlynhanvien.Controls.Add(this.btn_themmoi);
            this.gb_quanlynhanvien.Controls.Add(this.comboCV);
            this.gb_quanlynhanvien.Controls.Add(this.labelControl6);
            this.gb_quanlynhanvien.Controls.Add(this.btn_luunv);
            this.gb_quanlynhanvien.Controls.Add(this.btn_huynv);
            this.gb_quanlynhanvien.Controls.Add(this.btn_suanv);
            this.gb_quanlynhanvien.Controls.Add(this.btn_xoanv);
            this.gb_quanlynhanvien.Controls.Add(this.btn_themnv);
            this.gb_quanlynhanvien.Controls.Add(this.labelControl5);
            this.gb_quanlynhanvien.Controls.Add(this.labelControl4);
            this.gb_quanlynhanvien.Controls.Add(this.labelControl3);
            this.gb_quanlynhanvien.Controls.Add(this.labelControl2);
            this.gb_quanlynhanvien.Controls.Add(this.labelControl1);
            this.gb_quanlynhanvien.Controls.Add(this.txt_diachi);
            this.gb_quanlynhanvien.Controls.Add(this.txt_sodt);
            this.gb_quanlynhanvien.Controls.Add(this.txt_tennhanvien);
            this.gb_quanlynhanvien.Controls.Add(this.txt_matkhau);
            this.gb_quanlynhanvien.Controls.Add(this.txt_manhanvien);
            this.gb_quanlynhanvien.Location = new System.Drawing.Point(12, 12);
            this.gb_quanlynhanvien.Name = "gb_quanlynhanvien";
            this.gb_quanlynhanvien.Size = new System.Drawing.Size(780, 214);
            this.gb_quanlynhanvien.TabIndex = 2;
            this.gb_quanlynhanvien.Text = "Quản Lý Nhân Viên";
            this.gb_quanlynhanvien.Paint += new System.Windows.Forms.PaintEventHandler(this.gb_quanlynhanvien_Paint);
            // 
            // btn_themmoi
            // 
            this.btn_themmoi.Location = new System.Drawing.Point(90, 155);
            this.btn_themmoi.Name = "btn_themmoi";
            this.btn_themmoi.Size = new System.Drawing.Size(75, 39);
            this.btn_themmoi.TabIndex = 51;
            this.btn_themmoi.Text = "Thêm Mới";
            this.btn_themmoi.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // comboCV
            // 
            this.comboCV.Location = new System.Drawing.Point(486, 114);
            this.comboCV.Name = "comboCV";
            this.comboCV.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboCV.Properties.Items.AddRange(new object[] {
            "QUẢN LÝ ",
            "THỦ KHO",
            "NHÂN VIÊN BÁN HÀNG"});
            this.comboCV.Size = new System.Drawing.Size(179, 20);
            this.comboCV.TabIndex = 50;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(399, 117);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(44, 13);
            this.labelControl6.TabIndex = 49;
            this.labelControl6.Text = "Chức Vụ:";
            // 
            // gridNhanVien
            // 
            this.gridNhanVien.Location = new System.Drawing.Point(12, 232);
            this.gridNhanVien.MainView = this.gridView1;
            this.gridNhanVien.Name = "gridNhanVien";
            this.gridNhanVien.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1,
            this.repositoryItemTextEdit1});
            this.gridNhanVien.Size = new System.Drawing.Size(780, 213);
            this.gridNhanVien.TabIndex = 3;
            this.gridNhanVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridNhanVien.CursorChanged += new System.EventHandler(this.gridControl1_CursorChanged);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMANV,
            this.colMATKHAU,
            this.colTENNV,
            this.colDIACHI_NV,
            this.colSDT_NV});
            this.gridView1.GridControl = this.gridNhanVien;
            this.gridView1.Name = "gridView1";
            // 
            // colMANV
            // 
            this.colMANV.Caption = "Mã Nhân Viên";
            this.colMANV.FieldName = "MANV";
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 0;
            // 
            // colMATKHAU
            // 
            this.colMATKHAU.Caption = "Mật Khẩu";
            this.colMATKHAU.FieldName = "MATKHAU";
            this.colMATKHAU.Name = "colMATKHAU";
            this.colMATKHAU.Visible = true;
            this.colMATKHAU.VisibleIndex = 1;
            // 
            // colTENNV
            // 
            this.colTENNV.FieldName = "TENNV";
            this.colTENNV.Name = "colTENNV";
            this.colTENNV.Visible = true;
            this.colTENNV.VisibleIndex = 2;
            // 
            // colDIACHI_NV
            // 
            this.colDIACHI_NV.FieldName = "DIACHI_NV";
            this.colDIACHI_NV.Name = "colDIACHI_NV";
            this.colDIACHI_NV.Visible = true;
            this.colDIACHI_NV.VisibleIndex = 3;
            // 
            // colSDT_NV
            // 
            this.colSDT_NV.FieldName = "SDT_NV";
            this.colSDT_NV.Name = "colSDT_NV";
            this.colSDT_NV.Visible = true;
            this.colSDT_NV.VisibleIndex = 4;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // nHANVIENBindingSource1
            // 
            this.nHANVIENBindingSource1.DataMember = "NHANVIEN";
            this.nHANVIENBindingSource1.DataSource = this.qL_NHASACH1;
            // 
            // qL_NHASACH1
            // 
            this.qL_NHASACH1.DataSetName = "QL_NHASACH";
            this.qL_NHASACH1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nHANVIENBindingSource
            // 
            this.nHANVIENBindingSource.DataMember = "NHANVIEN";
            this.nHANVIENBindingSource.DataSource = this.qL_NHASACH;
            // 
            // qL_NHASACH
            // 
            this.qL_NHASACH.DataSetName = "QL_NHASACH";
            this.qL_NHASACH.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 457);
            this.Controls.Add(this.gridNhanVien);
            this.Controls.Add(this.gb_quanlynhanvien);
            this.Name = "Frm_NhanVien";
            this.Text = "Frm_NhanVien";
            this.Load += new System.EventHandler(this.Frm_NhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_diachi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sodt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tennhanvien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_matkhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_manhanvien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gb_quanlynhanvien)).EndInit();
            this.gb_quanlynhanvien.ResumeLayout(false);
            this.gb_quanlynhanvien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboCV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NHASACH1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NHASACH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_luunv;
        private DevExpress.XtraEditors.SimpleButton btn_huynv;
        private DevExpress.XtraEditors.SimpleButton btn_suanv;
        private DevExpress.XtraEditors.SimpleButton btn_xoanv;
        private DevExpress.XtraEditors.SimpleButton btn_themnv;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_diachi;
        private DevExpress.XtraEditors.TextEdit txt_sodt;
        private DevExpress.XtraEditors.TextEdit txt_tennhanvien;
        private DevExpress.XtraEditors.TextEdit txt_matkhau;
        private DevExpress.XtraEditors.TextEdit txt_manhanvien;
        private DevExpress.XtraEditors.GroupControl gb_quanlynhanvien;
        private DevExpress.XtraGrid.GridControl gridNhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private QL_NHASACH qL_NHASACH;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private QL_NHASACHTableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colMATKHAU;
        private DevExpress.XtraGrid.Columns.GridColumn colTENNV;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI_NV;
        private DevExpress.XtraGrid.Columns.GridColumn colSDT_NV;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.ComboBoxEdit comboCV;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private QL_NHASACH qL_NHASACH1;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource1;
        private DevExpress.XtraEditors.SimpleButton btn_themmoi;
    }
}