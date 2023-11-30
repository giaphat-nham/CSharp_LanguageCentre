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
using DTO;
using CSharp_LanguageCentre.DTO;

namespace CSharp_LanguageCentre.GUI
{
    public partial class XepLich : UserControl
    {
        KhoaHocBUS busKH = new KhoaHocBUS();
        XepLichBUS busXL;
        List<KhoaHocDTO> dsKH = new List<KhoaHocDTO>();
        List<XepLichDTO> dsXL = new List<XepLichDTO>();
        static bool isDeleting = false, isUpdating = false;
        public XepLich()
        {
            InitializeComponent();
            LoadKhoaHoc();
            LoadComboBoxGV();
        }

        private void LoadKhoaHoc()
        {
            dsKH = busKH.getAll();
            dgvKhoaHoc.DataSource = dsKH;
            LoadComboBoxKH();
        }

        private void LoadComboBoxKH()
        {
            cbbMaKH.Items.Clear();
            foreach (KhoaHocDTO kh in dsKH)
            {
                cbbMaKH.Items.Add(kh.MaKH.ToString().Trim());
            }
        }

        private void LoadComboBoxGV()
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCapBac_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dateBatDau_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dateKetThuc_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            Form1.ChangeControlTo(new Course());
        }

        private void LoadXepLich()
        {
            dgvLichKH.DataSource = dsXL;
        }

        private void cbbMaKH_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int maKH = Convert.ToInt32(cbbMaKH.SelectedItem);
            busXL = new XepLichBUS(maKH);
            dsXL = busXL.getLichKhoaHoc(maKH);
            LoadXepLich();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (isDeleting)
            {
                isDeleting = false;

                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;

                btnXacNhan.Enabled = false;
                btnHuy.Enabled = false;

                cbbNhomKH.Enabled = false;
                txtTenKH.Enabled = true;
                cbbGiangVien.Enabled = true;
                cbbThu.Enabled = true;
                cbbTietBD.Enabled = true;
                cbbSoTiet.Enabled = true;
                cbbPhong.Enabled = true;
            }
            else if (isUpdating)
            {
                isUpdating = false;

                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;

                btnXacNhan.Enabled = false;
                btnHuy.Enabled = false;

                cbbNhomKH.Enabled = false;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            isUpdating = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            btnXacNhan.Enabled = true;
            btnHuy.Enabled = true;

            cbbNhomKH.Enabled = true;
        }

        private bool InputEmpty()
        {
            if (String.IsNullOrWhiteSpace(txtTenKH.Text) || String.IsNullOrWhiteSpace(cbbMaKH.SelectedItem.ToString()) || String.IsNullOrWhiteSpace(cbbThu.SelectedItem.ToString()) || String.IsNullOrWhiteSpace(cbbTietBD.SelectedItem.ToString()) || String.IsNullOrWhiteSpace(cbbSoTiet.SelectedItem.ToString()) || String.IsNullOrWhiteSpace(cbbGiangVien.SelectedItem.ToString()) || String.IsNullOrWhiteSpace(cbbPhong.SelectedItem.ToString()))
            {
                return true;
            }
            return false;
        }

        private bool ThoiGianHopLe()
        {
            return false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (InputEmpty())
            {
                MessageBox.Show("Không được để trống thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!ThoiGianHopLe())
            {

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            isDeleting = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            btnXacNhan.Enabled = true;
            btnHuy.Enabled = true;

            cbbNhomKH.Enabled = true;
            txtTenKH.Enabled = false;
            cbbGiangVien.Enabled = false;
            cbbThu.Enabled = false;
            cbbTietBD.Enabled = false;
            cbbSoTiet.Enabled = false;
            cbbPhong.Enabled = false;
        }
    }
}
