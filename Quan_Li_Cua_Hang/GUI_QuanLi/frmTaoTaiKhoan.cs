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
    public partial class frmTaoTaiKhoan : MaterialForm
    {
        BUS_NhanVien nv = new BUS_NhanVien();
        public frmTaoTaiKhoan()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager manager = MaterialSkin.MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            manager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue300, MaterialSkin.Primary.Blue500, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.LightBlue400, MaterialSkin.TextShade.WHITE);

        }

        private void Btn_TaoTaiKhoan_Click1(object sender, EventArgs e)
        {
            if (tb_UserName.Text == "")
            {
                MessageBox.Show("Please enter username!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_UserName.Focus();
                return;
            }
            if (tb_Password.Text == "")
            {
                MessageBox.Show("Please enter password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_Password.Focus();
                return;
            }
            if (tb_PasswordAgain.Text == "")
            {
                MessageBox.Show("Please enter confirm password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_PasswordAgain.Focus();
                return;
            }
            if(rbtn_QuanLi.Checked==false&&rbtn_NhanVien.Checked==false)
            {
                MessageBox.Show("Vui long chọn chức vụ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (tb_Password.Text != tb_PasswordAgain.Text)
            {
                MessageBox.Show("Nhập sai mật khẩu xác nhận.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ////chua xong ne

            this.Hide();
            int cv = rbtn_QuanLi.Checked ? 0 : 1;
            int temp = nv.TaoTaiKhoan(tb_UserName.Text, tb_Password.Text, tb_PasswordAgain.Text,cv);
            if ( temp== 3)
            {
                this.ShowDialog();
                tb_PasswordAgain.Focus();
                return;         
            }
            else if (temp == 2)
            {
                MessageBox.Show("Tạo tài khoản thành công.");
                //MessageBox.Show("Form quan li.");
                frmDangNhap frmDN = new frmDangNhap();
                frmDN.ShowDialog();
                this.Close();
            }
            else
            {
                _ = MessageBox.Show("Lỗi!!", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
          
        }
    }
}
