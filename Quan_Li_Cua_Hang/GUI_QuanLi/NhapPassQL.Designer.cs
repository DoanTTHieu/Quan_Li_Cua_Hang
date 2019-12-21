namespace GUI_QuanLi
{
    partial class NhapPassQL
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_PasswordManeger = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lb_PasswordQL = new MaterialSkin.Controls.MaterialLabel();
            this.btn_XacNhan = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // tb_PasswordManeger
            // 
            this.tb_PasswordManeger.Depth = 0;
            this.tb_PasswordManeger.Hint = "";
            this.tb_PasswordManeger.Location = new System.Drawing.Point(45, 85);
            this.tb_PasswordManeger.Margin = new System.Windows.Forms.Padding(2);
            this.tb_PasswordManeger.MaxLength = 32767;
            this.tb_PasswordManeger.MouseState = MaterialSkin.MouseState.HOVER;
            this.tb_PasswordManeger.Name = "tb_PasswordManeger";
            this.tb_PasswordManeger.PasswordChar = '*';
            this.tb_PasswordManeger.SelectedText = "";
            this.tb_PasswordManeger.SelectionLength = 0;
            this.tb_PasswordManeger.SelectionStart = 0;
            this.tb_PasswordManeger.Size = new System.Drawing.Size(288, 23);
            this.tb_PasswordManeger.TabIndex = 8;
            this.tb_PasswordManeger.TabStop = false;
            this.tb_PasswordManeger.UseSystemPasswordChar = false;
            // 
            // lb_PasswordQL
            // 
            this.lb_PasswordQL.AutoSize = true;
            this.lb_PasswordQL.Depth = 0;
            this.lb_PasswordQL.Font = new System.Drawing.Font("Roboto", 11F);
            this.lb_PasswordQL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_PasswordQL.Location = new System.Drawing.Point(48, 65);
            this.lb_PasswordQL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_PasswordQL.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_PasswordQL.Name = "lb_PasswordQL";
            this.lb_PasswordQL.Size = new System.Drawing.Size(125, 19);
            this.lb_PasswordQL.TabIndex = 7;
            this.lb_PasswordQL.Text = "Mật khẩu Quản Lí";
            // 
            // btn_XacNhan
            // 
            this.btn_XacNhan.AutoSize = true;
            this.btn_XacNhan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_XacNhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(119)))), ((int)(((byte)(240)))));
            this.btn_XacNhan.Depth = 0;
            this.btn_XacNhan.Icon = null;
            this.btn_XacNhan.Location = new System.Drawing.Point(146, 112);
            this.btn_XacNhan.Margin = new System.Windows.Forms.Padding(2);
            this.btn_XacNhan.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_XacNhan.Name = "btn_XacNhan";
            this.btn_XacNhan.Primary = true;
            this.btn_XacNhan.Size = new System.Drawing.Size(90, 36);
            this.btn_XacNhan.TabIndex = 9;
            this.btn_XacNhan.Text = "Xác Nhận";
            this.btn_XacNhan.UseVisualStyleBackColor = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(155, 0);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(81, 19);
            this.materialLabel1.TabIndex = 10;
            this.materialLabel1.Text = "Thông Báo";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(20, 31);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(342, 21);
            this.materialLabel2.TabIndex = 11;
            this.materialLabel2.Text = "Nhập Mật Khẩu Quản Lí Mới Được Tạo Tài Khoản ";
            // 
            // NhapPassQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btn_XacNhan);
            this.Controls.Add(this.tb_PasswordManeger);
            this.Controls.Add(this.lb_PasswordQL);
            this.Name = "NhapPassQL";
            this.Size = new System.Drawing.Size(382, 166);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField tb_PasswordManeger;
        private MaterialSkin.Controls.MaterialLabel lb_PasswordQL;
        private MaterialSkin.Controls.MaterialRaisedButton btn_XacNhan;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}
