using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Net;
using System.Reflection.Emit;
using System.Windows.Forms;
using System.Xml.Linq;


namespace QLTHPT_KTPMUD_2022._2
{
    public partial class QLLH : Form
    {
        private Rectangle btnBack1OriginalRect;
        private Rectangle btnFindLHDOriginalRect;
        private Rectangle btnAddLHOriginalRect;
        private Rectangle btnFixLHOriginalRect;
        private Rectangle btnDelLHOriginalRect;
        private Rectangle tBFind1OriginalRect;
        private Rectangle tBTenLopOriginalRect;
        private Rectangle tBViTriOriginalRect;
        private Rectangle tBSiSoOriginalRect;
        private Rectangle lBTenLopOriginalRect;
        private Rectangle lBViTriOriginalRect;
        private Rectangle lBSiSoOriginalRect;
        private Rectangle dgvLHOriginalRect;
        
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
        private Size QLLHOriginalSize;
        private void resizeControl(Rectangle OriginalControlRect, Control control)
        {
            float xRatio = (float)(this.Width) / (float)(QLLHOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(QLLHOriginalSize.Height);


            int newX = (int)(OriginalControlRect.X * xRatio);
            int newY = (int)(OriginalControlRect.Y * yRatio);

            int newWidth = (int)(OriginalControlRect.Width * xRatio);
            int newHeight = (int)(OriginalControlRect.Height * yRatio);

            control.Location = new Point(newX, newY);
            control.Size = new Size(newWidth, newHeight);
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
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            this.Hide();
            mainPage.Show();
        }

        private void QLLH_Load(object sender, EventArgs e)
        {
            QLLHOriginalSize = this.Size;
            btnBack1OriginalRect = new Rectangle(btnBack1.Location.X, btnBack1.Location.Y, btnBack1.Width, btnBack1.Height);
            btnFindLHDOriginalRect = new Rectangle(btnFindLH.Location.X, btnFindLH.Location.Y, btnFindLH.Width, btnFindLH.Height);
            btnAddLHOriginalRect = new Rectangle(btnAddLH.Location.X, btnAddLH.Location.Y, btnAddLH.Width, btnAddLH.Height);
            btnFixLHOriginalRect = new Rectangle(btnFixLH.Location.X, btnFixLH.Location.Y, btnFixLH.Width, btnFixLH.Height);
            btnDelLHOriginalRect = new Rectangle(btnDelLH.Location.X, btnDelLH.Location.Y, btnDelLH.Width, btnDelLH.Height);
            tBFind1OriginalRect = new Rectangle(tBFind1.Location.X, tBFind1.Location.Y, tBFind1.Width, tBFind1.Height);
            tBTenLopOriginalRect = new Rectangle(tBTenLop.Location.X, tBTenLop.Location.Y, tBTenLop.Width, tBTenLop.Height);
            tBViTriOriginalRect = new Rectangle(tBViTri.Location.X, tBViTri.Location.Y, tBViTri.Width, tBViTri.Height);
            tBSiSoOriginalRect = new Rectangle(tBSiSo.Location.X, tBSiSo.Location.Y, tBSiSo.Width, tBSiSo.Height);
            lBTenLopOriginalRect = new Rectangle(lBTenLop.Location.X, lBTenLop.Location.Y, lBTenLop.Width, lBTenLop.Height);
            lBViTriOriginalRect = new Rectangle(lBViTri.Location.X, lBViTri.Location.Y, lBViTri.Width, lBViTri.Height);
            lBSiSoOriginalRect = new Rectangle(lBSiSo.Location.X, lBSiSo.Location.Y, lBSiSo.Width, lBSiSo.Height);
            dgvLHOriginalRect = new Rectangle(dgvLH.Location.X, dgvLH.Location.Y, dgvLH.Width, dgvLH.Height);
            LoadData();
        }
        private void resizeChildrenControls()
        {
            resizeControl(btnBack1OriginalRect, btnBack1);
            resizeControl(btnAddLHOriginalRect, btnAddLH);
            resizeControl(btnFixLHOriginalRect, btnFixLH);
            resizeControl(btnDelLHOriginalRect, btnDelLH);
            resizeControl(btnFindLHDOriginalRect, btnFindLH);
            resizeControl(tBFind1OriginalRect, tBFind1);
            resizeControl(tBTenLopOriginalRect, tBTenLop);
            resizeControl(tBViTriOriginalRect, tBViTri);
            resizeControl(tBSiSoOriginalRect, tBSiSo);
            resizeControl(lBTenLopOriginalRect, lBTenLop);
            resizeControl(lBViTriOriginalRect, lBViTri);
            resizeControl(lBSiSoOriginalRect, lBSiSo);
            resizeControl(dgvLHOriginalRect, dgvLH);
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

        private void QLLH_Resize(object sender, EventArgs e)
        {
            resizeChildrenControls();
        }

        private void dgvLH_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tBTenLop.Text = dgvLH.Rows[e.RowIndex].Cells[1].Value.ToString();
            tBViTri.Text = dgvLH.Rows[e.RowIndex].Cells[1].Value.ToString();
            tBSiSo.Text = dgvLH.Rows[e.RowIndex].Cells[1].Value.ToString();
            
        }
    }
}
