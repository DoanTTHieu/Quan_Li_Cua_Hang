namespace GUI_QuanLi
{
    partial class HoaDon
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_IDHD = new System.Windows.Forms.TextBox();
            this.tb_SoBan = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_ChonMon = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_ThanhToan = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tb_TongTien = new System.Windows.Forms.TextBox();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_XacNhan = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tb_IDHD);
            this.panel1.Controls.Add(this.tb_SoBan);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 22);
            this.panel1.TabIndex = 0;
            // 
            // tb_IDHD
            // 
            this.tb_IDHD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_IDHD.Dock = System.Windows.Forms.DockStyle.Right;
            this.tb_IDHD.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_IDHD.Location = new System.Drawing.Point(368, 0);
            this.tb_IDHD.Name = "tb_IDHD";
            this.tb_IDHD.Size = new System.Drawing.Size(20, 15);
            this.tb_IDHD.TabIndex = 19;
            this.tb_IDHD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_SoBan
            // 
            this.tb_SoBan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_SoBan.Dock = System.Windows.Forms.DockStyle.Left;
            this.tb_SoBan.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_SoBan.Location = new System.Drawing.Point(36, 0);
            this.tb_SoBan.Name = "tb_SoBan";
            this.tb_SoBan.Size = new System.Drawing.Size(19, 15);
            this.tb_SoBan.TabIndex = 18;
            this.tb_SoBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(0, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(36, 15);
            this.lblName.TabIndex = 20;
            this.lblName.Text = "Bàn :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 416);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(388, 34);
            this.panel2.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btn_ChonMon);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(131, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(79, 34);
            this.panel6.TabIndex = 18;
            // 
            // btn_ChonMon
            // 
            this.btn_ChonMon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_ChonMon.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_ChonMon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChonMon.ForeColor = System.Drawing.Color.Black;
            this.btn_ChonMon.Location = new System.Drawing.Point(0, 0);
            this.btn_ChonMon.Name = "btn_ChonMon";
            this.btn_ChonMon.Size = new System.Drawing.Size(79, 34);
            this.btn_ChonMon.TabIndex = 30;
            this.btn_ChonMon.Text = "Chọn Món";
            this.btn_ChonMon.UseVisualStyleBackColor = true;
            this.btn_ChonMon.Click += new System.EventHandler(this.btn_ChonMon_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_ThanhToan);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(210, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(92, 34);
            this.panel3.TabIndex = 16;
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_ThanhToan.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_ThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThanhToan.ForeColor = System.Drawing.Color.Black;
            this.btn_ThanhToan.Location = new System.Drawing.Point(0, 0);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(92, 34);
            this.btn_ThanhToan.TabIndex = 31;
            this.btn_ThanhToan.Text = "Thanh Toán";
            this.btn_ThanhToan.UseVisualStyleBackColor = true;
            this.btn_ThanhToan.Click += new System.EventHandler(this.btn_ThanhToan_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tb_TongTien);
            this.panel5.Controls.Add(this.lbTongTien);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(3, 5, 0, 0);
            this.panel5.Size = new System.Drawing.Size(134, 34);
            this.panel5.TabIndex = 15;
            // 
            // tb_TongTien
            // 
            this.tb_TongTien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_TongTien.Dock = System.Windows.Forms.DockStyle.Left;
            this.tb_TongTien.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TongTien.Location = new System.Drawing.Point(73, 5);
            this.tb_TongTien.Name = "tb_TongTien";
            this.tb_TongTien.Size = new System.Drawing.Size(54, 15);
            this.tb_TongTien.TabIndex = 16;
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbTongTien.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongTien.Location = new System.Drawing.Point(3, 5);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(70, 15);
            this.lbTongTien.TabIndex = 17;
            this.lbTongTien.Text = "Tổng Tiền :";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_XacNhan);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(302, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(86, 34);
            this.panel4.TabIndex = 17;
            // 
            // btn_XacNhan
            // 
            this.btn_XacNhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_XacNhan.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_XacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XacNhan.ForeColor = System.Drawing.Color.Black;
            this.btn_XacNhan.Location = new System.Drawing.Point(0, 0);
            this.btn_XacNhan.Name = "btn_XacNhan";
            this.btn_XacNhan.Size = new System.Drawing.Size(86, 34);
            this.btn_XacNhan.TabIndex = 32;
            this.btn_XacNhan.Text = "Xác Nhận";
            this.btn_XacNhan.UseVisualStyleBackColor = true;
            this.btn_XacNhan.Click += new System.EventHandler(this.btn_XacNhan_Click);
            // 
            // listView1
            // 
            this.listView1.AllowColumnReorder = true;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 22);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(388, 394);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên Món Ăn";
            this.columnHeader1.Width = 220;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Giá";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 106;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số Lượng";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "HoaDon";
            this.Size = new System.Drawing.Size(388, 450);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TextBox tb_IDHD;
        public System.Windows.Forms.TextBox tb_SoBan;
        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.ListView listView1;
        public System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.TextBox tb_TongTien;
        public System.Windows.Forms.Label lbTongTien;
        public System.Windows.Forms.Button btn_XacNhan;
        public System.Windows.Forms.Button btn_ChonMon;
        public System.Windows.Forms.Button btn_ThanhToan;
        public System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.ColumnHeader columnHeader1;
        public System.Windows.Forms.ColumnHeader columnHeader2;
        public System.Windows.Forms.ColumnHeader columnHeader3;
    }
}
