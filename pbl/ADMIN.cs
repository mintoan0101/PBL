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
    public partial class ADMIN : Form
    {
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel3.Controls.Add(childForm);
            panel3.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void OpenChildForm1(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false; 
            childForm.FormBorderStyle = FormBorderStyle.None; 
            panel3.Controls.Add(childForm);
            int centerX = (panel3.Width - childForm.Width) / 2;
            int centerY = (panel3.Height - childForm.Height) / 2;
            childForm.Left = centerX;
            childForm.Top = centerY;
            childForm.BringToFront();
            childForm.Show();
        }

        public ADMIN()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Khachhang_Nhanvien());
            button2.BackColor = panel2.BackColor;
            button9.BackColor = panel2.BackColor;
            button7.BackColor = panel2.BackColor;
            button1.BackColor = panel2.BackColor;
            button8.BackColor = panel2.BackColor;
            button3.BackColor = panel3.BackColor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Sanpham());
            button2.BackColor = panel2.BackColor;
            button9.BackColor = panel2.BackColor;
            button7.BackColor = panel2.BackColor;
            button3.BackColor = panel2.BackColor;
            button8.BackColor = panel2.BackColor;
            button1.BackColor = panel3.BackColor;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DanhSachHoaDon f = new DanhSachHoaDon();
            OpenChildForm1(f);
            button3.BackColor = panel2.BackColor;
            button9.BackColor = panel2.BackColor;
            button7.BackColor = panel2.BackColor;
            button1.BackColor = panel2.BackColor;
            button8.BackColor = panel2.BackColor;
            button2.BackColor = panel3.BackColor;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Quanlynhanvien());
            button2.BackColor = panel2.BackColor;
            button9.BackColor = panel2.BackColor;
            button2.BackColor = panel2.BackColor;
            button1.BackColor = panel2.BackColor;
            button8.BackColor = panel2.BackColor;
            button7.BackColor = panel3.BackColor;
        }
    }
}
