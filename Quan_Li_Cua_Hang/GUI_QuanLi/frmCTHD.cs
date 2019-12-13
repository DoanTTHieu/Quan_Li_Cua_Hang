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
                this.panel2.Controls.Add(HoaDon);
            }
            else
            {
                HoaDon.Dock = DockStyle.Right;
                this.panel2.Controls.Add(HoaDon);
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
