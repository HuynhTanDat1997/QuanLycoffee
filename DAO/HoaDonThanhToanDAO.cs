using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class HoaDonThanhToanDAO
    {
        QuanLyQuanCafeEntities _connection = new QuanLyQuanCafeEntities();

        public List<HoaDonThanhToanDTO> laydsmontheohd;

        public List<HoaDonThanhToanDTO> LayDSMonTheoHD(int idhd)
        {
            laydsmontheohd = new List<HoaDonThanhToanDTO>();

            var list = _connection.LayHDThanhToan(idhd);
            foreach (var item in list)
            {
                HoaDonThanhToanDTO hd = new HoaDonThanhToanDTO();

                hd.IDMenu = item.IDMeNu;
                hd.TenMon = item.TenMon;
                hd.SoLuong = item.SoLuong;
                hd.DonGia = item.Gia;
                hd.ThanhTien = item.ThanhTien;

                laydsmontheohd.Add(hd);
            }
            return laydsmontheohd;
        }
    }
}
