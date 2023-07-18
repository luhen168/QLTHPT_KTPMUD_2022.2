using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

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
        private DataTable dataTable = new DataTable();
        private Rectangle dgvGVOriginalRect;
        private Size QLGVOriginalSize;
     

        public QLGV()
        {
            InitializeComponent();
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

            dgvGVOriginalRect = new Rectangle(dgvGV.Location.X, dgvGV.Location.Y, dgvGV.Width, dgvGV.Height);
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT dbo.ND.*, dbo.NDGV.MaGV, dbo.NDGV.NgayBD, dbo.NDGV.NgayKT, dbo.NDGV.BoMon FROM dbo.NDGV JOIN dbo.ND ON dbo.NDGV.MaID = dbo.ND.MaID"; ;
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dataTable);
            }
            dgvGV.DataSource = dataTable;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tBID_TextChanged(object sender, EventArgs e)
        {

        }

        private void tBmaGV_TextChanged(object sender, EventArgs e)
        {

        }

        private void cBSex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAddGV_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFindGV_Click(object sender, EventArgs e)
        {
            string search = tBFind.Text;
            DataView dv = new DataView(dataTable);
            dv.RowFilter = $"HoVaTen like '%{search}%' or CCCD like '%{search}%' or MaGV like '%{search}%' or MaID like '%{search}%' or BoMon like '%{search}%' or DiaChi like '%{search}%'  or SDT like '%{search}%' or GioiTinh like '%{search}%'";
            dgvGV.DataSource = dv;

        }
    }
}
