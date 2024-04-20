using MySql.Data.MySqlClient;
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
    
    public partial class Sanpham : Form
    {
        
        public Sanpham()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Themsanpham f = new Themsanpham();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Themsanpham f = new Themsanpham();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Warning f = new Warning();
            f.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Sanpham_Load(object sender, EventArgs e)
        {
            //Đưa tên các danh mục vào comboBox
            LoadDanhMuc();
        }
        public void LoadSanPham()
        {
           
        }
        public void LoadDanhMuc()
        {
            comboBox1.Items.Add("");
            comboBox1.Items.Add("Thịt, cá, trứng, hải sản");
            comboBox1.Items.Add("Rau, củ, trái cây");
            comboBox1.Items.Add("Dầu ăn, nước chấm, gia vị");
            comboBox1.Items.Add("Đồ đông lạnh");
            comboBox1.Items.Add("Sữa các loại");
            comboBox1.Items.Add("Đồ uống");
            comboBox1.Items.Add("Bánh kẹo");
            comboBox1.Items.Add("Đồ dùng cá nhân");
            comboBox1.Items.Add("Vệ sinh nhà cửa");
        }
       
        public DataTable LoadSanPhamTheoDanhMuc(string danhMuc)
        {
            MySQL_Connection mySQL_Connection = new MySQL_Connection();
            MySqlConnection con = mySQL_Connection.getConnection("sieuthi");
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from "+danhMuc, con);
            MySqlDataAdapter adt = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adt.Fill(dataTable);
           // dataGridView1.DataSource = dataTable;
            con.Close();
            return dataTable;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string danhMuc = "";
            if(comboBox1.SelectedIndex ==1)
            {
                danhMuc = "thitcatrunghaisan"; 
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                danhMuc = "raucutraicay";
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                danhMuc = "dauannuocchamgiavi";
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                danhMuc = "dodonglanh";
            }
            else if (comboBox1.SelectedIndex == 5)
            {
                danhMuc = "suacacloai";
            }
            else if (comboBox1.SelectedIndex == 6)
            {
                danhMuc = "douong";
            }
            else if (comboBox1.SelectedIndex == 7)
            {
                danhMuc = "banhkeo";
            }
            else if (comboBox1.SelectedIndex == 8)
            {
                danhMuc = "dodungcanhan";
            }
            else if (comboBox1.SelectedIndex == 9)
            {
                danhMuc = "vesinhnhacua";
            }
            if (danhMuc != "")
            {
               dataGridView1.DataSource =  LoadSanPhamTheoDanhMuc(danhMuc);
            }
            else
            {
                LoadToanBoSanPham();
            }
        }
        public void LoadToanBoSanPham()
        {
            List<string> ds_bang = new List<string>();
            DataTable dataTable = new DataTable();
            MySQL_Connection mySQL_Connection = new MySQL_Connection();
            MySqlConnection con = mySQL_Connection.getConnection("sieuthi");
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SHOW TABLES", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            //Lấy từng tên table
            while(reader.Read())
            {
                string tenBang = reader.GetString(0);
                ds_bang.Add(tenBang);
            }
            con.Close();
            foreach(string st in ds_bang )
            {
                DataTable dt = new DataTable();
                dt = LoadSanPhamTheoDanhMuc(st);
                dataTable.Merge(dt);
            }
            dataGridView1.DataSource = dataTable;
        }
    }
}
