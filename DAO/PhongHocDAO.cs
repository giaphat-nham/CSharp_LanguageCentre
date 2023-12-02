using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp_LanguageCentre.DTO;

namespace DAO
{
	public class PhongHocDAO
	{
		DataServices dataServices = new DataServices();
		DataTable dataTable;

		public PhongHocDAO()
		{
		}

		public List<PhongHocDTO> getAll()
		{
			List<PhongHocDTO> list = new List<PhongHocDTO>();
			string query = "select * from phong_hoc";
			if (!dataServices.OpenDB()) return null;
			else dataTable = dataServices.RunQuery(query);
			PhongHocDTO ph;

			for (int i = 0; i < dataTable.Rows.Count; i++)
			{
				ph = new PhongHocDTO();
				ph.MaPH = (int)dataTable.Rows[i]["ma_ph"];
				ph.TenPH = dataTable.Rows[i]["ten_ph"].ToString();
				ph.SucChua = (int)dataTable.Rows[i]["suc_chua"];
				list.Add(ph);
			}
			return list;
		}
		public int AutoID()
		{
			int id = 0;
			string querygv = "select max(ma_gv) as max_magv from giang_vien";
			dataTable = dataServices.RunQuery(querygv);
			if (dataTable.Rows.Count > 0) id = Convert.ToInt32(dataTable.Rows[0]["max_magv"]) + 1;
			else id = 1;
			return id;

		}

		public bool DeletePH(int maPH)
		{
			/*string query_1 = "select * from thoi_khoa_bieu";
			dataTable = dataServices.RunQuery(query_1);
			foreach (DataRow row in dataTable.Rows)
			{
				if (row["ma_ph"].Equals(maPH)) row.Delete();
			}
			dataServices.Update(dataTable);
			*/
			string query = "select * from phong_hoc";
			dataTable = dataServices.RunQuery(query);
			dataTable.PrimaryKey = new DataColumn[] { dataTable.Columns["ma_ph"] };
			dataTable.Rows.Find(maPH).Delete();
			dataServices.Update(dataTable);
			return true;

		}
		public bool KiemTraMaPH(int maPH)
		{
			string query = $"select * from phong_hoc where ma_ph = {maPH}";
			dataTable = dataServices.RunQuery(query);
			if (dataTable.Rows.Count > 0) return false;
			return true;
		}

		public bool InsertPH(PhongHocDTO ph)
		{
			string query = "select * from phong_hoc";
			dataTable = dataServices.RunQuery(query);
			DataRow new_row = dataTable.NewRow();
			new_row["ma_ph"] = ph.MaPH;
			new_row["ten_ph"] = ph.TenPH;
			new_row["suc_chua"] = ph.SucChua;

			dataTable.Rows.Add(new_row);
			dataServices.Update(dataTable);
			return true;

		}

		public bool UpdatePH(PhongHocDTO ph)
		{
			string query = "select * from phong_hoc";
			dataTable = dataServices.RunQuery(query);
			//Tạo cột khóa chính trong DataTable
			dataTable.PrimaryKey = new DataColumn[] { dataTable.Columns["ma_ph"] };
			DataRow new_row = dataTable.Rows.Find(ph.MaPH);
			new_row["ten_ph"] = ph.MaPH;
			new_row["suc_chua"] = ph.SucChua; ;

			//Cập nhật lại dữ liệu lên database
			dataServices.Update(dataTable);
			return true;
		}

	}
}
