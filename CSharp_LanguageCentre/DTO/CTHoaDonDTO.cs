using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_LanguageCentre.DTO
{
    class CTHoaDonDTO
    {
        int maHD;
        int maKH;
        int gia;

        public CTHoaDonDTO(int maHD, int maKH, int gia)
        {
            this.maHD = maHD;
            this.maKH = maKH;
            this.gia = gia;
        }

        public int MaHD { get; set; }
        public int MaKH { get; set; }
        public int Gia { get; set; }
    }
}
