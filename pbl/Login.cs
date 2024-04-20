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
    public partial class Login : Form
    {
        private List_User list_user { get; set; }
        MySQL_Connection mySQL_Connection;
        public Login()
        {
            InitializeComponent();
            LoadUser();
        }
        public void LoadUser()
        {
            list_user = new List_User();
            mySQL_Connection = new MySQL_Connection();
            MySqlConnection con = mySQL_Connection.getConnection("sieuthi");
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from user", con);
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string username = reader["username"].ToString();
                    string password = reader["password"].ToString();
                    user new_user = new user(username, password);
                    list_user.AddUser(new_user);
                }
            }
            con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(txt_username.Text ==""||txt_password.Text=="")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                user person = new user(txt_username.Text,txt_password.Text);
                if(list_user.IsUserExist(person))
                {
                   
                     NHANVIEN nhanvien = new NHANVIEN(txt_username.Text);
                     nhanvien.ShowDialog();
          
                }
                else
                {
                    MessageBox.Show("Thông tin đăng nhập không chính xác, vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
