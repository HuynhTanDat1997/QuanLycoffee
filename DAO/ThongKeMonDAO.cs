using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class ThongKeMonDAO
    {
        QuanLyQuanCafeEntities _connection = new QuanLyQuanCafeEntities();

        List<ThongKeMonDTO> thongke;
        public List<ThongKeMonDTO> ThongKeMonTheoNgay(DateTime tungay, DateTime denngay)
        {
            thongke = new List<ThongKeMonDTO>();

            var list = _connection.ThongKe(tungay, denngay);
            //if (list == null) return null;

            foreach (var item in list)
            {
                ThongKeMonDTO tk = new ThongKeMonDTO();

                tk.TenMon = item.TenMon;
                tk.SoLuong = item.TongSL.Value;

                thongke.Add(tk);
            }
            return thongke;
        }
    }
}
