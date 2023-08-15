using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;


namespace QLTHPT_KTPMUD_2022._2
{

    public partial class QLGV : Form
    {
        //Khởi tạo các đối tượng của lớp Rectangle
        private Rectangle tBNameOriginalRect;
        private Rectangle tBIDOriginalRect;
        private Rectangle tBMaGVOriginalRect;
        private Rectangle cBMHOriginalRect;
        private Rectangle cBSexOriginalRect;
        private Rectangle tBCCCDOriginalRect;
        private Rectangle tBdateGVOriginalRect;
        private Rectangle tBPhoneOriginalRect;
        private Rectangle tBAddressOriginalRect;
        private Rectangle tBEmailOriginalRect;
        private Rectangle tBStartDateOriginalRect;
        private Rectangle tBEndDateOriginalRect;
        private Rectangle tBFindOriginalRect;
        private Rectangle btnAddGVOriginalRect;
        private Rectangle btnFixGVOriginalRect;
        private Rectangle btnFindGVOriginalRect;
        private Rectangle btnDelGVOriginalRect;
        private Rectangle btnBackOriginalRect;
        private Rectangle label1OriginalRect;
        private Rectangle label2OriginalRect;
        private Rectangle label3OriginalRect;
        private Rectangle label4OriginalRect;
        private Rectangle label5OriginalRect;
        private Rectangle label6OriginalRect;
        private Rectangle label7OriginalRect;
        private Rectangle label8OriginalRect;
        private Rectangle label9OriginalRect;
        private Rectangle label10OriginalRect;
        private Rectangle label11OriginalRect;
        private Rectangle label12OriginalRect;
        private Rectangle dgvGVOriginalRect;
        private Size QLGVOriginalSize;
        private DataTable dataTable = new DataTable(); //Tạo đối tượng bảng
        private MainPage mainPage = new MainPage(); //Tạo 1 đối tượng trang chủ thừa kế các method hoặc thuộc tính của lớp
        string connectionString = DatabaseConnection.Instance.ConnectionString;

        public QLGV()
        {
            InitializeComponent();
            //comment;gg
        }

        private void QLGV_Load(object sender, EventArgs e)
        {          
            QLGVOriginalSize = this.Size ;
            tBNameOriginalRect = new Rectangle(tBName.Location.X, tBName.Location.Y, tBName.Width, tBName.Height);
            tBIDOriginalRect = new Rectangle(tBID.Location.X, tBID.Location.Y, tBID.Width, tBID.Height);
            tBMaGVOriginalRect = new Rectangle(tBmaGV.Location.X, tBmaGV.Location.Y, tBmaGV.Width, tBmaGV.Height);
            tBAddressOriginalRect = new Rectangle(tBAddress.Location.X, tBAddress.Location.Y, tBAddress.Width, tBAddress.Height);
            tBPhoneOriginalRect = new Rectangle(tBPhone.Location.X, tBPhone.Location.Y, tBPhone.Width, tBPhone.Height);
            tBCCCDOriginalRect = new Rectangle(tBCCCD.Location.X, tBCCCD.Location.Y, tBCCCD.Width, tBCCCD.Height);
            tBdateGVOriginalRect = new Rectangle(tBdateGV.Location.X, tBdateGV.Location.Y, tBdateGV.Width, tBdateGV.Height);
            tBEmailOriginalRect = new Rectangle(tBEmail.Location.X, tBEmail.Location.Y, tBEmail.Width, tBEmail.Height);
            tBStartDateOriginalRect = new Rectangle(tBStartDate.Location.X, tBStartDate.Location.Y, tBStartDate.Width, tBStartDate.Height);
            tBEndDateOriginalRect = new Rectangle(tBEndDate.Location.X, tBEndDate.Location.Y, tBEndDate.Width, tBEndDate.Height);
            tBFindOriginalRect = new Rectangle(tBFind.Location.X, tBFind.Location.Y, tBFind.Width, tBFind.Height);
            cBMHOriginalRect = new Rectangle(cBMH.Location.X, cBMH.Location.Y, cBMH.Width, cBMH.Height);
            cBSexOriginalRect = new Rectangle(cBSex.Location.X, cBSex.Location.Y, cBSex.Width, cBSex.Height);
            label1OriginalRect = new Rectangle(label1.Location.X, label1.Location.Y, label1.Width, label1.Height);
            label2OriginalRect = new Rectangle(label2.Location.X, label2.Location.Y, label2.Width, label2.Height);
            label3OriginalRect = new Rectangle(label3.Location.X, label3.Location.Y, label3.Width, label3.Height);
            label4OriginalRect = new Rectangle(label4.Location.X, label4.Location.Y, label4.Width, label4.Height);
            label5OriginalRect = new Rectangle(label5.Location.X, label5.Location.Y, label5.Width, label5.Height);
            label6OriginalRect = new Rectangle(label6.Location.X, label6.Location.Y, label6.Width, label6.Height);
            label7OriginalRect = new Rectangle(label7.Location.X, label7.Location.Y, label7.Width, label7.Height);
            label8OriginalRect = new Rectangle(label8.Location.X, label8.Location.Y, label8.Width, label8.Height);
            label9OriginalRect = new Rectangle(label9.Location.X, label9.Location.Y, label9.Width, label9.Height);
            label10OriginalRect = new Rectangle(label10.Location.X, label10.Location.Y, label10.Width, label10.Height);
            label11OriginalRect = new Rectangle(label11.Location.X, label11.Location.Y, label11.Width, label11.Height);
            label12OriginalRect = new Rectangle(label12.Location.X, label12.Location.Y, label12.Width, label12.Height);
            btnAddGVOriginalRect = new Rectangle(btnAddGV.Location.X, btnAddGV.Location.Y, btnAddGV.Width, btnAddGV.Height);
            btnFixGVOriginalRect = new Rectangle(btnFixGV.Location.X, btnFixGV.Location.Y, btnFixGV.Width, btnFixGV.Height);
            btnFindGVOriginalRect = new Rectangle(btnFindGV.Location.X, btnFindGV.Location.Y, btnFindGV.Width, btnFindGV.Height);
            btnDelGVOriginalRect = new Rectangle(btnDelGV.Location.X, btnDelGV.Location.Y, btnDelGV.Width, btnDelGV.Height);
            btnBackOriginalRect = new Rectangle(btnBack.Location.X, btnBack.Location.Y, btnBack.Width, btnBack.Height);
            dgvGVOriginalRect = new Rectangle(dgvGV.Location.X, dgvGV.Location.Y, dgvGV.Width, dgvGV.Height);

            LoadData();
        }

        //Hàm thay đổi kích thước các control cho phù hợp với kích thước form 
        private void resizeChildrenControls()
        {
            resizeControl(tBNameOriginalRect, tBName);
            resizeControl(tBMaGVOriginalRect, tBmaGV);
            resizeControl(tBIDOriginalRect, tBID);
            resizeControl(cBSexOriginalRect, cBSex);
            resizeControl(cBMHOriginalRect, cBMH);
            resizeControl(tBAddressOriginalRect, tBAddress);
            resizeControl(tBPhoneOriginalRect, tBPhone);
            resizeControl(tBdateGVOriginalRect, tBdateGV);
            resizeControl(tBCCCDOriginalRect, tBCCCD);
            resizeControl(tBEmailOriginalRect, tBEmail);
            resizeControl(tBStartDateOriginalRect, tBStartDate);
            resizeControl(tBEndDateOriginalRect, tBEndDate);
            resizeControl(tBFindOriginalRect, tBFind);
            resizeControl(btnAddGVOriginalRect, btnAddGV);
            resizeControl(btnFixGVOriginalRect, btnFixGV);
            resizeControl(btnDelGVOriginalRect, btnDelGV);
            resizeControl(btnFindGVOriginalRect, btnFindGV);
            resizeControl(btnBackOriginalRect, btnBack);
            resizeControl(label1OriginalRect, label1);
            resizeControl(label2OriginalRect, label2);
            resizeControl(label3OriginalRect, label3);
            resizeControl(label4OriginalRect, label4);
            resizeControl(label5OriginalRect, label5);
            resizeControl(label6OriginalRect, label6);
            resizeControl(label7OriginalRect, label7);
            resizeControl(label8OriginalRect, label8);
            resizeControl(label9OriginalRect, label9);
            resizeControl(label10OriginalRect, label10);
            resizeControl(label11OriginalRect, label11);
            resizeControl(label12OriginalRect, label12);
            resizeControl(dgvGVOriginalRect, dgvGV);
        }

        //Hàm sử dụng để kiểm soát việc thay đổi kích thước lưu kích thước ban đầu và kích thước hiện tại 
        private void resizeControl(Rectangle OriginalControlRect, Control control)
        {
            float xRatio = (float)(this.Width) / (float)(QLGVOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(QLGVOriginalSize.Height);


            int newX = (int)(OriginalControlRect.X * xRatio);
            int newY = (int)(OriginalControlRect.Y * yRatio);

            int newWidth = (int)(OriginalControlRect.Width * xRatio);
            int newHeight = (int)(OriginalControlRect.Height * yRatio);

            control.Location = new Point(newX, newY);
            control.Size = new Size(newWidth, newHeight);
        }

        //Hàm thực hiện sự kiện thay đổi 
        private void QLGV_Resize_1(object sender, EventArgs e)
        {
            resizeChildrenControls();
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
