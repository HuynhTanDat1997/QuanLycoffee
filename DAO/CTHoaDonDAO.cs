using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class CTHoaDonDAO
    {
        QuanLyQuanCafeEntities _connection = new QuanLyQuanCafeEntities();

        List<CTHoaDonDTO> laydanhsachCT_HD;

        public List<CTHoaDonDTO> LayDanhSachCT_HD(int idhd)
        {
            laydanhsachCT_HD = new List<CTHoaDonDTO>();
            var list = _connection.LaydanhsachCT_HD(idhd);

            foreach (var item in list)
            {
                CTHoaDonDTO cthd = new CTHoaDonDTO();

                cthd.IDCTHD = item.IDCTHD;
                cthd.IDHoaDon = item.IDHoaDon;
                cthd.IDMeNu = item.IDMeNu;
                cthd.SoLuong = item.SoLuong;
                cthd.Gia = item.Gia;

                laydanhsachCT_HD.Add(cthd);
            }
            return laydanhsachCT_HD;
        }

        public int ThemCT_HD(int idhd, int idmon, int soluong, double gia)
        {
            try
            {
                _connection.ThemCTHD(idhd, idmon, soluong, gia);
                _connection.SaveChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public int TachCT_HD(int idhdmoi, int idhdcu, int idmenu)
        {
            try 
            {
                _connection.TachCT_HD(idhdmoi, idhdcu, idmenu);
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
