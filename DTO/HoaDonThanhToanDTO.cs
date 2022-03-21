using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonThanhToanDTO
    {
        private int iDMenu;
        private string tenMon;
        private int soLuong;
        private double donGia;
        private double thanhTien;

        public int IDMenu { get => iDMenu; set => iDMenu = value; }

        public string TenMon { get => tenMon; set => tenMon = value; }

        public int SoLuong { get => soLuong; set => soLuong = value; }

        public double DonGia { get => donGia; set => donGia = value; }

        public double ThanhTien { get => thanhTien; set => thanhTien = value; }
    }
}
