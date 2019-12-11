using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QuanLi
{
    public partial class frmQuanLi : MaterialForm
    {
        public frmQuanLi()
        {
            InitializeComponent();
        }

        private void Btn_DangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                frmDangNhap frm = new frmDangNhap();
                frm.ShowDialog();
                this.Close();
            }
            return;
        }

        private void btn_DoanhThu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDoanhThu frm = new frmDoanhThu();
            frm.ShowDialog();
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Point startpoint = new Point(1, 0);
            QL_UserControl monan = new QL_UserControl();
            monan.Location = new Point(startpoint.X + 250, startpoint.Y);
            //<tên giao diện>.Controls.Add(monan)
            startpoint.X += 250;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Point startpoint = new Point(1, 20);
            QuanLy_Nuoc nuoc = new QuanLy_Nuoc();
            nuoc.Location = new Point(startpoint.X + 250, startpoint.Y);
            //<tên giao diện>.Controls.Add(monan)
            startpoint.X += 250;
        }
    }
}
