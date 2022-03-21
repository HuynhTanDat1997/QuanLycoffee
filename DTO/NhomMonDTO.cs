using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhomMonDTO
    {
        private int iDNhom;
        private string tenNhom;
        private bool tinhTrang;

        public int IDNhom { get => iDNhom; set => iDNhom = value; }

        public string TenNhom { get => tenNhom; set => tenNhom = value; }

        public bool TinhTrang { get => tinhTrang; set => tinhTrang = value; }
    }
}
