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
    public partial class ThemNhanvien : Form
    {
        public ThemNhanvien()
        {
            InitializeComponent();
        }

        private void ThemNhanvien_Load(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.textBox1.Text) &&
                 !string.IsNullOrEmpty(this.textBox2.Text) &&
                 !string.IsNullOrEmpty(this.textBox3.Text) &&
                 !string.IsNullOrEmpty(this.textBox4.Text) &&
                 !string.IsNullOrEmpty(this.textBox5.Text) &&
                 !string.IsNullOrEmpty(this.textBox6.Text) &&
                 !string.IsNullOrEmpty(this.textBox7.Text) &&
                 !string.IsNullOrEmpty(this.textBox8.Text) &&
                 !string.IsNullOrEmpty(this.textBox9.Text) &&
                 !string.IsNullOrEmpty(this.textBox10.Text) &&
                 !string.IsNullOrEmpty(this.textBox11.Text))               
            {
                this.Close();
            }
        
            else MessageBox.Show("Vui lòng điền đầy đủ thông tin");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
