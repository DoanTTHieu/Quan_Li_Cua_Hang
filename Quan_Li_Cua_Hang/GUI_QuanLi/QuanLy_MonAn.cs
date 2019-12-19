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
using System.IO;
using DTO_QuanLi.Utils;
using BUS_QuanLi;
using BUS_QuanLi.Utils;

namespace GUI_QuanLi
{
    public partial class QuanLy_MonAn : UserControl
    {
        public QuanLy_MonAn()
        {
            InitializeComponent();
            btnDel.Tag = this;
        }

        public delegate bool OnClickHoaDon(string mamonan,string sl);

        public event OnClickHoaDon ClickChonMon;

        public DTO_MonAn Data { get; set; }

        public PhanLoai PhanLoai { get; set; } = PhanLoai.MonAn;

        public QuanLy_MonAn(DTO_MonAn data) : this()
        {
            if (data != null)
            {
                Data = data;
                tbxGia.Text = data.Gia.ToString();
                tbxTen.Text = data.Tenmon.ToString();
                PhanLoai = (PhanLoai)data.Phanloai;
                SetPic(data.Hinhanh.ToString());
            } else
            {
                ToggleInfo();
                PrepareEditMode();
            }
        }

        public void ToggleInfo()
        {
            tbxTen.Text = "";
            tbxGia.Text = "";
            picture.BackgroundImage = Properties.Resources.icons8_add_50px_1;
            picture.BackgroundImageLayout = ImageLayout.Center;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            PrepareEditMode();
        }

        private void SetPic(String imgPath)
        {
            picture.BackgroundImage = new Bitmap(imgPath);
            picture.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void PrepareEditMode()
        {
            panel2.Enabled = true;
            panel2.Visible = true;
            panel4.Enabled = false;
            panel4.Visible = false;
            tbxTen.Enabled = true;
            tbxGia.Enabled = true;
            if (Data == null)
            {
                btnBack.Enabled = btnBack.Visible =  false;
            } else
            {
                btnBack.Enabled = btnBack.Visible = true;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (Data == null)
            {
                SaveButtonClick();
            } else
            {
                UpdateButtonClick();
            }
        }

        private void BtnPic_Click(object sender, EventArgs e)
        {
            if (!panel2.Visible || !panel2.Enabled) return;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                SetPic(openFileDialog1.FileName);
            }
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            this.Visible = false;

            if (Data != null)
            {
                BUS_MonAn.DeleteTSLCKKCKLDLKCKKDLCKLKLCKLD(Data);
            }
        }

        public void UpdateButtonClick()
        {
            Data.Tenmon = tbxTen.Text;
            Data.Gia = Convert.ToInt64(tbxGia.Text);
            Data.Hinhanh = !File.Exists(openFileDialog1.FileName) ? Data.Hinhanh : openFileDialog1.FileName;

            BUS_MonAn.UpdateLKKLKLCDKLCKLCKLCD(Data);

            SaveModePrepare();
        }

        public void SaveButtonClick()
        {
            try
            {
                Data = new DTO_MonAn();
                Data.Tenmon = tbxTen.Text;
                Data.Gia = Convert.ToInt64(tbxGia.Text);
                Data.Phanloai = (int) PhanLoai;
                Data.Hinhanh = openFileDialog1.FileName;

                BUS_MonAn.AddNewIOKLLKKLKLMKLMMKLMKL(Data);

                SaveModePrepare();
            } catch
            {

            }
        }


        public void SaveModePrepare()
        {
            panel2.Enabled = false;
            panel2.Visible = false;
            panel4.Enabled = true;
            panel4.Visible = true;
            tbxTen.Enabled = false;
            tbxGia.Enabled = false;
        }

        private void TextboxName_Click(object sender, MouseEventArgs e)
        {

            tbxTen.Focus();
            tbxTen.BackColor = Color.AliceBlue;
        }

        private void TextboxGia_CLick(object sender, MouseEventArgs e)
        {
            tbxGia.Focus();
            tbxGia.BackColor = Color.AliceBlue;
        }

        private void TbxGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            if (Data == null) return;
            SaveModePrepare();
            tbxGia.Text = Data.Gia.ToString();
            tbxTen.Text = Data.Tenmon.ToString();
            SetPic(Data.Hinhanh.ToString());
        }

        private void btnAddbill_Click(object sender, EventArgs e)
        {
            if (ClickChonMon != null)
                if (ClickChonMon(this.Tag.ToString(), tbSL.Text))
                    tbSL.Clear();
        }
    }
}
