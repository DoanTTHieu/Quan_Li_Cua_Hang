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
            this.lvCTHD = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tb_TongTien = new System.Windows.Forms.TextBox();
            this.btn_ThanhToan = new System.Windows.Forms.Button();
            this.btn_ChonMon = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_SoBan = new System.Windows.Forms.TextBox();
            this.tb_IDHD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_XacNhan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvCTHD
            // 
            this.lvCTHD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvCTHD.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvCTHD.GridLines = true;
            this.lvCTHD.HideSelection = false;
            this.lvCTHD.Location = new System.Drawing.Point(3, 29);
            this.lvCTHD.Name = "lvCTHD";
            this.lvCTHD.Size = new System.Drawing.Size(294, 391);
            this.lvCTHD.TabIndex = 0;
            this.lvCTHD.UseCompatibleStateImageBehavior = false;
            this.lvCTHD.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên Món Ăn";
            this.columnHeader1.Width = 173;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Giá ";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số Lượng";
            // 
            // tb_TongTien
            // 
            this.tb_TongTien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_TongTien.Location = new System.Drawing.Point(3, 426);
            this.tb_TongTien.Name = "tb_TongTien";
            this.tb_TongTien.Size = new System.Drawing.Size(86, 13);
            this.tb_TongTien.TabIndex = 1;
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThanhToan.Location = new System.Drawing.Point(208, 421);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(89, 23);
            this.btn_ThanhToan.TabIndex = 2;
            this.btn_ThanhToan.Text = "Thanh Toán";
            this.btn_ThanhToan.UseVisualStyleBackColor = true;
            // 
            // btn_ChonMon
            // 
            this.btn_ChonMon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChonMon.Location = new System.Drawing.Point(127, 421);
            this.btn_ChonMon.Name = "btn_ChonMon";
            this.btn_ChonMon.Size = new System.Drawing.Size(75, 23);
            this.btn_ChonMon.TabIndex = 3;
            this.btn_ChonMon.Text = "Thêm Món";
            this.btn_ChonMon.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(3, 438);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(86, 1);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "VNĐ";
            // 
            // tb_SoBan
            // 
            this.tb_SoBan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_SoBan.Location = new System.Drawing.Point(26, 10);
            this.tb_SoBan.Name = "tb_SoBan";
            this.tb_SoBan.Size = new System.Drawing.Size(38, 13);
            this.tb_SoBan.TabIndex = 6;
            // 
            // tb_IDHD
            // 
            this.tb_IDHD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_IDHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_IDHD.Location = new System.Drawing.Point(276, 10);
            this.tb_IDHD.Name = "tb_IDHD";
            this.tb_IDHD.Size = new System.Drawing.Size(21, 13);
            this.tb_IDHD.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Bàn";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(26, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(38, 1);
            this.panel2.TabIndex = 9;
            // 
            // btn_XacNhan
            // 
            this.btn_XacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XacNhan.Location = new System.Drawing.Point(208, 421);
            this.btn_XacNhan.Name = "btn_XacNhan";
            this.btn_XacNhan.Size = new System.Drawing.Size(89, 23);
            this.btn_XacNhan.TabIndex = 10;
            this.btn_XacNhan.Text = "Xác Nhận";
            this.btn_XacNhan.UseVisualStyleBackColor = true;
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_XacNhan);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_IDHD);
            this.Controls.Add(this.tb_SoBan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_ChonMon);
            this.Controls.Add(this.btn_ThanhToan);
            this.Controls.Add(this.tb_TongTien);
            this.Controls.Add(this.lvCTHD);
            this.Name = "HoaDon";
            this.Size = new System.Drawing.Size(300, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListView lvCTHD;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        public System.Windows.Forms.TextBox tb_TongTien;
        public System.Windows.Forms.Button btn_ThanhToan;
        public System.Windows.Forms.Button btn_ChonMon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tb_SoBan;
        public System.Windows.Forms.TextBox tb_IDHD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button btn_XacNhan;
    }
}
