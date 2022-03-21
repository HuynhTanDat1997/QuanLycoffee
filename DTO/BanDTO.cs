using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BanDTO
    {
        private int iDBan;
        private string tenBan;
        private string trangThai;
        private bool tinhTrang;

        public int IDBan { get => iDBan; set => iDBan = value; }

        public string TenBan { get => tenBan; set => tenBan = value; }

        public string TrangThai { get => trangThai; set => trangThai = value; }

        public bool TinhTrang { get => tinhTrang; set => tinhTrang = value; }
    }
}
