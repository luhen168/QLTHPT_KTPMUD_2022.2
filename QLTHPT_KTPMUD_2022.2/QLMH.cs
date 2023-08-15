using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Net;
using System.Reflection.Emit;
using System.Windows.Forms;


namespace QLTHPT_KTPMUD_2022._2
{
    public partial class QLMH : Form
    {       
        private Rectangle tBNameOriginalRect;
        private Rectangle tBIDOriginalRect;    //chuan roi anh zai
        private Rectangle tBFindOriginalRect;
        private Rectangle label1OriginalRect;
        private Rectangle label2OriginalRect;
        private Rectangle dgvMHOriginalRect;
        private Rectangle btnAddOriginalRect;
        private Rectangle btnUpdateOriginalRect;
        private Rectangle btnFindOriginalRect;
        private Rectangle btnDeleteOriginalRect;
        private Rectangle BackOriginalRect;
        private Size QLMHOriginalSize;
        private MainPage mainPage = new MainPage();
        private DataTable dataTable = new DataTable(); //Tạo đối tượng bảng
        string connectionString = DatabaseConnection.Instance.ConnectionString;
        public QLMH()
        {
            InitializeComponent();
            //comment;cchellllllo
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainPage.Show();
        }
        private void QLMH_Load(object sender, EventArgs e)
        {
            QLMHOriginalSize = this.Size;
            tBNameOriginalRect = new Rectangle(tBName.Location.X, tBName.Location.Y, tBName.Width, tBName.Height);
            tBIDOriginalRect = new Rectangle(tBID.Location.X, tBID.Location.Y, tBID.Width, tBID.Height);
            tBFindOriginalRect = new Rectangle(tBFind.Location.X, tBFind.Location.Y, tBFind.Width, tBFind.Height);
            label1OriginalRect = new Rectangle(label1.Location.X, label1.Location.Y, label1.Width, label1.Height);
            label2OriginalRect = new Rectangle(label2.Location.X, label2.Location.Y, label2.Width, label2.Height);
            btnAddOriginalRect = new Rectangle(btnAdd.Location.X, btnAdd.Location.Y, btnAdd.Width, btnAdd.Height);
            btnUpdateOriginalRect = new Rectangle(btnUpdate.Location.X, btnUpdate.Location.Y, btnUpdate.Width, btnUpdate.Height);
            btnFindOriginalRect = new Rectangle(btnFind.Location.X, btnFind.Location.Y, btnFind.Width, btnFind.Height);
            btnDeleteOriginalRect = new Rectangle(btnDelete.Location.X, btnDelete.Location.Y, btnDelete.Width, btnDelete.Height);
            BackOriginalRect = new Rectangle(Back.Location.X, Back.Location.Y, Back.Width, Back.Height);
            dgvMHOriginalRect = new Rectangle(dgvMH.Location.X, dgvMH.Location.Y, dgvMH.Width, dgvMH.Height);
            LoadData();
        }
        private void resizeControl(Rectangle OriginalControlRect, Control control)
        {
            float xRatio = (float)(this.Width) / (float)(QLMHOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(QLMHOriginalSize.Height);


            int newX = (int)(OriginalControlRect.X * xRatio);
            int newY = (int)(OriginalControlRect.Y * yRatio);

            int newWidth = (int)(OriginalControlRect.Width * xRatio);
            int newHeight = (int)(OriginalControlRect.Height * yRatio);

            control.Location = new Point(newX, newY);
            control.Size = new Size(newWidth, newHeight);
        }
        private void resizeChildrenControls()
        {
            resizeControl(tBNameOriginalRect, tBName);
            resizeControl(tBIDOriginalRect, tBID);
            resizeControl(tBFindOriginalRect, tBFind);

            resizeControl(btnAddOriginalRect, btnAdd);
            resizeControl(btnUpdateOriginalRect, btnUpdate);
            resizeControl(btnDeleteOriginalRect, btnDelete);
            resizeControl(btnFindOriginalRect, btnFind);
            resizeControl(BackOriginalRect, Back);
            resizeControl(label1OriginalRect, label1);
            resizeControl(label2OriginalRect, label2);

            resizeControl(dgvMHOriginalRect, dgvMH);
        }
        private void Find_Click(object sender, EventArgs e)
        {
            string search = tBFind.Text;
            DataView dv = new DataView(dataTable);
            dv.RowFilter = $"MaMH like '%{search}%' or TenMH like '%{search}%'";
            dgvMH.DataSource = dv;
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
            dgvMH.DataSource = dataTable;
        }
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

                        command.Parameters.Add(new SqlParameter("@MaMH", tBID.Text));
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
            tBID.Text = dgvMH.Rows[e.RowIndex].Cells[0].Value.ToString();
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

        private void QLMH_Resize(object sender, EventArgs e)
        {
            resizeChildrenControls();
        }
    }
}