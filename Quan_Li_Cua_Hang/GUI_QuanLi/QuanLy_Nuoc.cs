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
        public QuanLy_Nuoc()
        {
            InitializeComponent();
        }

        private void QuanLy_Nuoc_Load(object sender, EventArgs e)
        {
            panel2.Enabled = false;
            panel2.Visible = false;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            panel2.Enabled = true;
            panel2.Visible = true;
            panel4.Enabled = false;
            panel4.Visible = false;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //SaveButtonClick();
            panel2.Enabled = false;
            panel2.Visible = false;
            panel4.Enabled = true;
            panel4.Visible = true;
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
            this.Enabled = false;
            this.Visible = false;
        }
    }
}
