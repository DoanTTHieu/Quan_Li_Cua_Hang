namespace GUI_QuanLi
{
    partial class TestForm
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
            this.qL_UserControl1 = new GUI_QuanLi.QL_UserControl();
            this.quanLy_Nuoc1 = new GUI_QuanLi.QuanLy_Nuoc();
            this.quanLy_Nuoc2 = new GUI_QuanLi.QuanLy_Nuoc();
            this.SuspendLayout();
            // 
            // qL_UserControl1
            // 
            this.qL_UserControl1.BackColor = System.Drawing.SystemColors.Window;
            this.qL_UserControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.qL_UserControl1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.qL_UserControl1.Location = new System.Drawing.Point(0, 0);
            this.qL_UserControl1.Name = "qL_UserControl1";
            this.qL_UserControl1.Size = new System.Drawing.Size(250, 250);
            this.qL_UserControl1.TabIndex = 0;
            // 
            // quanLy_Nuoc1
            // 
            this.quanLy_Nuoc1.BackColor = System.Drawing.SystemColors.Window;
            this.quanLy_Nuoc1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.quanLy_Nuoc1.Location = new System.Drawing.Point(256, 0);
            this.quanLy_Nuoc1.Name = "quanLy_Nuoc1";
            this.quanLy_Nuoc1.Size = new System.Drawing.Size(250, 300);
            this.quanLy_Nuoc1.TabIndex = 1;
            // 
            // quanLy_Nuoc2
            // 
            this.quanLy_Nuoc2.BackColor = System.Drawing.SystemColors.Window;
            this.quanLy_Nuoc2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.quanLy_Nuoc2.Location = new System.Drawing.Point(512, 0);
            this.quanLy_Nuoc2.Name = "quanLy_Nuoc2";
            this.quanLy_Nuoc2.Size = new System.Drawing.Size(250, 300);
            this.quanLy_Nuoc2.TabIndex = 2;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 450);
            this.Controls.Add(this.quanLy_Nuoc2);
            this.Controls.Add(this.quanLy_Nuoc1);
            this.Controls.Add(this.qL_UserControl1);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.Load += new System.EventHandler(this.TestForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private QL_UserControl qL_UserControl1;
        private QuanLy_Nuoc quanLy_Nuoc1;
        private QuanLy_Nuoc quanLy_Nuoc2;
    }
}