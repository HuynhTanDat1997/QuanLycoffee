using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class NhomMonDAO
    {
        QuanLyQuanCafeEntities _connection = new QuanLyQuanCafeEntities();
        //Tạo danh sách chứa nhóm món
        public List<NhomMonDTO> laydsnhommon;

        public List<NhomMonDTO> LayDanhSachNhomMon()
        {
            //Khởi tạo danh sách
            laydsnhommon = new List<NhomMonDTO>();
            //Lấy danh sách từ data
            var list = _connection.LayDanhSachNhomMon();
            //Thêm nhóm món vào danh sách
            foreach (var item in list)
            {
                NhomMonDTO nm = new NhomMonDTO();

                nm.IDNhom = item.IDNhom;
                nm.TenNhom = item.TenNhom;
                nm.TinhTrang = item.TinhTrang;

                laydsnhommon.Add(nm);
            }

            return laydsnhommon;
        }

        public bool KiemTraNhomMon(string tennhom)
        {
            var nm = _connection.KTNhomMon(tennhom);

            if (nm.SingleOrDefault() == null)
            {
                return true;
            }
            return false;
        }

        public int ThemNhomMon(string tennhom)
        {
            try
            {
                _connection.ThemNhomMon(tennhom);
                _connection.SaveChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public int XoaNhomMon(int id)
        {
            try
            {
                _connection.XoaNhomMon(id);
                _connection.SaveChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public int SuaNhomMon(int id, string tennhom)
        {
            try
            {
                _connection.SuaNhomMon(id, tennhom);
                _connection.SaveChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public int IDNhomMon(string tennhom)
        {
            var nhom = _connection.IDNhom(tennhom).SingleOrDefault();
            return nhom.Value;
        }
    }
}
