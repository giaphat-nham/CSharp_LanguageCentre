using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp_LanguageCentre.DTO;

namespace DAO
{
    public class ThoiKhoaBieuDAO
    {
        DataServices dataServices = new DataServices();
        DataTable dt;

        public ThoiKhoaBieuDAO()
        {

        }

        public List<ThoiKhoaBieuDTO> getTKBHV(int maHV)
        {
            List<ThoiKhoaBieuDTO> ds = new List<ThoiKhoaBieuDTO>();
            string sql = "SELECT kh.ma_kh, ten_kh, thu, tiet_bd, so_tiet, ngay_bd, ngay_kt FROM khoa_hoc kh, thoi_khoa_bieu tkb, hoc_vien hv, dang_ky_khoa_hoc dk WHERE " +
                "kh.ma_kh = tkb.ma_kh AND " +
                "tkb.ma_kh = dk.ma_kh AND tkb.nhom_kh = dk.nhom_kh AND" +
                "dk.ma_hv = hv.ma_hv AND" +
                $"hv.ma_hv = {maHV}";
            if (!dataServices.OpenDB()) return null;
            dt = dataServices.RunQuery(sql);
            ThoiKhoaBieuDTO tkb;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                tkb = new ThoiKhoaBieuDTO();
                tkb.MaKH = (int)dt.Rows[i]["ma_kh"];
                tkb.TenKH = dt.Rows[i]["ten_kh"].ToString();
                tkb.Thu = (int)dt.Rows[i]["thu"];
                tkb.TietBD = (int)dt.Rows[i]["tiet_bd"];
                tkb.SoTiet = (int)dt.Rows[i]["so_tiet"];
                tkb.NgayBD = (DateTime)dt.Rows[i]["ngay_bd"];
                tkb.NgayKT = (DateTime)dt.Rows[i]["ngay_kt"];
                ds.Add(tkb);
            }

            return ds;
        }

        public List<ThoiKhoaBieuDTO> getTKBGV(int maGV)
        {
            List<ThoiKhoaBieuDTO> ds = new List<ThoiKhoaBieuDTO>();
            string sql = "SELECT kh.ma_kh, ten_kh, thu, tiet_bd, so_tiet, ngay_bd, ngay_kt FROM khoa_hoc kh, thoi_khoa_bieu tkb WHERE " +
                "kh.ma_kh = tkb.ma_kh AND " +
                $"tkb.ma_gv = {maGV}";
            if (!dataServices.OpenDB()) return null;
            dt = dataServices.RunQuery(sql);
            ThoiKhoaBieuDTO tkb;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                tkb = new ThoiKhoaBieuDTO();
                tkb.MaKH = (int)dt.Rows[i]["ma_kh"];
                tkb.TenKH = dt.Rows[i]["ten_kh"].ToString();
                tkb.Thu = (int)dt.Rows[i]["thu"];
                tkb.TietBD = (int)dt.Rows[i]["tiet_bd"];
                tkb.SoTiet = (int)dt.Rows[i]["so_tiet"];
                tkb.NgayBD = (DateTime)dt.Rows[i]["ngay_bd"];
                tkb.NgayKT = (DateTime)dt.Rows[i]["ngay_kt"];
                ds.Add(tkb);
            }

            return ds;
        }
    }
}
