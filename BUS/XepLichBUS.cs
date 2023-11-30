using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class XepLichBUS
    {
        static XepLichDAO dao;
        static List<XepLichDTO> danhSach;

        public XepLichBUS(int maKH)
        {
            dao = new XepLichDAO();
            danhSach = dao.getLichKhoaHoc(maKH);
        }

        public List<XepLichDTO> getLichKhoaHoc(int maKH)
        {
            return dao.getLichKhoaHoc(maKH);
        }

        public bool TrungLich(XepLichDTO xepLich)
        {
            return dao.TrungLich(xepLich);
        }
    }
}
