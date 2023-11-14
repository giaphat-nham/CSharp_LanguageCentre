using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class QuyenBUS
    {
        static QuyenDAO dao;
        static List<QuyenDTO> danhSach;

        public QuyenBUS()
        {
            dao = new QuyenDAO();
            danhSach = dao.getAll();
        }

        public List<QuyenDTO> getAll()
        {
            return dao.getAll();
        }

        public int nextID()
        {
            return danhSach.Count + 1;
        }

        public string Insert(QuyenDTO quyen)
        {
            if (dao.Insert(quyen))
            {
                return "Thêm thành công!";
            }
            return "Đã có lỗi xảy ra!";
        }

        public string Delete(int maQuyen)
        {
            if (dao.Delete(maQuyen))
            {
                return "Xóa thành công!";
            }
            return "Đã có lỗi xảy ra!";
        }
        public string Update(QuyenDTO quyen)
        {
            if (dao.Update(quyen))
            {
                return "Cập nhật thành công!";
            }
            return "Đã có lỗi xảy ra!";
        }
    }
}
