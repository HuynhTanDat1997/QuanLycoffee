using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class NhomMonBUS
    {
        NhomMonDAO nmDao = new NhomMonDAO();

        public List<NhomMonDTO> LayDanhSachNhomMon()
        {
            return nmDao.LayDanhSachNhomMon();
        }

        public bool KiemTraNhomMon(string tennhom)
        {
            return nmDao.KiemTraNhomMon(tennhom);
        }

        public int IDNhomMon(string tennhom)
        {
            return nmDao.IDNhomMon(tennhom);
        }

        public int ThemNhomMon(string tennhom)
        {
            return nmDao.ThemNhomMon(tennhom);
        }

        public int XoaNhomMon(int id)
        {
            return nmDao.XoaNhomMon(id);
        }

        public int SuaNhomMon(int id, string tennhom)
        {
            return nmDao.SuaNhomMon(id, tennhom);
        }
    }
}
