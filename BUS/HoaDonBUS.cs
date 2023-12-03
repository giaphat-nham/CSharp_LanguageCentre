using CSharp_LanguageCentre.DTO;
using DAO;
using System;
using System.Collections.Generic;
namespace BUS
{
    public class HoaDonBUS
    {
        static HoaDonDAO dao;
        static List<HoaDonDTO> danhSach;

        public HoaDonBUS()
        {
            dao = new HoaDonDAO();
            danhSach = dao.getAll();
        }

        public List<HoaDonDTO> getAll()
        {
            return dao.getAll();
        }

        public int NextID()
        {
            return dao.NextID();
        }

        public int GetFee(int maKH)
        {
            return dao.GetFee(maKH);
        }

        public string Insert(HoaDonDTO hoaDon)
        {
            
            hoaDon.TinhTrangThanhToan = false;
            
            if (dao.Insert(hoaDon))
            {
                danhSach = dao.getAll();
                return "Thêm thành công!";
            }
            return "Đã có lỗi xảy ra!";
        }

        public string Delete(int maHD)
        {
            if (dao.Delete(maHD))
            {
                danhSach = dao.getAll();
                return "Xóa thành công!";
            }
            return "Đã có lỗi xảy ra";
        }

        public string Update(HoaDonDTO hoaDon)
        {
            if (dao.Update(hoaDon))
            {
                danhSach = dao.getAll();
                return "Cập nhật thành công!";
            }
            return "Đã có lỗi xảy ra!";
        }

        public bool TrungMa(int maHD)
        {
            return dao.TrungMa(maHD);
        }

        //public List<HoaDonDTO> Search(string key, int option, int state)
        //{
        //    List<HoaDonDTO> searchList = new List<HoaDonDTO>();

        //    if (option == 0) //tim bang ma khoa hoc
        //    {
        //        if(state == 0)
        //        {
        //            foreach (HoaDonDTO hd in danhSach)
        //            {
        //                if (hd.MaHV == Convert.ToInt32(key) && hd.TinhTrangThanhToan == 0)
        //                {
        //                    searchList.Add(hd);
        //                    break;
        //                }
        //            }
        //        }
        //        else if(state == 1)
        //        {
        //            foreach (HoaDonDTO hd in danhSach)
        //            {
        //                if (hd.MaHV == Convert.ToInt32(key) && hd.TinhTrangThanhToan == 1)
        //                {
        //                    searchList.Add(hd);
        //                    break;
        //                }
        //            }
        //        }
        //        else
        //        {
        //            foreach (HoaDonDTO hd in danhSach)
        //            {
        //                if (hd.MaHV == Convert.ToInt32(key))
        //                {
        //                    searchList.Add(hd);
        //                    break;
        //                }
        //            }
        //        }


        //    }
        //    else if (option == 1) //tim theo ngay
        //    {

        //    }

        //    return searchList;

        //}

        public List<HoaDonDTO> Search(string key, int option, DateTime date, int state)
        {
            List<HoaDonDTO> searchList = new List<HoaDonDTO>();

            if (option == 0) //tim bang ma hoa don
            {
                if(state == 0)
                {
                    foreach (HoaDonDTO hd in danhSach)
                    {
                        if (hd.MaHD == Convert.ToInt32(key) || hd.TinhTrangThanhToan == false)
                        {
                            searchList.Add(hd);
                            break;
                        }
                    }
                }
                else if (state == 1)
                {
                    foreach (HoaDonDTO hd in danhSach)
                    {
                        if (hd.MaHD == Convert.ToInt32(key) || hd.TinhTrangThanhToan == true)
                        {
                            searchList.Add(hd);
                            break;
                        }
                    }
                }
                else
                {
                    foreach (HoaDonDTO hd in danhSach)
                    {
                        if (hd.MaHD == Convert.ToInt32(key))
                        {
                            searchList.Add(hd);
                            break;
                        }
                    }
                }
            }
            else if (option == 1) //tim theo ngay
            {
                if(state == 0)
                {
                    foreach (HoaDonDTO hd in danhSach)
                    {
                        if (hd.NgayHD == date || hd.TinhTrangThanhToan == false)
                        {
                            searchList.Add(hd);
                        }
                    }
                }
                else if(state == 1)
                {
                    foreach (HoaDonDTO hd in danhSach)
                    {
                        if (hd.NgayHD == date || hd.TinhTrangThanhToan == true)
                        {
                            searchList.Add(hd);
                        }
                    }
                }
                else
                {
                    foreach (HoaDonDTO hd in danhSach)
                    {
                        if (hd.NgayHD == date)
                        {
                            searchList.Add(hd);
                        }
                    }
                }
            }

            return searchList;

        }

    }
}
