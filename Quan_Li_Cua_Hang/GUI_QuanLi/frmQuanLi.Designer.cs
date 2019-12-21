namespace GUI_QuanLi
{
    partial class frmQuanLi
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
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.fLoutMonAn = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.fLoutMonNuoc = new System.Windows.Forms.FlowLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btn_DoanhThu = new System.Windows.Forms.Button();
            this.btn_DangXuat = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.fLoutMonAn.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.fLoutMonNuoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialTabControl1.Location = new System.Drawing.Point(0, 163);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1588, 825);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.fLoutMonAn);
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabPage1.Location = new System.Drawing.Point(4, 35);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(1580, 786);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Món Ăn";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // fLoutMonAn
            // 
            this.fLoutMonAn.Controls.Add(this.button1);
            this.fLoutMonAn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fLoutMonAn.Location = new System.Drawing.Point(3, 3);
            this.fLoutMonAn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fLoutMonAn.Name = "fLoutMonAn";
            this.fLoutMonAn.Size = new System.Drawing.Size(1574, 780);
            this.fLoutMonAn.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::GUI_QuanLi.Properties.Resources.plus;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(119)))), ((int)(((byte)(240)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(4, 5);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(375, 385);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.fLoutMonNuoc);
            this.tabPage2.Location = new System.Drawing.Point(4, 35);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(1580, 786);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nước";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // fLoutMonNuoc
            // 
            this.fLoutMonNuoc.Controls.Add(this.button2);
            this.fLoutMonNuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fLoutMonNuoc.Location = new System.Drawing.Point(3, 3);
            this.fLoutMonNuoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fLoutMonNuoc.Name = "fLoutMonNuoc";
            this.fLoutMonNuoc.Size = new System.Drawing.Size(1574, 780);
            this.fLoutMonNuoc.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::GUI_QuanLi.Properties.Resources.plus;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(119)))), ((int)(((byte)(240)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(4, 5);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(375, 462);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 98);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1800, 68);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(1590, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 817);
            this.panel1.TabIndex = 2;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(1644, 346);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(125, 27);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Người dùng";
            // 
            // btn_DoanhThu
            // 
            this.btn_DoanhThu.BackColor = System.Drawing.Color.Transparent;
            this.btn_DoanhThu.FlatAppearance.BorderSize = 0;
            this.btn_DoanhThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_DoanhThu.Location = new System.Drawing.Point(1636, 382);
            this.btn_DoanhThu.Name = "btn_DoanhThu";
            this.btn_DoanhThu.Size = new System.Drawing.Size(124, 46);
            this.btn_DoanhThu.TabIndex = 5;
            this.btn_DoanhThu.Text = "Doanh thu";
            this.btn_DoanhThu.UseVisualStyleBackColor = false;
            this.btn_DoanhThu.Click += new System.EventHandler(this.btn_DoanhThu_Click);
            // 
            // btn_DangXuat
            // 
            this.btn_DangXuat.BackColor = System.Drawing.Color.Transparent;
            this.btn_DangXuat.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_DangXuat.FlatAppearance.BorderSize = 0;
            this.btn_DangXuat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_DangXuat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_DangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Underline);
            this.btn_DangXuat.Location = new System.Drawing.Point(1636, 434);
            this.btn_DangXuat.Name = "btn_DangXuat";
            this.btn_DangXuat.Size = new System.Drawing.Size(120, 48);
            this.btn_DangXuat.TabIndex = 6;
            this.btn_DangXuat.Text = "Đăng xuất";
            this.btn_DangXuat.UseVisualStyleBackColor = false;
            this.btn_DangXuat.Click += new System.EventHandler(this.Btn_DangXuat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI_QuanLi.Properties.Resources.user2;
            this.pictureBox1.Location = new System.Drawing.Point(1611, 166);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(1593, 345);
            this.panel4.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(207, 2);
            this.panel4.TabIndex = 7;
            // 
            // frmQuanLi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1800, 1000);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btn_DangXuat);
            this.Controls.Add(this.btn_DoanhThu);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Name = "frmQuanLi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lí";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.fLoutMonAn.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.fLoutMonNuoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Button btn_DoanhThu;
        private System.Windows.Forms.Button btn_DangXuat;
        private System.Windows.Forms.FlowLayoutPanel fLoutMonAn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel fLoutMonNuoc;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel4;
    }
}