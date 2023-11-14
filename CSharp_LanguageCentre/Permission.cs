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

namespace CSharp_LanguageCentre
{
    public partial class Permission : UserControl
    {
        QuyenBUS busQuyen = new QuyenBUS();
        List<QuyenDTO> listQuyen;
        public Permission()
        {
            InitializeComponent();
            LoadQuyen();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        private void LoadQuyen()
        {
            listQuyen = busQuyen.getAll();
            dgvQuyen.DataSource = listQuyen;
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Form1.ChangeControlTo(new function_menu(Form1.TKDaDangNhap));
        }

        private void btnThemQuyen_Click(object sender, EventArgs e)
        {
           if (String.IsNullOrWhiteSpace(txtTenQuyen.Text))
            {
                MessageBox.Show("Không được để trống thông tin!", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
           else
            {
                MessageBox.Show(busQuyen.Insert(new QuyenDTO(-1,txtTenQuyen.Text)), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ToggleButtonQuyen(bool enterMode)
        {
            btnXacNhanQuyen.Enabled = enterMode;
        }

        private void btnXoaQuyen_Click(object sender, EventArgs e)
        {

        }
    }
}
