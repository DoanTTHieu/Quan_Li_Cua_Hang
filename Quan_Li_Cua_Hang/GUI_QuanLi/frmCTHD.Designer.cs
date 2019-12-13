namespace GUI_QuanLi
{
    partial class frmCTHD
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.fLoutMonAn = new System.Windows.Forms.FlowLayoutPanel();
            this.fLoutMonNuoc = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.materialTabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialTabControl1.Location = new System.Drawing.Point(-1, 36);
            this.materialTabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(800, 617);
            this.materialTabControl1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(799, 36);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 618);
            this.panel1.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.fLoutMonNuoc);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(792, 586);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nước";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.fLoutMonAn);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(792, 586);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Món Ăn";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(-1, 0);
            this.materialTabSelector1.Margin = new System.Windows.Forms.Padding(2);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1201, 32);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // fLoutMonAn
            // 
            this.fLoutMonAn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fLoutMonAn.Location = new System.Drawing.Point(2, 2);
            this.fLoutMonAn.Name = "fLoutMonAn";
            this.fLoutMonAn.Size = new System.Drawing.Size(788, 582);
            this.fLoutMonAn.TabIndex = 0;
            // 
            // fLoutMonNuoc
            // 
            this.fLoutMonNuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fLoutMonNuoc.Location = new System.Drawing.Point(2, 2);
            this.fLoutMonNuoc.Name = "fLoutMonNuoc";
            this.fLoutMonNuoc.Size = new System.Drawing.Size(788, 582);
            this.fLoutMonNuoc.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(854, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 486);
            this.panel2.TabIndex = 3;
            // 
            // btn_Huy
            // 
            this.btn_Huy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Huy.Location = new System.Drawing.Point(1069, 77);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(85, 23);
            this.btn_Huy.TabIndex = 4;
            this.btn_Huy.Text = "Hủy Hóa Đơn";
            this.btn_Huy.UseVisualStyleBackColor = true;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // frmCTHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmCTHD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCTHD";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.FlowLayoutPanel fLoutMonAn;
        private System.Windows.Forms.FlowLayoutPanel fLoutMonNuoc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Huy;
    }
}