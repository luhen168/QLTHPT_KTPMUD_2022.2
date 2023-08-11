using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace QLTHPT_KTPMUD_2022._2
{
    public partial class QLLH : Form
    {
        private DataTable dataTable = new DataTable();
        string connectionString = DatabaseConnection.Instance.ConnectionString;

        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM LOP";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dataTable);
            }
            dgvLH.DataSource = dataTable;
        }

        private void ClearData()
        {

            tBTenLop.Text = "";
            tBViTri.Text = "";
            tBSiSo.Text = "";
        }

        public QLLH()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Width = 1024;   // Thiết lập chiều rộng
            this.Height = 768;  // Thiết lập chiều cao
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            this.Hide();
            mainPage.Show();
        }

        private void QLLH_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnFindLH_Click(object sender, EventArgs e)
        {
            string search = tBFind1.Text;
            DataView dv = new DataView(dataTable);
            dv.RowFilter = $"TenLop like '%{search}%' or ViTri like '%{search}%' or SiSo like '%{search}%' ";
            dgvLH.DataSource = dv;
        }

        private void btnAddLH_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Lop (TenLop, ViTri, SiSo)" +
                        "VALUES (@TenLop, @ViTri, @SiSo) ";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@TenLop", tBTenLop.Text));
                        command.Parameters.Add(new SqlParameter("@ViTri", tBViTri.Text));
                        command.Parameters.Add(new SqlParameter("@SiSo", tBSiSo.Text.ToString()));

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

        private void btnFixLH_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = " UPDATE Lop SET TenLop = @TenLop,ViTri = @ViTri,SiSo = @SiSo,";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.Add(new SqlParameter("@TenLop", tBTenLop.Text));
                        command.Parameters.Add(new SqlParameter("@ViTri", tBViTri.Text));
                        command.Parameters.Add(new SqlParameter("@SiSo", tBSiSo.Text));
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

        private void btnDelLH_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM Lop WHERE TenLop = @TenLop, ViTri = @ViTri, SiSo = @SiSo";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.Add(new SqlParameter("@TenLop", tBTenLop.Text));
                        command.Parameters.Add(new SqlParameter("@ViTri", tBViTri.Text));
                        command.Parameters.Add(new SqlParameter("@SiSo", tBViTri.Text));
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
    }
}
