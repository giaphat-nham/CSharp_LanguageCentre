using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp_LanguageCentre.DTO;

namespace DAO
{
	public class ThongKeDAO
	{

		DataServices dataServices = new DataServices();
		DataTable dataTable;

		public ThongKeDAO()
		{
		}
		public List<HoaDonDTO> getAllHoaDon(DateTime ngayHD)
		{
			List<HoaDonDTO> list = new List<HoaDonDTO>();
			string sql = "SELECT * FROM hoa_don";
			if (!dataServices.OpenDB()) return null;
			dataTable = dataServices.RunQuery(sql);
			HoaDonDTO hoadon;

			for (int i = 0; i < dataTable.Rows.Count; i++)
			{
				hoadon = new HoaDonDTO();
				hoadon.MaHD = (int)dataTable.Rows[i]["ma_hd"];
				hoadon.NgayHD = (DateTime)dataTable.Rows[i]["ngay"];
				hoadon.HocPhi = (int)dataTable.Rows[i]["hoc_phi"];
				hoadon.MaHV = (int)dataTable.Rows[int]["ma_hv"];
				list.Add(hoadon);
			}

			return list;
		}
	}
}
