using System.Drawing;
namespace GUI_QuanLi
{
    partial class frmDangNhap
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
            this.UserName = new MaterialSkin.Controls.MaterialLabel();
            this.tb_UserName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.tb_Password = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btn_DangNhap = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_TaoTaiKhoan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.BackColor = System.Drawing.Color.Transparent;
            this.UserName.Depth = 0;
            this.UserName.Font = new System.Drawing.Font("Roboto", 11F);
            this.UserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UserName.Location = new System.Drawing.Point(197, 272);
            this.UserName.MouseState = MaterialSkin.MouseState.HOVER;
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(111, 27);
            this.UserName.TabIndex = 0;
            this.UserName.Text = "Username";
            // 
            // tb_UserName
            // 
            this.tb_UserName.Depth = 0;
            this.tb_UserName.Hint = "";
            this.tb_UserName.Location = new System.Drawing.Point(202, 313);
            this.tb_UserName.MaxLength = 32767;
            this.tb_UserName.MouseState = MaterialSkin.MouseState.HOVER;
            this.tb_UserName.Name = "tb_UserName";
            this.tb_UserName.PasswordChar = '\0';
            this.tb_UserName.SelectedText = "";
            this.tb_UserName.SelectionLength = 0;
            this.tb_UserName.SelectionStart = 0;
            this.tb_UserName.Size = new System.Drawing.Size(350, 32);
            this.tb_UserName.TabIndex = 1;
            this.tb_UserName.TabStop = false;
            this.tb_UserName.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(199, 357);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(109, 27);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Password";
            // 
            // tb_Password
            // 
            this.tb_Password.Depth = 0;
            this.tb_Password.Hint = "";
            this.tb_Password.Location = new System.Drawing.Point(202, 397);
            this.tb_Password.MaxLength = 32767;
            this.tb_Password.MouseState = MaterialSkin.MouseState.HOVER;
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.SelectedText = "";
            this.tb_Password.SelectionLength = 0;
            this.tb_Password.SelectionStart = 0;
            this.tb_Password.Size = new System.Drawing.Size(350, 32);
            this.tb_Password.TabIndex = 3;
            this.tb_Password.TabStop = false;
            this.tb_Password.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(156, 588);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(183, 27);
            this.materialLabel1.TabIndex = 6;
            this.materialLabel1.Text = "New to Manager?";
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.AutoSize = true;
            this.btn_DangNhap.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_DangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(126)))), ((int)(((byte)(230)))));
            this.btn_DangNhap.Depth = 0;
            this.btn_DangNhap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_DangNhap.Icon = null;
            this.btn_DangNhap.Location = new System.Drawing.Point(260, 502);
            this.btn_DangNhap.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Primary = true;
            this.btn_DangNhap.Size = new System.Drawing.Size(88, 36);
            this.btn_DangNhap.TabIndex = 8;
            this.btn_DangNhap.Text = "LOG IN";
            this.btn_DangNhap.UseVisualStyleBackColor = false;
            this.btn_DangNhap.Click += new System.EventHandler(this.Btn_DangNhap_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI_QuanLi.Properties.Resources.user2;
            this.pictureBox1.Location = new System.Drawing.Point(239, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btn_TaoTaiKhoan
            // 
            this.btn_TaoTaiKhoan.BackColor = System.Drawing.Color.White;
            this.btn_TaoTaiKhoan.FlatAppearance.BorderSize = 0;
            this.btn_TaoTaiKhoan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_TaoTaiKhoan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_TaoTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TaoTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_TaoTaiKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(119)))), ((int)(((byte)(240)))));
            this.btn_TaoTaiKhoan.Location = new System.Drawing.Point(344, 584);
            this.btn_TaoTaiKhoan.Name = "btn_TaoTaiKhoan";
            this.btn_TaoTaiKhoan.Size = new System.Drawing.Size(207, 36);
            this.btn_TaoTaiKhoan.TabIndex = 9;
            this.btn_TaoTaiKhoan.Text = "Create an account.";
            this.btn_TaoTaiKhoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_TaoTaiKhoan.UseCompatibleTextRendering = true;
            this.btn_TaoTaiKhoan.UseVisualStyleBackColor = false;
            this.btn_TaoTaiKhoan.Click += new System.EventHandler(this.btn_TaoTaiKhoan_Click);
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 650);
            this.Controls.Add(this.btn_TaoTaiKhoan);
            this.Controls.Add(this.btn_DangNhap);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.tb_UserName);
            this.Controls.Add(this.UserName);
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign in";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    

        #endregion

        private MaterialSkin.Controls.MaterialLabel UserName;
        private MaterialSkin.Controls.MaterialSingleLineTextField tb_UserName;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField tb_Password;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton btn_DangNhap;
        private System.Windows.Forms.Button btn_TaoTaiKhoan;
    }
}