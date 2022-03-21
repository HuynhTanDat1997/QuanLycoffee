using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class ThongKeMonBUS
    {
        ThongKeMonDAO thongkeDao = new ThongKeMonDAO();

        public List<ThongKeMonDTO> ThongKeMonTheoNgay(DateTime tungay, DateTime denngay)
        {
            return thongkeDao.ThongKeMonTheoNgay(tungay, denngay);
        }
    }
}
