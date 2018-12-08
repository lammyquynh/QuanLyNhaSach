namespace MyBookStore
{
    partial class Frm_KhachHang
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
            this.btn_luukh = new DevExpress.XtraEditors.SimpleButton();
            this.btn_huykh = new DevExpress.XtraEditors.SimpleButton();
            this.btn_suakh = new DevExpress.XtraEditors.SimpleButton();
            this.btn_xoakh = new DevExpress.XtraEditors.SimpleButton();
            this.btn_themkh = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_diachi = new DevExpress.XtraEditors.TextEdit();
            this.txt_sodt = new DevExpress.XtraEditors.TextEdit();
            this.txt_tenkhachhang = new DevExpress.XtraEditors.TextEdit();
            this.txt_makhachhang = new DevExpress.XtraEditors.TextEdit();
            this.colSDT_KH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI_KH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALOAI_KH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grid_khachhang = new DevExpress.XtraGrid.GridControl();
            this.gb_quanlykhachhang = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txt_ChietKhau = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.combo_maloaikhachhang = new DevExpress.XtraEditors.ComboBoxEdit();
            this.qL_NHASACH = new MyBookStore.QL_NHASACH();
            this.dMMANHINHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dM_MANHINHTableAdapter = new MyBookStore.QL_NHASACHTableAdapters.DM_MANHINHTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.txt_diachi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sodt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tenkhachhang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_makhachhang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_khachhang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gb_quanlykhachhang)).BeginInit();
            this.gb_quanlykhachhang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ChietKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combo_maloaikhachhang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NHASACH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMMANHINHBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_luukh
            // 
            this.btn_luukh.Enabled = false;
            this.btn_luukh.Location = new System.Drawing.Point(424, 148);
            this.btn_luukh.Name = "btn_luukh";
            this.btn_luukh.Size = new System.Drawing.Size(75, 37);
            this.btn_luukh.TabIndex = 33;
            this.btn_luukh.Text = "Lưu";
            this.btn_luukh.Click += new System.EventHandler(this.btn_luukh_Click);
            // 
            // btn_huykh
            // 
            this.btn_huykh.Enabled = false;
            this.btn_huykh.Location = new System.Drawing.Point(524, 148);
            this.btn_huykh.Name = "btn_huykh";
            this.btn_huykh.Size = new System.Drawing.Size(75, 37);
            this.btn_huykh.TabIndex = 32;
            this.btn_huykh.Text = "Hủy";
            this.btn_huykh.Click += new System.EventHandler(this.btn_huykh_Click);
            // 
            // btn_suakh
            // 
            this.btn_suakh.Location = new System.Drawing.Point(324, 148);
            this.btn_suakh.Name = "btn_suakh";
            this.btn_suakh.Size = new System.Drawing.Size(75, 37);
            this.btn_suakh.TabIndex = 31;
            this.btn_suakh.Text = "Sửa";
            this.btn_suakh.Click += new System.EventHandler(this.btn_suakh_Click);
            // 
            // btn_xoakh
            // 
            this.btn_xoakh.Location = new System.Drawing.Point(224, 148);
            this.btn_xoakh.Name = "btn_xoakh";
            this.btn_xoakh.Size = new System.Drawing.Size(75, 37);
            this.btn_xoakh.TabIndex = 30;
            this.btn_xoakh.Text = "Xóa";
            this.btn_xoakh.Click += new System.EventHandler(this.btn_xoakh_Click);
            // 
            // btn_themkh
            // 
            this.btn_themkh.Enabled = false;
            this.btn_themkh.Location = new System.Drawing.Point(124, 148);
            this.btn_themkh.Name = "btn_themkh";
            this.btn_themkh.Size = new System.Drawing.Size(75, 37);
            this.btn_themkh.TabIndex = 29;
            this.btn_themkh.Text = "Thêm";
            this.btn_themkh.Click += new System.EventHandler(this.btn_themkh_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(334, 71);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(66, 13);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Số Điện Thoại";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(334, 35);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(34, 13);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Địa Chỉ";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(25, 107);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(79, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Loại Khách Hàng";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(25, 71);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(78, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Tên Khách Hàng";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(25, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(74, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Mã Khách Hàng";
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(421, 32);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(179, 20);
            this.txt_diachi.TabIndex = 4;
            // 
            // txt_sodt
            // 
            this.txt_sodt.Location = new System.Drawing.Point(421, 68);
            this.txt_sodt.Name = "txt_sodt";
            this.txt_sodt.Size = new System.Drawing.Size(179, 20);
            this.txt_sodt.TabIndex = 3;
            // 
            // txt_tenkhachhang
            // 
            this.txt_tenkhachhang.Location = new System.Drawing.Point(122, 68);
            this.txt_tenkhachhang.Name = "txt_tenkhachhang";
            this.txt_tenkhachhang.Size = new System.Drawing.Size(179, 20);
            this.txt_tenkhachhang.TabIndex = 2;
            // 
            // txt_makhachhang
            // 
            this.txt_makhachhang.Location = new System.Drawing.Point(122, 32);
            this.txt_makhachhang.Name = "txt_makhachhang";
            this.txt_makhachhang.Size = new System.Drawing.Size(179, 20);
            this.txt_makhachhang.TabIndex = 0;
            // 
            // colSDT_KH
            // 
            this.colSDT_KH.FieldName = "SDT_KH";
            this.colSDT_KH.Name = "colSDT_KH";
            this.colSDT_KH.Visible = true;
            this.colSDT_KH.VisibleIndex = 4;
            this.colSDT_KH.Width = 101;
            // 
            // colDIACHI_KH
            // 
            this.colDIACHI_KH.FieldName = "DIACHI_KH";
            this.colDIACHI_KH.Name = "colDIACHI_KH";
            this.colDIACHI_KH.Visible = true;
            this.colDIACHI_KH.VisibleIndex = 3;
            this.colDIACHI_KH.Width = 186;
            // 
            // colTENKH
            // 
            this.colTENKH.FieldName = "TENKH";
            this.colTENKH.Name = "colTENKH";
            this.colTENKH.Visible = true;
            this.colTENKH.VisibleIndex = 1;
            this.colTENKH.Width = 92;
            // 
            // colMALOAI_KH
            // 
            this.colMALOAI_KH.FieldName = "TENLOAI_KH";
            this.colMALOAI_KH.Name = "colMALOAI_KH";
            this.colMALOAI_KH.Visible = true;
            this.colMALOAI_KH.VisibleIndex = 2;
            this.colMALOAI_KH.Width = 124;
            // 
            // colMAKH
            // 
            this.colMAKH.FieldName = "MAKH";
            this.colMAKH.Name = "colMAKH";
            this.colMAKH.Visible = true;
            this.colMAKH.VisibleIndex = 0;
            this.colMAKH.Width = 50;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAKH,
            this.colMALOAI_KH,
            this.colTENKH,
            this.colDIACHI_KH,
            this.colSDT_KH,
            this.gridColumn1});
            this.gridView1.GridControl = this.grid_khachhang;
            this.gridView1.Name = "gridView1";
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "CHIETKHAU_KH";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 5;
            this.gridColumn1.Width = 66;
            // 
            // grid_khachhang
            // 
            this.grid_khachhang.Location = new System.Drawing.Point(12, 236);
            this.grid_khachhang.MainView = this.gridView1;
            this.grid_khachhang.Name = "grid_khachhang";
            this.grid_khachhang.Size = new System.Drawing.Size(637, 183);
            this.grid_khachhang.TabIndex = 2;
            this.grid_khachhang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gb_quanlykhachhang
            // 
            this.gb_quanlykhachhang.Controls.Add(this.simpleButton1);
            this.gb_quanlykhachhang.Controls.Add(this.txt_ChietKhau);
            this.gb_quanlykhachhang.Controls.Add(this.labelControl7);
            this.gb_quanlykhachhang.Controls.Add(this.combo_maloaikhachhang);
            this.gb_quanlykhachhang.Controls.Add(this.btn_luukh);
            this.gb_quanlykhachhang.Controls.Add(this.btn_huykh);
            this.gb_quanlykhachhang.Controls.Add(this.btn_suakh);
            this.gb_quanlykhachhang.Controls.Add(this.btn_xoakh);
            this.gb_quanlykhachhang.Controls.Add(this.btn_themkh);
            this.gb_quanlykhachhang.Controls.Add(this.labelControl5);
            this.gb_quanlykhachhang.Controls.Add(this.labelControl4);
            this.gb_quanlykhachhang.Controls.Add(this.labelControl3);
            this.gb_quanlykhachhang.Controls.Add(this.labelControl2);
            this.gb_quanlykhachhang.Controls.Add(this.labelControl1);
            this.gb_quanlykhachhang.Controls.Add(this.txt_diachi);
            this.gb_quanlykhachhang.Controls.Add(this.txt_sodt);
            this.gb_quanlykhachhang.Controls.Add(this.txt_tenkhachhang);
            this.gb_quanlykhachhang.Controls.Add(this.txt_makhachhang);
            this.gb_quanlykhachhang.Location = new System.Drawing.Point(12, 12);
            this.gb_quanlykhachhang.Name = "gb_quanlykhachhang";
            this.gb_quanlykhachhang.Size = new System.Drawing.Size(637, 209);
            this.gb_quanlykhachhang.TabIndex = 3;
            this.gb_quanlykhachhang.Text = "Quản Lý Khách Hàng";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(24, 148);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 37);
            this.simpleButton1.TabIndex = 39;
            this.simpleButton1.Text = "Thêm Mới";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txt_ChietKhau
            // 
            this.txt_ChietKhau.Enabled = false;
            this.txt_ChietKhau.Location = new System.Drawing.Point(421, 100);
            this.txt_ChietKhau.Name = "txt_ChietKhau";
            this.txt_ChietKhau.Size = new System.Drawing.Size(179, 20);
            this.txt_ChietKhau.TabIndex = 38;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(334, 107);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(77, 13);
            this.labelControl7.TabIndex = 37;
            this.labelControl7.Text = "Tỉ Lệ Chiết Khấu";
            // 
            // combo_maloaikhachhang
            // 
            this.combo_maloaikhachhang.Enabled = false;
            this.combo_maloaikhachhang.Location = new System.Drawing.Point(122, 104);
            this.combo_maloaikhachhang.Name = "combo_maloaikhachhang";
            this.combo_maloaikhachhang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.combo_maloaikhachhang.Size = new System.Drawing.Size(179, 20);
            this.combo_maloaikhachhang.TabIndex = 34;
            // 
            // qL_NHASACH
            // 
            this.qL_NHASACH.DataSetName = "QL_NHASACH";
            this.qL_NHASACH.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dMMANHINHBindingSource
            // 
            this.dMMANHINHBindingSource.DataMember = "DM_MANHINH";
            this.dMMANHINHBindingSource.DataSource = this.qL_NHASACH;
            // 
            // dM_MANHINHTableAdapter
            // 
            this.dM_MANHINHTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 431);
            this.Controls.Add(this.grid_khachhang);
            this.Controls.Add(this.gb_quanlykhachhang);
            this.Name = "Frm_KhachHang";
            this.Text = "tt";
            this.Load += new System.EventHandler(this.Frm_KhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_diachi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sodt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tenkhachhang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_makhachhang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_khachhang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gb_quanlykhachhang)).EndInit();
            this.gb_quanlykhachhang.ResumeLayout(false);
            this.gb_quanlykhachhang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ChietKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combo_maloaikhachhang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NHASACH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMMANHINHBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_luukh;
        private DevExpress.XtraEditors.SimpleButton btn_huykh;
        private DevExpress.XtraEditors.SimpleButton btn_suakh;
        private DevExpress.XtraEditors.SimpleButton btn_xoakh;
        private DevExpress.XtraEditors.SimpleButton btn_themkh;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_diachi;
        private DevExpress.XtraEditors.TextEdit txt_sodt;
        private DevExpress.XtraEditors.TextEdit txt_tenkhachhang;
        private DevExpress.XtraEditors.TextEdit txt_makhachhang;
        private DevExpress.XtraGrid.Columns.GridColumn colSDT_KH;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI_KH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENKH;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOAI_KH;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl grid_khachhang;
        private DevExpress.XtraEditors.GroupControl gb_quanlykhachhang;
        private DevExpress.XtraEditors.ComboBoxEdit combo_maloaikhachhang;
        private DevExpress.XtraEditors.TextEdit txt_ChietKhau;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private QL_NHASACH qL_NHASACH;
        private System.Windows.Forms.BindingSource dMMANHINHBindingSource;
        private QL_NHASACHTableAdapters.DM_MANHINHTableAdapter dM_MANHINHTableAdapter;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}