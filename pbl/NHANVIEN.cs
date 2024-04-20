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
    public partial class NHANVIEN : Form
    {
        private Form currentFormChild;
        private string username { get; set; }
        public NHANVIEN(string str)
        {   
            username = str;
            InitializeComponent();
        }
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
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
                    }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool isClick = false;
            if (isClick)
            {
                panel4.Size = panel4.MinimumSize;
                isClick = true;
            }
            else
            {
                panel4.Size = panel4.MaximumSize;
                isClick = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Hoadon_nhanvien());
            button2.BackColor = panel3.BackColor;
            button1.BackColor = panel2.BackColor;
            button3.BackColor = panel2.BackColor;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Khachhang_Nhanvien());
            button3.BackColor = panel3.BackColor;
            button1.BackColor = panel2.BackColor;
            button2.BackColor = panel2.BackColor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Sanpham());
            button1.BackColor = panel3.BackColor;
            button3.BackColor = panel2.BackColor;
            button2.BackColor = panel2.BackColor;
        }

        private void NHANVIEN_Load(object sender, EventArgs e)
        {
            btn_user.Text = username;
        }
    }
}
