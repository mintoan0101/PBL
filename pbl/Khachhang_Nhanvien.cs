using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbl
{
    public partial class Khachhang_Nhanvien : Form
    {
        public Khachhang_Nhanvien()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ThemKhachHang f = new ThemKhachHang();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ThemKhachHang f = new ThemKhachHang();
            f.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Warning f = new Warning();
            f.ShowDialog();
        }
    }
}
