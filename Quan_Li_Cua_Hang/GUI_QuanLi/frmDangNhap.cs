using MaterialSkin;
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


namespace GUI_QuanLi
{
    
    public partial class frmDangNhap : MaterialForm
    {
        public frmDangNhap()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager manager = MaterialSkin.MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
          
            manager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue300, MaterialSkin.Primary.Blue500, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.LightBlue400, MaterialSkin.TextShade.WHITE);
        //manager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Amber200, MaterialSkin.Primary.Blue500, MaterialSkin.Primary.Blue50, MaterialSkin.Accent.Blue700, MaterialSkin.TextShade.BLACK);
    }

        private void Btn_DangNhap_Click(object sender, EventArgs e)
        {
            //chuyen sang form chinh
        }
        private void btn_TaoTaiKhoan_Click(object sender, EventArgs e)
        {
            this.Hide();
            //chuyen sang form tao tai khoan
            frmTaoTaiKhoan frm = new frmTaoTaiKhoan();
            frm.ShowDialog();
            this.Close();
        }



    }
}
