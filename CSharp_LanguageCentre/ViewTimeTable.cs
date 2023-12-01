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
    public partial class ViewTimeTable : UserControl
    {
        ThoiKhoaBieuBUS bus = new ThoiKhoaBieuBUS();
        List<ThoiKhoaBieuDTO> dsTKB;
        public ViewTimeTable()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtMaGV_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnXemTKBGV_Click(object sender, EventArgs e)
        {
            int num = -1;
            if (String.IsNullOrWhiteSpace(txtMaGV.Text))
            {
                MessageBox.Show("Không được để trống thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!int.TryParse(txtMaGV.Text, out num) || num <= 0)
            {
                MessageBox.Show("Mã giảng viên không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                dsTKB = bus.getTKBGV(Convert.ToInt32(txtMaHV.Text));
                dgvTKB.DataSource = dsTKB;
            }
        }

        private void btnInTKBGV_Click(object sender, EventArgs e)
        {

        }

        private void btnXemTKBHV_Click(object sender, EventArgs e)
        {
            int num = -1;
            if (String.IsNullOrWhiteSpace(txtMaHV.Text))
            {
                MessageBox.Show("Không được để trống thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!int.TryParse(txtMaHV.Text, out num) || num <= 0)
            {
                MessageBox.Show("Mã học viên không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                dsTKB = bus.getTKBHV(Convert.ToInt32(txtMaHV.Text));
                dgvTKB.DataSource = dsTKB;
            }
        }
    }
}
