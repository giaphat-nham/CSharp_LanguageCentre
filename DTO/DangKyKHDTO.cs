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

        public int MaKH { get { return MaKH; } set { MaKH = value; } }
        public int MaHV { get { return maHV; } set { maHV = value; } }
        public float DiemGK { get { return diemGK; } set { diemGK = value; } }
        public float DiemCK { get { return diemCK; } set { diemCK = value; } }
    }
}
