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
		ThongKeDAO thongKeDAO;
		List<ThongKeDAO> thongKeDAOList;

		public ThongKeBUS()
		{
			thongKeDAO = new ThongKeDAO();
		}

		public List<HoaDonDTO> getAllHoaDon(DateTime ngayHD)
		{
			return thongKeDAO.getAllHoaDon(ngayHD);
		}

		public List<KhoaHocDTO> getAllKhoaHoc(DateTime ngayBD) 
		{
			return KhoaHocDAO.getAll()
	}
}
