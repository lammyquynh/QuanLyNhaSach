namespace MyBookStore
{
    partial class Frm_HoaDon
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
            this.btn_xemhoadon = new DevExpress.XtraEditors.SimpleButton();
            this.btn_inhoadon = new DevExpress.XtraEditors.SimpleButton();
            this.txt_xemsohoadon = new DevExpress.XtraEditors.TextEdit();
            this.gb_xemhoadon = new DevExpress.XtraEditors.GroupControl();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_xoahoadon = new DevExpress.XtraEditors.SimpleButton();
            this.btn_timhoadon = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_timmakhachhangHD = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_timmanhanvienHD = new DevExpress.XtraEditors.TextEdit();
            this.txt_timsohoadon = new DevExpress.XtraEditors.TextEdit();
            this.txt_ngaylaphoadon = new DevExpress.XtraEditors.DateEdit();
            this.gb_timkiemhoadon = new DevExpress.XtraEditors.GroupControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAHD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYLAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTONGTHANHTIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grid_hoadon = new DevExpress.XtraGrid.GridControl();
            this.hOADONBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.qL_NHASACH = new MyBookStore.QL_NHASACH();
            this.hOADONBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cTHOADONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hOADONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hANGHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hANGHOATableAdapter = new MyBookStore.QL_NHASACHTableAdapters.HANGHOATableAdapter();
            this.hOADONTableAdapter = new MyBookStore.QL_NHASACHTableAdapters.HOADONTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.txt_xemsohoadon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gb_xemhoadon)).BeginInit();
            this.gb_xemhoadon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_timmakhachhangHD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_timmanhanvienHD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_timsohoadon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ngaylaphoadon.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ngaylaphoadon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gb_timkiemhoadon)).BeginInit();
            this.gb_timkiemhoadon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_hoadon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NHASACH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTHOADONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hANGHOABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_xemhoadon
            // 
            this.btn_xemhoadon.Location = new System.Drawing.Point(107, 113);
            this.btn_xemhoadon.Name = "btn_xemhoadon";
            this.btn_xemhoadon.Size = new System.Drawing.Size(75, 23);
            this.btn_xemhoadon.TabIndex = 12;
            this.btn_xemhoadon.Text = "Xem";
            // 
            // btn_inhoadon
            // 
            this.btn_inhoadon.Location = new System.Drawing.Point(226, 113);
            this.btn_inhoadon.Name = "btn_inhoadon";
            this.btn_inhoadon.Size = new System.Drawing.Size(75, 23);
            this.btn_inhoadon.TabIndex = 13;
            this.btn_inhoadon.Text = "In";
            // 
            // txt_xemsohoadon
            // 
            this.txt_xemsohoadon.Location = new System.Drawing.Point(107, 57);
            this.txt_xemsohoadon.Name = "txt_xemsohoadon";
            this.txt_xemsohoadon.Size = new System.Drawing.Size(194, 20);
            this.txt_xemsohoadon.TabIndex = 10;
            // 
            // gb_xemhoadon
            // 
            this.gb_xemhoadon.Controls.Add(this.btn_xemhoadon);
            this.gb_xemhoadon.Controls.Add(this.btn_inhoadon);
            this.gb_xemhoadon.Controls.Add(this.label5);
            this.gb_xemhoadon.Controls.Add(this.txt_xemsohoadon);
            this.gb_xemhoadon.Location = new System.Drawing.Point(474, 12);
            this.gb_xemhoadon.Name = "gb_xemhoadon";
            this.gb_xemhoadon.Size = new System.Drawing.Size(334, 201);
            this.gb_xemhoadon.TabIndex = 31;
            this.gb_xemhoadon.Text = "Xem Chi Tiết Hóa Đơn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Số Hóa Đơn";
            // 
            // btn_xoahoadon
            // 
            this.btn_xoahoadon.Location = new System.Drawing.Point(365, 107);
            this.btn_xoahoadon.Name = "btn_xoahoadon";
            this.btn_xoahoadon.Size = new System.Drawing.Size(75, 23);
            this.btn_xoahoadon.TabIndex = 36;
            this.btn_xoahoadon.Text = "Xóa";
            // 
            // btn_timhoadon
            // 
            this.btn_timhoadon.Location = new System.Drawing.Point(365, 69);
            this.btn_timhoadon.Name = "btn_timhoadon";
            this.btn_timhoadon.Size = new System.Drawing.Size(75, 23);
            this.btn_timhoadon.TabIndex = 35;
            this.btn_timhoadon.Text = "Tìm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Mã Khách Hàng";
            // 
            // txt_timmakhachhangHD
            // 
            this.txt_timmakhachhangHD.Location = new System.Drawing.Point(137, 111);
            this.txt_timmakhachhangHD.Name = "txt_timmakhachhangHD";
            this.txt_timmakhachhangHD.Size = new System.Drawing.Size(194, 20);
            this.txt_timmakhachhangHD.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Ngày Lập Hóa Đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Mã Nhân Viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Số Hóa Đơn";
            // 
            // txt_timmanhanvienHD
            // 
            this.txt_timmanhanvienHD.Location = new System.Drawing.Point(137, 70);
            this.txt_timmanhanvienHD.Name = "txt_timmanhanvienHD";
            this.txt_timmanhanvienHD.Size = new System.Drawing.Size(194, 20);
            this.txt_timmanhanvienHD.TabIndex = 29;
            // 
            // txt_timsohoadon
            // 
            this.txt_timsohoadon.Location = new System.Drawing.Point(137, 29);
            this.txt_timsohoadon.Name = "txt_timsohoadon";
            this.txt_timsohoadon.Size = new System.Drawing.Size(194, 20);
            this.txt_timsohoadon.TabIndex = 27;
            // 
            // txt_ngaylaphoadon
            // 
            this.txt_ngaylaphoadon.EditValue = new System.DateTime(2018, 10, 28, 18, 20, 13, 0);
            this.txt_ngaylaphoadon.Location = new System.Drawing.Point(137, 152);
            this.txt_ngaylaphoadon.Name = "txt_ngaylaphoadon";
            this.txt_ngaylaphoadon.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_ngaylaphoadon.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_ngaylaphoadon.Properties.DisplayFormat.FormatString = "";
            this.txt_ngaylaphoadon.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txt_ngaylaphoadon.Properties.EditFormat.FormatString = "";
            this.txt_ngaylaphoadon.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txt_ngaylaphoadon.Properties.Mask.EditMask = "";
            this.txt_ngaylaphoadon.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txt_ngaylaphoadon.Size = new System.Drawing.Size(194, 20);
            this.txt_ngaylaphoadon.TabIndex = 28;
            // 
            // gb_timkiemhoadon
            // 
            this.gb_timkiemhoadon.Controls.Add(this.btn_xoahoadon);
            this.gb_timkiemhoadon.Controls.Add(this.btn_timhoadon);
            this.gb_timkiemhoadon.Controls.Add(this.label4);
            this.gb_timkiemhoadon.Controls.Add(this.txt_timmakhachhangHD);
            this.gb_timkiemhoadon.Controls.Add(this.label3);
            this.gb_timkiemhoadon.Controls.Add(this.label2);
            this.gb_timkiemhoadon.Controls.Add(this.label1);
            this.gb_timkiemhoadon.Controls.Add(this.txt_timmanhanvienHD);
            this.gb_timkiemhoadon.Controls.Add(this.txt_timsohoadon);
            this.gb_timkiemhoadon.Controls.Add(this.txt_ngaylaphoadon);
            this.gb_timkiemhoadon.Location = new System.Drawing.Point(12, 12);
            this.gb_timkiemhoadon.Name = "gb_timkiemhoadon";
            this.gb_timkiemhoadon.Size = new System.Drawing.Size(456, 201);
            this.gb_timkiemhoadon.TabIndex = 30;
            this.gb_timkiemhoadon.Text = "Tìm Kiếm Hóa Đơn";
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAHD,
            this.colMANV,
            this.colMAKH,
            this.colNGAYLAP,
            this.colTONGTHANHTIEN});
            this.gridView1.GridControl = this.grid_hoadon;
            this.gridView1.Name = "gridView1";
            // 
            // colMAHD
            // 
            this.colMAHD.FieldName = "MAHD";
            this.colMAHD.Name = "colMAHD";
            this.colMAHD.Visible = true;
            this.colMAHD.VisibleIndex = 0;
            // 
            // colMANV
            // 
            this.colMANV.FieldName = "MANV";
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 1;
            // 
            // colMAKH
            // 
            this.colMAKH.FieldName = "MAKH";
            this.colMAKH.Name = "colMAKH";
            this.colMAKH.Visible = true;
            this.colMAKH.VisibleIndex = 2;
            // 
            // colNGAYLAP
            // 
            this.colNGAYLAP.FieldName = "NGAYLAP";
            this.colNGAYLAP.Name = "colNGAYLAP";
            this.colNGAYLAP.Visible = true;
            this.colNGAYLAP.VisibleIndex = 3;
            // 
            // colTONGTHANHTIEN
            // 
            this.colTONGTHANHTIEN.FieldName = "TONGTHANHTIEN";
            this.colTONGTHANHTIEN.Name = "colTONGTHANHTIEN";
            this.colTONGTHANHTIEN.Visible = true;
            this.colTONGTHANHTIEN.VisibleIndex = 4;
            // 
            // grid_hoadon
            // 
            this.grid_hoadon.DataSource = this.hOADONBindingSource2;
            this.grid_hoadon.Location = new System.Drawing.Point(12, 219);
            this.grid_hoadon.MainView = this.gridView1;
            this.grid_hoadon.Name = "grid_hoadon";
            this.grid_hoadon.Size = new System.Drawing.Size(796, 213);
            this.grid_hoadon.TabIndex = 29;
            this.grid_hoadon.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // hOADONBindingSource2
            // 
            this.hOADONBindingSource2.DataMember = "HOADON";
            this.hOADONBindingSource2.DataSource = this.qL_NHASACH;
            // 
            // qL_NHASACH
            // 
            this.qL_NHASACH.DataSetName = "QL_NHASACH";
            this.qL_NHASACH.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hOADONBindingSource1
            // 
            this.hOADONBindingSource1.DataMember = "HOADON";
            // 
            // cTHOADONBindingSource
            // 
            this.cTHOADONBindingSource.DataMember = "CT_HOADON";
            // 
            // hOADONBindingSource
            // 
            this.hOADONBindingSource.DataMember = "HOADON";
            // 
            // hANGHOABindingSource
            // 
            this.hANGHOABindingSource.DataMember = "HANGHOA";
            this.hANGHOABindingSource.DataSource = this.qL_NHASACH;
            // 
            // hANGHOATableAdapter
            // 
            this.hANGHOATableAdapter.ClearBeforeFill = true;
            // 
            // hOADONTableAdapter
            // 
            this.hOADONTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 444);
            this.Controls.Add(this.gb_xemhoadon);
            this.Controls.Add(this.gb_timkiemhoadon);
            this.Controls.Add(this.grid_hoadon);
            this.Name = "Frm_HoaDon";
            this.Text = "Frm_HoaDon";
            this.Load += new System.EventHandler(this.Frm_HoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_xemsohoadon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gb_xemhoadon)).EndInit();
            this.gb_xemhoadon.ResumeLayout(false);
            this.gb_xemhoadon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_timmakhachhangHD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_timmanhanvienHD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_timsohoadon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ngaylaphoadon.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ngaylaphoadon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gb_timkiemhoadon)).EndInit();
            this.gb_timkiemhoadon.ResumeLayout(false);
            this.gb_timkiemhoadon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_hoadon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NHASACH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTHOADONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hANGHOABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_xemhoadon;
        private DevExpress.XtraEditors.SimpleButton btn_inhoadon;
        private DevExpress.XtraEditors.TextEdit txt_xemsohoadon;
        private DevExpress.XtraEditors.GroupControl gb_xemhoadon;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton btn_xoahoadon;
        private DevExpress.XtraEditors.SimpleButton btn_timhoadon;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txt_timmakhachhangHD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txt_timmanhanvienHD;
        private DevExpress.XtraEditors.TextEdit txt_timsohoadon;
        private DevExpress.XtraEditors.DateEdit txt_ngaylaphoadon;
        private DevExpress.XtraEditors.GroupControl gb_timkiemhoadon;
        private DevExpress.XtraGrid.Columns.GridColumn colTONGTHANHTIEN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYLAP;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAHD;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl grid_hoadon;
        private System.Windows.Forms.BindingSource hOADONBindingSource1;
        private System.Windows.Forms.BindingSource cTHOADONBindingSource;
        private System.Windows.Forms.BindingSource hOADONBindingSource;
        private QL_NHASACH qL_NHASACH;
        private System.Windows.Forms.BindingSource hANGHOABindingSource;
        private QL_NHASACHTableAdapters.HANGHOATableAdapter hANGHOATableAdapter;
        private System.Windows.Forms.BindingSource hOADONBindingSource2;
        private QL_NHASACHTableAdapters.HOADONTableAdapter hOADONTableAdapter;
    }
}