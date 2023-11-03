using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CSharp_LanguageCentre.DTO;

namespace DAO
{
    public class TaiKhoanDAO
    {
        DataServices dataServices = new DataServices();
        DataTable dataTable;

        public TaiKhoanDAO()
        {

        }

        public List<TaiKhoanDTO> getAll()
        {
            List<TaiKhoanDTO> danhSach = new List<TaiKhoanDTO>();
            string sql = "SELECT * FROM tai_khoan";
            if (!dataServices.OpenDB()) return null;
            dataTable = dataServices.RunQuery(sql);
            TaiKhoanDTO taiKhoan;

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                taiKhoan = new TaiKhoanDTO();
                taiKhoan.TenTK = dataTable.Rows[i]["ten_tk"].ToString();
                taiKhoan.MatKhau = dataTable.Rows[i]["mat_khau"].ToString();
                taiKhoan.MaQuyen = (int)dataTable.Rows[i]["ma_quyen"];
                danhSach.Add(taiKhoan);
            }

            return danhSach;
        }

        public TaiKhoanDTO TimTaiKhoan(string tenTK, string matKhau)
        {
            string sql = $"SELECT * FROM tai_khoan WHERE ten_tk = '{tenTK}' AND mat_khau = '{matKhau}'";
            dataTable = dataServices.RunQuery(sql);
            if (dataTable.Rows.Count == 0) return null;
            TaiKhoanDTO taiKhoan = new TaiKhoanDTO();
            taiKhoan.TenTK = dataTable.Rows[0]["ten_tk"].ToString();
            taiKhoan.MatKhau = dataTable.Rows[0]["mat_khau"].ToString();
            taiKhoan.MaQuyen = (int)dataTable.Rows[0]["ma_quyen"];
            return taiKhoan;
        }
    }
}
