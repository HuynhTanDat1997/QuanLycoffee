using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class HoaDonBUS
    {
        HoaDonDAO hdDao = new HoaDonDAO();

        public int ThemHD(int idban,int idnv, double tamtinh)
        {
            return hdDao.ThemHD(idban,idnv, tamtinh);
        }

        public int IDHoaDon()
        {
            return hdDao.IDHoaDon();
        }

        public HoaDonDTO HDTheoBan(int idban)
        {
            return hdDao.HDTheoBan(idban);
        }

        public bool KTHoaDon(int idban)
        {
            return hdDao.KTHoaDon(idban);
        }

        public int CapNhatTongTien(int idban, float tamtinh)
        {
            return hdDao.CapNhatTongTien(idban, tamtinh);
        }

        public int CapNhatIDbanTrongHD(int idhd, int idbanmoi)
        {
            return hdDao.CapNhatIDbanTrongHD(idhd, idbanmoi);
        }

        public int ThanhToanHD(int idhd)
        {
            return hdDao.ThanhToanHD(idhd);
        }

        public double DoanhThu(DateTime tungay, DateTime denngay)
        {
            return hdDao.DoanhThu(tungay, denngay);
        }

        public List<HoaDonDTO> LayDanhSachHD()
        {
            return hdDao.LayDanhSachHD();
        }

        public int HDDaThanhToan(DateTime tungay, DateTime denngay)
        {
            return hdDao.HDDaThanhToan(tungay, denngay);
        }

        public int HDChuaThanhToan(DateTime tungay, DateTime denngay)
        {
            return hdDao.HDChuaThanhToan(tungay, denngay);
        }

        public List<HoaDonDTO> LayDanhSachHDTheoNgay(DateTime ngay)
        {
            return hdDao.LayDanhSachHDTheoNgay(ngay);
        }

        public int TongTienSauTach(int idban, float tongtien)
        {
            return hdDao.TongTienSauTach(idban, tongtien);
        }
    }
}
