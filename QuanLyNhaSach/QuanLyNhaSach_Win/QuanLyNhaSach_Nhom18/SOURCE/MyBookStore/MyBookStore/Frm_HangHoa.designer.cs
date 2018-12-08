namespace MyBookStore
{
    partial class Frm_HangHoa
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
            this.colMAHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALOAI_HH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHUYENMAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONGTON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGIATIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOIDUNG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grid_hanghoa = new DevExpress.XtraGrid.GridControl();
            this.btn_luuhanghoa = new DevExpress.XtraEditors.SimpleButton();
            this.btn_huyhanghoa = new DevExpress.XtraEditors.SimpleButton();
            this.btn_suahanghoa = new DevExpress.XtraEditors.SimpleButton();
            this.btn_xoahanghoa = new DevExpress.XtraEditors.SimpleButton();
            this.btn_themhanghoa = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.cbo_makhuyenmai = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_giatien = new DevExpress.XtraEditors.TextEdit();
            this.txt_noidung = new DevExpress.XtraEditors.TextEdit();
            this.txt_maloaihanghoa = new DevExpress.XtraEditors.TextEdit();
            this.txt_soluongton = new DevExpress.XtraEditors.TextEdit();
            this.txt_tenhanghoa = new DevExpress.XtraEditors.TextEdit();
            this.txt_mahanghoa = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_hanghoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_makhuyenmai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_giatien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_noidung.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_maloaihanghoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_soluongton.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tenhanghoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mahanghoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAHH,
            this.colMALOAI_HH,
            this.colMAKHUYENMAI,
            this.colTENHH,
            this.colSOLUONGTON,
            this.colGIATIEN,
            this.colNOIDUNG});
            this.gridView1.GridControl = this.grid_hanghoa;
            this.gridView1.Name = "gridView1";
            // 
            // colMAHH
            // 
            this.colMAHH.FieldName = "MAHH";
            this.colMAHH.Name = "colMAHH";
            this.colMAHH.Visible = true;
            this.colMAHH.VisibleIndex = 0;
            // 
            // colMALOAI_HH
            // 
            this.colMALOAI_HH.FieldName = "MALOAI_HH";
            this.colMALOAI_HH.Name = "colMALOAI_HH";
            this.colMALOAI_HH.Visible = true;
            this.colMALOAI_HH.VisibleIndex = 1;
            // 
            // colMAKHUYENMAI
            // 
            this.colMAKHUYENMAI.FieldName = "MAKHUYENMAI";
            this.colMAKHUYENMAI.Name = "colMAKHUYENMAI";
            this.colMAKHUYENMAI.Visible = true;
            this.colMAKHUYENMAI.VisibleIndex = 2;
            // 
            // colTENHH
            // 
            this.colTENHH.FieldName = "TENHH";
            this.colTENHH.Name = "colTENHH";
            this.colTENHH.Visible = true;
            this.colTENHH.VisibleIndex = 3;
            // 
            // colSOLUONGTON
            // 
            this.colSOLUONGTON.FieldName = "SOLUONGTON";
            this.colSOLUONGTON.Name = "colSOLUONGTON";
            this.colSOLUONGTON.Visible = true;
            this.colSOLUONGTON.VisibleIndex = 4;
            // 
            // colGIATIEN
            // 
            this.colGIATIEN.FieldName = "GIATIEN";
            this.colGIATIEN.Name = "colGIATIEN";
            this.colGIATIEN.Visible = true;
            this.colGIATIEN.VisibleIndex = 5;
            // 
            // colNOIDUNG
            // 
            this.colNOIDUNG.FieldName = "NOIDUNG";
            this.colNOIDUNG.Name = "colNOIDUNG";
            this.colNOIDUNG.Visible = true;
            this.colNOIDUNG.VisibleIndex = 6;
            // 
            // grid_hanghoa
            // 
            this.grid_hanghoa.Location = new System.Drawing.Point(12, 226);
            this.grid_hanghoa.MainView = this.gridView1;
            this.grid_hanghoa.Name = "grid_hanghoa";
            this.grid_hanghoa.Size = new System.Drawing.Size(680, 200);
            this.grid_hanghoa.TabIndex = 3;
            this.grid_hanghoa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // btn_luuhanghoa
            // 
            this.btn_luuhanghoa.Location = new System.Drawing.Point(426, 170);
            this.btn_luuhanghoa.Name = "btn_luuhanghoa";
            this.btn_luuhanghoa.Size = new System.Drawing.Size(75, 23);
            this.btn_luuhanghoa.TabIndex = 18;
            this.btn_luuhanghoa.Text = "Lưu";
            this.btn_luuhanghoa.Click += new System.EventHandler(this.btn_luuhanghoa_Click);
            // 
            // btn_huyhanghoa
            // 
            this.btn_huyhanghoa.Location = new System.Drawing.Point(555, 170);
            this.btn_huyhanghoa.Name = "btn_huyhanghoa";
            this.btn_huyhanghoa.Size = new System.Drawing.Size(75, 23);
            this.btn_huyhanghoa.TabIndex = 17;
            this.btn_huyhanghoa.Text = "Hủy";
            // 
            // btn_suahanghoa
            // 
            this.btn_suahanghoa.Location = new System.Drawing.Point(297, 170);
            this.btn_suahanghoa.Name = "btn_suahanghoa";
            this.btn_suahanghoa.Size = new System.Drawing.Size(75, 23);
            this.btn_suahanghoa.TabIndex = 16;
            this.btn_suahanghoa.Text = "Sửa";
            this.btn_suahanghoa.Click += new System.EventHandler(this.btn_suahanghoa_Click);
            // 
            // btn_xoahanghoa
            // 
            this.btn_xoahanghoa.Location = new System.Drawing.Point(168, 170);
            this.btn_xoahanghoa.Name = "btn_xoahanghoa";
            this.btn_xoahanghoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoahanghoa.TabIndex = 15;
            this.btn_xoahanghoa.Text = "Xóa";
            this.btn_xoahanghoa.Click += new System.EventHandler(this.btn_xoahanghoa_Click);
            // 
            // btn_themhanghoa
            // 
            this.btn_themhanghoa.Location = new System.Drawing.Point(87, 170);
            this.btn_themhanghoa.Name = "btn_themhanghoa";
            this.btn_themhanghoa.Size = new System.Drawing.Size(75, 23);
            this.btn_themhanghoa.TabIndex = 14;
            this.btn_themhanghoa.Text = "Thêm";
            this.btn_themhanghoa.Click += new System.EventHandler(this.btn_themhanghoa_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(39, 139);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(43, 13);
            this.labelControl7.TabIndex = 13;
            this.labelControl7.Text = "Nội Dung";
            // 
            // cbo_makhuyenmai
            // 
            this.cbo_makhuyenmai.Location = new System.Drawing.Point(476, 76);
            this.cbo_makhuyenmai.Name = "cbo_makhuyenmai";
            this.cbo_makhuyenmai.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_makhuyenmai.Size = new System.Drawing.Size(173, 20);
            this.cbo_makhuyenmai.TabIndex = 12;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(362, 105);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(38, 13);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Giá Tiền";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(362, 79);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(72, 13);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Mã Khuyến Mãi";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(362, 53);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(86, 13);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Mã Loại Hàng Hóa";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(39, 107);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(66, 13);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Số Lượng Tồn";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(39, 82);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(68, 13);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Tên Hàng Hóa";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(39, 57);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(61, 13);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "MãHàng Hóa";
            // 
            // txt_giatien
            // 
            this.txt_giatien.Location = new System.Drawing.Point(476, 104);
            this.txt_giatien.Name = "txt_giatien";
            this.txt_giatien.Size = new System.Drawing.Size(173, 20);
            this.txt_giatien.TabIndex = 5;
            // 
            // txt_noidung
            // 
            this.txt_noidung.Location = new System.Drawing.Point(141, 136);
            this.txt_noidung.Name = "txt_noidung";
            this.txt_noidung.Size = new System.Drawing.Size(508, 20);
            this.txt_noidung.TabIndex = 4;
            // 
            // txt_maloaihanghoa
            // 
            this.txt_maloaihanghoa.Location = new System.Drawing.Point(476, 50);
            this.txt_maloaihanghoa.Name = "txt_maloaihanghoa";
            this.txt_maloaihanghoa.Size = new System.Drawing.Size(173, 20);
            this.txt_maloaihanghoa.TabIndex = 3;
            // 
            // txt_soluongton
            // 
            this.txt_soluongton.Location = new System.Drawing.Point(141, 103);
            this.txt_soluongton.Name = "txt_soluongton";
            this.txt_soluongton.Size = new System.Drawing.Size(189, 20);
            this.txt_soluongton.TabIndex = 2;
            // 
            // txt_tenhanghoa
            // 
            this.txt_tenhanghoa.Location = new System.Drawing.Point(141, 76);
            this.txt_tenhanghoa.Name = "txt_tenhanghoa";
            this.txt_tenhanghoa.Size = new System.Drawing.Size(189, 20);
            this.txt_tenhanghoa.TabIndex = 1;
            // 
            // txt_mahanghoa
            // 
            this.txt_mahanghoa.Location = new System.Drawing.Point(141, 50);
            this.txt_mahanghoa.Name = "txt_mahanghoa";
            this.txt_mahanghoa.Size = new System.Drawing.Size(189, 20);
            this.txt_mahanghoa.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.btn_luuhanghoa);
            this.groupControl1.Controls.Add(this.btn_huyhanghoa);
            this.groupControl1.Controls.Add(this.btn_suahanghoa);
            this.groupControl1.Controls.Add(this.btn_xoahanghoa);
            this.groupControl1.Controls.Add(this.btn_themhanghoa);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.cbo_makhuyenmai);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txt_giatien);
            this.groupControl1.Controls.Add(this.txt_noidung);
            this.groupControl1.Controls.Add(this.txt_maloaihanghoa);
            this.groupControl1.Controls.Add(this.txt_soluongton);
            this.groupControl1.Controls.Add(this.txt_tenhanghoa);
            this.groupControl1.Controls.Add(this.txt_mahanghoa);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(680, 208);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Quản Lý Hàng Hóa";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(7, 170);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 19;
            this.simpleButton1.Text = "Thêm Mới";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // Frm_HangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 442);
            this.Controls.Add(this.grid_hanghoa);
            this.Controls.Add(this.groupControl1);
            this.Name = "Frm_HangHoa";
            this.Text = "Frm_HangHoa";
            this.Load += new System.EventHandler(this.Frm_HangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_hanghoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_makhuyenmai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_giatien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_noidung.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_maloaihanghoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_soluongton.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tenhanghoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mahanghoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAHH;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOAI_HH;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHUYENMAI;
        private DevExpress.XtraGrid.Columns.GridColumn colTENHH;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONGTON;
        private DevExpress.XtraGrid.Columns.GridColumn colGIATIEN;
        private DevExpress.XtraGrid.Columns.GridColumn colNOIDUNG;
        private DevExpress.XtraGrid.GridControl grid_hanghoa;
        private DevExpress.XtraEditors.SimpleButton btn_luuhanghoa;
        private DevExpress.XtraEditors.SimpleButton btn_huyhanghoa;
        private DevExpress.XtraEditors.SimpleButton btn_suahanghoa;
        private DevExpress.XtraEditors.SimpleButton btn_xoahanghoa;
        private DevExpress.XtraEditors.SimpleButton btn_themhanghoa;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.ComboBoxEdit cbo_makhuyenmai;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_giatien;
        private DevExpress.XtraEditors.TextEdit txt_noidung;
        private DevExpress.XtraEditors.TextEdit txt_maloaihanghoa;
        private DevExpress.XtraEditors.TextEdit txt_soluongton;
        private DevExpress.XtraEditors.TextEdit txt_tenhanghoa;
        private DevExpress.XtraEditors.TextEdit txt_mahanghoa;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}