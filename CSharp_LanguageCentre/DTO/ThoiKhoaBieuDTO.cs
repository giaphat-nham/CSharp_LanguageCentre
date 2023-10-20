using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_LanguageCentre.DTO
{
    class ThoiKhoaBieuDTO
    {
        int maKH;
        int maPH;
        int thu;
        int tietBD;
        int soTiet;

        public ThoiKhoaBieuDTO(int maKH, int maPH, int thu, int tietBD, int soTiet)
        {
            this.maKH = maKH;
            this.maPH = maPH;
            this.thu = thu;
            this.tietBD = tietBD;
            this.soTiet = soTiet;
        }

        public int MaKH { get; set; }
        public int MaPH { get; set; }
        public int Thu { get; set; }
        public int TietBD { get; set; }
        public int SoTiet { get; set; }
    }
}
