namespace GUI_QuanLi
{
    partial class frmTaoTaiKhoan
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
            this.lb_UserName = new MaterialSkin.Controls.MaterialLabel();
            this.lb_Password = new MaterialSkin.Controls.MaterialLabel();
            this.lb_PasswordAgain = new MaterialSkin.Controls.MaterialLabel();
            this.tb_UserName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tb_Password = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tb_PasswordAgain = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btn_TaoTaiKhoan = new MaterialSkin.Controls.MaterialRaisedButton();
            this.rbtn_NhanVien = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbtn_QuanLi = new MaterialSkin.Controls.MaterialRadioButton();
            this.btn_TroVe = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pn_MatKhauQuanLi = new System.Windows.Forms.Panel();
            this.tb_MatKhauQuanLi = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.pn_MatKhauQuanLi.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_UserName
            // 
            this.lb_UserName.AutoSize = true;
            this.lb_UserName.Depth = 0;
            this.lb_UserName.Font = new System.Drawing.Font("Roboto", 11F);
            this.lb_UserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_UserName.Location = new System.Drawing.Point(159, 148);
            this.lb_UserName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_UserName.Name = "lb_UserName";
            this.lb_UserName.Size = new System.Drawing.Size(163, 27);
            this.lb_UserName.TabIndex = 1;
            this.lb_UserName.Text = "Tên người dùng";
            // 
            // lb_Password
            // 
            this.lb_Password.AutoSize = true;
            this.lb_Password.Depth = 0;
            this.lb_Password.Font = new System.Drawing.Font("Roboto", 11F);
            this.lb_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_Password.Location = new System.Drawing.Point(159, 243);
            this.lb_Password.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_Password.Name = "lb_Password";
            this.lb_Password.Size = new System.Drawing.Size(102, 27);
            this.lb_Password.TabIndex = 2;
            this.lb_Password.Text = "Mật khẩu";
            // 
            // lb_PasswordAgain
            // 
            this.lb_PasswordAgain.AutoSize = true;
            this.lb_PasswordAgain.Depth = 0;
            this.lb_PasswordAgain.Font = new System.Drawing.Font("Roboto", 11F);
            this.lb_PasswordAgain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_PasswordAgain.Location = new System.Drawing.Point(159, 337);
            this.lb_PasswordAgain.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_PasswordAgain.Name = "lb_PasswordAgain";
            this.lb_PasswordAgain.Size = new System.Drawing.Size(195, 27);
            this.lb_PasswordAgain.TabIndex = 3;
            this.lb_PasswordAgain.Text = "Mật khẩu xác nhận";
            // 
            // tb_UserName
            // 
            this.tb_UserName.Depth = 0;
            this.tb_UserName.Hint = "";
            this.tb_UserName.Location = new System.Drawing.Point(154, 178);
            this.tb_UserName.MaxLength = 32767;
            this.tb_UserName.MouseState = MaterialSkin.MouseState.HOVER;
            this.tb_UserName.Name = "tb_UserName";
            this.tb_UserName.PasswordChar = '\0';
            this.tb_UserName.SelectedText = "";
            this.tb_UserName.SelectionLength = 0;
            this.tb_UserName.SelectionStart = 0;
            this.tb_UserName.Size = new System.Drawing.Size(432, 32);
            this.tb_UserName.TabIndex = 1;
            this.tb_UserName.TabStop = false;
            this.tb_UserName.UseSystemPasswordChar = false;
            // 
            // tb_Password
            // 
            this.tb_Password.Depth = 0;
            this.tb_Password.Hint = "";
            this.tb_Password.Location = new System.Drawing.Point(154, 273);
            this.tb_Password.MaxLength = 32767;
            this.tb_Password.MouseState = MaterialSkin.MouseState.HOVER;
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.SelectedText = "";
            this.tb_Password.SelectionLength = 0;
            this.tb_Password.SelectionStart = 0;
            this.tb_Password.Size = new System.Drawing.Size(432, 32);
            this.tb_Password.TabIndex = 2;
            this.tb_Password.TabStop = false;
            this.tb_Password.UseSystemPasswordChar = false;
            // 
            // tb_PasswordAgain
            // 
            this.tb_PasswordAgain.Depth = 0;
            this.tb_PasswordAgain.Hint = "";
            this.tb_PasswordAgain.Location = new System.Drawing.Point(163, 367);
            this.tb_PasswordAgain.MaxLength = 32767;
            this.tb_PasswordAgain.MouseState = MaterialSkin.MouseState.HOVER;
            this.tb_PasswordAgain.Name = "tb_PasswordAgain";
            this.tb_PasswordAgain.PasswordChar = '*';
            this.tb_PasswordAgain.SelectedText = "";
            this.tb_PasswordAgain.SelectionLength = 0;
            this.tb_PasswordAgain.SelectionStart = 0;
            this.tb_PasswordAgain.Size = new System.Drawing.Size(432, 32);
            this.tb_PasswordAgain.TabIndex = 3;
            this.tb_PasswordAgain.TabStop = false;
            this.tb_PasswordAgain.UseSystemPasswordChar = false;
            // 
            // btn_TaoTaiKhoan
            // 
            this.btn_TaoTaiKhoan.AutoSize = true;
            this.btn_TaoTaiKhoan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_TaoTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(119)))), ((int)(((byte)(240)))));
            this.btn_TaoTaiKhoan.Depth = 0;
            this.btn_TaoTaiKhoan.Icon = null;
            this.btn_TaoTaiKhoan.Location = new System.Drawing.Point(322, 571);
            this.btn_TaoTaiKhoan.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_TaoTaiKhoan.Name = "btn_TaoTaiKhoan";
            this.btn_TaoTaiKhoan.Primary = true;
            this.btn_TaoTaiKhoan.Size = new System.Drawing.Size(110, 36);
            this.btn_TaoTaiKhoan.TabIndex = 8;
            this.btn_TaoTaiKhoan.Text = "Đăng ký";
            this.btn_TaoTaiKhoan.UseVisualStyleBackColor = false;
            this.btn_TaoTaiKhoan.Click += new System.EventHandler(this.Btn_TaoTaiKhoan_Click1);
            // 
            // rbtn_NhanVien
            // 
            this.rbtn_NhanVien.AutoSize = true;
            this.rbtn_NhanVien.Depth = 0;
            this.rbtn_NhanVien.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbtn_NhanVien.Location = new System.Drawing.Point(168, 413);
            this.rbtn_NhanVien.Margin = new System.Windows.Forms.Padding(0);
            this.rbtn_NhanVien.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtn_NhanVien.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtn_NhanVien.Name = "rbtn_NhanVien";
            this.rbtn_NhanVien.Ripple = true;
            this.rbtn_NhanVien.Size = new System.Drawing.Size(123, 30);
            this.rbtn_NhanVien.TabIndex = 9;
            this.rbtn_NhanVien.TabStop = true;
            this.rbtn_NhanVien.Text = "Nhân viên";
            this.rbtn_NhanVien.UseVisualStyleBackColor = true;
            // 
            // rbtn_QuanLi
            // 
            this.rbtn_QuanLi.AutoSize = true;
            this.rbtn_QuanLi.Depth = 0;
            this.rbtn_QuanLi.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbtn_QuanLi.Location = new System.Drawing.Point(337, 413);
            this.rbtn_QuanLi.Margin = new System.Windows.Forms.Padding(0);
            this.rbtn_QuanLi.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtn_QuanLi.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtn_QuanLi.Name = "rbtn_QuanLi";
            this.rbtn_QuanLi.Ripple = true;
            this.rbtn_QuanLi.Size = new System.Drawing.Size(95, 30);
            this.rbtn_QuanLi.TabIndex = 10;
            this.rbtn_QuanLi.TabStop = true;
            this.rbtn_QuanLi.Text = "Quản lí";
            this.rbtn_QuanLi.UseVisualStyleBackColor = true;
            // 
            // btn_TroVe
            // 
            this.btn_TroVe.AutoSize = true;
            this.btn_TroVe.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_TroVe.Depth = 0;
            this.btn_TroVe.Icon = null;
            this.btn_TroVe.Location = new System.Drawing.Point(168, 571);
            this.btn_TroVe.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_TroVe.Name = "btn_TroVe";
            this.btn_TroVe.Primary = true;
            this.btn_TroVe.Size = new System.Drawing.Size(93, 36);
            this.btn_TroVe.TabIndex = 11;
            this.btn_TroVe.Text = "Trở về";
            this.btn_TroVe.UseVisualStyleBackColor = true;
            this.btn_TroVe.Click += new System.EventHandler(this.btn_TroVe_Click);
            // 
            // pn_MatKhauQuanLi
            // 
            this.pn_MatKhauQuanLi.Controls.Add(this.tb_MatKhauQuanLi);
            this.pn_MatKhauQuanLi.Controls.Add(this.materialLabel1);
            this.pn_MatKhauQuanLi.Location = new System.Drawing.Point(154, 457);
            this.pn_MatKhauQuanLi.Name = "pn_MatKhauQuanLi";
            this.pn_MatKhauQuanLi.Size = new System.Drawing.Size(440, 108);
            this.pn_MatKhauQuanLi.TabIndex = 4;
            // 
            // tb_MatKhauQuanLi
            // 
            this.tb_MatKhauQuanLi.Depth = 0;
            this.tb_MatKhauQuanLi.Hint = "";
            this.tb_MatKhauQuanLi.Location = new System.Drawing.Point(9, 51);
            this.tb_MatKhauQuanLi.MaxLength = 32767;
            this.tb_MatKhauQuanLi.MouseState = MaterialSkin.MouseState.HOVER;
            this.tb_MatKhauQuanLi.Name = "tb_MatKhauQuanLi";
            this.tb_MatKhauQuanLi.PasswordChar = '*';
            this.tb_MatKhauQuanLi.SelectedText = "";
            this.tb_MatKhauQuanLi.SelectionLength = 0;
            this.tb_MatKhauQuanLi.SelectionStart = 0;
            this.tb_MatKhauQuanLi.Size = new System.Drawing.Size(335, 32);
            this.tb_MatKhauQuanLi.TabIndex = 4;
            this.tb_MatKhauQuanLi.TabStop = false;
            this.tb_MatKhauQuanLi.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(10, 13);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(171, 27);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Mật khẩu quản lí";
            // 
            // frmTaoTaiKhoan
            // 
            this.AcceptButton = this.btn_TaoTaiKhoan;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 650);
            this.Controls.Add(this.pn_MatKhauQuanLi);
            this.Controls.Add(this.btn_TroVe);
            this.Controls.Add(this.rbtn_QuanLi);
            this.Controls.Add(this.rbtn_NhanVien);
            this.Controls.Add(this.btn_TaoTaiKhoan);
            this.Controls.Add(this.tb_PasswordAgain);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_UserName);
            this.Controls.Add(this.lb_PasswordAgain);
            this.Controls.Add(this.lb_Password);
            this.Controls.Add(this.lb_UserName);
            this.Name = "frmTaoTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký";
            this.pn_MatKhauQuanLi.ResumeLayout(false);
            this.pn_MatKhauQuanLi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel lb_UserName;
        private MaterialSkin.Controls.MaterialLabel lb_Password;
        private MaterialSkin.Controls.MaterialLabel lb_PasswordAgain;
        private MaterialSkin.Controls.MaterialSingleLineTextField tb_UserName;
        private MaterialSkin.Controls.MaterialSingleLineTextField tb_Password;
        private MaterialSkin.Controls.MaterialSingleLineTextField tb_PasswordAgain;
        private MaterialSkin.Controls.MaterialRaisedButton btn_TaoTaiKhoan;
        private MaterialSkin.Controls.MaterialRadioButton rbtn_NhanVien;
        private MaterialSkin.Controls.MaterialRadioButton rbtn_QuanLi;
        private MaterialSkin.Controls.MaterialRaisedButton btn_TroVe;
        private System.Windows.Forms.Panel pn_MatKhauQuanLi;
        private MaterialSkin.Controls.MaterialSingleLineTextField tb_MatKhauQuanLi;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}