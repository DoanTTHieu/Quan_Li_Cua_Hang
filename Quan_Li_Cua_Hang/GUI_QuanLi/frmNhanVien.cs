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
            this.DoubleBuffered = true;
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
                HoaDon hd = new HoaDon();
                hd.tb_IDHD.Text = row["mahd"].ToString();
                hd.tb_SoBan.Text = row["ban"].ToString();
                hd.tb_TongTien.Text = row["trigia"].ToString();
                hd.panel4.Visible = false;
                hd.tb_IDHD.Enabled = false;
                hd.tb_SoBan.Enabled = false;
                hd.tb_TongTien.Enabled = false;
                hd.panel3.Size = new Size(55, 23);
                hd.panel6.Size = new Size(55, 23);
                hd.columnHeader1.Width = 145;
                hd.columnHeader2.Width = 75;
                hd.columnHeader3.Width = 80;
                this.flowDSHoaDon.Controls.Add(hd);
                hd.Size = new Size(300, 450);
                hd.btn_ThanhToan.Click += Btn_ThanhToan_Click;
            }
        }

        private void Btn_ThanhToan_Click(object sender, EventArgs e)
        {
            frmNhanVien frm = new frmNhanVien();
            frm.ShowDialog();
            this.Close();
            //foreach (UserControl item in this.Controls.OfType<HoaDon>())
            //{
            //    this.flowDSHoaDon.Controls.Remove(item);
            //    item.Dispose();
            //}
            //loadHoaDon();
        }
    }
}
