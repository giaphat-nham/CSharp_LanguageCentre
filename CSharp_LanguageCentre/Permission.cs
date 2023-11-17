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
        static bool isDeleting = false, isUpdating = false;
        public Permission()
        {
            InitializeComponent();
            LoadQuyen();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (isDeleting)
            {
                if (String.IsNullOrWhiteSpace(txtMaQuyen.Text))
                {
                    MessageBox.Show("Không được để trống thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (isUpdating)
            {

            }
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
                MessageBox.Show("Không được để trống thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                QuyenDTO quyen = new QuyenDTO(-1, txtTenQuyen.Text);
                MessageBox.Show(busQuyen.Insert(quyen), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadQuyen();
            }
        }

        private void ToggleButtonQuyen()
        {
            if (isDeleting || isUpdating)
            {
                btnXacNhanQuyen.Enabled = true;
                btnHuyQuyen.Enabled = true;
                btnThemQuyen.Enabled = false;
                btnSuaQuyen.Enabled = false;
                btnXoaQuyen.Enabled = false;
            }

        }

        private void btnHuyQuyen_Click(object sender, EventArgs e)
        {
            if (isDeleting)
            {
                isDeleting = false;
                btnXacNhanQuyen.Enabled = false;
                btnHuyQuyen.Enabled = false;
                btnThemQuyen.Enabled = true;
                btnSuaQuyen.Enabled = true;
                btnXoaQuyen.Enabled = true;

                btnXoaQuyen.ForeColor = Color.Black;
                txtMaQuyen.Enabled = false;
                txtTenQuyen.Enabled = true;
            }
            else if (isUpdating)
            {
                isUpdating = false;
                btnXacNhanQuyen.Enabled = false;
                btnHuyQuyen.Enabled = false;
                btnThemQuyen.Enabled = true;
                btnSuaQuyen.Enabled = true;
                btnXoaQuyen.Enabled = true;

                btnSuaQuyen.ForeColor = Color.Black;
                txtMaQuyen.Enabled = false;
                txtTenQuyen.Enabled = true;
            }
        }

        private void btnSuaQuyen_Click(object sender, EventArgs e)
        {
            isUpdating = true;
            btnSuaQuyen.ForeColor = Color.FromArgb(1, 226, 91, 69);
            txtMaQuyen.Enabled = true;
            txtTenQuyen.Enabled = true;
            ToggleButtonQuyen();
        }

        private void btnXoaQuyen_Click(object sender, EventArgs e)
        {
            isDeleting = true;
            btnXoaQuyen.ForeColor = Color.FromArgb(1, 226, 91, 69);
            txtMaQuyen.Enabled = true;
            txtTenQuyen.Enabled = false;
            ToggleButtonQuyen();
        }
    }
}
