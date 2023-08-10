using System;
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
        private Rectangle labeltitleRec;
        private Rectangle logoRec;
        private Rectangle tb1Rec;
        private Rectangle tb2Rec;
        private Rectangle labelNameRec;
        private Rectangle labelPassRec;
        private Rectangle checkBox1Rec;
        private Rectangle btnSignInRec;
        private Size signInForm;
        MainPage mainpage; //Tạo 1 đối tượng và 1 
        SqlConnection conn;
        SqlCommand cmd;
        public signIn()
        {
            InitializeComponent();

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

        private void signIn_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            signInForm = this.Size;
            logoRec = new Rectangle(logo.Location.X, logo.Location.Y, logo.Width, logo.Height);
            tb1Rec = new Rectangle(tBUserName.Location.X, tBUserName.Location.Y, tBUserName.Width, tBUserName.Height);
            tb2Rec = new Rectangle(tBPass.Location.X, tBPass.Location.Y, tBPass.Width, tBPass.Height);
            labelNameRec = new Rectangle(labelUserName.Location.X, labelUserName.Location.Y, labelUserName.Width, labelUserName.Height);
            labelPassRec = new Rectangle(labelPass.Location.X, labelPass.Location.Y, labelPass.Width, labelPass.Height);
            checkBox1Rec = new Rectangle(cBPass.Location.X, cBPass.Location.Y, cBPass.Width, cBPass.Height);
            btnSignInRec = new Rectangle(btnSignIn.Location.X, btnSignIn.Location.Y, btnSignIn.Width, btnSignIn.Height);
            labeltitleRec = new Rectangle(label2.Location.X, label2.Location.Y, label2.Width, label2.Height);

        }

        private void resizeChildrenControls()
        {
            resizeControl(labeltitleRec, label2);
            resizeControl(logoRec, logo);
            resizeControl(btnSignInRec, btnSignIn);
            resizeControl(tb1Rec, tBUserName);
            resizeControl(tb2Rec, tBPass);
            resizeControl(labelNameRec, labelUserName);
            resizeControl(labelPassRec, labelPass); 
            resizeControl(checkBox1Rec, cBPass);

        }

        //Hàm sử dụng để kiểm soát việc thay đổi kích thước lưu kích thước ban đầu và kích thước hiện tại 
        private void resizeControl(Rectangle OriginalControlRect, Control control)
        {
            float xRatio = (float)(this.Width) / (float)(signInForm.Width);
            float yRatio = (float)(this.Height) / (float)(signInForm.Height);


            int newX = (int)(OriginalControlRect.X * xRatio);
            int newY = (int)(OriginalControlRect.Y * yRatio);

            int newWidth = (int)(OriginalControlRect.Width * xRatio);
            int newHeight = (int)(OriginalControlRect.Height * yRatio);

            control.Location = new Point(newX, newY);
            control.Size = new Size(newWidth, newHeight);
        }

        //Hàm thực hiện sự kiện thay đổi 
        private void signIn_Resize(object sender, EventArgs e)
        {
            resizeChildrenControls();
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
    }
}
