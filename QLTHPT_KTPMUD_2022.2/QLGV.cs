using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;


namespace QLTHPT_KTPMUD_2022._2
{

    public partial class QLGV : Form
    {
       
        private DataTable dataTable = new DataTable(); //Tạo đối tượng bảng
        private MainPage mainPage = new MainPage(); //Tạo 1 đối tượng trang chủ thừa kế các method hoặc thuộc tính của lớp
        string connectionString = DatabaseConnection.Instance.ConnectionString;

        public QLGV()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Width = 1024;   // Thiết lập chiều rộng
            this.Height = 768;  // Thiết lập chiều cao
        }

        private void QLGV_Load(object sender, EventArgs e)
        {          
            LoadData();
        }

        //Thực hiện quay lại trang chủ
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainPage.Show();
        }

        //Thực hiện tải dữ liệu 
        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT ND.*,NDGV.MaGV,NDGV.NgayBD,NDGV.NgayKT,NDGV.BoMon FROM NDGV JOIN ND ON NDGV.MaID = ND.MaID";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dataTable);
            }
            dgvGV.DataSource = dataTable;
        }

        //Thực hiện XÓA dữ liệu trên các textBox khi thực hiện xong 1 chức năng
        private void ClearData()
        {
            tBStartDate.CustomFormat = " ";
            tBStartDate.Format = DateTimePickerFormat.Custom;
            tBEndDate.CustomFormat = " ";
            tBEndDate.Format = DateTimePickerFormat.Custom;
            tBdateGV.CustomFormat = " ";
            tBdateGV.Format = DateTimePickerFormat.Custom;
            tBName.Text = "";
            tBID.Text = "";
            tBmaGV.Text = "";
            cBSex.Text = "";
            cBMH.Text = "";
            tBCCCD.Text = "";
            tBPhone.Text = "";
            tBAddress.Text = "";
            tBEmail.Text = "";
        }

        //Thực hiện sự kiện kích vào đầu của mỗi hàng
        private void dgvGV_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            tBName.Text = dgvGV.Rows[e.RowIndex].Cells[1].Value.ToString();
            tBID.Text = dgvGV.Rows[e.RowIndex].Cells[0].Value.ToString();
            tBmaGV.Text = dgvGV.Rows[e.RowIndex].Cells[8].Value.ToString();
            cBSex.Text = dgvGV.Rows[e.RowIndex].Cells[7].Value.ToString();
            cBMH.Text = dgvGV.Rows[e.RowIndex].Cells[11].Value.ToString();
            tBStartDate.Text = dgvGV.Rows[e.RowIndex].Cells[9].Value.ToString();
            tBCCCD.Text = dgvGV.Rows[e.RowIndex].Cells[4].Value.ToString();
            tBPhone.Text = dgvGV.Rows[e.RowIndex].Cells[5].Value.ToString();
            tBAddress.Text = dgvGV.Rows[e.RowIndex].Cells[3].Value.ToString();
            tBEmail.Text = dgvGV.Rows[e.RowIndex].Cells[6].Value.ToString();
            //Đối với ngày bắt đàu
            if (string.IsNullOrEmpty(dgvGV.Rows[e.RowIndex].Cells[9].Value.ToString()))
            {
                tBStartDate.CustomFormat = " ";
                tBStartDate.Format = DateTimePickerFormat.Custom;
            }
            else
            {
                tBStartDate.CustomFormat = "dd/MM/yyyy"; // Đặt lại định dạng ngày
                tBStartDate.Format = DateTimePickerFormat.Custom;
                tBStartDate.Text = dgvGV.Rows[e.RowIndex].Cells[9].Value.ToString();
            }
            //đối với ngày sinh nhật
            if (string.IsNullOrEmpty(dgvGV.Rows[e.RowIndex].Cells[2].Value.ToString()))
            {
                tBdateGV.CustomFormat = " ";
                tBdateGV.Format = DateTimePickerFormat.Custom;
            }
            else
            {
                tBdateGV.CustomFormat = "dd/MM/yyyy"; // Đặt lại định dạng ngày
                tBdateGV.Format = DateTimePickerFormat.Custom;
                tBdateGV.Text = dgvGV.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            //Đối với ngày kết thúc
            if (string.IsNullOrEmpty(dgvGV.Rows[e.RowIndex].Cells[10].Value.ToString()))
            {
                tBEndDate.CustomFormat = " ";
                tBEndDate.Format = DateTimePickerFormat.Custom;
            }
            else
            {
                tBEndDate.CustomFormat = "dd/MM/yyyy"; // Đặt lại định dạng ngày
                tBEndDate.Format = DateTimePickerFormat.Custom;
                tBEndDate.Text = dgvGV.Rows[e.RowIndex].Cells[10].Value.ToString();
            }
        }

        //Thực hiện TÌM KIẾM dữ liệu
        private void btnFindGV_Click(object sender, EventArgs e)
        {
            string search = tBFind.Text;
            DataView dv = new DataView(dataTable);
            dv.RowFilter = $"HoVaTen like '%{search}%' or CCCD like '%{search}%' or MaGV like '%{search}%' or MaID like '%{search}%' or BoMon like '%{search}%' or DiaChi like '%{search}%'  or SDT like '%{search}%' or GioiTinh like '%{search}%'";
            dgvGV.DataSource = dv;

        }

        //Thực hiện THÊM dữ liệu 
        private void btnAddGV_Click(object sender, EventArgs e)
        {
            // Xử lý truy vấn INSERT vào cơ sở dữ liệu tại đây
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "BEGIN TRAN INSERT INTO ND (MaID, HoVaTen, DOB, DiaChi, CCCD, SDT, Email, GioiTinh) " +
                        "VALUES (@MaID, @HoVaTen, @DOB, @DiaChi, @CCCD, @SDT, @Email, @GioiTinh) " +
                        "INSERT INTO NDGV (MaID, MaGV, NgayBD, BoMon) VALUES (@MaID, @MaGV, @NgayBD, @BoMon) COMMIT TRAN";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@NgayKT", (tBEndDate.CustomFormat == " ") ? (object)DBNull.Value : tBEndDate.Value));//Sử dụng toán tử điều kiện 2 ngôi 
                        command.Parameters.Add(new SqlParameter("@NgayBD", (tBStartDate.CustomFormat == " ") ? (object)DBNull.Value : tBStartDate.Value));
                        command.Parameters.Add(new SqlParameter("@DOB", (tBdateGV.CustomFormat == " ") ? (object)DBNull.Value : tBdateGV.Value));
                        command.Parameters.Add(new SqlParameter("@HoVaTen", tBName.Text));
                        command.Parameters.Add(new SqlParameter("@MaID", tBID.Text));
                        command.Parameters.Add(new SqlParameter("@DiaChi", tBAddress.Text));
                        command.Parameters.Add(new SqlParameter("@GioiTinh", cBSex.Text));
                        command.Parameters.Add(new SqlParameter("@Email", tBEmail.Text));
                        command.Parameters.Add(new SqlParameter("@SDT", tBPhone.Text));
                        command.Parameters.Add(new SqlParameter("@BoMon", cBMH.Text));
                        command.Parameters.Add(new SqlParameter("@MaGV", tBmaGV.Text));
                        command.Parameters.Add(new SqlParameter("@CCCD", tBCCCD.Text));
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

        //Thực hiện  SỬA dữ liệu
        private void btnFixGV_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "BEGIN TRAN UPDATE ND SET HoVaTen = @HoVaTen,DOB = @DOB,DiaChi = @DiaChi," +
                        "CCCD = @CCCD,SDT = @SDT,Email = @Email,GioiTinh = @GioiTinh WHERE MaID = @MaID;" +
                        "UPDATE NDGV SET NgayBD = @NgayBD,NgayKT = @NgayKT, BoMon = @BoMon WHERE MaID = @MaID; COMMIT TRAN";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@NgayKT", (tBEndDate.CustomFormat == " ") ? (object)DBNull.Value : tBEndDate.Value));//Sử dụng toán tử điều kiện 2 ngôi 
                        command.Parameters.Add(new SqlParameter("@NgayBD", (tBStartDate.CustomFormat == " ") ? (object)DBNull.Value : tBStartDate.Value));
                        command.Parameters.Add(new SqlParameter("@DOB", (tBdateGV.CustomFormat == " ") ? (object)DBNull.Value : tBdateGV.Value));
                        command.Parameters.Add(new SqlParameter("@HoVaTen", tBName.Text));
                        command.Parameters.Add(new SqlParameter("@MaID", tBID.Text));
                        command.Parameters.Add(new SqlParameter("@DiaChi", tBAddress.Text));
                        command.Parameters.Add(new SqlParameter("@GioiTinh", cBSex.Text));
                        command.Parameters.Add(new SqlParameter("@Email", tBEmail.Text));
                        command.Parameters.Add(new SqlParameter("@SDT", tBPhone.Text));
                        command.Parameters.Add(new SqlParameter("@BoMon", cBMH.Text));
                        command.Parameters.Add(new SqlParameter("@MaGV", tBmaGV.Text));
                        command.Parameters.Add(new SqlParameter("@CCCD", tBCCCD.Text));
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

        //Thực hiện XÓA dữ liệu
        private void btnDelGV_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                { 
                    connection.Open();
                    string query = "DELETE FROM DayMon    " +
                        "WHERE MaGV IN (SELECT MaGV FROM NDGV WHERE MaID = @MaID)" +
                        "DELETE FROM DayLop WHERE MaGV IN (SELECT MaGV FROM NDGV WHERE MaID = @MaID)" +
                        "DELETE FROM ChuNhiem WHERE MaGV IN (SELECT MaGV FROM NDGV " +
                        "WHERE MaID = @MaID) DELETE FROM TK WHERE MaID = @MaID DELETE FROM NDGV WHERE MaID = @MaID\r\nDELETE FROM ND WHERE MaID = @MaID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@NgayKT", tBEndDate.Value));
                        command.Parameters.Add(new SqlParameter("@NgayBD", tBStartDate.Value));
                        command.Parameters.Add(new SqlParameter("@DOB", tBdateGV.Value));
                        command.Parameters.Add(new SqlParameter("@HoVaTen", tBName.Text));
                        command.Parameters.Add(new SqlParameter("@MaID", tBID.Text));
                        command.Parameters.Add(new SqlParameter("@DiaChi", tBAddress.Text));
                        command.Parameters.Add(new SqlParameter("@GioiTinh", cBSex.Text));
                        command.Parameters.Add(new SqlParameter("@Email", tBEmail.Text));
                        command.Parameters.Add(new SqlParameter("@SDT", tBPhone.Text));
                        command.Parameters.Add(new SqlParameter("@BoMon", cBMH.Text));
                        command.Parameters.Add(new SqlParameter("@MaGV", tBmaGV.Text));
                        command.Parameters.Add(new SqlParameter("@CCCD", tBCCCD.Text));
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

        //Các hàm có sẵn
        private void tBdateGV_ValueChanged(object sender, EventArgs e)
        {
            tBdateGV.CustomFormat = "dd/MM/yyyy";
        }
        private void tBStartDate_ValueChanged(object sender, EventArgs e)
        {
            tBStartDate.CustomFormat = "dd/MM/yyyy";
        }
        private void tBEndDate_ValueChanged(object sender, EventArgs e)
        {
            tBEndDate.CustomFormat = "dd/MM/yyyy";
        }



        //Thực hiện xóa ngày bằng KeyDown
        private void tBEndDate_KeyDown(object sender, KeyEventArgs e)
        {
            if((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                 tBEndDate.CustomFormat = " "; // Ẩn giá trị ngày
            }
        }
        private void tBdateGV_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                tBdateGV.CustomFormat = " "; // Ẩn giá trị ngày
            }
        }
        private void tBStartDate_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                tBStartDate.CustomFormat = " "; // Ẩn giá trị ngày
            }
        }
    }
}
