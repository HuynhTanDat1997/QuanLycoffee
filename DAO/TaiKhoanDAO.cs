using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class TaiKhoanDAO
    {
        private QuanLyQuanCafeEntities _connection = new QuanLyQuanCafeEntities();

        //Tạo danh sách chứa nhân viên DTO
        public List<TaiKhoanDTO> laydstaikhoan;

        public List<TaiKhoanDTO> LayDanhSachTK()
        {
            //Khởi tạo danh sách
            laydstaikhoan = new List<TaiKhoanDTO>();
            //Lấy danh sách từ data
            var list = _connection.LayDanhSachTK();
            //Thêm nhân viên vào danh sách
            foreach (var item in list)
            {
                TaiKhoanDTO tk = new TaiKhoanDTO();

                tk.IDTaiKhoan = item.IDTaiKhoan;
                tk.TaiKhoan = item.TaiKhoan;
                tk.MatKhau = item.MatKhau;
                tk.PhanQuyen = item.PhanQuyen;
                tk.TinhTrang = item.TinhTrang;
                tk.IDNhanVien = item.IDNhanVien;

                laydstaikhoan.Add(tk);
            }

            return laydstaikhoan;
        }

        public bool KiemTraTrungLap(String tentaikhoan)
        {
            var tk = _connection.KiemTraTrungLap(tentaikhoan);

            if (tk.SingleOrDefault() == null)
            {
                return true;
            }
            return false;
        }

        public bool KTDoiMatKhau(string taikhoan, string matkhau)
        {
            var tk = _connection.KTDoiMatKhau(taikhoan, matkhau);

            if (tk.SingleOrDefault() != null)
            {
                return true;
            }
            return false;
        }



        public int XoaTaiKhoan(string taikhoan)
        {
            try
            {
                _connection.XoaTK(taikhoan);
                _connection.SaveChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public int ThemTaiKhoan(int idnv, string taikhoan, string matkhau, bool phanquyen)
        {
            string matkhauMD5 = matkhau.MaHoaMD5();
            try
            {
                _connection.ThemTK(idnv, taikhoan, matkhauMD5, phanquyen);
                _connection.SaveChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public int DoiMatKhau(string taikhoan, string matkhau)
        {
            try
            {
                _connection.DoiMatKhau(taikhoan, matkhau);
                _connection.SaveChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        //Đăng nhập
        public bool DangNhap(string taikhoan, string matkhau)
        {
            string matkhauMD5 = matkhau.MaHoaMD5();
            var dn = _connection.DangNhap(taikhoan, matkhauMD5);

            if (dn.SingleOrDefault() == null)
            {
                return false;
            }
            return true;
        }

        //Phân quyền
        public bool PhanQuyen(string taikhoan)
        {
            var kt = _connection.KiemTraQuyen(taikhoan, 1);// kiểm tra phải quyển quản lý hay k

            if (kt.SingleOrDefault() == null)
            {
                return false;
            }
            return true;
        }

        public string NguoiDungTK(string taikhoan)
        {
            string nguoidung = "";
            var nd =_connection.NguoiDungTK(taikhoan);
            foreach(var item in nd)
            {
                nguoidung = item.HoVaTen;
            }
            return nguoidung;
        }

        public int IDNguoiDungTK(string taikhoan)
        {
            int id = 0;
            var nd = _connection.NguoiDungTK(taikhoan);
            foreach (var item in nd)
            {
                id = item.IDNhanVien;
            }
            return id;
        }

        public TaiKhoanDTO TaiKhoanNV(int idnv)
        {
            TaiKhoanDTO taikhoan = new TaiKhoanDTO();
            var tk = _connection.TaiKhoanNV(idnv);
            
            foreach(var item in tk)
            {
                taikhoan.IDNhanVien = item.IDNhanVien;
                taikhoan.IDTaiKhoan = item.IDTaiKhoan;
                taikhoan.TaiKhoan = item.TaiKhoan;
                taikhoan.MatKhau = item.MatKhau;
                taikhoan.PhanQuyen = item.PhanQuyen;
            }
            return taikhoan;
        }
    }
}
