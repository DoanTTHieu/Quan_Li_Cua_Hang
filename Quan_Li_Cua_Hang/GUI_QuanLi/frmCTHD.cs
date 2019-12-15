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
        HoaDon HoaDon = new HoaDon();
        BUS_HoaDon hd = new BUS_HoaDon();
        BUS_CTHD ct = new BUS_CTHD();
        float tien = 0;
        public frmCTHD(int x)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.fLoutMonAn.AutoScroll = true;
            this.fLoutMonNuoc.AutoScroll = true;
            BUS_QuanLi.BUS_QuanLi.LoadMon(PhanLoai.MonAn, LoadMonAn);
            BUS_QuanLi.BUS_QuanLi.LoadMon(PhanLoai.MonNuoc, LoadMonNuoc);
            LoadHoaDon(x);
        }
        private void LoadHoaDon(int x)
        {
            foreach (DataRow row in hd.LayThongTinHoaDon(x).Rows)
            {
                HoaDon.tb_SoBan.Text = row["ban"].ToString();
                HoaDon.tb_TongTien.Text = row["trigia"].ToString();
            }
            HoaDon.Dock = DockStyle.Right;
            HoaDon.tb_IDHD.Text = x.ToString();
            HoaDon.tb_IDHD.Enabled = false;
            HoaDon.tb_TongTien.Enabled = false;
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
                hd.CapNhatHoaDon(tien, int.Parse(HoaDon.tb_IDHD.Text));
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
            if (tien == 0)
            {

            }
            else
            {
                this.Hide();
                frmNhanVien frm = new frmNhanVien();
                frm.ShowDialog();
                this.Close();
            }
        }

        private void LoadMonAn(List<DTO_MonAn> monAns)
        {
            foreach (var monAn in monAns)
            {
                try
                {
                    this.fLoutMonAn.Invoke((MethodInvoker)delegate
                    {
                        QuanLy_MonAn element = new QuanLy_MonAn(monAn);
                        this.fLoutMonAn.Controls.Add(element);
                        element.Tag = monAn.Mamon;
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
                    });
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }      

        private void LoadMonNuoc(List<DTO_MonAn> monAns)
        {
            foreach (DTO_MonAn monAn in monAns)
            {
                try
                {
                    this.fLoutMonAn.Invoke((MethodInvoker)delegate
                    {
                        QuanLy_MonAn element = new QuanLy_MonAn(monAn);
                        this.fLoutMonNuoc.Controls.Add(element);
                        element.Tag = monAn.Mamon;
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

                    });
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }

        private void Element_ClickChonMon(string mamonan, string sl)
        {
            int sltam = 0;
            int tam = int.Parse(HoaDon.tb_IDHD.Text);
            int solg = ct.LaySLMonAn(tam, int.Parse(mamonan));
            if(sl=="")
            {
                sltam = 1;
            }
            else if(sl=="0")
            {
                sltam = 0;
            }
            else if(sl!=""&&sl!="0")
            {
                sltam = int.Parse(sl);
            }

            if (solg == 0)
            {
                ct.TaoCTHD(tam, int.Parse(mamonan), sltam);
            }
            else if(solg != 0)
            {
                if(sltam != 0)
                {
                    sltam = solg + sltam;
                    ct.CapNhatCTHD(tam, int.Parse(mamonan), sltam);
                }
                else if(sltam ==0)
                {
                    ct.XoaCTHD(tam, int.Parse(mamonan));
                }
            }
            frmCTHD frm = new frmCTHD(tam);
            frm.ShowDialog();
            this.Close();            
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Hide();
            int tam = hd.LayIDHoaDon();
            int tam1 = int.Parse(HoaDon.tb_IDHD.Text);
            hd.HuyHoaDon(int.Parse(HoaDon.tb_IDHD.Text));
            ct.xoaCTHDver2(tam1);
            if (tam == tam1)
            {
                hd.ResetMaHoaDon(int.Parse(HoaDon.tb_IDHD.Text));
            }
            frmNhanVien frm = new frmNhanVien();
            frm.ShowDialog();
            this.Close();
        }
    }
}
