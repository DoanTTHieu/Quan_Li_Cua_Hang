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
using BUS_QuanLi;
using DTO_QuanLi;

namespace GUI_QuanLi
{
    public partial class frmDoanhThu : MaterialForm
    {
        BUS_HoaDon hd = new BUS_HoaDon();
        BUS_CTHD ct = new BUS_CTHD();
        public frmDoanhThu()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager manager = MaterialSkin.MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            manager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue300, MaterialSkin.Primary.Blue500, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.LightBlue400, MaterialSkin.TextShade.WHITE);
        }

        private void btn_Xem_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.flowDSHD.Controls.OfType<HoaDon>())
            {
                this.flowDSHD.Controls.Clear();
            }
            loadhd(ngay.Value);
            layslhd(ngay.Value);
            laytongtienhd(ngay.Value);
        }

        private void loadhd(DateTime ng)
        {
            foreach (DataRow row in hd.LayHoaDonChoQuanLi(ng).Rows)
            {
                float tien = 0;
                HoaDon hoadon = new HoaDon();
                hoadon.Tag = row["mahd"].ToString();
                hoadon.tb_IDHD.Text = row["mahd"].ToString();
                hoadon.tb_SoBan.Text = row["ban"].ToString();
                hoadon.tb_IDHD.Enabled = false;
                hoadon.tb_SoBan.Enabled = false;
                hoadon.tb_TongTien.Enabled = false;
                foreach (DataRow row1 in ct.LayCTHD(int.Parse(hoadon.tb_IDHD.Text)).Rows)
                {
                    double gia = Convert.ToDouble(row1["gia"]);
                    double sl = Convert.ToDouble(row1["solg"]);
                    ListViewItem item = new ListViewItem();
                    item.Text = row1["tenmon"].ToString();
                    item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = gia.ToString() });
                    item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = row1["solg"].ToString() });
                    hoadon.listView1.Items.Add(item);
                    hoadon.tb_TongTien.Text = (tien + gia * sl).ToString();
                    tien = float.Parse(hoadon.tb_TongTien.Text);
                    hd.CapNhatHoaDonv2(tien, int.Parse(hoadon.tb_IDHD.Text), int.Parse(hoadon.tb_SoBan.Text));
                }
                this.flowDSHD.Controls.Add(hoadon);
                hoadon.Size = new Size(300, 450);
                hoadon.panel3.Size = new Size(75, 23);
                hoadon.panel4.Visible = false;
                hoadon.panel3.Visible = false;
                hoadon.panel6.Visible = false;
                hoadon.panel6.Size = new Size(75, 23);
                hoadon.columnHeader1.Width = 130;
                hoadon.columnHeader2.Width = 85;
                hoadon.columnHeader3.Width = 80;
            }
        }

        private void layslhd(DateTime ng)
        {
            foreach(DataRow row in hd.SLHoaDon(ng).Rows )
            {
                tb_SLHD.Text = row["sl"].ToString();
            }
        }

        private void laytongtienhd(DateTime ng)
        {
            foreach (DataRow row in hd.TongTien(ng).Rows)
            {
                tb_TongTien.Text = row["trigia"].ToString();
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuanLi frm = new frmQuanLi();
            frm.ShowDialog();
            this.Close();
        }
    }
}
