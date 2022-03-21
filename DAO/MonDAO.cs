using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class MonDAO
    {
        QuanLyQuanCafeEntities _connection = new QuanLyQuanCafeEntities();

        //Tạo danh sách chứa MonDTO
        public List<MonDTO> laydsmenu;
        public MonDTO mon;

        public List<MonDTO> LayDanhSachMenu()
        {
            //Khởi tạo danh sách
            laydsmenu = new List<MonDTO>();
            //Lấy danh sách từ data
            var list = _connection.LayDanhSachMenu();
            //Thêm nhân viên vào danh sách
            foreach (var item in list)
            {
                MonDTO mon = new MonDTO();

                mon.IDMeNu = item.IDMeNu;
                mon.TenMon = item.TenMon;
                mon.IDNhom = item.IDNhom;
                mon.TinhTrang = item.TinhTrang;
                mon.DonViTinh = item.DonViTinh;
                mon.Gia = item.Gia;

                laydsmenu.Add(mon);
            }

            return laydsmenu;
        }

        public List<MonDTO> LayDSMonTheoNhom(int idnhom)
        {
            laydsmenu = new List<MonDTO>();
            var list = _connection.DSMonTheoNhom(idnhom);
            foreach (var item in list)
            {
                MonDTO mon = new MonDTO();
                mon.IDMeNu = item.IDMeNu;
                mon.IDNhom = item.IDNhom;
                mon.TenMon = item.TenMon;
                mon.Gia = item.Gia;
                mon.DonViTinh = item.DonViTinh;

                laydsmenu.Add(mon);
            }
            return laydsmenu;
        }

        public MonDTO LayThongTinTheoMon(int idmon)
        {
            mon = new MonDTO();
            var m = _connection.LayThongTinMon(idmon);
            foreach (var item in m)
            {
                mon.IDMeNu = item.IDMeNu;
                mon.IDNhom = item.IDNhom;
                mon.TenMon = item.TenMon;
                mon.Gia = item.Gia;
                mon.DonViTinh = item.DonViTinh;
            }
            return mon;
        }

        public bool KTTrungLapMon(string tenmon)
        {
            var kt = _connection.KTTrungLapMon(tenmon);

            if (kt.SingleOrDefault() == null)
            {
                return true;
            }
            return false;
        }

        public int ThemMon(string tenmon, int idnhom, string donvitinh, float gia)
        {
            try
            {
                _connection.ThemMon(tenmon, idnhom, donvitinh, gia);
                _connection.SaveChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public int SuaMon(int id, string tenmon, int idnhom, string donvitinh, float gia)
        {
            try
            {
                _connection.SuaMon(id, tenmon, idnhom, donvitinh, gia);
                _connection.SaveChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public int XoaMon(int id)
        {
            try
            {
                _connection.XoaMon(id);
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
