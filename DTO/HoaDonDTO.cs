using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonDTO
    {
        private int iDHoaDon;
        private int iDBan;
        private int iDNhanVien;
        private System.DateTime ngayLap;
        private double tongTien;
        private bool tinhTrang;
        private bool trangThai;

        public int IDHoaDon { get => iDHoaDon; set => iDHoaDon = value; }

        public int IDBan { get => iDBan; set => iDBan = value; }

        public int IDNhanVien { get => iDNhanVien; set => iDNhanVien = value; }

        public DateTime NgayLap { get => ngayLap; set => ngayLap = value; }

        public double TongTien { get => tongTien; set => tongTien = value; }

        public bool TinhTrang { get => tinhTrang; set => tinhTrang = value; }

        public bool TrangThai { get => trangThai; set => trangThai = value; }
    }
}
