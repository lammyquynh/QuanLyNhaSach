namespace MyBookStore
{
    partial class frm_Doimatkhauu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Doimatkhauu));
            this.txtMKmoiRe = new DevExpress.XtraEditors.TextEdit();
            this.txt_MKmoi = new DevExpress.XtraEditors.TextEdit();
            this.txtMKcu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtErro = new System.Windows.Forms.Label();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btn_reset = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtMKmoiRe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MKmoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMKcu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMKmoiRe
            // 
            this.txtMKmoiRe.Location = new System.Drawing.Point(12, 192);
            this.txtMKmoiRe.Name = "txtMKmoiRe";
            this.txtMKmoiRe.Properties.PasswordChar = '*';
            this.txtMKmoiRe.Size = new System.Drawing.Size(237, 20);
            this.txtMKmoiRe.TabIndex = 16;
            this.txtMKmoiRe.TextChanged += new System.EventHandler(this.txtMKcu_TextChanged);
            // 
            // txt_MKmoi
            // 
            this.txt_MKmoi.Location = new System.Drawing.Point(12, 142);
            this.txt_MKmoi.Name = "txt_MKmoi";
            this.txt_MKmoi.Properties.PasswordChar = '*';
            this.txt_MKmoi.Size = new System.Drawing.Size(237, 20);
            this.txt_MKmoi.TabIndex = 15;
            this.txt_MKmoi.TextChanged += new System.EventHandler(this.txtMKcu_TextChanged);
            // 
            // txtMKcu
            // 
            this.txtMKcu.Location = new System.Drawing.Point(12, 92);
            this.txtMKcu.Name = "txtMKcu";
            this.txtMKcu.Properties.PasswordChar = '*';
            this.txtMKcu.Size = new System.Drawing.Size(237, 20);
            this.txtMKcu.TabIndex = 14;
            this.txtMKcu.TextChanged += new System.EventHandler(this.txtMKcu_TextChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(12, 168);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(151, 18);
            this.labelControl4.TabIndex = 13;
            this.labelControl4.Text = "Nhập lại mật khẩu mới:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(12, 118);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(94, 18);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "Mật khẩu mới:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 68);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(117, 18);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Mật khẩu hiện tại:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(26, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(223, 35);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "ĐỔI MẬT KHẨU";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // txtErro
            // 
            this.txtErro.AutoSize = true;
            this.txtErro.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtErro.ForeColor = System.Drawing.Color.Red;
            this.txtErro.Location = new System.Drawing.Point(10, 215);
            this.txtErro.Name = "txtErro";
            this.txtErro.Size = new System.Drawing.Size(0, 13);
            this.txtErro.TabIndex = 20;
            // 
            // btnLuu
            // 
            this.btnLuu.Enabled = false;
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.Location = new System.Drawing.Point(13, 238);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 39);
            this.btnLuu.TabIndex = 19;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Enabled = false;
            this.btn_reset.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_reset.ImageOptions.Image")));
            this.btn_reset.Location = new System.Drawing.Point(94, 238);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(85, 39);
            this.btn_reset.TabIndex = 18;
            this.btn_reset.Text = "Làm mới";
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.Image")));
            this.btnHuy.Location = new System.Drawing.Point(185, 238);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(65, 39);
            this.btnHuy.TabIndex = 17;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // frm_Doimatkhauu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 282);
            this.Controls.Add(this.txtErro);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.txtMKmoiRe);
            this.Controls.Add(this.txt_MKmoi);
            this.Controls.Add(this.txtMKcu);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "frm_Doimatkhauu";
            this.Text = "frm_Doimatkhauu";
            ((System.ComponentModel.ISupportInitialize)(this.txtMKmoiRe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MKmoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMKcu.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btn_reset;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.TextEdit txtMKmoiRe;
        private DevExpress.XtraEditors.TextEdit txt_MKmoi;
        private DevExpress.XtraEditors.TextEdit txtMKcu;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Label txtErro;
    }
}