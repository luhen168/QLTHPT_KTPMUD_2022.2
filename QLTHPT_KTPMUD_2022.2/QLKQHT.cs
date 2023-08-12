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

namespace QLTHPT_KTPMUD_2022._2
{
    public partial class QLKQHT : Form
    {
        private DataTable dataTable = new DataTable(); //Tạo đối tượng bảng
        private MainPage mainPage = new MainPage(); //Tạo 1 đối tượng trang chủ thừa kế các method hoặc thuộc tính của lớp
        string connectionString = DatabaseConnection.Instance.ConnectionString;
        public QLKQHT()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Width = 1024;   // Thiết lập chiều rộng
            this.Height = 768;  // Thiết lập chiều cao
        }
        //Thực hiện tải lại dữ liệu lên KQHT
        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT ND.MaID, ND.HoVaTen, Co.LoaiHK, NDHS.TenLop, NDHS.XepLoaiHL, NDHS.DiemTBHK, Hoc.*" +
                               "FROM(((NDHS INNER JOIN Hoc ON NDHS.MaHS = Hoc.MaHS AND NDHS.HocKy = Hoc.HocKy)" +
                               "INNER JOIN Co ON NDHS.MaHS = Co.MaHS AND NDHS.HocKy = Co.HocKy) INNER JOIN ND ON NDHS.MaID = ND.MaID)";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dataTable);
            }
            dgvKQHT.DataSource = dataTable;
        }
        //Thực hiện xóa trên gridview
        private void ClearData()
        {
            tBName.Text = "";
            tBID.Text = "";
            tBmaHS.Text = "";
            tBmaMH.Text = "";
            cBHL.Text = "";
            cBHanhKiem.Text = "";
            tBDiem15p.Text = "";
            tBDiem1Tiet.Text = "";
            tBHocKy.Text = "";
            tBClass.Text = "";
            tBDiemTBHK.Text = "";
            tBDiemThi.Text = "";
            tBDiemTBMH.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainPage.Show();
        }

        private void dgvKQHT_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tBName.Text = dgvKQHT.Rows[e.RowIndex].Cells[1].Value.ToString();
            tBID.Text = dgvKQHT.Rows[e.RowIndex].Cells[0].Value.ToString();
            tBmaHS.Text = dgvKQHT.Rows[e.RowIndex].Cells[6].Value.ToString();
            tBmaMH.Text = dgvKQHT.Rows[e.RowIndex].Cells[7].Value.ToString();
            tBDiem15p.Text = dgvKQHT.Rows[e.RowIndex].Cells[9].Value.ToString();
            tBDiem1Tiet.Text = dgvKQHT.Rows[e.RowIndex].Cells[10].Value.ToString();
            tBDiemThi.Text = dgvKQHT.Rows[e.RowIndex].Cells[11].Value.ToString();
            tBDiemTBMH.Text = dgvKQHT.Rows[e.RowIndex].Cells[12].Value.ToString();
            cBHL.Text = dgvKQHT.Rows[e.RowIndex].Cells[4].Value.ToString();
            cBHanhKiem.Text = dgvKQHT.Rows[e.RowIndex].Cells[2].Value.ToString();
            tBClass.Text = dgvKQHT.Rows[e.RowIndex].Cells[3].Value.ToString();
            tBDiemTBHK.Text = dgvKQHT.Rows[e.RowIndex].Cells[5].Value.ToString();
            tBHocKy.Text = dgvKQHT.Rows[e.RowIndex].Cells[8].Value.ToString();
        }

        //Thực hiện thêm dữu liệu vào SQL
        private void btnAddKQ_Click(object sender, EventArgs e)
        {
            // Xử lý truy vấn INSERT vào cơ sở dữ liệu tại đây
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "BEGIN TRAN INSERT INTO Hoc (MaHS, MaMH, Diem15p, Diem1Tiet, DiemThi, DiemTBMH, HocKy)" +
                                   "VALUES (@MaHS, @MaMH, @Diem15p, @Diem1Tiet, @DiemThi, @DiemTBMH, @HK);" +
                                   "INSERT INTO Co (MaHS, LoaiHK, HocKy) VALUES (@MaHS, @LoaiHK, @HK);" +
                                   "UPDATE NDHS SET HanhKiem = Co.LoaiHK FROM NDHS INNER JOIN Co ON NDHS.MaHS = Co.MaHS AND NDHS.HocKy = Co.HocKy;" +
                                   "UPDATE NDHS SET XepLoaiHL = CASE WHEN DiemTBHK >= 8 AND HanhKiem = 'Tốt' THEN 'Giỏi'" +
                                   "WHEN (DiemTBHK >= 5 AND DiemTBHK < 8) AND HanhKiem = 'Khá' THEN 'Khá'" +
                                   "WHEN DiemTBHK < 5 AND (HanhKiem = 'Trung Bình' OR HanhKiem = 'Yếu' OR HanhKiem = 'Kém') THEN 'Trung Bình'" +
                                   "ELSE NULL END COMMIT TRAN";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@HoVaTen", tBName.Text));
                        command.Parameters.Add(new SqlParameter("@MaID", tBID.Text));
                        command.Parameters.Add(new SqlParameter("@LoaiHK", cBHanhKiem.Text));
                        command.Parameters.Add(new SqlParameter("@TenLop", tBClass.Text));
                        command.Parameters.Add(new SqlParameter("@XepLoaiHL", cBHL.Text));
                        command.Parameters.Add(new SqlParameter("@DiemTBHK", tBDiemTBHK.Text));
                        command.Parameters.Add(new SqlParameter("@Diem15p", tBDiem15p.Text));
                        command.Parameters.Add(new SqlParameter("@Diem1Tiet", tBDiem1Tiet.Text));
                        command.Parameters.Add(new SqlParameter("@DiemThi", tBDiemThi.Text));
                        command.Parameters.Add(new SqlParameter("@DiemTBMH", tBDiemTBMH.Text));
                        command.Parameters.Add(new SqlParameter("@MaHS", tBmaHS.Text));
                        command.Parameters.Add(new SqlParameter("@MaMH", tBmaMH.Text));
                        command.Parameters.Add(new SqlParameter("@HK", tBHocKy.Text));
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

        private void btnFixKQ_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "BEGIN TRAN UPDATE Hoc SET Diem15p = @Diem15p, Diem1Tiet = @Diem1Tiet, DiemThi = @DiemThi, DiemTBMH = @DiemTBMH " +
                                   "WHERE MaHS = @MaHS AND MaMH = @MaMH AND HocKy = @HK;" +
                                   "UPDATE Co SET LoaiHK = @LoaiHK WHERE MaHS = @MaHS AND HocKy = @HK;" +
                                   "UPDATE NDHS SET HanhKiem = Co.LoaiHK FROM NDHS INNER JOIN Co ON NDHS.MaHS = Co.MaHS AND NDHS.HocKy = Co.HocKy;" +
                                   "UPDATE NDHS SET XepLoaiHL = CASE WHEN DiemTBHK >= 8 AND HanhKiem = 'Tốt' THEN 'Giỏi'" +
                                   "WHEN (DiemTBHK >= 5 AND DiemTBHK < 8) AND HanhKiem = 'Khá' THEN 'Khá'" +
                                   "WHEN DiemTBHK < 5 AND (HanhKiem = 'Trung Bình' OR HanhKiem = 'Yếu' OR HanhKiem = 'Kém') THEN 'Trung Bình'" +
                                   "ELSE NULL END COMMIT TRAN";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@HoVaTen", tBName.Text));
                        command.Parameters.Add(new SqlParameter("@MaID", tBID.Text));
                        command.Parameters.Add(new SqlParameter("@LoaiHK", cBHanhKiem.Text));
                        command.Parameters.Add(new SqlParameter("@TenLop", tBClass.Text));
                        command.Parameters.Add(new SqlParameter("@XepLoaiHL", cBHL.Text));
                        command.Parameters.Add(new SqlParameter("@DiemTBHK", tBDiemTBHK.Text));
                        command.Parameters.Add(new SqlParameter("@Diem15p", tBDiem15p.Text));
                        command.Parameters.Add(new SqlParameter("@Diem1Tiet", tBDiem1Tiet.Text));
                        command.Parameters.Add(new SqlParameter("@DiemThi", tBDiemThi.Text));
                        command.Parameters.Add(new SqlParameter("@DiemTBMH", tBDiemTBMH.Text));
                        command.Parameters.Add(new SqlParameter("@MaHS", tBmaHS.Text));
                        command.Parameters.Add(new SqlParameter("@MaMH", tBmaMH.Text));
                        command.Parameters.Add(new SqlParameter("@HK", tBHocKy.Text));
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

        private void btnDelKQ_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM Hoc WHERE MaHS = @MaHS AND MaMH = @MaMH AND HocKy = @HK;" +
                                   "DELETE FROM Co WHERE MaHS = @MaHS AND HocKy = @HK;" +
                                   "UPDATE NDHS SET XepLoaiHL = NULL, HanhKiem = NULL, DiemTBHK = 0";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@HoVaTen", tBName.Text));
                        command.Parameters.Add(new SqlParameter("@MaID", tBID.Text));
                        command.Parameters.Add(new SqlParameter("@LoaiHK", cBHanhKiem.Text));
                        command.Parameters.Add(new SqlParameter("@TenLop", tBClass.Text));
                        command.Parameters.Add(new SqlParameter("@XepLoaiHL", cBHL.Text));
                        command.Parameters.Add(new SqlParameter("@DiemTBHK", tBDiemTBHK.Text));
                        command.Parameters.Add(new SqlParameter("@Diem15p", tBDiem15p.Text));
                        command.Parameters.Add(new SqlParameter("@Diem1Tiet", tBDiem1Tiet.Text));
                        command.Parameters.Add(new SqlParameter("@DiemThi", tBDiemThi.Text));
                        command.Parameters.Add(new SqlParameter("@DiemTBMH", tBDiemTBMH.Text));
                        command.Parameters.Add(new SqlParameter("@MaHS", tBmaHS.Text));
                        command.Parameters.Add(new SqlParameter("@MaMH", tBmaMH.Text));
                        command.Parameters.Add(new SqlParameter("@HK", tBHocKy.Text));
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

        private void QLKQHT_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnFindKQ_Click(object sender, EventArgs e)
        {
            string search = tBFind.Text;
            DataView dv = new DataView(dataTable);
            dv.RowFilter = $"HoVaTen like '%{search}%' or MaHS like '%{search}%' or MaID like '%{search}%' or MaMH like '%{search}%' or LoaiHK like '%{search}%'  or TenLop like '%{search}%' or XepLoaiHL like '%{search}%' or HocKy like '%{search}%' ";
            dgvKQHT.DataSource = dv;
        }
    }
}
