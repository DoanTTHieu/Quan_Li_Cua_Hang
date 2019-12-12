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

using DTO_QuanLi;
using BUS_QuanLi;
namespace GUI_QuanLi
{
    
    public partial class frmDangNhap : MaterialForm
    {
        BUS_NhanVien nv = new BUS_NhanVien();
        public frmDangNhap()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager manager = MaterialSkin.MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            manager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue300, MaterialSkin.Primary.Blue500, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.LightBlue400, MaterialSkin.TextShade.WHITE);
        }

        private void FrmDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            this.btn_DangNhap.Focus();

            if (e.KeyCode == Keys.Enter)
            {
                Btn_DangNhap_Click(sender, e);
                return;
            }
        }

        private void btn_TaoTaiKhoan_Click(object sender, EventArgs e)
        {
            this.Hide();
            //chuyen sang form tao tai khoan
            frmTaoTaiKhoan frm = new frmTaoTaiKhoan();
            frm.ShowDialog();
            this.Close();
        }

        private void Btn_DangNhap_Click(object sender, EventArgs e)
        {
            if (tb_UserName.Text == ""&&tb_Password.Text==null)
            {
                MessageBox.Show("Please enter username and password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_UserName.Focus();
                return;
            }
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
            if (nv.DangNhap(tb_UserName.Text, tb_Password.Text) == "1")
            {
                //hien form nhan vien
                this.Hide();
                frmNhanVien frm = new frmNhanVien();
                frm.ShowDialog();
                this.Close();
                //MessageBox.Show("Form nhan vien.");
            }
            else if (nv.DangNhap(tb_UserName.Text, tb_Password.Text) == "0")
            {
                //hien form quan li
                this.Hide();
                frmQuanLi frm = new frmQuanLi();
                frm.ShowDialog();
                this.Close();

                //MessageBox.Show("Form quan li.");
            }
            else
            {
                 MessageBox.Show("Không tồn tại tài khoản.","Thông báo.",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}


