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
using BUS;
using DTO;
namespace WindowsFormsApp1
{
    public partial class frmThemTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        TaiKhoanBUS tkBus = new TaiKhoanBUS();
        frmQuanLy f0;
        NhanVienBUS nvBus = new NhanVienBUS();

        public frmThemTaiKhoan(frmQuanLy f0)
        {
            InitializeComponent();
            cboChucVu.SelectedIndex = 0;
            this.f0 = f0;

            cboMaNV.DataSource = nvBus.DsNvChuaCoTK();
                
            cboMaNV.DisplayMember = "Show";
            cboMaNV.ValueMember = "IDNhanVien";


            if (nvBus.DsNvChuaCoTK().Count == 0)
            {
                lblThongBao.Text = "Tất cả nhân viên hiện tại đã có tài khoản, hãy thêm nhân viên mới trước khi đăng ký!";
                btnDangKi.Enabled = false;
            }

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenTaiKhoan.Text) || string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show("Chưa nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Xđ Chức vụ
                bool phanquyen = false;

                if (cboChucVu.SelectedIndex == 1)// 1 quản lý - 0 nhân viên
                {
                    phanquyen = true;
                }
                int idnv = int.Parse(cboMaNV.SelectedValue.ToString());

                if (tkBus.KiemTraTrungLap(txtTenTaiKhoan.Text))
                {
                    //Thêm tài khoản
                    int kq = tkBus.ThemTaiKhoan(idnv, txtTenTaiKhoan.Text, txtMatKhau.Text, phanquyen);
                    if(kq == 1)
                    {
                        MessageBox.Show("Đăng kí thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }    
                    else
                    {
                        MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }    

                    //gọi hàm từ form quản lý
                    this.f0.LoadTaiKhoan();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tài khoản đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }    
                     
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Hủy đăng kí","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                
            }
        }

    }
}