using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class BanDAO
    {
        QuanLyQuanCafeEntities _connection = new QuanLyQuanCafeEntities();

        public List<BanDTO> laydsban;
        public BanDTO ban;
        public List<BanDTO> dsbantrong;

        public List<BanDTO> LayDanhSachBan()
        {
            laydsban = new List<BanDTO>();

            var list = _connection.LayDanhSachBan();

            foreach (var item in list)
            {
                BanDTO ban = new BanDTO();

                ban.IDBan = item.IDBan;
                ban.TenBan = item.TenBan;
                ban.TrangThai = item.TrangThai;
                ban.TinhTrang = item.TinhTrang;

                laydsban.Add(ban);
            }
            return laydsban;
        }

        public List<BanDTO> DanhSachBanTrong()
        {
            dsbantrong = new List<BanDTO>();
            var list = _connection.DsBanTrong();

            foreach (var item in list)
            {
                BanDTO ban = new BanDTO();

                ban.IDBan = item.IDBan;
                ban.TenBan = item.TenBan;
                ban.TrangThai = item.TrangThai;

                dsbantrong.Add(ban);
            }
            return dsbantrong;
        }

        public BanDTO LayThongTinTheoBan(int idban)
        {
            ban = new BanDTO();
            var b = _connection.LayThongTinTheoBan(idban);
            foreach (var item in b)
            {
                ban.IDBan = item.IDBan;
                ban.TenBan = item.TenBan;
                ban.TrangThai = item.TrangThai;
            }
            return ban;
        }

        public int ThemBan(string tenban)
        {
            try
            {
                _connection.TangBan(tenban);
                _connection.SaveChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public int XoaBan(int idban)
        {
            try
            {
                _connection.XoaBan(idban);
                _connection.SaveChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public void ChuyenTrangThai(int idban, string trangthaimoi)
        {
            _connection.ChuyenTrangThai(idban, trangthaimoi);
            _connection.SaveChanges();
        }

        public bool KTTenBan(string tenban)
        {
            var ban = _connection.KTTenban(tenban);
            if (ban.SingleOrDefault() == null)
            {
                return false;
            }
            return true;
        }
    }
}
