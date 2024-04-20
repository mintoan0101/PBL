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
    public partial class Quanlynhanvien : Form
    {
        public Quanlynhanvien()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Warning f = new Warning();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ThemNhanvien f = new ThemNhanvien();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ThemNhanvien f = new ThemNhanvien();
            f.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DatLaiMatKhau f = new DatLaiMatKhau();
            f.ShowDialog();
        }
    }
}
