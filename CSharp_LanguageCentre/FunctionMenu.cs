using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharp_LanguageCentre.DTO;

namespace CSharp_LanguageCentre
{
    public partial class function_menu : UserControl
    {
        static TaiKhoanDTO tkDaDangNhap;
        static List<ChucNang> danhSachCN = new List<ChucNang>();
        public function_menu()
        {
            InitializeComponent();
        }

        public function_menu(TaiKhoanDTO tkDaDangNhap)
        {
            function_menu.tkDaDangNhap = tkDaDangNhap;
            InitializeComponent();
            lblLoggedInUser.Text = function_menu.tkDaDangNhap.TenTK;
            LoadDanhSachChucNang();
        }

        public void LoadDanhSachChucNang()
        {
            danhSachCN.Add(new ChucNang(1, pnlTaiKhoan));
            danhSachCN.Add(new ChucNang(2, pnlPhanQuyen));
            danhSachCN.Add(new ChucNang(3, pnlHocVien));
            danhSachCN.Add(new ChucNang(4, pnlKhoaHoc));
            danhSachCN.Add(new ChucNang(5, pnlHoaDon));
            danhSachCN.Add(new ChucNang(6, pnlPhongHoc));
            danhSachCN.Add(new ChucNang(7, pnlGiangVien));
            danhSachCN.Add(new ChucNang(8, pnlLuong));
            danhSachCN.Add(new ChucNang(9, pnlNhanVien));
            danhSachCN.Add(new ChucNang(10, pnlThongKe));
            danhSachCN.Add(new ChucNang(11, pnlThoiKhoaBieu));
            danhSachCN.Add(new ChucNang(12, pnlHocPhi));
        }

        public void LoadPanelChucNang(TaiKhoanDTO tkDaDangNhap)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
