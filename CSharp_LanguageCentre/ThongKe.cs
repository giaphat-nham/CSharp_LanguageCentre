using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using CSharp_LanguageCentre.DTO;

namespace CSharp_LanguageCentre
{
	public partial class ThongKe : UserControl
	{
		ThongKeBUS thongKeBUS = new ThongKeBUS();
		List<HoaDonDTO> hoaDonList = new List<HoaDonDTO>();
		List<KhoaHocDTO> khoaHocList = new List<KhoaHocDTO>();
		public ThongKe()
		{
			InitializeComponent();
		}

		private void ThongKe_Load(object sender, EventArgs e)
		{

		}

		private void btnTimKiem_Click(object sender, EventArgs e)
		{
			if(cbbLocTimKiem.SelectedIndex == 0)
			{
				hoaDonList = thongKeBUS.getHoaDon(dateTimePicker1.Value);

				if (hoaDonList.Count < 1)
				{
					MessageBox.Show("Không tìm thấy kết quả tìm kiếm hợp lệ !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					dataGridView1.DataSource = hoaDonList;
				}
			}
			else if (cbbLocTimKiem.SelectedIndex == 1)
			{
				khoaHocList = thongKeBUS.getKhoaHoc(dateTimePicker1.Value);

				if (khoaHocList.Count < 1)
				{
					MessageBox.Show("Không tìm thấy kết quả tìm kiếm hợp lệ !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					dataGridView1.DataSource = khoaHocList;
				}
			}
		}

		private void btnQuayLai_Click(object sender, EventArgs e)
		{
			Form1.ChangeControlTo(new function_menu(Form1.TKDaDangNhap));

		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{

		}
	}
}
