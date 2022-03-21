using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class TaiKhoanBUS
    {
        TaiKhoanDAO tkDAO = new TaiKhoanDAO();

        public bool KiemTraTrungLap(String tentaikhoan)
        {
            return tkDAO.KiemTraTrungLap(tentaikhoan);
        }

        public List<TaiKhoanDTO> LayDanhSachTK()
        {
            return tkDAO.LayDanhSachTK();
        }

        public int XoaTaiKhoan(string taikhoan)
        {
            return tkDAO.XoaTaiKhoan(taikhoan);
        }

        public int ThemTaiKhoan(int idnv, string taikhoan, string matkhau, bool phanquyen)
        {
            return tkDAO.ThemTaiKhoan(idnv, taikhoan, matkhau, phanquyen);
        }

        public int DoiMatKhau(string taikhoan, string matkhau)
        {
            return tkDAO.DoiMatKhau(taikhoan, matkhau);
        }

        public bool KTDoiMatKhau(string taikhoan, string matkhau)
        {
            return tkDAO.KTDoiMatKhau(taikhoan, matkhau);
        }

        public bool DangNhap(string taikhoan, string matkhau)
        {
            return tkDAO.DangNhap(taikhoan, matkhau);
        }

        public bool PhanQuyen(string taikhoan)
        {
            return tkDAO.PhanQuyen(taikhoan);
        }

        public string NguoiDungTK(string taikhoan)
        {
            return tkDAO.NguoiDungTK(taikhoan);
        }

        public int IDNguoiDungTK(string taikhoan)
        {
            return tkDAO.IDNguoiDungTK(taikhoan);
        }

        public TaiKhoanDTO TaiKhoanNV(int idnv)
        {
            return tkDAO.TaiKhoanNV(idnv);
        }


    }
}
