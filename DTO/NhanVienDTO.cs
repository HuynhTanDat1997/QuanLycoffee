using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVienDTO
    {
        private int iDNhanVien;
        private string hoVaTen;
        private string gioiTinh;
        private string diaChi;
        private string sDT;
        private string cMND;
        private bool tinhTrang;
        private DateTime ngaySinh;

        public string show;
        
        public string Show
        {
            get { return string.Format("ID: {0} - Họ tên: {1}", IDNhanVien, HoVaTen); }
            set { show = value; }
        }

        public int IDNhanVien { get => iDNhanVien; set => iDNhanVien = value; }

        public string HoVaTen { get => hoVaTen; set => hoVaTen = value; }

        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }

        public string DiaChi { get => diaChi; set => diaChi = value; }

        public string SDT { get => sDT; set => sDT = value; }

        public string CMND { get => cMND; set => cMND = value; }

        public bool TinhTrang { get => tinhTrang; set => tinhTrang = value; }

        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
    }
}
