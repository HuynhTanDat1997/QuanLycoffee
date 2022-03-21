using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace DTO
{
    public class MonDTO
    {
        private int iDMeNu;
        private string tenMon;
        private int iDNhom;
        private string donViTinh;
        private double gia;
        private bool tinhTrang;

        public int IDMeNu { get => iDMeNu; set => iDMeNu = value; }

        public string TenMon { get => tenMon; set => tenMon = value; }

        public int IDNhom { get => iDNhom; set => iDNhom = value; }

        public string DonViTinh { get => donViTinh; set => donViTinh = value; }

        public double Gia { get => gia; set => gia = value; }

        public bool TinhTrang { get => tinhTrang; set => tinhTrang = value; }
    }
}
