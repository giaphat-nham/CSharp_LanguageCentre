using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_LanguageCentre.DTO
{
    
    public class TaiKhoanDTO
    {
        string tenTK;
        string matKhau;
        int maQuyen;

        public TaiKhoanDTO()
        {

        }
        public TaiKhoanDTO(string tenTK, string matKhau, int maQuyen)
        {
            this.tenTK = tenTK;
            this.matKhau = matKhau;
            this.maQuyen = maQuyen;
        }

        public string TenTK { get; set; }
        public string MatKhau { get; set; }
        public int MaQuyen { get; set; }
    }
}
