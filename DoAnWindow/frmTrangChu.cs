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
    public partial class frmTrangChu : DevExpress.XtraEditors.XtraForm
    {
        TaiKhoanBUS tkBus = new TaiKhoanBUS();

        string TaiKhoan = "";
      
        public frmTrangChu()
        {
            InitializeComponent();
        }

        public frmTrangChu(string taikhoan):this()
        {
            TaiKhoan = taikhoan; //nhận từ lbltaikhoan
        }
        private void frmTrangChu_Load(object sender, EventArgs e)
        {           
            if(tkBus.PhanQuyen(TaiKhoan) == false) //true là quản lý, false nhân viên
            {
                itemQuanLy.Enabled = false;
                itemBaoCao.Enabled = false;
            }

            lblNguoiDung.Text = tkBus.NguoiDungTK(TaiKhoan);
        }

        private void itemQuanLy_ItemClick(object sender, TileItemEventArgs e)
        {
            this.Hide();
            frmQuanLy quanly = new frmQuanLy(TaiKhoan);
            quanly.ShowDialog();
            this.Close();
        }

        private void itemBanHang_ItemClick(object sender, TileItemEventArgs e)
        {
            this.Hide();
            frmBanHang banhang = new frmBanHang(TaiKhoan);
            banhang.ShowDialog();
            this.Close();
        }

        private void itemBaoCao_ItemClick(object sender, TileItemEventArgs e)
        {
            this.Hide();
            frmBaoCaoThongKe banhang = new frmBaoCaoThongKe(TaiKhoan);
            banhang.ShowDialog();
            this.Close();
        }

        private void frmTrangChu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.F1)
            {
                itemBanHang_ItemClick(null, null);
            }

            if (e.Control == true && e.KeyCode == Keys.F2)
            {
                if (tkBus.PhanQuyen(TaiKhoan) == false) return;
                
                itemQuanLy_ItemClick(null, null);
            }

            if (e.Control == true && e.KeyCode == Keys.F3)
            {
                if (tkBus.PhanQuyen(TaiKhoan) == false) return;

                itemBaoCao_ItemClick(null, null);
            }

        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Hide();
                frmDangNhap dangnhap = new frmDangNhap();
                dangnhap.ShowDialog();
                this.Close();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}