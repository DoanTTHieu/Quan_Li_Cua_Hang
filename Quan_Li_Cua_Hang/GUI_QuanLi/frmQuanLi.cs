﻿using DTO_QuanLi;
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
        public frmQuanLi()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.fLoutMonAn.AutoScroll = true;
            this.fLoutMonNuoc.AutoScroll = true;
            BUS_QuanLi.BUS_QuanLi.LoadMon(PhanLoai.MonAn, LoadMonAn);
            //BUS_QuanLi.BUS_QuanLi.LoadMon(PhanLoai.MonNuoc, LoadMonNuoc);
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
                    });
                } catch (Exception e)
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
                        element.panel5.Visible = false;
                        element.panel3.Visible = false;
                        element.panel2.Enabled = false;
                        element.panel2.Visible = false;
                        element.tbxTen.Enabled = false;
                        element.tbxGia.Enabled = false;
                        element.panel4.Visible = true;
                        element.panel4.Enabled = true;
                        element.Size = new Size(250, 300);
                        element.btnDel.Click += new EventHandler((o, e) => RemoveElement(o, e, fLoutMonNuoc));
                    });
                } catch (Exception e)
                {
                    Console.WriteLine(e);
                }
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

        private void btn_DoanhThu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDoanhThu frm = new frmDoanhThu();
            frm.ShowDialog();
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            QuanLy_MonAn element = new QuanLy_MonAn(null);
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
        }
    }
}
