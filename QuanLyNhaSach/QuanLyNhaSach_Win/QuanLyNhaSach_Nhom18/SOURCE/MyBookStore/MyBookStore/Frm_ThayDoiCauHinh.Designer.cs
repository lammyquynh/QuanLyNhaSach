namespace MyBookStore
{
    partial class Frm_ThayDoiCauHinh
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
            this.Label5 = new System.Windows.Forms.Label();
            this.Combo_database = new System.Windows.Forms.ComboBox();
            this.cb_ServerName = new System.Windows.Forms.ComboBox();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.White;
            this.Label5.Location = new System.Drawing.Point(81, 11);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(364, 72);
            this.Label5.TabIndex = 63;
            this.Label5.Text = "CẬP NHẬP \r\nTHÔNG TIN CẤU HÌNH";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Combo_database
            // 
            this.Combo_database.FormattingEnabled = true;
            this.Combo_database.Location = new System.Drawing.Point(183, 181);
            this.Combo_database.Name = "Combo_database";
            this.Combo_database.Size = new System.Drawing.Size(268, 21);
            this.Combo_database.TabIndex = 62;
            // 
            // cb_ServerName
            // 
            this.cb_ServerName.FormattingEnabled = true;
            this.cb_ServerName.Location = new System.Drawing.Point(183, 97);
            this.cb_ServerName.Name = "cb_ServerName";
            this.cb_ServerName.Size = new System.Drawing.Size(268, 21);
            this.cb_ServerName.TabIndex = 61;
            this.cb_ServerName.DropDown += new System.EventHandler(this.cb_ServerName_DropDown);
            // 
            // txt_Username
            // 
            this.txt_Username.Location = new System.Drawing.Point(183, 124);
            this.txt_Username.Multiline = true;
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(268, 23);
            this.txt_Username.TabIndex = 60;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(67, 97);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(106, 22);
            this.Label4.TabIndex = 59;
            this.Label4.Text = "Tên Server:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(36, 125);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(137, 22);
            this.Label3.TabIndex = 58;
            this.Label3.Text = "Tên đăng nhập:";
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.White;
            this.btn_cancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(340, 213);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(111, 45);
            this.btn_cancel.TabIndex = 57;
            this.btn_cancel.Text = "Hủy";
            this.btn_cancel.UseVisualStyleBackColor = false;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.White;
            this.btn_save.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(183, 213);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(111, 45);
            this.btn_save.TabIndex = 56;
            this.btn_save.Text = "Lưu lại";
            this.btn_save.UseVisualStyleBackColor = false;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(183, 153);
            this.txt_Password.Multiline = true;
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(268, 22);
            this.txt_Password.TabIndex = 55;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(44, 181);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(129, 22);
            this.Label2.TabIndex = 54;
            this.Label2.Text = "Tên Database:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(78, 153);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(95, 22);
            this.Label1.TabIndex = 53;
            this.Label1.Text = "Mật khẩu:";
            // 
            // Frm_ThayDoiCauHinh
            // 
            this.Appearance.BackColor = System.Drawing.Color.YellowGreen;
            this.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 274);
            this.ControlBox = false;
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Combo_database);
            this.Controls.Add(this.cb_ServerName);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "Frm_ThayDoiCauHinh";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.ComboBox Combo_database;
        internal System.Windows.Forms.ComboBox cb_ServerName;
        internal System.Windows.Forms.TextBox txt_Username;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Button btn_cancel;
        internal System.Windows.Forms.Button btn_save;
        internal System.Windows.Forms.TextBox txt_Password;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
    }
}