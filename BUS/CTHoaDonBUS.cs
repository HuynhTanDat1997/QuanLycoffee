using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class CTHoaDonBUS
    {
        CTHoaDonDAO cthdDAO = new CTHoaDonDAO();

        public List<CTHoaDonDTO> LayDanhSachCT_HD(int idhd)
        {
            return cthdDAO.LayDanhSachCT_HD(idhd);
        }

        public int ThemCT_HD(int idhd, int idmon, int soluong, float gia)
        {
            return cthdDAO.ThemCT_HD(idhd, idmon, soluong, gia);
        }

        public int TachCT_HD(int idhdmoi, int idhdcu, int idmenu)
        {
            return cthdDAO.TachCT_HD(idhdmoi, idhdcu, idmenu);
        }
    }
}
