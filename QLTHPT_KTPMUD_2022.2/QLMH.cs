using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace QLTHPT_KTPMUD_2022._2
{
    public partial class QLMH : Form  //Thừa kế từ lớp Form 
    {       
        private MainPage mainPage = new MainPage();   //Tạo đối tượng    
        private DataTable dataTable = new DataTable(); //Tạo đối tượng
        string connectionString = DatabaseConnection.Instance.ConnectionString;


        public QLMH()
        {
            InitializeComponent();          //Khởi tạo các phần tử ở QLMH.cs[Design]
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Width = 1024;              // Thiết lập chiều rộng
            this.Height = 768;              // Thiết lập chiều cao
        }
       

        //Thực hiện chức năng quay lại 
        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainPage.Show();
        }

        
        //Sự kiện tải dữ liệu
        private void QLMH_Load(object sender, EventArgs e)  
        {
            LoadData();
        }
        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString)) //Mở kết nối với SQL Server, tạo 1 đối tượng kết nối tới chuỗi 
            {
                string query = "SELECT * FROM MH";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection); //Bấm ctrl+ chuột phải để xem phương thức trong lớp
                adapter.Fill(dataTable);                                        //Đối tượng adapter đổ dữ liệu vào đối tượng dataTable
            }
            dgvMH.DataSource = dataTable;                                       //dataGridView nhận dữ liệu từ đối tượng dataTable
        }


        //Đặt lại về rỗng 
        private void ClearData()
        {
            tBName.Text = "";
            tBmaMH.Text = "";
        }


        //Thực hiện thao tác tìm kiếm
        private void Find_Click(object sender, EventArgs e)
        {
            string search = tBFind.Text;
            DataView dv = new DataView(dataTable);
            dv.RowFilter = $"MaMH like '%{search}%' or TenMH like '%{search}%'";
            dgvMH.DataSource = dv;
        }


        //Thực hiện thao tác thêm 
        private void Add_Click(object sender, EventArgs e)
        {
            // Xử lý truy vấn INSERT vào cơ sở dữ liệu tại đây
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO MH (MaMH, TenMH) " +
                        "VALUES (@MaMH,@TenMH)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.Add(new SqlParameter("@MaMH", tBmaMH.Text));
                        command.Parameters.Add(new SqlParameter("@TenMH", tBName.Text));
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thêm dữ liệu thành công!");
                            // Sau khi THÊM thành công
                            dataTable.Clear();
                            LoadData();
                            ClearData();
                        }
                        else
                        {
                            MessageBox.Show("Không thể thêm dữ liệu!");
                            ClearData();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm dữ liệu: " + ex.Message);
            }
        }


        //Thực hiện thao tác xóa dữ liệu một môn học 
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

        private void dgvMH_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tBName.Text = dgvMH.Rows[e.RowIndex].Cells[1].Value.ToString();
            tBmaMH.Text = dgvMH.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

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

        private void dgvMH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tBName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tBFind_TextChanged(object sender, EventArgs e)
        {

        }

        private void tBmaMH_TextChanged(object sender, EventArgs e)
        {

        }
    }
}