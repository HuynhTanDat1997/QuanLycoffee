using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NgayThangDTO
    {
        public DateTime DenNgay { get; set; }
        public DateTime TuNgay { get; set; }

        public NgayThangDTO()
        {
            DenNgay = DateTime.Now;
            TuNgay = DateTime.Now;
        }
    }

    
}
