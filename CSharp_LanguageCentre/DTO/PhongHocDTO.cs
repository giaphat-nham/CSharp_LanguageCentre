using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_LanguageCentre.DTO
{
    class PhongHocDTO
    {
        int maPH;
        string tenPH;
        int sucChua;

        public PhongHocDTO(int maPH, string tenPH, int sucChua)
        {
            this.maPH = maPH;
            this.tenPH = tenPH;
            this.sucChua = sucChua;
        }

        public int MaPH { get; set; }
        public string TenPH { get; set; }
        public int SucChua { get; set; }
    }
}
