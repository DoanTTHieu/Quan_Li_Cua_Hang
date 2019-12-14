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
using DTO_QuanLi;
using BUS_QuanLi;

namespace GUI_QuanLi
{
    public partial class frmNhanVien : MaterialForm
    {
        BUS_HoaDon hd = new BUS_HoaDon();
        public frmNhanVien()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager manager = MaterialSkin.MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            manager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue300, MaterialSkin.Primary.Blue500, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.LightBlue400, MaterialSkin.TextShade.WHITE);
            loadHoaDon();
        }

        private void Btn_Thoat_Click(object sender, EventArgs e)
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

        private void btn_ThemHoaDon_Click(object sender, EventArgs e)
        {
            hd.TaoHoaDon();
            frmCTHD frm = new frmCTHD(0);
            frm.ShowDialog();
        }

        private void loadHoaDon()
        {
            foreach (DataRow row in hd.LayHoaDon().Rows)
            {
                HoaDon hoadon = new HoaDon();
                hoadon.tb_IDHD.Text = row["mahd"].ToString();
                hoadon.tb_SoBan.Text = row["ban"].ToString();
                hoadon.tb_TongTien.Text = row["trigia"].ToString();
                hoadon.tb_IDHD.Enabled = false;
                hoadon.tb_SoBan.Enabled = false;
                hoadon.tb_TongTien.Enabled = false;
                this.flowHoaDon.Controls.Add(hoadon);
                hoadon.Size = new Size(300, 450);
                hoadon.panel3.Size = new Size(75, 23);
                hoadon.panel4.Visible = false;
                hoadon.panel6.Size = new Size(75, 23);
                hoadon.columnHeader1.Width = 145;
                hoadon.columnHeader2.Width = 75;
                hoadon.columnHeader3.Width = 80;
                hoadon.btn_ChonMon.Click += Btn_ChonMon_Click;
                hoadon.btn_ThanhToan.Click += Btn_ThanhToan_Click;
            }
        }

        private void Btn_ThanhToan_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNhanVien frm = new frmNhanVien();
            frm.ShowDialog();
            this.Close();
        }

        private void Btn_ChonMon_Click(object sender, EventArgs e)
        {
            this.Hide();

            this.Close();
        }
    }
}
