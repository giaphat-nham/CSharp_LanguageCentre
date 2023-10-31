using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_LanguageCentre.DTO
{
    class KhoaHocDTO
    {
        int maKH;
        string tenKH;
        int gia;
        string capBac;
        DateTime ngayBD;
        DateTime ngayKT;

        public KhoaHocDTO(int maKH, string tenKH, int gia, string capBac, DateTime ngayBD, DateTime ngayKT)
        {
            this.maKH = maKH;
            this.tenKH = tenKH;
            this.gia = gia;
            this.capBac = capBac;
            this.ngayBD = ngayBD;
            this.ngayKT = ngayKT;
        }
        
        public int MaKH { get; set; }
        public string TenKH { get; set; }
        public int Gia { get; set; }
        public string CapBac { get; set; }
        public DateTime NgayBD{ get; set; }
        public DateTime NgayKT{ get; set; }
    }
}
