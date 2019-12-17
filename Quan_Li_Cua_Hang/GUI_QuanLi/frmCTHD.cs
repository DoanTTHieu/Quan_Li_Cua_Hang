using DTO_QuanLi;
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
using DTO_QuanLi.Utils;

namespace GUI_QuanLi
{
    public partial class frmCTHD : Form
    {
        bool flag = true;
        string sobantam = "";
        int mahdtam = 0;
        BUS_HoaDon hd = new BUS_HoaDon();
        BUS_CTHD ct = new BUS_CTHD();
        BUS_MonAn2 ma = new BUS_MonAn2();
        float tien = 0;
        public frmCTHD(int x)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.fLoutMonAn.AutoScroll = true;
            this.fLoutMonNuoc.AutoScroll = true;
            loadmonan();
            loadmonnuoc();
            LoadHoaDon(x);
        }
        private void LoadHoaDon(int x)
        {
            mahdtam = x;
            HoaDon HoaDon = new HoaDon();
            foreach (DataRow row in hd.LayThongTinHoaDon(x).Rows)
            {
                tb_Ban.Text = row["ban"].ToString();
                HoaDon.tb_SoBan.Text = row["ban"].ToString();
                sobantam = row["ban"].ToString();
                if (row["trigia"].ToString() == "0")
                {
                    HoaDon.tb_TongTien.Text = row["trigia"].ToString();
                }
            }
            HoaDon.Dock = DockStyle.Right;
            HoaDon.tb_IDHD.Text = x.ToString();
            HoaDon.tb_IDHD.Enabled = false;
            HoaDon.tb_TongTien.Enabled = false;
            HoaDon.tb_SoBan.Enabled = false;
            foreach (DataRow row1 in ct.LayCTHD(int.Parse(HoaDon.tb_IDHD.Text)).Rows)
            {
                double gia = Convert.ToDouble(row1["gia"]);
                double sl = Convert.ToDouble(row1["solg"]);
                ListViewItem item = new ListViewItem();
                item.Text = row1["tenmon"].ToString();
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = gia.ToString() });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = row1["solg"].ToString() });
                HoaDon.listView1.Items.Add(item);
                HoaDon.tb_TongTien.Text = (tien + gia * sl).ToString();
                tien = float.Parse(HoaDon.tb_TongTien.Text);
                if(HoaDon.tb_SoBan.Text =="")
                {
                    if(flag == true)
                    {
                        MessageBox.Show("Yêu Cầu Nhập Số Bàn", "Thông Báo", MessageBoxButtons.OK);
                        flag = false;
                    }                    
                }
                else
                {
                    hd.CapNhatHoaDonv2(tien, int.Parse(HoaDon.tb_IDHD.Text), int.Parse(HoaDon.tb_SoBan.Text));
                }                
            }
            this.panel2.Controls.Add(HoaDon);
            HoaDon.Size = new Size(300, 450);
            HoaDon.panel4.Size = new Size(75, 23);
            HoaDon.panel6.Visible = false;
            HoaDon.panel3.Visible = false;
            HoaDon.columnHeader1.Width = 130;
            HoaDon.columnHeader2.Width = 85;
            HoaDon.columnHeader3.Width = 80;
            HoaDon.btn_XacNhan.Click += Btn_XacNhan_Click;
        }

        private void Btn_XacNhan_Click(object sender, EventArgs e)
        {
            if (tien == 0 || tb_Ban.Text =="")
            {
                
            }
            else
            {
                hd.CapNhatBan(int.Parse(tb_Ban.Text), mahdtam);
                this.Hide();
                frmNhanVien frm = new frmNhanVien();
                frm.ShowDialog();
                this.Close();
            }
        }
        private void loadmonan()
        {
            foreach (DataRow row in ma.LayMonAn(0).Rows)
            {
                QuanLy_MonAn element = new QuanLy_MonAn();
                element.tbxTen.Text = row["tenmon"].ToString();
                element.tbxGia.Text = row["gia"].ToString();
                Image image = Image.FromFile(row["hinhanh"].ToString());
                element.picture.Image = image;
                this.fLoutMonAn.Controls.Add(element);
                element.Tag = row["mamon"].ToString();
                element.panel5.Visible = true;
                element.panel3.Visible = true;
                element.panel2.Enabled = false;
                element.panel2.Visible = false;
                element.tbxTen.Enabled = false;
                element.tbxGia.Enabled = false;
                element.panel4.Visible = false;
                element.panel4.Enabled = false;
                element.Size = new Size(250, 250);
                element.ClickChonMon += Element_ClickChonMon;                
            }
        }
        private void loadmonnuoc()
        {
            foreach (DataRow row in ma.LayMonAn(1).Rows)
            {
                QuanLy_MonAn element = new QuanLy_MonAn();
                element.tbxTen.Text = row["tenmon"].ToString();
                element.tbxGia.Text = row["gia"].ToString();
                Image image = Image.FromFile(row["hinhanh"].ToString());
                element.picture.Image = image;
                this.fLoutMonNuoc.Controls.Add(element);
                element.Tag = row["mamon"].ToString();
                element.panel5.Visible = true;
                element.panel3.Visible = true;
                element.panel2.Enabled = false;
                element.panel2.Visible = false;
                element.tbxTen.Enabled = false;
                element.tbxGia.Enabled = false;
                element.panel4.Visible = false;
                element.panel4.Enabled = false;
                element.Size = new Size(250, 300);
                element.ClickChonMon += Element_ClickChonMon;
            }
        }
        private void Element_ClickChonMon(string mamonan, string sl)
        {
            if (tb_Ban.Text == "")
            {
                MessageBox.Show("Yêu Cầu Nhập Số Bàn", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            {
                hd.CapNhatBan(int.Parse(tb_Ban.Text), mahdtam);
                int sltam = 0;
                int tam = mahdtam;
                int solg = ct.LaySLMonAn(tam, int.Parse(mamonan));

                if (sl == "")
                {
                    sltam = 1;
                }
                else if (sl == "0")
                {
                    sltam = 0;
                }
                else if (sl != "" && sl != "0")
                {
                    sltam = int.Parse(sl);
                }

                if (solg == 0)
                {
                    ct.TaoCTHD(tam, int.Parse(mamonan), sltam);
                }
                else if (solg != 0)
                {
                    if (sltam != 0)
                    {
                        sltam = solg + sltam;
                        ct.CapNhatCTHD(tam, int.Parse(mamonan), sltam);
                    }
                    else if (sltam == 0)
                    {
                        ct.XoaCTHD(tam, int.Parse(mamonan));
                    }
                }
                foreach (Control item in this.Controls.OfType<HoaDon>())
                {
                    this.Controls.Remove(item);
                    item.Dispose();
                }
                tien = 0;
                flag = true;
                LoadHoaDon(mahdtam);
                foreach (Control item in this.fLoutMonAn.Controls.OfType<QuanLy_MonAn>())
                {
                    this.fLoutMonAn.Controls.Clear();
                }
                foreach (Control item in this.fLoutMonNuoc.Controls.OfType<QuanLy_MonAn>())
                {
                    this.fLoutMonNuoc.Controls.Clear();
                }
                loadmonan();
                loadmonnuoc();
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Hide();
            int tam = hd.LayIDHoaDon();
            int tam1 = mahdtam;
            hd.HuyHoaDon(mahdtam);
            ct.xoaCTHDver2(tam1);
            if (tam == tam1)
            {
                hd.ResetMaHoaDon(mahdtam);
            }
            frmNhanVien frm = new frmNhanVien();
            frm.ShowDialog();
            this.Close();
        }
    }
}
