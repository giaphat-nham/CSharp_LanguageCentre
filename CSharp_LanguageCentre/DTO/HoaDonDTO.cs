using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_LanguageCentre.DTO
{
    class HoaDonDTO
    {
        int maHD;
        DateTime ngayHD;
        int hocPhi;
        bool tinhTrangThanhToan;
        int maHV;

        public HoaDonDTO(int maHD, DateTime ngayHD, int hocPhi, bool tinhTrangThanhToan, int maHV)
        {
            this.maHD = maHD;
            this.ngayHD = ngayHD;
            this.hocPhi = hocPhi;
            this.tinhTrangThanhToan = tinhTrangThanhToan;
            this.maHV = maHV;
        }

        public int MaHD { get; set; }
        public DateTime NgayHD { get; set; }
        public int HocPhi { get; set; }
        public bool TinhTrangThanhToan { get; set; }
        public int MaHV { get; set; }
    }
}
