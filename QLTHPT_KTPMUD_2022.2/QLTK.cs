using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QLTHPT_KTPMUD_2022._2
{
    public partial class QLTK : Form
    {
        private DataTable dataTable = new DataTable(); //Tạo đối tượng bảng
        private MainPage mainPage = new MainPage(); //Tạo 1 đối tượng trang chủ thừa kế các method hoặc thuộc tính của lớp
        string connectionString = DatabaseConnection.Instance.ConnectionString;
        public QLTK()
        {
            InitializeComponent();
        }

        //Thực hiện tải lại dữ liệu lên TK
        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT TK.*, ND.HoVaTen FROM ND INNER JOIN TK ON ND.MaID = TK.MaID";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dataTable);
            }
            dgvTK.DataSource = dataTable;
        }

        //Thực hiện xóa trên gridview
        private void ClearData()
        {
            tBName.Text = "";
            tBID.Text = "";
            tBTenND.Text = "";
            tBpass.Text = "";
            tBmaQL.Text = "";
            tBmaTK.Text = "";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tBDiem1Tiet_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainPage.Show();
        }

        private void QLTK_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvTK_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tBName.Text = dgvTK.Rows[e.RowIndex].Cells[5].Value.ToString();
            tBID.Text = dgvTK.Rows[e.RowIndex].Cells[4].Value.ToString();
            tBmaQL.Text = dgvTK.Rows[e.RowIndex].Cells[3].Value.ToString();
            tBmaTK.Text = dgvTK.Rows[e.RowIndex].Cells[0].Value.ToString();
            tBpass.Text = dgvTK.Rows[e.RowIndex].Cells[2].Value.ToString();
            tBTenND.Text = dgvTK.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnFindTK_Click(object sender, EventArgs e)
        {
            string search = tBFind.Text;
            DataView dv = new DataView(dataTable);
            dv.RowFilter = $"HoVaTen like '%{search}%' or MaTK like '%{search}%' or MaID like '%{search}%' or MaQL like '%{search}%' or TenND like '%{search}%'  or MatKhau like '%{search}%'";
            dgvTK.DataSource = dv;
        }

        private void btnAddTK_Click(object sender, EventArgs e)
        {
            // Xử lý truy vấn INSERT vào cơ sở dữ liệu tại đây
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO TK (MaTK, TenND, MatKhau, MaID, MaQL) VALUES (@MaTK, @TenND, @MatKhau, @MaID, @MaQL)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@HoVaTen", tBName.Text));
                        command.Parameters.Add(new SqlParameter("@MaID", tBID.Text));
                        command.Parameters.Add(new SqlParameter("@MatKhau", tBpass.Text));
                        command.Parameters.Add(new SqlParameter("@TenND", tBTenND.Text));
                        command.Parameters.Add(new SqlParameter("@MaQL", tBmaQL.Text));
                        command.Parameters.Add(new SqlParameter("@MaTK", tBmaTK.Text));
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

        private void btnFixTK_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE TK SET TenND = @TenND, MatKhau = @MatKhau, MaQL = @MaQL WHERE MaTK = @MaTK AND MaID = @MaID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@HoVaTen", tBName.Text));
                        command.Parameters.Add(new SqlParameter("@MaID", tBID.Text));
                        command.Parameters.Add(new SqlParameter("@MatKhau", tBpass.Text));
                        command.Parameters.Add(new SqlParameter("@TenND", tBTenND.Text));
                        command.Parameters.Add(new SqlParameter("@MaQL", tBmaQL.Text));
                        command.Parameters.Add(new SqlParameter("@MaTK", tBmaTK.Text));
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

        private void btnDelTK_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM TK WHERE MaTK = @MaTK AND MaID = @MaID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@HoVaTen", tBName.Text));
                        command.Parameters.Add(new SqlParameter("@MaID", tBID.Text));
                        command.Parameters.Add(new SqlParameter("@MatKhau", tBpass.Text));
                        command.Parameters.Add(new SqlParameter("@TenND", tBTenND.Text));
                        command.Parameters.Add(new SqlParameter("@MaQL", tBmaQL.Text));
                        command.Parameters.Add(new SqlParameter("@MaTK", tBmaTK.Text));
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
