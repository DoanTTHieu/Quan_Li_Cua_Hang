using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QuanLi;
using BUS_QuanLi;

namespace GUI_QuanLi
{
    public partial class HoaDon : UserControl
    {
        BUS_HoaDon hd = new BUS_HoaDon();
        public HoaDon()
        {
            InitializeComponent();
        }
        public delegate void OnClickHoaDon(string mahd);

        public event OnClickHoaDon ClickHoaDon;

       

        private void btn_ChonMon_Click(object sender, EventArgs e)
        {
            if (ClickHoaDon != null) ClickHoaDon(this.Tag.ToString());
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            if (tb_TongTien.Text == "0"||tb_SoBan.Text =="")
            {
                if(tb_TongTien.Text == "0" && tb_SoBan.Text == "")
                {
                    MessageBox.Show("Yêu Cầu Chọn Ít Nhất 1 Món \nYêu Cầu Nhập Số Bàn", "Thông Báo", MessageBoxButtons.OK);
                }
                else if (tb_TongTien.Text == "0")
                {
                    MessageBox.Show("Yêu Cầu Chọn Ít Nhất 1 Món", "Thông Báo", MessageBoxButtons.OK);
                }
                else if(tb_SoBan.Text == "")
                {
                    MessageBox.Show("Yêu Cầu Nhập Số Bàn", "Thông Báo", MessageBoxButtons.OK);                    
                }
            }
            else
            {
                hd.CapNhatHoaDonv2(float.Parse(tb_TongTien.Text), int.Parse(tb_IDHD.Text),int.Parse(tb_SoBan.Text));
            }
            
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            hd.CapNhatTrangThai(int.Parse(tb_IDHD.Text));
        }
    }
}
