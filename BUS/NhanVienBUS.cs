using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class NhanVienBUS
    {
        private NhanVienDAO nvDao = new NhanVienDAO();

        public List<NhanVienDTO> LayDanhSachNV()
        {
            return nvDao.LayDanhSachNV();
        }

        public List<NhanVienDTO> DsNvChuaCoTK()
        {
            return nvDao.DsNvChuaCoTK();
        }

        public bool KiemTraCmnd(string cmnd)
        {
            return nvDao.KiemTraCmnd(cmnd);
        }

        public int XoaNhanVien(int idnhanvien)
        {
            return nvDao.XoaNhanVien(idnhanvien);
        }

        public int ThemNhanVien(string hoten, string gioitinh, string diachi, string sdt, string cmnd, DateTime ngaysinh)
        {
            return nvDao.ThemNhanVien(hoten, gioitinh, diachi, sdt, cmnd, ngaysinh);
        }

        public int SuaNhanVien(int id, string hoten, string gioitinh, DateTime ngaysinh, string diachi, string sdt, string cmnd)
        {
            return nvDao.SuaNhanVien(id, hoten, gioitinh, ngaysinh, diachi, sdt, cmnd);
        }
    }
}
