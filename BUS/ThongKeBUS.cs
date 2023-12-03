using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp_LanguageCentre.DTO;
using DTO;

namespace BUS
{
	public class ThongKeBUS
	{
		static ThongKeDAO thongKeDAO;
		static KhoaHocDAO khoaHocDAO;
		static List<HoaDonDTO> hdList;
		static List<KhoaHocDTO> khList;

		public ThongKeBUS()
		{
		}


		public List<HoaDonDTO> getHoaDon(DateTime ngayHD)
		{
			List<HoaDonDTO>  list = new List<HoaDonDTO>();
			foreach (HoaDonDTO dto in hdList)
			{
				if (dto.NgayHD.Month == ngayHD.Month)
				{
					list.Add(dto);
				}
			}
			return list;
		}

		public List<KhoaHocDTO> getKhoaHoc(DateTime ngayBD)
		{
			List<KhoaHocDTO> list = new List<KhoaHocDTO>();
			foreach (KhoaHocDTO dto in khList)
			{
				if (dto.NgayBD.Month == ngayBD.Month)
				{
					list.Add(dto);
				}
			}
			return list;
		}
	}
}
