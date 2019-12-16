namespace GUI_QuanLi
{
    partial class frmDoanhThu
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
            this.ngay = new System.Windows.Forms.DateTimePicker();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.tb_SLHD = new System.Windows.Forms.TextBox();
            this.tb_TongTien = new System.Windows.Forms.TextBox();
            this.btn_Xem = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowDSHD = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ngay
            // 
            this.ngay.CustomFormat = "dd/MM/yyyy";
            this.ngay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngay.Location = new System.Drawing.Point(11, 71);
            this.ngay.Margin = new System.Windows.Forms.Padding(2);
            this.ngay.Name = "ngay";
            this.ngay.Size = new System.Drawing.Size(183, 24);
            this.ngay.TabIndex = 0;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(974, 593);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(132, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Số lượng hóa đơn:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(974, 618);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(117, 19);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Tổng doanh thu:";
            // 
            // tb_SLHD
            // 
            this.tb_SLHD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_SLHD.Enabled = false;
            this.tb_SLHD.Location = new System.Drawing.Point(1101, 597);
            this.tb_SLHD.Margin = new System.Windows.Forms.Padding(2);
            this.tb_SLHD.Name = "tb_SLHD";
            this.tb_SLHD.Size = new System.Drawing.Size(88, 13);
            this.tb_SLHD.TabIndex = 5;
            this.tb_SLHD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_TongTien
            // 
            this.tb_TongTien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_TongTien.Enabled = false;
            this.tb_TongTien.Location = new System.Drawing.Point(1087, 623);
            this.tb_TongTien.Margin = new System.Windows.Forms.Padding(2);
            this.tb_TongTien.Name = "tb_TongTien";
            this.tb_TongTien.Size = new System.Drawing.Size(72, 13);
            this.tb_TongTien.TabIndex = 6;
            // 
            // btn_Xem
            // 
            this.btn_Xem.BackColor = System.Drawing.Color.White;
            this.btn_Xem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xem.Location = new System.Drawing.Point(199, 72);
            this.btn_Xem.Name = "btn_Xem";
            this.btn_Xem.Size = new System.Drawing.Size(75, 23);
            this.btn_Xem.TabIndex = 7;
            this.btn_Xem.Text = "Xem";
            this.btn_Xem.UseVisualStyleBackColor = false;
            this.btn_Xem.Click += new System.EventHandler(this.btn_Xem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(1101, 611);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(88, 1);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(1085, 635);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(104, 1);
            this.panel3.TabIndex = 9;
            // 
            // flowDSHD
            // 
            this.flowDSHD.AutoScroll = true;
            this.flowDSHD.Location = new System.Drawing.Point(11, 100);
            this.flowDSHD.Name = "flowDSHD";
            this.flowDSHD.Size = new System.Drawing.Size(1177, 490);
            this.flowDSHD.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1155, 621);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "VND";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.White;
            this.btn_Thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Thoat.Location = new System.Drawing.Point(280, 71);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_Thoat.TabIndex = 19;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // frmDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowDSHD);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_Xem);
            this.Controls.Add(this.tb_TongTien);
            this.Controls.Add(this.tb_SLHD);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.ngay);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doanh Thu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker ngay;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.TextBox tb_SLHD;
        private System.Windows.Forms.TextBox tb_TongTien;
        private System.Windows.Forms.Button btn_Xem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowDSHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Thoat;
    }
}