using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Net;
using System.Reflection.Emit;
using System.Windows.Forms;


namespace QLTHPT_KTPMUD_2022._2
{
    public partial class QLMH : Form
    {       
        
        private MainPage mainPage = new MainPage();
        private DataTable dataTable = new DataTable(); //Tạo đối tượng bảng
        string connectionString = DatabaseConnection.Instance.ConnectionString;
        public QLMH()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Width = 1024;   // Thiết lập chiều rộng
            this.Height = 768;  // Thiết lập chiều cao
        }
       
        //Nút quay lại trang chủ
        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainPage.Show();
        }
        
        // hàm thực hiện load data từ sql vào dataGridview
        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM MH";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dataTable);
            }
            dgvMH.DataSource = dataTable;
        }

        // chức năng tìm kiếm
        private void Find_Click(object sender, EventArgs e)
        {
            string search = tBFind.Text;
            DataView dv = new DataView(dataTable);
            dv.RowFilter = $"MaMH like '%{search}%' or TenMH like '%{search}%'";
            dgvMH.DataSource = dv;
        }

        // thêm dữ liệu
        private void Add_Click(object sender, EventArgs e)
        {
            // Xử lý truy vấn INSERT vào cơ sở dữ liệu tại đây
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO MH (MaMH, TenMH) " +
                        "VALUES (@MaMH,@TenMH)";  // chuỗi truy vần sql để thêm dữ liệu vào bảng
                    using (SqlCommand command = new SqlCommand(query, connection))  // tạo đối tượng thuộc lớp SqlCommand đê thực hiện truy vấn
                    {
                        // lấy các giá trị từ textbox để thực hiện truy vấn
                        command.Parameters.Add(new SqlParameter("@MaMH", tBmaMH.Text));
                        command.Parameters.Add(new SqlParameter("@TenMH", tBName.Text));
                        int rowsAffected = command.ExecuteNonQuery();  // tạo biến rowAffected, kết quả trả về là số dòng bị thay đổi trong cơ sở dữ liệu
                        if (rowsAffected > 0)  // nếu có hàng bị ảnh hưởng
                        {
                            MessageBox.Show("Thêm dữ liệu thành công!");
                            // Sau khi THÊM thành công
                            dataTable.Clear();   //thực hiện xóa dữ liệu cũ trên dataGridview
                            LoadData();    // tải lại và cập nhật dữ liệu mới trên dataGridview
                            ClearData();  // thực hiện xóa dữ liệu trên các textbox 
                        }
                        else  // không có hàng bị ảnh hưởng
                        {
                            MessageBox.Show("Không thể thêm dữ liệu!");
                            ClearData();
                        }
                    }
                }
            }
            catch (Exception ex) // thực hiện bắt các lỗi, ngoại lệ (exception) trong khối try khi truy vấn, nếu có lỗi sẽ chương trình sẽ chạy khối cacth
            {
                MessageBox.Show("Lỗi khi thêm dữ liệu: " + ex.Message);  // thực hiện hiển thị lỗi mà biến 'ex' chứa
            }
        }
        private void ClearData()  // hàm thực hiện xóa dữ liệu trên các textbox
        {
            // gán giá trị null có các textbox
            tBName.Text = "";
            tBmaMH.Text = "";
        }
        
        // Xóa dữ liệu
        private void Delete_Click(object sender, EventArgs e)
        {
            try 
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM MH WHERE MaMH = @MaMH";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.Add(new SqlParameter("@MaMH", tBmaMH.Text));
                        command.Parameters.Add(new SqlParameter("@TenMH", tBName.Text));
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Xóa dữ liệu thành công!");
                            // Sau khi XÓA thành công
                            dataTable.Clear();
                            LoadData();
                            ClearData();
                        }
                        else
                        {
                            MessageBox.Show("Không thể xóa dữ liệu!");
                            ClearData();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi Xóa dữ liệu: " + ex.Message);
                ClearData();

            }
        }

        // hàm thực hiện xử lý sự kiện lấy vị trí hàng được nhấp chuột trên dataGridview
        private void dgvMH_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e) 
        {
            tBName.Text = dgvMH.Rows[e.RowIndex].Cells[1].Value.ToString();  // gán giá trị của ô tại cột 1 của hàng đã chọn vào textbox
            tBmaMH.Text = dgvMH.Rows[e.RowIndex].Cells[0].Value.ToString();  // gán giá trị của ô tại cột 0 của hàng đã chọn vào textbox
        }

        // hàm thực hiện sửa dữ liệu
        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE MH SET MaMH = @MaMH,TenMH = @TenMH WHERE MaMH = @MaMH";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.Add(new SqlParameter("@MaMH", tBmaMH.Text));
                        command.Parameters.Add(new SqlParameter("@TenMH", tBName.Text));
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Sửa dữ liệu thành công!");
                            // Sau khi SỬA thành công
                            dataTable.Clear();
                            LoadData();
                            ClearData();
                        }
                        else
                        {
                            MessageBox.Show("Không thể sửa dữ liệu!");
                            ClearData();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa dữ liệu: " + ex.Message);
                ClearData();
            }
        }

        private void QLMH_Load(object sender, EventArgs e)
        {
            LoadData(); 
        }
    }
}