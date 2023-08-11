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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace QLTHPT_KTPMUD_2022._2
{
    public partial class QLHS : Form
    {
        private DataTable dataTable = new DataTable(); //Tạo đối tượng bảng
        private MainPage mainPage = new MainPage(); //Tạo 1 đối tượng trang chủ thừa kế các method hoặc thuộc tính của lớp
        string connectionString = DatabaseConnection.Instance.ConnectionString;
        public QLHS()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Width = 1024;   // Thiết lập chiều rộng
            this.Height = 768;  // Thiết lập chiều cao
        }

        private void QLHS_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        //Thực hiện quay lại mà hình chính
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainPage.Show();
        }

        //Thực hiện tải lại dữ liệu lêm GV
        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT ND.*,NDHS.MaHS,NDHS.NienKhoa,NDHS.ThongTinPH,NDHS.HocPhi, NDHS.XepLoaiHL, NDHS.HanhKiem, NDHS.TenLop, NDHS.DiemTBHK, NDHS.HocKy FROM NDHS JOIN ND ON NDHS.MaID = ND.MaID";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dataTable);
            }
            dgvHS.DataSource = dataTable;
        }

        //Thực hiện xóa trên gridview
        private void ClearData()
        {
            tBdateHS.CustomFormat = " ";
            tBdateHS.Format = DateTimePickerFormat.Custom;
            tBName.Text = "";
            tBID.Text = "";
            tBmaHS.Text = "";
            cBSex.Text = "";
            cBHL.Text = "";
            cBHanhKiem.Text = "";
            tBNienKhoa.Text = "";
            tBPH.Text = "";
            tBHocKy.Text = "";
            tBClass.Text = "";
            tBDiemTB.Text = "";
            tBHocPhi.Text = "";
            tBCCCD.Text = "";
            tBPhone.Text = "";
            tBAddress.Text = "";
            tBEmail.Text = "";
        }

        //Thực hiện nhấn đầu dòng trong gridview
        private void dgvHS_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tBName.Text = dgvHS.Rows[e.RowIndex].Cells[1].Value.ToString();
            tBID.Text = dgvHS.Rows[e.RowIndex].Cells[0].Value.ToString();
            tBmaHS.Text = dgvHS.Rows[e.RowIndex].Cells[8].Value.ToString();
            cBSex.Text = dgvHS.Rows[e.RowIndex].Cells[7].Value.ToString();
            tBPH.Text = dgvHS.Rows[e.RowIndex].Cells[10].Value.ToString();
            tBNienKhoa.Text = dgvHS.Rows[e.RowIndex].Cells[9].Value.ToString();
            tBCCCD.Text = dgvHS.Rows[e.RowIndex].Cells[4].Value.ToString();
            tBPhone.Text = dgvHS.Rows[e.RowIndex].Cells[5].Value.ToString();
            tBAddress.Text = dgvHS.Rows[e.RowIndex].Cells[3].Value.ToString();
            tBEmail.Text = dgvHS.Rows[e.RowIndex].Cells[6].Value.ToString();
            tBHocPhi.Text = dgvHS.Rows[e.RowIndex].Cells[11].Value.ToString();
            cBHL.Text = dgvHS.Rows[e.RowIndex].Cells[12].Value.ToString();
            cBHanhKiem.Text = dgvHS.Rows[e.RowIndex].Cells[13].Value.ToString();
            tBClass.Text = dgvHS.Rows[e.RowIndex].Cells[14].Value.ToString();
            tBDiemTB.Text = dgvHS.Rows[e.RowIndex].Cells[15].Value.ToString();
            tBHocKy.Text = dgvHS.Rows[e.RowIndex].Cells[16].Value.ToString();
            //đối với ngày sinh nhật
            if (string.IsNullOrEmpty(dgvHS.Rows[e.RowIndex].Cells[2].Value.ToString()))
            {
                tBdateHS.CustomFormat = " ";
                tBdateHS.Format = DateTimePickerFormat.Custom;
            }
            else
            {
                tBdateHS.CustomFormat = "dd/MM/yyyy"; // Đặt lại định dạng ngày
                tBdateHS.Format = DateTimePickerFormat.Custom;
                tBdateHS.Text = dgvHS.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        //Thực hiện thêm dữu liệu vào SQL
        private void btnAddHS_Click(object sender, EventArgs e)
        {
            // Xử lý truy vấn INSERT vào cơ sở dữ liệu tại đây
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "BEGIN TRAN INSERT INTO ND (MaID, HoVaTen, DOB, DiaChi, CCCD, SDT, Email, GioiTinh) " +
                        "VALUES (@MaID, @HoVaTen, @DOB, @DiaChi, @CCCD, @SDT, @Email, @GioiTinh) " +
                        "INSERT INTO NDHS (MaID, MaHS, NienKhoa, ThongTinPH, HocPhi, XepLoaiHL, HanhKiem, TenLop, DiemTBHK, HocKy) VALUES (@MaID, @MaHS, @NK, @ThongTinPH, @HocPhi, @XepLoaiHL, @HanhKiem, @TenLop, @DiemTBHK, @HK) COMMIT TRAN";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@DOB", (tBdateHS.CustomFormat == " ") ? (object)DBNull.Value : tBdateHS.Value));
                        command.Parameters.Add(new SqlParameter("@HoVaTen", tBName.Text));
                        command.Parameters.Add(new SqlParameter("@MaID", tBID.Text));
                        command.Parameters.Add(new SqlParameter("@DiaChi", tBAddress.Text));
                        command.Parameters.Add(new SqlParameter("@GioiTinh", cBSex.Text));
                        command.Parameters.Add(new SqlParameter("@Email", tBEmail.Text));
                        command.Parameters.Add(new SqlParameter("@SDT", tBPhone.Text));
                        command.Parameters.Add(new SqlParameter("@XepLoaiHL", cBHL.Text));
                        command.Parameters.Add(new SqlParameter("@MaHS", tBmaHS.Text));
                        command.Parameters.Add(new SqlParameter("@CCCD", tBCCCD.Text));
                        command.Parameters.Add(new SqlParameter("@NK", tBNienKhoa.Text));
                        command.Parameters.Add(new SqlParameter("@ThongTinPH", tBPH.Text));
                        command.Parameters.Add(new SqlParameter("@HocPhi", tBHocPhi.Text));
                        command.Parameters.Add(new SqlParameter("@HanhKiem", cBHanhKiem.Text));
                        command.Parameters.Add(new SqlParameter("@TenLop", tBClass.Text));
                        command.Parameters.Add(new SqlParameter("@DiemTBHK", tBDiemTB.Text));
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
         
        //Thực hiện sửa dữ liệu trong SQL
        private void btnFixHS_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "BEGIN TRAN UPDATE ND SET HoVaTen = @HoVaTen,DOB = @DOB,DiaChi = @DiaChi," +
                        "CCCD = @CCCD,SDT = @SDT,Email = @Email,GioiTinh = @GioiTinh WHERE MaID = @MaID;" +
                        "UPDATE NDHS SET NienKhoa = @NK, ThongTinPH = @ThongTinPH, HocPhi = @HocPhi, XepLoaiHL = @XepLoaiHL, HanhKiem = @HanhKiem, TenLop = @TenLop, DiemTBHK = @DiemTBHK, HocKy = @HK WHERE MaID = @MaID; COMMIT TRAN";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@DOB", (tBdateHS.CustomFormat == " ") ? (object)DBNull.Value : tBdateHS.Value));
                        command.Parameters.Add(new SqlParameter("@HoVaTen", tBName.Text));
                        command.Parameters.Add(new SqlParameter("@MaID", tBID.Text));
                        command.Parameters.Add(new SqlParameter("@DiaChi", tBAddress.Text));
                        command.Parameters.Add(new SqlParameter("@GioiTinh", cBSex.Text));
                        command.Parameters.Add(new SqlParameter("@Email", tBEmail.Text));
                        command.Parameters.Add(new SqlParameter("@SDT", tBPhone.Text));
                        command.Parameters.Add(new SqlParameter("@XepLoaiHL", cBHL.Text));
                        command.Parameters.Add(new SqlParameter("@MaHS", tBmaHS.Text));
                        command.Parameters.Add(new SqlParameter("@CCCD", tBCCCD.Text));
                        command.Parameters.Add(new SqlParameter("@NK", tBNienKhoa.Text));
                        command.Parameters.Add(new SqlParameter("@ThongTinPH", tBPH.Text));
                        command.Parameters.Add(new SqlParameter("@HocPhi", tBHocPhi.Text));
                        command.Parameters.Add(new SqlParameter("@HanhKiem", cBHanhKiem.Text));
                        command.Parameters.Add(new SqlParameter("@TenLop", tBClass.Text));
                        command.Parameters.Add(new SqlParameter("@DiemTBHK", tBDiemTB.Text));
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

        //Thực hiện tìm kiếm dữ liệu trong Gridview
        private void btnFindHS_Click(object sender, EventArgs e)
        {
            string search = tBFind.Text;
            DataView dv = new DataView(dataTable);
            dv.RowFilter = $"HoVaTen like '%{search}%' or CCCD like '%{search}%' or MaHS like '%{search}%' or MaID like '%{search}%' or NienKhoa like '%{search}%' or DiaChi like '%{search}%'  or SDT like '%{search}%' or GioiTinh like '%{search}%' or ThongTinPH like '%{search}%' or HanhKiem like '%{search}%' or HocKy like '%{search}%' or TenLop like '%{search}%' or XepLoaiHL like '%{search}%'";
            dgvHS.DataSource = dv;
        }

        //Thực hiện XÓA dữ liệu trong SQL
        private void btnDelHS_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM Hoc WHERE MaHS IN (SELECT MaHS FROM NDHS WHERE MaID = @MaID) "
                                    + "DELETE FROM Co WHERE MaHS IN(SELECT MaHS FROM NDHS WHERE MaID = @MaID) "
                                    + "DELETE FROM Thuoc WHERE MaHS IN(SELECT MaHS FROM NDHS WHERE MaID = @MaID) "
                                    + "DELETE FROM TK WHERE MaID = @MaID "
                                    + "DELETE FROM NDHS WHERE MaID = @MaID "
                                    + "DELETE FROM ND WHERE MaID = @MaID ";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@DOB", tBdateHS.Value));
                        command.Parameters.Add(new SqlParameter("@HoVaTen", tBName.Text));
                        command.Parameters.Add(new SqlParameter("@MaID", tBID.Text));
                        command.Parameters.Add(new SqlParameter("@DiaChi", tBAddress.Text));
                        command.Parameters.Add(new SqlParameter("@GioiTinh", cBSex.Text));
                        command.Parameters.Add(new SqlParameter("@Email", tBEmail.Text));
                        command.Parameters.Add(new SqlParameter("@SDT", tBPhone.Text));
                        command.Parameters.Add(new SqlParameter("@XepLoaiHL", cBHL.Text));
                        command.Parameters.Add(new SqlParameter("@MaHS", tBmaHS.Text));
                        command.Parameters.Add(new SqlParameter("@CCCD", tBCCCD.Text));
                        command.Parameters.Add(new SqlParameter("@NK", tBNienKhoa.Text));
                        command.Parameters.Add(new SqlParameter("@ThongTinPH", tBPH.Text));
                        command.Parameters.Add(new SqlParameter("@HocPhi", tBHocPhi.Text));
                        command.Parameters.Add(new SqlParameter("@HanhKiem", cBHanhKiem.Text));
                        command.Parameters.Add(new SqlParameter("@TenLop", tBClass.Text));
                        command.Parameters.Add(new SqlParameter("@DiemTBHK", tBDiemTB.Text));
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

        //Khi thay đổi VALUE ngày tháng thì định dạng lại ngày tháng
        private void tBdateHS_ValueChanged(object sender, EventArgs e)
        {
            tBdateHS.CustomFormat = "dd/MM/yyyy";
        }
    }
}
