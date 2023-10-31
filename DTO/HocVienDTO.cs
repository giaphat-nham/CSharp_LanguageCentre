using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_LanguageCentre.DTO
{
    class HocVienDTO
    {
        int maHV;
        string hoTen;
        string soDienThoai;
        int trinhDo;

        public HocVienDTO(int maHV, string hoTen, string soDienThoai, int trinhDo)
        {
            this.maHV = maHV;
            this.hoTen = hoTen;
            this.soDienThoai = soDienThoai;
            this.trinhDo = trinhDo;
        }

        public int MaHV { get; set; }
        public string HoTen { get; set; }
        public string SoDienThoai { get; set; }
        public int TrinhDo { get; set; }
    }
}
