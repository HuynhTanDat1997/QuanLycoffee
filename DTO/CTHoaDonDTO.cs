using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CTHoaDonDTO
    {
        private int iDCTHD;
        private int iDHoaDon;
        private int iDMeNu;
        private int soLuong;
        private double gia;
        private bool tinhTrang;

        public int IDCTHD { get => iDCTHD; set => iDCTHD = value; }

        public int IDHoaDon { get => iDHoaDon; set => iDHoaDon = value; }

        public int IDMeNu { get => iDMeNu; set => iDMeNu = value; }

        public int SoLuong { get => soLuong; set => soLuong = value; }

        public double Gia { get => gia; set => gia = value; }

        public bool TinhTrang { get => tinhTrang; set => tinhTrang = value; }
    }
}
