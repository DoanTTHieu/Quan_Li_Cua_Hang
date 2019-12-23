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
        BUS_CTHD ct = new BUS_CTHD();
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
            DialogResult result = MessageBox.Show("Bạn Có Muốn Thoát Không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
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
            this.Hide();
            hd.TaoHoaDon();
            int mahdtam = hd.LayIDHoaDon();
            frmCTHD frm = new frmCTHD(mahdtam);
            frm.ShowDialog();
            this.Close();
        }

        private void loadHoaDon()
        {
            foreach (DataRow row in hd.LayHoaDon().Rows)
            {
                float tien = 0;
                HoaDon hoadon = new HoaDon();
                hoadon.Tag = row["mahd"].ToString();
                hoadon.tb_IDHD.Text = row["mahd"].ToString();
                hoadon.tb_SoBan.Text = row["ban"].ToString();
                hoadon.tb_IDHD.Enabled = false;
                hoadon.tb_SoBan.Enabled = false;
                hoadon.tb_TongTien.Enabled = false;
                foreach(DataRow row1 in ct.LayCTHD(int.Parse(hoadon.tb_IDHD.Text)).Rows)
                {
                    double gia = Convert.ToDouble(row1["gia"]);
                    double sl = Convert.ToDouble(row1["solg"]);
                    ListViewItem item = new ListViewItem();
                    item.Text = row1["tenmon"].ToString();
                    item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = gia.ToString() });
                    item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = row1["solg"].ToString() });
                    hoadon.listView1.Items.Add(item);
                    hoadon.tb_TongTien.Text = (tien + gia*sl).ToString();
                    tien = float.Parse(hoadon.tb_TongTien.Text);
                    hd.CapNhatHoaDonv2(tien, int.Parse(hoadon.tb_IDHD.Text),int.Parse(hoadon.tb_SoBan.Text));
                }
                this.flowHoaDon.Controls.Add(hoadon);               
                hoadon.Size = new Size(300, 450);
                hoadon.panel3.Size = new Size(65, 23);
                hoadon.panel5.Size = new Size(100, 23);
                hoadon.panel4.Visible = false;
                hoadon.panel6.Size = new Size(65, 23);
                hoadon.columnHeader1.Width = 130;
                hoadon.columnHeader2.Width = 85;
                hoadon.columnHeader3.Width = 80;
                hoadon.btn_ThanhToan.Click += Btn_ThanhToan_Click;
                hoadon.ClickHoaDon += Hoadon_ClickHoaDon;
            }
        }
        private void Hoadon_ClickHoaDon(string mahd)
        {
            this.Hide();
            frmCTHD frm = new frmCTHD(int.Parse(mahd));
            frm.ShowDialog();
            this.Close();
        }

        private void Btn_ThanhToan_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNhanVien frm = new frmNhanVien();
            frm.ShowDialog();
            this.Close();
        }
    }
}
