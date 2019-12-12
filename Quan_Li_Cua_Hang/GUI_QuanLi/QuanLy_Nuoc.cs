using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QuanLi
{
    public partial class QuanLy_Nuoc : UserControl
    {
        public static MD Instance { get; private set; }

        public QuanLy_Nuoc()
        {
            InitializeComponent();
            panel2.Enabled = false;
            panel2.Visible = false;
            tbxTen.Enabled = false;
            tbxGia.Enabled = false;
        }


        private void BtnEdit_Click(object sender, EventArgs e)
        {
            panel2.Enabled = true;
            panel2.Visible = true;
            panel4.Enabled = false;
            panel4.Visible = false;
            tbxTen.Enabled = true;
            tbxGia.Enabled = true;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveButtonClick();            
        }

        private void BtnPic_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picture.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            //DelButtonClick();
        }

        public void SaveButtonClick()
        {
            MonAn mon = new MonAn();
            mon.tenmon = tbxTen.Text;
            mon.gia = Convert.ToInt32(tbxGia.Text);
            mon.phanloai = 0;
            mon.hinhanh = openFileDialog1.FileName;

            MD.Instance.AddInfo(mon);

            SaveModePrepare();
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

        public void DeleteModePrepare()
        {
            this.Enabled = false;
            this.Visible = false;
        }

        public void DelButtonClick()
        {

            //MD.Instance.DeleteInfo(mamon);
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

    }
}
