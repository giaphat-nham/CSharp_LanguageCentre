using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietPhanQuyenDTO
    {
        int maQuyen;
        int maCN;

        public ChiTietPhanQuyenDTO()
        {

        }

        public ChiTietPhanQuyenDTO(int maQuyen, int maCN)
        {
            this.maQuyen = maQuyen;
            this.maCN = maCN;
        }

        public int MaQuyen { get; set; }
        public int MaCN { get; set; }
    }
}
