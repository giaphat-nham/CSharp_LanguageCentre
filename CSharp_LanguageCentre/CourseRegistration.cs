using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BUS;
using CSharp_LanguageCentre.DTO;
namespace CSharp_LanguageCentre.GUI
{
    public partial class CourseRegistration : UserControl
    {
        KhoaHocBUS busKH = new KhoaHocBUS();
        HocVienBUS busHV = new HocVienBUS();
        List<KhoaHocDTO> listKH;
        List<HocVienDTO> listHV;
        HoaDonBUS busHD = new HoaDonBUS();
        CTHoaDonBUS busCTHD = new CTHoaDonBUS();

        public CourseRegistration()
        {
            InitializeComponent();
            LoadKH();
            LoadHV();
        }

        private void LoadKH()
        {
            listKH = busKH.getAll();
            dgvKH.DataSource = listKH;

            cbbMaKH.Items.Clear();
            listKH.ForEach(kh =>
            {
                cbbMaKH.Items.Add(kh.MaKH.ToString().Trim());
            });
        }

        private void LoadHV()
        {
            listHV = busHV.getAll();
            dgvHV.DataSource = listHV;

            cbbMaHV.Items.Clear();
            listHV.ForEach(hv =>
            {
                cbbMaHV.Items.Add(hv.MaHV.ToString().Trim());
            });
        }
        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(cbbMaHV.Text) || String.IsNullOrWhiteSpace(cbbMaKH.Text) || String.IsNullOrWhiteSpace(txtNhomKH.Text))
            {
                MessageBox.Show("Không được để trống thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //else if (!busKH.TrungMa(int.Parse(cbbMaKH.SelectedItem.ToString())) || !busHV.TrungMa(int.Parse(cbbMaHV.SelectedItem.ToString())))
            //{
            //    MessageBox.Show("Không tìm thấy mã!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            else
            {
                CTHoaDonDTO cthd = new CTHoaDonDTO(-1, int.Parse(cbbMaKH.SelectedItem.ToString()), 0);
                busCTHD.Insert(cthd);
                HoaDonDTO hoaDon = new HoaDonDTO(cthd.MaHD, DateTime.Today, cthd.Gia, false, int.Parse(cbbMaHV.SelectedItem.ToString()));
                MessageBox.Show(busHD.Insert(hoaDon), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                LoadKH();
                LoadHV();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnXacNhan.Enabled = true;
            btnHuy.Enabled = true;
            

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            btnXacNhan.Enabled = false;
            btnHuy.Enabled = false;
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            Form1.ChangeControlTo(new Student());

        }
    }
}
