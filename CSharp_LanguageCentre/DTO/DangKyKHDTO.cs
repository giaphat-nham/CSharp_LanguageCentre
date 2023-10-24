using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_LanguageCentre.DTO
{
    class DangKyKHDTO
    {
        int maKH;
        int maHV;
        float diemGK;
        float diemCK;

        public DangKyKHDTO(int maKH, int maHV, float diemGK, float diemCK)
        {
            this.maKH = maKH;
            this.maHV = maHV;
            this.diemGK = diemGK;
            this.diemCK = diemCK;
        }

        public int MaKH { get; set; }
        public int MaHV { get; set; }
        public float DiemGK { get; set; }
        public float DiemCK { get; set; }
    }
}
