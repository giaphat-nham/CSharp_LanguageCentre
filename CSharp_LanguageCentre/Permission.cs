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
    }
}
