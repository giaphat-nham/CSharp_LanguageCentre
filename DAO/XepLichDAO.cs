﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class XepLichDAO
    {
        DataTable dt;
        DataServices dataServices = new DataServices();

        public XepLichDAO()
        {

        }

        public List<XepLichDTO> getLichKhoaHoc(int maKH)
        {
            List<XepLichDTO> danhSach = new List<XepLichDTO>();
            string sql = $"SELECT * FROM thoi_khoa_bieu tkb WHERE ma_kh = {maKH}";
            if (!dataServices.OpenDB()) return null;
            dt = dataServices.RunQuery(sql);
            XepLichDTO xepLich;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                xepLich = new XepLichDTO();
                xepLich.MaKH = (int)dt.Rows[i]["ma_kh"];
                xepLich.NhomKH = (int)dt.Rows[i]["nhom_kh"];
                xepLich.Thu = (int)dt.Rows[i]["thu"];
                xepLich.TietBD = (int)dt.Rows[i]["tiet_bd"];
                xepLich.SoTiet = (int)dt.Rows[i]["so_tiet"];
                xepLich.MaGV = (int)dt.Rows[i]["ma_gv"];
                xepLich.MaPH = (int)dt.Rows[i]["ma_ph"];
                danhSach.Add(xepLich);
            }

            return danhSach;
        }

        public bool Insert(XepLichDTO xepLich)
        {
            try
            {
                string sql = $"INSERT INTO thoi_khoa_bieu(ma_kh, nhom_kh, thu, tiet_bd, so_tiet, ma_gv, ma_ph) VALUES({xepLich.MaKH},{xepLich.NhomKH},{xepLich.Thu},{xepLich.TietBD},{xepLich.SoTiet},{xepLich.MaGV},{xepLich.MaPH})";
                dataServices.ExecuteNonQuery(sql);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            return true;
        }

        public bool Delete(int maKH, int nhomKH)
        {
            try
            {
                string sql = $"DELETE FROM thoi_khoa_bieu WHERE ma_kh = {maKH} AND nhom_kh = {nhomKH}";
                dataServices.ExecuteNonQuery(sql);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            return true;
        }

        public bool Update(XepLichDTO xepLich)
        {   
            try
            {
                string sql = $"UPDATE thoi_khoa_bieu SET thu = {xepLich.Thu}, tiet_bd = {xepLich.TietBD}, so_tiet = {xepLich.SoTiet}, ma_gv = {xepLich.MaGV}, ma_ph = {xepLich.MaPH} WHERE ma_kh = {xepLich.MaKH} AND nhom_kh = {xepLich.NhomKH}";
                dataServices.ExecuteNonQuery(sql);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            return true;
        }

        public bool TrungMa(int maKH, int nhomKH)
        {
            string sql = $"SELECT * FROM thoi_khoa_bieu WHERE ma_kh = {maKH} AND nhom_kh = {nhomKH}";
            dt = dataServices.RunQuery(sql);
            if (dt.Rows.Count == 0) return false;
            return true;
        }

        public int NextNhomKH(int maKH)
        {
            string sql = $"SELECT MAX(nhom_kh) as 'max' FROM thoi_khoa_bieu WHERE ma_kh = {maKH}";
            dt = dataServices.RunQuery(sql);
            if (dt.Rows.Count == 0) return 1;
            int curId = (int)dt.Rows[0]["max"];
            return curId + 1;
        }

        public bool TrungLich(XepLichDTO xepLich)
        {
            string sql = $"SELECT * FROM thoi_khoa_bieu WHERE thu = {xepLich.Thu} AND ma_ph = {xepLich.MaPH} AND (tiet_bd = {xepLich.TietBD} OR tiet_bd < {xepLich.TietBD} AND tiet_bd <= {xepLich.TietBD + xepLich.SoTiet - 1} OR tiet_bd > {xepLich.TietBD} AND tiet_bd + so_tiet - 1 >= {xepLich.TietBD})";
            dt = dataServices.RunQuery(sql);
            if (dt.Rows.Count > 0) return true;
            return false;
        }
    }
}