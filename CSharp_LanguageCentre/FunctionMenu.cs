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
        public function_menu()
        {
            InitializeComponent();
        }

        public function_menu(TaiKhoanDTO tkDaDangNhap)
        {
            function_menu.tkDaDangNhap = tkDaDangNhap;
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
