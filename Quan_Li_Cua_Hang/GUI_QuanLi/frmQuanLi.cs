using DTO_QuanLi;
using BUS_QuanLi;
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
using DTO_QuanLi.Utils;

namespace GUI_QuanLi
{
    public partial class frmQuanLi : MaterialForm
    {
        BUS_MonAn2 ma = new BUS_MonAn2();
        public frmQuanLi()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.fLoutMonAn.AutoScroll = true;
            this.fLoutMonNuoc.AutoScroll = true;
            loadmonan();
            loadmonnuoc();
        }

        private void loadmonan()
        {
            foreach (DataRow row in ma.LayMonAn(0).Rows)
            {
                DTO_MonAn monan = new DTO_MonAn(int.Parse(row["mamon"].ToString()), row["tenmon"].ToString(), float.Parse(row["gia"].ToString()), 0, row["hinhanh"].ToString());
                QuanLy_MonAn element = new QuanLy_MonAn(monan);
                this.fLoutMonAn.Controls.Add(element);
                element.panel5.Visible = false;
                element.panel3.Visible = false;
                element.panel2.Enabled = false;
                element.panel2.Visible = false;
                element.tbxTen.Enabled = false;
                element.tbxGia.Enabled = false;
                element.panel4.Visible = true;
                element.panel4.Enabled = true;
                element.Size = new Size(250, 250);
                element.btnDel.Click += new EventHandler((o, e) => RemoveElement(o, e, fLoutMonAn));
                element.btnSave.Click += BtnSave_Click;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {            
            foreach(Control item in this.fLoutMonAn.Controls.OfType<QuanLy_MonAn>())
            {
                this.fLoutMonAn.Controls.Clear();
            }
            foreach (Control item in this.fLoutMonNuoc.Controls.OfType<QuanLy_MonAn>())
            {
                this.fLoutMonNuoc.Controls.Clear();
            }           
            this.fLoutMonAn.Controls.Add(button1);
            this.fLoutMonNuoc.Controls.Add(button2);
            loadmonan();
            loadmonnuoc();
        }

        private void loadmonnuoc()
        {
            foreach (DataRow row in ma.LayMonAn(1).Rows)
            {
                DTO_MonAn monan = new DTO_MonAn(int.Parse(row["mamon"].ToString()), row["tenmon"].ToString(), float.Parse(row["gia"].ToString()), 1, row["hinhanh"].ToString());
                QuanLy_MonAn element = new QuanLy_MonAn(monan);
                this.fLoutMonNuoc.Controls.Add(element);
                element.panel5.Visible = false;
                element.panel3.Visible = false;
                element.panel2.Enabled = false;
                element.panel2.Visible = false;
                element.tbxTen.Enabled = false;
                element.tbxGia.Enabled = false;
                element.panel4.Visible = true;
                element.panel4.Enabled = true;
                element.Size = new Size(250, 300);
                element.btnDel.Click += new EventHandler((o, e) => RemoveElement(o, e, fLoutMonAn));
                element.btnSave.Click += BtnSave_Click;
            }
        }     

        private void RemoveElement(object sender, EventArgs ev, FlowLayoutPanel container)
        {
            try
            {
                if (!(sender is Button)) return;
                Button btn = sender as Button;

                if (!(btn.Tag is QuanLy_MonAn)) return;
                container.Controls.Remove(btn.Tag as QuanLy_MonAn);
            } catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void Btn_DangXuat_Click(object sender, EventArgs e)
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

        private void btn_DoanhThu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDoanhThu frm = new frmDoanhThu();
            frm.ShowDialog();
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            QuanLy_MonAn element = new QuanLy_MonAn(null) { PhanLoai = PhanLoai.MonAn }; ;
            this.fLoutMonAn.Controls.Add(element);
            this.fLoutMonAn.Controls.SetChildIndex(element, 1);
            element.panel5.Visible = false;
            element.panel3.Visible = false;
            element.panel2.Enabled = false;
            element.panel2.Visible = false;
            element.tbxTen.Enabled = false;
            element.tbxGia.Enabled = false;
            element.panel4.Visible = true;
            element.panel4.Enabled = true;
            element.Size = new Size(250, 250);
            element.btnDel.Click += new EventHandler((o, ev) => RemoveElement(o, ev, fLoutMonAn));
            element.btnSave.Click += BtnSave_Click;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            QuanLy_MonAn element = new QuanLy_MonAn(null) { PhanLoai = PhanLoai.MonNuoc };
            this.fLoutMonNuoc.Controls.Add(element);
            this.fLoutMonNuoc.Controls.SetChildIndex(element, 1);
            element.panel5.Visible = false;
            element.panel3.Visible = false;
            element.panel2.Enabled = false;
            element.panel2.Visible = false;
            element.tbxTen.Enabled = false;
            element.tbxGia.Enabled = false;
            element.panel4.Visible = true;
            element.panel4.Enabled = true;
            element.Size = new Size(250, 300);
            element.btnDel.Click += new EventHandler((o, ev) => RemoveElement(o, ev, fLoutMonNuoc));
            element.btnSave.Click += BtnSave_Click;
        }
    }
}
