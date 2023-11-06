﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharp_LanguageCentre.DTO;
using DTO;
using BUS;

namespace CSharp_LanguageCentre
{
    public partial class function_menu : UserControl
    {
        static TaiKhoanDTO tkDaDangNhap;
        static List<Panel> danhSachCN = new List<Panel>();
        static List<ChiTietPhanQuyenDTO> danhSachCNNguoiDung = new List<ChiTietPhanQuyenDTO>();
        static ChiTietPhanQuyenBUS quyenBUS = new ChiTietPhanQuyenBUS();
        public function_menu()
        {
            InitializeComponent();
        }

        public function_menu(TaiKhoanDTO tkDaDangNhap)
        {
            function_menu.tkDaDangNhap = tkDaDangNhap;
            danhSachCNNguoiDung = quyenBUS.QuyenTK(function_menu.tkDaDangNhap.TenTK);
            InitializeComponent();
            lblLoggedInUser.Text = function_menu.tkDaDangNhap.TenTK;
            LoadDanhSachChucNang();
            LoadPanelChucNang(function_menu.tkDaDangNhap);

        }

        public void LoadDanhSachChucNang()
        {
            danhSachCN.Add(pnlTaiKhoan);
            danhSachCN.Add(pnlPhanQuyen);
            danhSachCN.Add(pnlHocVien);
            danhSachCN.Add(pnlKhoaHoc);
            danhSachCN.Add(pnlHoaDon);
            danhSachCN.Add(pnlPhongHoc);
            danhSachCN.Add(pnlGiangVien);
            danhSachCN.Add(pnlLuong);
            danhSachCN.Add(pnlNhanVien);
            danhSachCN.Add(pnlThongKe);
            danhSachCN.Add(pnlThoiKhoaBieu);
            danhSachCN.Add(pnlHocPhi);
        }                          

        public void LoadPanelChucNang(TaiKhoanDTO tkDaDangNhap)
        {
            danhSachCN.ForEach(chucnang =>
            {
                chucnang.Visible = false;
            });
            danhSachCNNguoiDung.ForEach(chucnang =>
            {
                danhSachCN[chucnang.MaCN - 1].Visible = true;
            });
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            tkDaDangNhap = null;
            
            DialogResult result = MessageBox.Show("Quay trở lại màn hình đăng nhập?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                Form1.ChangeControlTo(new MainMenu());
            }
        }
    }
}
