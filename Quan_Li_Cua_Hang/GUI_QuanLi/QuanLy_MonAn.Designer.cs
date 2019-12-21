namespace GUI_QuanLi
{
    partial class QuanLy_MonAn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLy_MonAn));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_idmonan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxGia = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.tbxTen = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tbSL = new System.Windows.Forms.TextBox();
            this.lbSL = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAddbill = new System.Windows.Forms.Button();
            this.picture = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnDel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(453, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(237, 78);
            this.panel2.TabIndex = 11;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.Window;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.SystemColors.Window;
            this.btnBack.Image = global::GUI_QuanLi.Properties.Resources.icons8_undo_50px;
            this.btnBack.Location = new System.Drawing.Point(9, 3);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 75);
            this.btnBack.TabIndex = 5;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(168, 5);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(68, 74);
            this.btnSave.TabIndex = 7;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnDel
            // 
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.Location = new System.Drawing.Point(88, 5);
            this.btnDel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(70, 75);
            this.btnDel.TabIndex = 6;
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnEdit);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(390, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(63, 78);
            this.panel4.TabIndex = 12;
            // 
            // btnEdit
            // 
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(4, 5);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(54, 69);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tb_idmonan);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbxGia);
            this.panel1.Controls.Add(this.lblPrice);
            this.panel1.Controls.Add(this.tbxTen);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(4, 8, 0, 0);
            this.panel1.Size = new System.Drawing.Size(690, 38);
            this.panel1.TabIndex = 13;
            // 
            // tb_idmonan
            // 
            this.tb_idmonan.Location = new System.Drawing.Point(652, 3);
            this.tb_idmonan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_idmonan.Name = "tb_idmonan";
            this.tb_idmonan.Size = new System.Drawing.Size(31, 26);
            this.tb_idmonan.TabIndex = 18;
            this.tb_idmonan.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "VND";
            // 
            // tbxGia
            // 
            this.tbxGia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxGia.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbxGia.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxGia.Location = new System.Drawing.Point(179, 8);
            this.tbxGia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxGia.Name = "tbxGia";
            this.tbxGia.Size = new System.Drawing.Size(66, 23);
            this.tbxGia.TabIndex = 13;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblPrice.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(131, 8);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(48, 23);
            this.lblPrice.TabIndex = 16;
            this.lblPrice.Text = "Giá:";
            // 
            // tbxTen
            // 
            this.tbxTen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxTen.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbxTen.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTen.Location = new System.Drawing.Point(53, 8);
            this.tbxTen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxTen.Name = "tbxTen";
            this.tbxTen.Size = new System.Drawing.Size(78, 23);
            this.tbxTen.TabIndex = 11;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(4, 8);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 23);
            this.lblName.TabIndex = 15;
            this.lblName.Text = "Tên:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel5);
            this.panel6.Controls.Add(this.panel3);
            this.panel6.Controls.Add(this.panel4);
            this.panel6.Controls.Add(this.panel2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 497);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(690, 78);
            this.panel6.TabIndex = 14;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tbSL);
            this.panel5.Controls.Add(this.lbSL);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(4, 8, 0, 0);
            this.panel5.Size = new System.Drawing.Size(327, 80);
            this.panel5.TabIndex = 14;
            // 
            // tbSL
            // 
            this.tbSL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSL.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbSL.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSL.Location = new System.Drawing.Point(103, 8);
            this.tbSL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSL.Name = "tbSL";
            this.tbSL.Size = new System.Drawing.Size(45, 23);
            this.tbSL.TabIndex = 16;
            // 
            // lbSL
            // 
            this.lbSL.AutoSize = true;
            this.lbSL.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbSL.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSL.Location = new System.Drawing.Point(4, 8);
            this.lbSL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSL.Name = "lbSL";
            this.lbSL.Size = new System.Drawing.Size(99, 23);
            this.lbSL.TabIndex = 17;
            this.lbSL.Text = "Số Lượng:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnAddbill);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(327, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(63, 78);
            this.panel3.TabIndex = 13;
            // 
            // btnAddbill
            // 
            this.btnAddbill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddbill.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAddbill.Image = ((System.Drawing.Image)(resources.GetObject("btnAddbill.Image")));
            this.btnAddbill.Location = new System.Drawing.Point(4, 5);
            this.btnAddbill.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddbill.Name = "btnAddbill";
            this.btnAddbill.Size = new System.Drawing.Size(54, 69);
            this.btnAddbill.TabIndex = 29;
            this.btnAddbill.UseVisualStyleBackColor = true;
            this.btnAddbill.Click += new System.EventHandler(this.btnAddbill_Click);
            // 
            // picture
            // 
            this.picture.BackgroundImage = global::GUI_QuanLi.Properties.Resources.icons8_add_50px_1;
            this.picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picture.Location = new System.Drawing.Point(0, 38);
            this.picture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(690, 459);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            this.picture.Click += new System.EventHandler(this.BtnPic_Click);
            // 
            // QuanLy_MonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.picture);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "QuanLy_MonAn";
            this.Size = new System.Drawing.Size(690, 575);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Button btnBack;
        public System.Windows.Forms.Button btnDel;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblName;
        public System.Windows.Forms.TextBox tbxGia;
        public System.Windows.Forms.TextBox tbxTen;
        private System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAddbill;
        public System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.TextBox tbSL;
        private System.Windows.Forms.Label lbSL;
        public System.Windows.Forms.TextBox tb_idmonan;
    }
}
