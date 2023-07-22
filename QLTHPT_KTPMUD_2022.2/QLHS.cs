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
        private Rectangle tBNameOriginalRect;
        private Rectangle tBIDOriginalRect;
        private Rectangle tBMaHSOriginalRect;
        private Rectangle tBNienKhoaOriginalRect;
        private Rectangle cBSexOriginalRect;
        private Rectangle tBCCCDOriginalRect;
        private Rectangle tBdateHSOriginalRect;
        private Rectangle tBPhoneOriginalRect;
        private Rectangle tBAddressOriginalRect;
        private Rectangle tBEmailOriginalRect;
        private Rectangle tBPHOriginalRect;
        private Rectangle cBHLOriginalRect;
        private Rectangle cBHanhKiemOriginalRect;
        private Rectangle tBHocPhiOriginalRect;
        private Rectangle tBClassOriginalRect;
        private Rectangle tBHocKyOriginalRect;
        private Rectangle tBDiemTBOriginalRect;
        private Rectangle tBFindOriginalRect;
        private Rectangle btnAddHSOriginalRect;
        private Rectangle btnFixHSOriginalRect;
        private Rectangle btnFindHSOriginalRect;
        private Rectangle btnDelHSOriginalRect;
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
        private Rectangle label13OriginalRect;
        private Rectangle label14OriginalRect;
        private Rectangle label15OriginalRect;
        private Rectangle label16OriginalRect;
        private Rectangle label17OriginalRect;
        private Rectangle dgvHSOriginalRect;
        private Size QLHSOriginalSize;
        private DataTable dataTable = new DataTable(); //Tạo đối tượng bảng
        private MainPage mainPage = new MainPage(); //Tạo 1 đối tượng trang chủ thừa kế các method hoặc thuộc tính của lớp
        string connectionString = DatabaseConnection.Instance.ConnectionString;
        public QLHS()
        {
            InitializeComponent();
        }

        private void QLHS_Load(object sender, EventArgs e)
        {
            QLHSOriginalSize = this.Size;
            tBNameOriginalRect = new Rectangle(tBName.Location.X, tBName.Location.Y, tBName.Width, tBName.Height);
            tBIDOriginalRect = new Rectangle(tBID.Location.X, tBID.Location.Y, tBID.Width, tBID.Height);
            tBMaHSOriginalRect = new Rectangle(tBmaHS.Location.X, tBmaHS.Location.Y, tBmaHS.Width, tBmaHS.Height);
            tBAddressOriginalRect = new Rectangle(tBAddress.Location.X, tBAddress.Location.Y, tBAddress.Width, tBAddress.Height);
            tBPhoneOriginalRect = new Rectangle(tBPhone.Location.X, tBPhone.Location.Y, tBPhone.Width, tBPhone.Height);
            tBCCCDOriginalRect = new Rectangle(tBCCCD.Location.X, tBCCCD.Location.Y, tBCCCD.Width, tBCCCD.Height);
            tBdateHSOriginalRect = new Rectangle(tBdateHS.Location.X, tBdateHS.Location.Y, tBdateHS.Width, tBdateHS.Height);
            tBEmailOriginalRect = new Rectangle(tBEmail.Location.X, tBEmail.Location.Y, tBEmail.Width, tBEmail.Height);
            tBPHOriginalRect = new Rectangle(tBPH.Location.X, tBPH.Location.Y, tBPH.Width, tBPH.Height);
            cBHLOriginalRect = new Rectangle(cBHL.Location.X, cBHL.Location.Y, cBHL.Width, cBHL.Height);
            tBFindOriginalRect = new Rectangle(tBFind.Location.X, tBFind.Location.Y, tBFind.Width, tBFind.Height);
            cBHanhKiemOriginalRect = new Rectangle(cBHanhKiem.Location.X, cBHanhKiem.Location.Y, cBHanhKiem.Width, cBHanhKiem.Height);
            tBHocPhiOriginalRect = new Rectangle(tBHocPhi.Location.X, tBHocPhi.Location.Y, tBHocPhi.Width, tBHocPhi.Height);
            tBClassOriginalRect = new Rectangle(tBClass.Location.X, tBClass.Location.Y, tBClass.Width, tBClass.Height);
            tBHocKyOriginalRect = new Rectangle(tBHocKy.Location.X, tBHocKy.Location.Y, tBHocKy.Width, tBHocKy.Height);
            tBDiemTBOriginalRect = new Rectangle(tBDiemTB.Location.X, tBDiemTB.Location.Y, tBDiemTB.Width, tBDiemTB.Height);
            tBNienKhoaOriginalRect = new Rectangle(tBNienKhoa.Location.X, tBNienKhoa.Location.Y, tBNienKhoa.Width, tBNienKhoa.Height);
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
            label13OriginalRect = new Rectangle(label13.Location.X, label13.Location.Y, label13.Width, label13.Height);
            label14OriginalRect = new Rectangle(label14.Location.X, label14.Location.Y, label14.Width, label14.Height);
            label15OriginalRect = new Rectangle(label15.Location.X, label15.Location.Y, label15.Width, label15.Height);
            label16OriginalRect = new Rectangle(label16.Location.X, label16.Location.Y, label16.Width, label16.Height);
            label17OriginalRect = new Rectangle(label17.Location.X, label17.Location.Y, label17.Width, label17.Height);
            btnAddHSOriginalRect = new Rectangle(btnAddHS.Location.X, btnAddHS.Location.Y, btnAddHS.Width, btnAddHS.Height);
            btnFixHSOriginalRect = new Rectangle(btnFixHS.Location.X, btnFixHS.Location.Y, btnFixHS.Width, btnFixHS.Height);
            btnFindHSOriginalRect = new Rectangle(btnFindHS.Location.X, btnFindHS.Location.Y, btnFindHS.Width, btnFindHS.Height);
            btnDelHSOriginalRect = new Rectangle(btnDelHS.Location.X, btnDelHS.Location.Y, btnDelHS.Width, btnDelHS.Height);
            btnBackOriginalRect = new Rectangle(btnBack.Location.X, btnBack.Location.Y, btnBack.Width, btnBack.Height);
            dgvHSOriginalRect = new Rectangle(dgvHS.Location.X, dgvHS.Location.Y, dgvHS.Width, dgvHS.Height);
            LoadData();
        }
        //Hàm thay đổi kích thước các control cho phù hợp với kích thước form 
        private void resizeChildrenControls()
        {
            resizeControl(tBNameOriginalRect, tBName);
            resizeControl(tBMaHSOriginalRect, tBmaHS);
            resizeControl(tBIDOriginalRect, tBID);
            resizeControl(cBSexOriginalRect, cBSex);
            resizeControl(tBPHOriginalRect, tBPH);
            resizeControl(tBNienKhoaOriginalRect, tBNienKhoa);
            resizeControl(cBHanhKiemOriginalRect, cBHanhKiem);
            resizeControl(cBHLOriginalRect, cBHL);
            resizeControl(tBAddressOriginalRect, tBAddress);
            resizeControl(tBPhoneOriginalRect, tBPhone);
            resizeControl(tBHocPhiOriginalRect, tBHocPhi);
            resizeControl(tBdateHSOriginalRect, tBdateHS);
            resizeControl(tBCCCDOriginalRect, tBCCCD);
            resizeControl(tBEmailOriginalRect, tBEmail);
            resizeControl(tBClassOriginalRect, tBClass);
            resizeControl(tBHocKyOriginalRect, tBHocKy);
            resizeControl(tBDiemTBOriginalRect, tBDiemTB);
            resizeControl(tBFindOriginalRect, tBFind);
            resizeControl(btnAddHSOriginalRect, btnAddHS);
            resizeControl(btnFixHSOriginalRect, btnFixHS);
            resizeControl(btnDelHSOriginalRect, btnDelHS);
            resizeControl(btnFindHSOriginalRect, btnFindHS);
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
            resizeControl(label13OriginalRect, label13);
            resizeControl(label14OriginalRect, label14);
            resizeControl(label15OriginalRect, label15);
            resizeControl(label16OriginalRect, label16);
            resizeControl(label17OriginalRect, label17);
            resizeControl(dgvHSOriginalRect, dgvHS);
        }

        //Hàm sử dụng để kiểm soát việc thay đổi kích thước lưu kích thước ban đầu và kích thước hiện tại 
        private void resizeControl(Rectangle OriginalControlRect, Control control)
        {
            float xRatio = (float)(this.Width) / (float)(QLHSOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(QLHSOriginalSize.Height);


            int newX = (int)(OriginalControlRect.X * xRatio);
            int newY = (int)(OriginalControlRect.Y * yRatio);

            int newWidth = (int)(OriginalControlRect.Width * xRatio);
            int newHeight = (int)(OriginalControlRect.Height * yRatio);

            control.Location = new Point(newX, newY);
            control.Size = new Size(newWidth, newHeight);
        }

        //Sự kiện thay đổi kích thước
        private void QLHS_Resize(object sender, EventArgs e)
        {
            resizeChildrenControls();
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
