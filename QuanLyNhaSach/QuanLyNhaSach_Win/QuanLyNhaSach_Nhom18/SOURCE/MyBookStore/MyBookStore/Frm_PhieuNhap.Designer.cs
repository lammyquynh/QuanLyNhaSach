namespace MyBookStore
{
    partial class Frm_PhieuNhap
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
            this.colMAPG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG_NHAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA_NHAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grid_ketqua = new DevExpress.XtraGrid.GridControl();
            this.pHIEUNHAPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txt_MAPN = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_timkiemphieunhap = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.pn = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_TenSP = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_dongia = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_MaSp = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Sl = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_ketqua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUNHAPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MAPN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gb_timkiemphieunhap)).BeginInit();
            this.gb_timkiemphieunhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pn)).BeginInit();
            this.pn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaSp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Sl.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPG,
            this.colMAHH,
            this.colSOLUONG_NHAP,
            this.colDONGIA_NHAP});
            this.gridView1.GridControl = this.grid_ketqua;
            this.gridView1.Name = "gridView1";
            // 
            // colMAPG
            // 
            this.colMAPG.FieldName = "MAPG";
            this.colMAPG.Name = "colMAPG";
            this.colMAPG.Visible = true;
            this.colMAPG.VisibleIndex = 0;
            // 
            // colMAHH
            // 
            this.colMAHH.FieldName = "MAHH";
            this.colMAHH.Name = "colMAHH";
            this.colMAHH.Visible = true;
            this.colMAHH.VisibleIndex = 1;
            // 
            // colSOLUONG_NHAP
            // 
            this.colSOLUONG_NHAP.FieldName = "SOLUONG_NHAP";
            this.colSOLUONG_NHAP.Name = "colSOLUONG_NHAP";
            this.colSOLUONG_NHAP.Visible = true;
            this.colSOLUONG_NHAP.VisibleIndex = 2;
            // 
            // colDONGIA_NHAP
            // 
            this.colDONGIA_NHAP.FieldName = "DONGIA_NHAP";
            this.colDONGIA_NHAP.Name = "colDONGIA_NHAP";
            this.colDONGIA_NHAP.Visible = true;
            this.colDONGIA_NHAP.VisibleIndex = 3;
            // 
            // grid_ketqua
            // 
            this.grid_ketqua.DataSource = this.pHIEUNHAPBindingSource;
            this.grid_ketqua.Enabled = false;
            this.grid_ketqua.Location = new System.Drawing.Point(12, 214);
            this.grid_ketqua.MainView = this.gridView1;
            this.grid_ketqua.Name = "grid_ketqua";
            this.grid_ketqua.Size = new System.Drawing.Size(813, 200);
            this.grid_ketqua.TabIndex = 7;
            this.grid_ketqua.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // pHIEUNHAPBindingSource
            // 
            this.pHIEUNHAPBindingSource.DataMember = "PHIEUNHAP";
            // 
            // txt_MAPN
            // 
            this.txt_MAPN.Location = new System.Drawing.Point(125, 40);
            this.txt_MAPN.Name = "txt_MAPN";
            this.txt_MAPN.Size = new System.Drawing.Size(194, 20);
            this.txt_MAPN.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã Phiếu Nhập";
            // 
            // gb_timkiemphieunhap
            // 
            this.gb_timkiemphieunhap.Controls.Add(this.simpleButton1);
            this.gb_timkiemphieunhap.Controls.Add(this.label1);
            this.gb_timkiemphieunhap.Controls.Add(this.txt_MAPN);
            this.gb_timkiemphieunhap.Location = new System.Drawing.Point(12, 62);
            this.gb_timkiemphieunhap.Name = "gb_timkiemphieunhap";
            this.gb_timkiemphieunhap.Size = new System.Drawing.Size(413, 66);
            this.gb_timkiemphieunhap.TabIndex = 5;
            this.gb_timkiemphieunhap.Text = "Tìm Kiếm Phiếu Nhập";
            this.gb_timkiemphieunhap.Paint += new System.Windows.Forms.PaintEventHandler(this.gb_timkiemphieunhap_Paint);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(325, 37);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 9;
            this.simpleButton1.Text = "Thêm";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // pn
            // 
            this.pn.Controls.Add(this.simpleButton5);
            this.pn.Controls.Add(this.simpleButton3);
            this.pn.Controls.Add(this.simpleButton2);
            this.pn.Controls.Add(this.simpleButton4);
            this.pn.Controls.Add(this.label12);
            this.pn.Controls.Add(this.txt_TenSP);
            this.pn.Controls.Add(this.label9);
            this.pn.Controls.Add(this.txt_dongia);
            this.pn.Controls.Add(this.label6);
            this.pn.Controls.Add(this.txt_MaSp);
            this.pn.Controls.Add(this.label4);
            this.pn.Controls.Add(this.label5);
            this.pn.Controls.Add(this.txt_Sl);
            this.pn.Enabled = false;
            this.pn.Location = new System.Drawing.Point(431, 12);
            this.pn.Name = "pn";
            this.pn.Size = new System.Drawing.Size(422, 171);
            this.pn.TabIndex = 57;
            this.pn.Text = "Chi Tiết Phiếu Nhập";
            // 
            // simpleButton5
            // 
            this.simpleButton5.Location = new System.Drawing.Point(200, 133);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(75, 23);
            this.simpleButton5.TabIndex = 68;
            this.simpleButton5.Text = "Sửa";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(108, 133);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 23);
            this.simpleButton3.TabIndex = 67;
            this.simpleButton3.Text = "Xóa";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(11, 133);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 66;
            this.simpleButton2.Text = "Thêm";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(360, 21);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(57, 23);
            this.simpleButton4.TabIndex = 62;
            this.simpleButton4.Text = "Tìm";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(134, 150);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 18);
            this.label12.TabIndex = 65;
            // 
            // txt_TenSP
            // 
            this.txt_TenSP.AutoSize = true;
            this.txt_TenSP.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenSP.Location = new System.Drawing.Point(134, 48);
            this.txt_TenSP.Name = "txt_TenSP";
            this.txt_TenSP.Size = new System.Drawing.Size(74, 18);
            this.txt_TenSP.TabIndex = 62;
            this.txt_TenSP.Text = "Sản Phẩm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 18);
            this.label9.TabIndex = 61;
            this.label9.Text = "Đơn Giá";
            // 
            // txt_dongia
            // 
            this.txt_dongia.AutoSize = true;
            this.txt_dongia.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dongia.ForeColor = System.Drawing.Color.Red;
            this.txt_dongia.Location = new System.Drawing.Point(134, 74);
            this.txt_dongia.Name = "txt_dongia";
            this.txt_dongia.Size = new System.Drawing.Size(81, 18);
            this.txt_dongia.TabIndex = 60;
            this.txt_dongia.Text = "Sản Phẩm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 18);
            this.label6.TabIndex = 59;
            this.label6.Text = "Sản Phẩm";
            // 
            // txt_MaSp
            // 
            this.txt_MaSp.Location = new System.Drawing.Point(136, 23);
            this.txt_MaSp.Name = "txt_MaSp";
            this.txt_MaSp.Size = new System.Drawing.Size(218, 20);
            this.txt_MaSp.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 18);
            this.label4.TabIndex = 44;
            this.label4.Text = "Số Lượng Mua";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 18);
            this.label5.TabIndex = 42;
            this.label5.Text = "Mã Sản Phẩm";
            // 
            // txt_Sl
            // 
            this.txt_Sl.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txt_Sl.Location = new System.Drawing.Point(137, 95);
            this.txt_Sl.Name = "txt_Sl";
            this.txt_Sl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_Sl.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.txt_Sl.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txt_Sl.Size = new System.Drawing.Size(100, 20);
            this.txt_Sl.TabIndex = 54;
            // 
            // Frm_PhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 421);
            this.Controls.Add(this.pn);
            this.Controls.Add(this.grid_ketqua);
            this.Controls.Add(this.gb_timkiemphieunhap);
            this.Name = "Frm_PhieuNhap";
            this.Text = "Frm_PhieuNhap";
            this.Load += new System.EventHandler(this.Frm_PhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_ketqua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUNHAPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MAPN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gb_timkiemphieunhap)).EndInit();
            this.gb_timkiemphieunhap.ResumeLayout(false);
            this.gb_timkiemphieunhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pn)).EndInit();
            this.pn.ResumeLayout(false);
            this.pn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaSp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Sl.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG_NHAP;
        private DevExpress.XtraGrid.Columns.GridColumn colMAHH;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPG;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA_NHAP;
        private DevExpress.XtraGrid.GridControl grid_ketqua;
        private System.Windows.Forms.BindingSource pHIEUNHAPBindingSource;
        private DevExpress.XtraEditors.TextEdit txt_MAPN;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GroupControl gb_timkiemphieunhap;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.GroupControl pn;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label txt_TenSP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label txt_dongia;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit txt_MaSp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SpinEdit txt_Sl;
    }
}