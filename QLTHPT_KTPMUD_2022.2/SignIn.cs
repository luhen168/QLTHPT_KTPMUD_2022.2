﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace QLTHPT_KTPMUD_2022._2
{
    public partial class signIn : Form
    {
        MainPage mainpage; //Tạo 1 đối tượng và 1 
        SqlConnection conn;
        SqlCommand cmd;
        public signIn()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Width = 800;   // Thiết lập chiều rộng
            this.Height = 600;  // Thiết lập chiều cao

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = DatabaseConnection.Instance.ConnectionString;
            conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "SELECT COUNT(*) FROM dbo.TK WHERE TenND = @username AND MatKhau = @password"; //Đếm số tài khoản 
            cmd = new SqlCommand(query, conn); //Thuc thi lenh de truy van toi bang trong SQL Server
            cmd.Parameters.Add(new SqlParameter("@username",tBUserName.Text)); //Nhan vao tu ban phim
            cmd.Parameters.Add(new SqlParameter("@password", tBPass.Text)); //Nhan vao tu ban phim

            int x =  (int)cmd.ExecuteScalar();
            if (x == 1)
            {
                //MessageBox.Show("Đăng nhập thành công!");
                this.Hide(); //trỏ đến SignIn và ẩn 
                mainpage = new MainPage(); //Tạo 1 đối tượng từ lớp
                mainpage.Show(); //truy cập vào phương thức của đối tượng 
            }
            else
            {
                //MessageBox.Show("Đăng nhập không thành công!");
                Incorrect.Text = "Sai tên đăng nhập hoặc mật khẩu!";
                tBUserName.Text = ""; //Tu dong xoa cac ki tu sai 
                tBPass.Text = "";      //Tu dong xoa cac ki tu sai 
                tBUserName.Focus();     //Quay lai phan tBUserName de go
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }



        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cBPass.Checked)
            {
                tBPass.UseSystemPasswordChar = false;
            }
            else 
            { 
                tBPass.UseSystemPasswordChar = true; 
            }
        }

        private void signIn_Load(object sender, EventArgs e)
        {

        }
    }
}
