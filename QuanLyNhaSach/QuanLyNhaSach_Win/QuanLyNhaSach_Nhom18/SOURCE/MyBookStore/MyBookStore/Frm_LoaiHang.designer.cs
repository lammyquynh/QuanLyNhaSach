namespace MyBookStore
{
    partial class Frm_LoaiHang
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
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALOAI_HH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENLOAI_HH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grid_loaihanghoa = new DevExpress.XtraGrid.GridControl();
            this.lOAIHANGHOABindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qL_NHASACH = new MyBookStore.QL_NHASACH();
            this.lOAIHANGHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_luuloaihang = new DevExpress.XtraEditors.SimpleButton();
            this.btn_huyloaihang = new DevExpress.XtraEditors.SimpleButton();
            this.btn_sualoaihang = new DevExpress.XtraEditors.SimpleButton();
            this.btn_xoaloaihang = new DevExpress.XtraEditors.SimpleButton();
            this.btn_themloaihang = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_maloai = new DevExpress.XtraEditors.TextEdit();
            this.txt_tenloai = new DevExpress.XtraEditors.TextEdit();
            this.gb_theloaihanghoa = new DevExpress.XtraEditors.GroupControl();
            this.kHUYENMAIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOAIHANGHOATableAdapter = new MyBookStore.QL_NHASACHTableAdapters.LOAIHANGHOATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_loaihanghoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIHANGHOABindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NHASACH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIHANGHOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_maloai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tenloai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gb_theloaihanghoa)).BeginInit();
            this.gb_theloaihanghoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kHUYENMAIBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALOAI_HH,
            this.colTENLOAI_HH});
            this.gridView1.GridControl = this.grid_loaihanghoa;
            this.gridView1.Name = "gridView1";
            // 
            // colMALOAI_HH
            // 
            this.colMALOAI_HH.FieldName = "MALOAI_HH";
            this.colMALOAI_HH.Name = "colMALOAI_HH";
            this.colMALOAI_HH.Visible = true;
            this.colMALOAI_HH.VisibleIndex = 0;
            // 
            // colTENLOAI_HH
            // 
            this.colTENLOAI_HH.FieldName = "TENLOAI_HH";
            this.colTENLOAI_HH.Name = "colTENLOAI_HH";
            this.colTENLOAI_HH.Visible = true;
            this.colTENLOAI_HH.VisibleIndex = 1;
            // 
            // grid_loaihanghoa
            // 
            this.grid_loaihanghoa.DataSource = this.lOAIHANGHOABindingSource1;
            this.grid_loaihanghoa.Location = new System.Drawing.Point(12, 221);
            this.grid_loaihanghoa.MainView = this.gridView1;
            this.grid_loaihanghoa.Name = "grid_loaihanghoa";
            this.grid_loaihanghoa.Size = new System.Drawing.Size(704, 236);
            this.grid_loaihanghoa.TabIndex = 7;
            this.grid_loaihanghoa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // lOAIHANGHOABindingSource1
            // 
            this.lOAIHANGHOABindingSource1.DataMember = "LOAIHANGHOA";
            this.lOAIHANGHOABindingSource1.DataSource = this.qL_NHASACH;
            // 
            // qL_NHASACH
            // 
            this.qL_NHASACH.DataSetName = "QL_NHASACH";
            this.qL_NHASACH.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOAIHANGHOABindingSource
            // 
            this.lOAIHANGHOABindingSource.DataMember = "LOAIHANGHOA";
            // 
            // btn_luuloaihang
            // 
            this.btn_luuloaihang.Location = new System.Drawing.Point(424, 151);
            this.btn_luuloaihang.Name = "btn_luuloaihang";
            this.btn_luuloaihang.Size = new System.Drawing.Size(75, 23);
            this.btn_luuloaihang.TabIndex = 23;
            this.btn_luuloaihang.Text = "Lưu";
            this.btn_luuloaihang.Click += new System.EventHandler(this.btn_luuloaihang_Click);
            // 
            // btn_huyloaihang
            // 
            this.btn_huyloaihang.Location = new System.Drawing.Point(553, 151);
            this.btn_huyloaihang.Name = "btn_huyloaihang";
            this.btn_huyloaihang.Size = new System.Drawing.Size(75, 23);
            this.btn_huyloaihang.TabIndex = 22;
            this.btn_huyloaihang.Text = "Hủy";
            // 
            // btn_sualoaihang
            // 
            this.btn_sualoaihang.Location = new System.Drawing.Point(295, 151);
            this.btn_sualoaihang.Name = "btn_sualoaihang";
            this.btn_sualoaihang.Size = new System.Drawing.Size(75, 23);
            this.btn_sualoaihang.TabIndex = 21;
            this.btn_sualoaihang.Text = "Sửa";
            this.btn_sualoaihang.Click += new System.EventHandler(this.btn_sualoaihang_Click);
            // 
            // btn_xoaloaihang
            // 
            this.btn_xoaloaihang.Location = new System.Drawing.Point(166, 151);
            this.btn_xoaloaihang.Name = "btn_xoaloaihang";
            this.btn_xoaloaihang.Size = new System.Drawing.Size(75, 23);
            this.btn_xoaloaihang.TabIndex = 20;
            this.btn_xoaloaihang.Text = "Xóa";
            this.btn_xoaloaihang.Click += new System.EventHandler(this.btn_xoaloaihang_Click);
            // 
            // btn_themloaihang
            // 
            this.btn_themloaihang.Location = new System.Drawing.Point(37, 151);
            this.btn_themloaihang.Name = "btn_themloaihang";
            this.btn_themloaihang.Size = new System.Drawing.Size(75, 23);
            this.btn_themloaihang.TabIndex = 19;
            this.btn_themloaihang.Text = "Thêm";
            this.btn_themloaihang.Click += new System.EventHandler(this.btn_themloaihang_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(37, 59);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(86, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Mã Loại Hàng Hóa";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(37, 110);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(90, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Tên Loại Hàng Hóa";
            // 
            // txt_maloai
            // 
            this.txt_maloai.Location = new System.Drawing.Point(140, 52);
            this.txt_maloai.Name = "txt_maloai";
            this.txt_maloai.Size = new System.Drawing.Size(193, 20);
            this.txt_maloai.TabIndex = 1;
            // 
            // txt_tenloai
            // 
            this.txt_tenloai.Location = new System.Drawing.Point(140, 103);
            this.txt_tenloai.Name = "txt_tenloai";
            this.txt_tenloai.Size = new System.Drawing.Size(193, 20);
            this.txt_tenloai.TabIndex = 0;
            // 
            // gb_theloaihanghoa
            // 
            this.gb_theloaihanghoa.Controls.Add(this.btn_luuloaihang);
            this.gb_theloaihanghoa.Controls.Add(this.btn_huyloaihang);
            this.gb_theloaihanghoa.Controls.Add(this.btn_sualoaihang);
            this.gb_theloaihanghoa.Controls.Add(this.btn_xoaloaihang);
            this.gb_theloaihanghoa.Controls.Add(this.btn_themloaihang);
            this.gb_theloaihanghoa.Controls.Add(this.labelControl2);
            this.gb_theloaihanghoa.Controls.Add(this.labelControl1);
            this.gb_theloaihanghoa.Controls.Add(this.txt_maloai);
            this.gb_theloaihanghoa.Controls.Add(this.txt_tenloai);
            this.gb_theloaihanghoa.Location = new System.Drawing.Point(12, 12);
            this.gb_theloaihanghoa.Name = "gb_theloaihanghoa";
            this.gb_theloaihanghoa.Size = new System.Drawing.Size(704, 202);
            this.gb_theloaihanghoa.TabIndex = 6;
            this.gb_theloaihanghoa.Text = "Quản Lý Thể Loại Hàng Hóa";
            // 
            // kHUYENMAIBindingSource
            // 
            this.kHUYENMAIBindingSource.DataMember = "KHUYENMAI";
            // 
            // lOAIHANGHOATableAdapter
            // 
            this.lOAIHANGHOATableAdapter.ClearBeforeFill = true;
            // 
            // Frm_LoaiHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 484);
            this.Controls.Add(this.grid_loaihanghoa);
            this.Controls.Add(this.gb_theloaihanghoa);
            this.Name = "Frm_LoaiHang";
            this.Text = "Frm_LoaiHang";
            this.Load += new System.EventHandler(this.Frm_LoaiHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_loaihanghoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIHANGHOABindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NHASACH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIHANGHOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_maloai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tenloai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gb_theloaihanghoa)).EndInit();
            this.gb_theloaihanghoa.ResumeLayout(false);
            this.gb_theloaihanghoa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kHUYENMAIBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn colMALOAI_HH;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOAI_HH;
        private DevExpress.XtraGrid.GridControl grid_loaihanghoa;
        private System.Windows.Forms.BindingSource lOAIHANGHOABindingSource;
        private DevExpress.XtraEditors.SimpleButton btn_luuloaihang;
        private DevExpress.XtraEditors.SimpleButton btn_huyloaihang;
        private DevExpress.XtraEditors.SimpleButton btn_sualoaihang;
        private DevExpress.XtraEditors.SimpleButton btn_xoaloaihang;
        private DevExpress.XtraEditors.SimpleButton btn_themloaihang;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_maloai;
        private DevExpress.XtraEditors.TextEdit txt_tenloai;
        private System.Windows.Forms.BindingSource kHUYENMAIBindingSource;
        private DevExpress.XtraEditors.GroupControl gb_theloaihanghoa;
        private QL_NHASACH qL_NHASACH;
        private System.Windows.Forms.BindingSource lOAIHANGHOABindingSource1;
        private QL_NHASACHTableAdapters.LOAIHANGHOATableAdapter lOAIHANGHOATableAdapter;
    }
}