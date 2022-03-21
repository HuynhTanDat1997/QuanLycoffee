using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class NhanVienDAO
    {
        QuanLyQuanCafeEntities _connection = new QuanLyQuanCafeEntities();
        //Tạo danh sách chứa nhân viên DTO
        List<NhanVienDTO> laydsnhanvien;
        List<NhanVienDTO> dsnvchuacotk;

        public List<NhanVienDTO> LayDanhSachNV()
        {
            //Khởi tạo danh sách
            laydsnhanvien = new List<NhanVienDTO>();
            //Lấy danh sách từ data
            var list = _connection.LayDanhSachNV();
            //Thêm nhân viên vào danh sách
            foreach (var item in list)
            {
                NhanVienDTO nv = new NhanVienDTO();

                nv.HoVaTen = item.HoVaTen;
                nv.IDNhanVien = item.IDNhanVien;
                nv.GioiTinh = item.GioiTinh;
                nv.SDT = item.SDT;
                nv.DiaChi = item.DiaChi;
                nv.TinhTrang = item.TinhTrang;
                nv.CMND = item.CMND;
                nv.NgaySinh = item.NgaySinh.Date;

                laydsnhanvien.Add(nv);
            }

            return laydsnhanvien;
        }

        public List<NhanVienDTO> DsNvChuaCoTK()
        {
            //Khởi tạo danh sách
            dsnvchuacotk = new List<NhanVienDTO>();
            //Lấy danh sách từ data
            var list = _connection.DSNVChuacoTK();
            //Thêm nhân viên vào danh sách
            foreach (var item in list)
            {
                NhanVienDTO nv = new NhanVienDTO();

                nv.HoVaTen = item.HoVaTen;
                nv.IDNhanVien = item.IDNhanVien;
                nv.GioiTinh = item.GioiTinh;
                nv.SDT = item.SDT;
                nv.DiaChi = item.DiaChi;
                nv.TinhTrang = item.TinhTrang;
                nv.CMND = item.CMND;
                nv.NgaySinh = item.NgaySinh.Date;

                dsnvchuacotk.Add(nv);
            }

            return dsnvchuacotk;
        }
        //Kiểm tra trùng lặp
        public bool KiemTraCmnd(string cmnd)
        {
            var item = _connection.KiemTraCmnd(cmnd);

            if (item.SingleOrDefault() == null)
                return true;

            return false;

        }
        //Xóa nhân viên
        public int XoaNhanVien(int idnhanvien)
        {
            try
            {
                _connection.XoaNV(idnhanvien);
                _connection.SaveChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        //Thêm nhân viên
        public int ThemNhanVien(string hoten, string gioitinh, string diachi, string sdt, string cmnd, DateTime ngaysinh)
        {
            try
            {
                _connection.ThemNV(hoten, gioitinh, diachi, sdt, cmnd, ngaysinh);
                _connection.SaveChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        //Sửa thông tin nhân viên
        public int SuaNhanVien(int id, string hoten, string gioitinh, DateTime ngaysinh, string diachi, string sdt, string cmnd)
        {
            try
            {
                _connection.SuaNV(id, hoten, gioitinh, ngaysinh, diachi, sdt, cmnd);
                _connection.SaveChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
    }
}
