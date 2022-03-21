using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class HoaDonThanhToanBUS
    {
        HoaDonThanhToanDAO hdttDao = new HoaDonThanhToanDAO();

        public List<HoaDonThanhToanDTO> LayDSMonTheoHD(int idhd)
        {
            return hdttDao.LayDSMonTheoHD(idhd);
        }
    }
}
