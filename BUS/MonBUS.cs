using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class MonBUS
    {
        MonDAO monDao = new MonDAO();

        public List<MonDTO> LayDanhSachMenu()
        {
            return monDao.LayDanhSachMenu();
        }

        public List<MonDTO> LayDSMonTheoNhom(int idnhom)
        {
            return monDao.LayDSMonTheoNhom(idnhom);
        }

        public MonDTO LayThongTinTheoMon(int idmon)
        {
            return monDao.LayThongTinTheoMon(idmon);
        }

        public int ThemMon(string tenmon, int idnhom, string donvitinh, float gia)
        {
            return monDao.ThemMon(tenmon, idnhom, donvitinh, gia);
        }

        public bool KTTrungLapMon(string tenmon)
        {
            return monDao.KTTrungLapMon(tenmon);
        }

        public int SuaMon(int id, string tenmon, int idnhom, string donvitinh, float gia)
        {
            return monDao.SuaMon(id, tenmon, idnhom, donvitinh, gia);
        }

        public int XoaMon(int id)
        {
            return monDao.XoaMon(id);
        }
    }
}
