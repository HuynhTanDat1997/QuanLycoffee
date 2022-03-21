using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
namespace WindowsFormsApp1
{
    public partial class frmDoimatKhau : DevExpress.XtraEditors.XtraForm
    {
        TaiKhoanBUS tkBus = new TaiKhoanBUS();

        frmQuanLy f0;

        public frmDoimatKhau(frmQuanLy f0)
        {
            InitializeComponent();
            this.f0 = f0;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenTaiKhoan.Text) || string.IsNullOrEmpty(txtMatKhauCu.Text) || string.IsNullOrEmpty(txtMatKhauMoi.Text))
            {
                MessageBox.Show("Chưa nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string mahoaMKcu = txtMatKhauCu.Text.MaHoaMD5();
                if (tkBus.KTDoiMatKhau(txtTenTaiKhoan.Text, mahoaMKcu))
                {
                    //Đổi mật khẩu
                    string mahoaMKmoi = txtMatKhauMoi.Text.MaHoaMD5();
                    int kq = tkBus.DoiMatKhau(txtTenTaiKhoan.Text, mahoaMKmoi);
                    if (kq == 1)
                    {
                        MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.f0.LoadTaiKhoan();

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu cũ chưa đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }         
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}