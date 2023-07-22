using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QLTHPT_KTPMUD_2022._2
{
    public partial class QLMH : Form
    {
        public QLMH()
        {
            InitializeComponent();
        }
        private MainPage mainPage = new MainPage();
        private DataTable dataTable = new DataTable(); //Tạo đối tượng bảng
        string connectionString = DatabaseConnection.Instance.ConnectionString;
        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainPage.Show();
        }

        private void QLMH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTHPT_20222DataSet.MH' table. You can move, or remove it, as needed.
            //this.mHTableAdapter.Fill(this.qLTHPT_20222DataSet.MH);
            LoadData();
        }

        private void Find_Click(object sender, EventArgs e)
        {
            string search = tBFind.Text;
            DataView dv = new DataView(dataTable);
            dv.RowFilter = $"MaMH like '%{search}%' or TenMH like '%{search}%'";
            dataGridView1.DataSource = dv;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tBFind_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            // Xử lý truy vấn INSERT vào cơ sở dữ liệu tại đây
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "BEGIN TRAN INSERT INTO MH (MaMH, TenMH) " +
                        "VALUES (@MaMH,@TenMH) COMMIT TRAN";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.Add(new SqlParameter("@MaMH", tBID.Text));
                        command.Parameters.Add(new SqlParameter("@TenMH", tBName.Text));
                        //command.Parameters.Add(new SqlParameter("@GioiTinh", cBSex.Text));

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
        private void ClearData()
        {
            tBName.Text = "";
            tBID.Text = "";
            tBFind.Text = "";
        }
        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM MH";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dataTable);
            }
            dataGridView1.DataSource = dataTable;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM MH WHERE MaMH = @MaMH"; /*+
                        "WHERE MaGV IN (SELECT MaGV FROM NDGV WHERE MaID = @MaID)" +
                        "DELETE FROM DayLop WHERE MaGV IN (SELECT MaGV FROM NDGV WHERE MaID = @MaID)" +
                        "DELETE FROM ChuNhiem WHERE MaGV IN (SELECT MaGV FROM NDGV " +
                        "WHERE MaID = @MaID) DELETE FROM TK WHERE MaID = @MaID DELETE FROM NDGV WHERE MaID = @MaID\r\nDELETE FROM ND WHERE MaID = @MaID";*/
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.Add(new SqlParameter("@MaMH", tBID.Text));
                        //command.Parameters.Add(new SqlParameter("@CCCD", tBCCCD.Text));
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

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tBName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            tBID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
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
                        
                        command.Parameters.Add(new SqlParameter("@MaMH", tBID.Text));
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
    }
}