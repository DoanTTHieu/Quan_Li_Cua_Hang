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
            Load_Form();
        }
        private void Load_Form()
        {
            int tam = nv.KiemTraTonTaiQuanLi();
            if (tam == 1)
            {
                rbtn_NhanVien.Checked = true;
                rbtn_QuanLi.Enabled = false;
            }
        }
        private void Btn_TaoTaiKhoan_Click1(object sender, EventArgs e)
        {
            if (tb_UserName.Text == ""&& tb_Password.Text == ""&&tb_PasswordAgain.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_UserName.Focus();
                return;
            }
            if (tb_UserName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_UserName.Focus();
                return;
            }
            if (tb_Password.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_Password.Focus();
                return;
            }
            if (tb_PasswordAgain.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu xác nhận!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_PasswordAgain.Focus();
                return;
            }
            if(rbtn_QuanLi.Checked==false&&rbtn_NhanVien.Checked==false)
            {
                MessageBox.Show("Vui lòng chọn chức vụ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if (tb_Password.Text != tb_PasswordAgain.Text)
            {
                MessageBox.Show("Nhập sai mật khẩu xác nhận.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            this.Hide();
            int cv = rbtn_QuanLi.Checked ? 0 : 1;
            int temp = nv.TaoTaiKhoan(tb_UserName.Text, tb_Password.Text, tb_PasswordAgain.Text,cv);
            if ( temp== 3)
            {
                this.Show();
                tb_PasswordAgain.Focus();       
            }
            else if (temp == 2)
            {
                //nhap  mat khau tai khoan quan li
                MessageBox.Show("Tạo tài khoản thành công.");
                frmDangNhap frmDN = new frmDangNhap();
                frmDN.ShowDialog();
                this.Close();
            }
            else if(temp==-1)
            {
                MessageBox.Show("Đã tồn tại tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Show();
                tb_UserName.Focus();

            }
            else
            {
                _ = MessageBox.Show("Lỗi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Show();
            }
          
        }

        private void btn_TroVe_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDangNhap frmDN = new frmDangNhap();
            frmDN.ShowDialog();
            this.Close();
        }
    }
}
