using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace DTO
{
    public static class HoTro
    {
        public static string MaHoaMD5( this string matkhau)
        {
            //Tạo MD5 
            MD5 mh = MD5.Create();
            //Chuyển kiểu chuổi thành kiểu byte
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(matkhau);
            //mã hóa chuỗi đã chuyển
            byte[] hash = mh.ComputeHash(inputBytes);
            //tạo đối tượng StringBuilder (làm việc với kiểu dữ liệu lớn)
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString().ToLower();
        }

        public static int ChieuDaiBan = 100;
        public static int ChieuRongBan = 100;
        public static string _img = @"F:\ảnh\BanHang.png";
        public static DateTime DenNgay { get; set; }
        public static DateTime TuNgay { get; set; }
    }
}
