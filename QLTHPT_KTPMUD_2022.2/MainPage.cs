using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTHPT_KTPMUD_2022._2
{
    public partial class MainPage : Form
    {
        QLGV qlgv;
        QLHS qlhs;
        QLLH qllh;
        QLBCTK qlbctk;
        QLMH qlmh;
        QLKQHT qlkqht;
        QLTK qltk;
        string connectionString = DatabaseConnection.Instance.ConnectionString;
        signIn signin;
        public MainPage()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Width = 1024;   // Thiết lập chiều rộng
            this.Height = 768;  // Thiết lập chiều cao
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuQLKQHT_Click(object sender, EventArgs e)
        {

        }

        private void menuQLGV_Click(object sender, EventArgs e)
        {
            this.Hide();
            qlgv = new QLGV();
            qlgv.Show();
        }

        private void menuQLHS_Click(object sender, EventArgs e)
        {
            this.Hide();
            qlhs = new QLHS();
            qlhs.Show();
        }

        private void menuQLLH_Click(object sender, EventArgs e)
        {
            this.Hide();
            qllh = new QLLH();
            qllh.Show();
        }

        private void menuQLMH_Click(object sender, EventArgs e)
        {
            this.Hide();
            qlmh = new QLMH();
            qlmh.Show();
        }

        //Hàm xử lí Đăng xuất 
        private void signOut_Click(object sender, EventArgs e)
        {
            // đối tượng MessageBox xử lí kết quả hộp thoại bằng phương thức Show
            DialogResult = MessageBox.Show("Bạn muốn đăng xuất ?","Đăng xuất",MessageBoxButtons.YesNo); //Tạo 1 đối tượng Dialog và gán giá trị do của MessageBox.Show 
            if(DialogResult == DialogResult.Yes) //Nếu kết quả là Yes thì thực hiện thoát ứng dụng
            {
                this.Hide(); //this là ngầm định của MainPage,lớp này được ẩn đi 
                signin = new signIn(); //tạo 1 đối tượng để quay lại màn hình đăng nhập
                signin.Show(); //sử dụng phương thức Show hiển thị ra màn hình đăng nhập
            }
        }

    }
}
