using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoanDTO
    {
        private int iDTaiKhoan;
        private string taiKhoan;
        private string matKhau;
        private int iDNhanVien;
        private bool phanQuyen;
        private bool tinhTrang;

        public int IDTaiKhoan { get => iDTaiKhoan; set => iDTaiKhoan = value; }

        public string TaiKhoan { get => taiKhoan; set => taiKhoan = value; }

        public string MatKhau { get => matKhau; set => matKhau = value; }

        public int IDNhanVien { get => iDNhanVien; set => iDNhanVien = value; }

        public bool PhanQuyen { get => phanQuyen; set => phanQuyen = value; }

        public bool TinhTrang { get => tinhTrang; set => tinhTrang = value; }
    }
}
