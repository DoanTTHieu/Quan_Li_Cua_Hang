namespace GUI_QuanLi
{
    partial class frmNhanVien
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowHoaDon = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_ThemHoaDon = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowHoaDon.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btn_Thoat);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1009, 65);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 650);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(1, 144);
            this.panel4.Margin = new System.Windows.Forms.Padding(6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 1);
            this.panel4.TabIndex = 1;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.White;
            this.btn_Thoat.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Thoat.FlatAppearance.BorderSize = 0;
            this.btn_Thoat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_Thoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_Thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Thoat.Location = new System.Drawing.Point(48, 189);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(104, 31);
            this.btn_Thoat.TabIndex = 2;
            this.btn_Thoat.Text = "Log Out";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.Btn_Thoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 151);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::GUI_QuanLi.Properties.Resources.user2;
            this.pictureBox1.Location = new System.Drawing.Point(37, 19);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(1005, 65);
            this.panel3.Margin = new System.Windows.Forms.Padding(6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 650);
            this.panel3.TabIndex = 1;
            // 
            // flowHoaDon
            // 
            this.flowHoaDon.AutoScroll = true;
            this.flowHoaDon.Controls.Add(this.btn_ThemHoaDon);
            this.flowHoaDon.Location = new System.Drawing.Point(4, 65);
            this.flowHoaDon.Name = "flowHoaDon";
            this.flowHoaDon.Size = new System.Drawing.Size(998, 581);
            this.flowHoaDon.TabIndex = 2;
            // 
            // btn_ThemHoaDon
            // 
            this.btn_ThemHoaDon.BackgroundImage = global::GUI_QuanLi.Properties.Resources.plus;
            this.btn_ThemHoaDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_ThemHoaDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ThemHoaDon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(119)))), ((int)(((byte)(240)))));
            this.btn_ThemHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThemHoaDon.Location = new System.Drawing.Point(4, 4);
            this.btn_ThemHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ThemHoaDon.Name = "btn_ThemHoaDon";
            this.btn_ThemHoaDon.Size = new System.Drawing.Size(300, 450);
            this.btn_ThemHoaDon.TabIndex = 1;
            this.btn_ThemHoaDon.UseVisualStyleBackColor = true;
            this.btn_ThemHoaDon.Click += new System.EventHandler(this.btn_ThemHoaDon_Click);
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.flowHoaDon);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân Viên";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowHoaDon.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.FlowLayoutPanel flowHoaDon;
        private System.Windows.Forms.Button btn_ThemHoaDon;
    }
}