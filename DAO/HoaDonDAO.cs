using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class HoaDonDAO
    {
        QuanLyQuanCafeEntities _connection = new QuanLyQuanCafeEntities();

        List<HoaDonDTO> danhsachHD;
        List<HoaDonDTO> danhsachHDtheongay;

        public List<HoaDonDTO> LayDanhSachHD()
        {
            var list = _connection.LayDanhSachHD();

            danhsachHD = new List<HoaDonDTO>();
            foreach (var item in list)
            {
                HoaDonDTO hd = new HoaDonDTO();

                hd.IDHoaDon = item.IDHoaDon;
                hd.IDBan = item.IDBan;
                hd.NgayLap = item.NgayLap;
                hd.TinhTrang = item.TinhTrang;
                hd.TrangThai = item.TrangThai;
                hd.TongTien = item.TongTien;
                hd.IDNhanVien = item.IDNhanVien;

                danhsachHD.Add(hd);
            }
            return danhsachHD;
        }

        public List<HoaDonDTO> LayDanhSachHDTheoNgay(DateTime ngay)
        {
            var list = _connection.TimKiemHDTheoNgay(ngay);

            danhsachHDtheongay = new List<HoaDonDTO>();
            foreach (var item in list)
            {
                HoaDonDTO hd = new HoaDonDTO();

                hd.IDHoaDon = item.IDHoaDon;
                hd.IDBan = item.IDBan;
                hd.NgayLap = item.NgayLap;
                hd.TinhTrang = item.TinhTrang;
                hd.TrangThai = item.TrangThai;
                hd.TongTien = item.TongTien;
                hd.IDNhanVien = hd.IDNhanVien;

                danhsachHDtheongay.Add(hd);
            }
            return danhsachHDtheongay;
        }

        public int ThemHD(int idban,int idnv, double tamtinh)
        {
            try
            {
                _connection.ThemHoaDon(idban,idnv, tamtinh);
                _connection.SaveChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public int IDHoaDon()
        {
            int? id = _connection.IDHoaDon().SingleOrDefault();
            return id.Value;
        }

        public HoaDonDTO HDTheoBan(int idban)
        {
            HoaDonDTO hd = new HoaDonDTO();
            var hoadon = _connection.HDTungBan(idban);

            foreach (var item in hoadon)
            {
                hd.IDHoaDon = item.IDHoaDon;
                hd.IDBan = item.IDBan;
                hd.NgayLap = item.NgayLap;
                hd.TongTien = item.TongTien;
                hd.TrangThai = item.TrangThai;
                hd.IDNhanVien = hd.IDNhanVien;
            }
            return hd;
        }

        public bool KTHoaDon(int idban)
        {
            var hd = _connection.KTHoaDon(idban);
            if (hd.SingleOrDefault() == null)
            {
                return false;
            }
            return true;
        }

        public int CapNhatTongTien(int idban, float tamtinh)
        {
            try
            {
                _connection.CapNhatTongTien(idban, tamtinh);
                _connection.SaveChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public int CapNhatIDbanTrongHD(int idhd, int idbanmoi)
        {
            try
            {
                _connection.CapNhatIDbantrongHD(idhd, idbanmoi);
                _connection.SaveChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public int ThanhToanHD(int idhd)
        {
            try
            {
                _connection.ThanhToanHD(idhd);
                _connection.SaveChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public double DoanhThu(DateTime tungay, DateTime denngay)
        {
            double doanhthu;
            var dt = _connection.DoanhThu(tungay, denngay).SingleOrDefault();
            if (dt != null)
            {
                doanhthu = dt.Value;
                return doanhthu;
            }
            return 0;
        }

        public int HDDaThanhToan(DateTime tungay, DateTime denngay)
        {
            var hd = _connection.HDDThanhToan(tungay, denngay).SingleOrDefault();
            if (hd != null)
            {
                return hd.Value;
            }
            return 0;
        }

        public int HDChuaThanhToan(DateTime tungay, DateTime denngay)
        {
            var hd = _connection.HDCThanhToan(tungay, denngay).SingleOrDefault();
            if (hd != null)
            {
                return hd.Value;
            }
            return 0;
        }

        public int TongTienSauTach(int idban, float tongtien)
        {
            try
            {
                _connection.TongTienSauTach(idban, tongtien);
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
