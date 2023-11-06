using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class ChiTietPhanQuyenBUS
    {
        static ChiTietPhanQuyenDAO dao = new ChiTietPhanQuyenDAO();

        public ChiTietPhanQuyenBUS()
        {

        }

        public List<ChiTietPhanQuyenDTO> QuyenTK(string tenTK )
        {
            return dao.QuyenTK(tenTK);
        }
    }
}
