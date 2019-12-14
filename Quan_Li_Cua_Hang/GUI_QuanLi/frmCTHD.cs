using DTO_QuanLi;
using GUI_QuanLi.Utils;
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

namespace GUI_QuanLi
{
    public partial class frmCTHD : Form
    {
        HoaDon HoaDon = new HoaDon();
        BUS_HoaDon hd = new BUS_HoaDon();
        float tien = 0;
        public frmCTHD(int x)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.fLoutMonAn.AutoScroll = true;
            this.fLoutMonNuoc.AutoScroll = true;
            LoadMonAn();
            LoadMonNuoc();
            LoadHoaDon(x);
        }
        private void LoadHoaDon(int x)
        {
            int tam = 0;
            tam = hd.LayIDHoaDon();
            if (x == 0)
            {                
                HoaDon.Dock = DockStyle.Right;                
                HoaDon.tb_IDHD.Text = tam.ToString();
                HoaDon.tb_IDHD.Enabled = false;
                HoaDon.tb_TongTien.Text = "0";
                this.panel2.Controls.Add(HoaDon);
                HoaDon.Size = new Size(300, 450);
                HoaDon.panel3.Size = new Size(55, 23);
                HoaDon.panel6.Size = new Size(55, 23);
                HoaDon.panel6.Visible = false;
                HoaDon.panel3.Visible = false;
                HoaDon.columnHeader1.Width = 145;
                HoaDon.columnHeader2.Width = 75;
                HoaDon.columnHeader3.Width = 80;
                HoaDon.btn_XacNhan.Click += Btn_XacNhan_Click;              
            }
            else
            {
                foreach (DataRow row in hd.LayThongTinHoaDon(x).Rows)
                {
                    HoaDon.tb_SoBan.Text = row["ban"].ToString();
                    HoaDon.tb_TongTien.Text = row["trigia"].ToString();
                    tien = float.Parse(HoaDon.tb_TongTien.Text);
                }
                this.btn_Huy.Visible = false;
                HoaDon.Dock = DockStyle.Right;
                HoaDon.tb_IDHD.Text = x.ToString();
                HoaDon.tb_IDHD.Enabled = false;
                HoaDon.tb_TongTien.Enabled = false;
                this.panel2.Controls.Add(HoaDon);
                HoaDon.Size = new Size(300, 450);
                HoaDon.panel3.Size = new Size(55, 23);
                HoaDon.panel6.Size = new Size(55, 23);
                HoaDon.panel6.Visible = false;
                HoaDon.panel3.Visible = false;
                HoaDon.columnHeader1.Width = 145;
                HoaDon.columnHeader2.Width = 75;
                HoaDon.columnHeader3.Width = 80;
                HoaDon.btn_XacNhan.Click += Btn_XacNhan_Click;
            }
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

        private void LoadMonAn()
        {
            MD.StartService();
            foreach (DTO_MonAn monAn in MD.Instance.GetAllRecords(PhanLoai.MonAn))
            {
                QuanLy_MonAn element = new QuanLy_MonAn(monAn);
                this.fLoutMonAn.Controls.Add(element);
                element.panel5.Visible = true;
                element.panel3.Visible = true;
                element.panel2.Enabled = false;
                element.panel2.Visible = false;
                element.tbxTen.Enabled = false;
                element.tbxGia.Enabled = false;
                element.panel4.Visible = false;
                element.Size = new Size(250, 250);
            }
        }

        private void LoadMonNuoc()
        {
            MD.StartService();
            foreach (DTO_MonAn monAn in MD.Instance.GetAllRecords(PhanLoai.MonNuoc))
            {
                QuanLy_MonAn element = new QuanLy_MonAn(monAn);
                this.fLoutMonNuoc.Controls.Add(element);
                element.panel5.Visible = true;
                element.panel3.Visible = true;
                element.panel2.Enabled = false;
                element.panel2.Visible = false;
                element.tbxTen.Enabled = false;
                element.tbxGia.Enabled = false;
                element.panel4.Visible = false;
                element.Size = new Size(250, 300);
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Hide();
            hd.HuyHoaDon(int.Parse(HoaDon.tb_IDHD.Text));
            hd.ResetMaHoaDon(int.Parse(HoaDon.tb_IDHD.Text));
            this.Close();
        }
    }
}
