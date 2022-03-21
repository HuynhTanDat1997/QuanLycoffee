using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class BanBUS
    {
        BanDAO banDao = new BanDAO();

        public List<BanDTO> LayDanhSachBan()
        {
            return banDao.LayDanhSachBan();
        }

        public List<BanDTO> DanhSachBanTrong()
        {
            return banDao.DanhSachBanTrong();
        }

        public int ThemBan(string tenban)
        {
            return banDao.ThemBan(tenban);
        }

        public int XoaBan(int idban)
        {
            return banDao.XoaBan(idban);
        }

        public BanDTO LayThongTinTheoBan(int idban)
        {
            return banDao.LayThongTinTheoBan(idban);
        }

        public void ChuyenTrangThai(int idban, string trangthaimoi)
        {
            banDao.ChuyenTrangThai(idban, trangthaimoi);
        }

        public bool KTTenBan(string tenban)
        {
            return banDao.KTTenBan(tenban);
        }
    }
}
