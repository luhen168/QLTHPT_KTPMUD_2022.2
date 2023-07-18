using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace QLTHPT_KTPMUD_2022._2
{
    partial class QLGV
    {
        string connectionString = DatabaseConnection.Instance.ConnectionString;
        SqlConnection conn;
        DataSet GetGV()
        {
            DataSet dsGV = new DataSet();
            string query = "SELECT dbo.ND.*, dbo.NDGV.MaGV, dbo.NDGV.NgayBD, dbo.NDGV.NgayKT, dbo.NDGV.BoMon FROM dbo.NDGV JOIN dbo.ND ON dbo.NDGV.MaID = dbo.ND.MaID";

            using (conn = new SqlConnection(connectionString)) //Tao 1 ket noi toi SQL server
            { 
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query,conn);
                adapter.Fill(dsGV);
                conn.Close();
            } 
                return dsGV;  
        }

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLGV));
            this.tBName = new System.Windows.Forms.TextBox();
            this.tBID = new System.Windows.Forms.TextBox();
            this.tBmaGV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tBPhone = new System.Windows.Forms.TextBox();
            this.tBAddress = new System.Windows.Forms.TextBox();
            this.tBCCCD = new System.Windows.Forms.TextBox();
            this.cBMH = new System.Windows.Forms.ComboBox();
            this.cBSex = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tBdateGV = new System.Windows.Forms.DateTimePicker();
            this.btnAddGV = new System.Windows.Forms.Button();
            this.btnFixGV = new System.Windows.Forms.Button();
            this.btnFindGV = new System.Windows.Forms.Button();
            this.btnDelGV = new System.Windows.Forms.Button();
            this.dgvGV = new System.Windows.Forms.DataGridView();
            this.tBStartDate = new System.Windows.Forms.TextBox();
            this.tBEmail = new System.Windows.Forms.TextBox();
            this.tBEndDate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tBFind = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGV)).BeginInit();
            this.SuspendLayout();
            // 
            // tBName
            // 
            this.tBName.Location = new System.Drawing.Point(89, 53);
            this.tBName.Name = "tBName";
            this.tBName.Size = new System.Drawing.Size(155, 20);
            this.tBName.TabIndex = 0;
            this.tBName.TextChanged += new System.EventHandler(this.cbName_TextChanged);
            // 
            // tBID
            // 
            this.tBID.Location = new System.Drawing.Point(89, 78);
            this.tBID.Name = "tBID";
            this.tBID.Size = new System.Drawing.Size(155, 20);
            this.tBID.TabIndex = 1;
            this.tBID.TextChanged += new System.EventHandler(this.tBID_TextChanged);
            // 
            // tBmaGV
            // 
            this.tBmaGV.Location = new System.Drawing.Point(89, 104);
            this.tBmaGV.Name = "tBmaGV";
            this.tBmaGV.Size = new System.Drawing.Size(155, 20);
            this.tBmaGV.TabIndex = 3;
            this.tBmaGV.TextChanged += new System.EventHandler(this.tBmaGV_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Họ và tên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mã GV";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Môn học";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(382, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "CCCD";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(382, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ngày sinh";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(382, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "SDT";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(382, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Địa chỉ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // tBPhone
            // 
            this.tBPhone.Location = new System.Drawing.Point(440, 104);
            this.tBPhone.Name = "tBPhone";
            this.tBPhone.Size = new System.Drawing.Size(155, 20);
            this.tBPhone.TabIndex = 14;
            // 
            // tBAddress
            // 
            this.tBAddress.Location = new System.Drawing.Point(440, 130);
            this.tBAddress.Name = "tBAddress";
            this.tBAddress.Size = new System.Drawing.Size(155, 20);
            this.tBAddress.TabIndex = 15;
            // 
            // tBCCCD
            // 
            this.tBCCCD.Location = new System.Drawing.Point(440, 53);
            this.tBCCCD.Name = "tBCCCD";
            this.tBCCCD.Size = new System.Drawing.Size(155, 20);
            this.tBCCCD.TabIndex = 16;
            // 
            // cBMH
            // 
            this.cBMH.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBMH.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBMH.FormattingEnabled = true;
            this.cBMH.Items.AddRange(new object[] {
            "Địa ",
            "Giáo dục công dân",
            "Hóa",
            "Lý",
            "Sinh",
            "Sử",
            "Thể chất",
            "Tiếng Anh",
            "Toán",
            "Văn "});
            this.cBMH.Location = new System.Drawing.Point(89, 130);
            this.cBMH.Name = "cBMH";
            this.cBMH.Size = new System.Drawing.Size(155, 21);
            this.cBMH.Sorted = true;
            this.cBMH.TabIndex = 19;
            this.cBMH.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cBSex
            // 
            this.cBSex.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBSex.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBSex.FormattingEnabled = true;
            this.cBSex.Items.AddRange(new object[] {
            "Khác",
            "Nam",
            "Nữ"});
            this.cBSex.Location = new System.Drawing.Point(89, 157);
            this.cBSex.Name = "cBSex";
            this.cBSex.Size = new System.Drawing.Size(155, 21);
            this.cBSex.Sorted = true;
            this.cBSex.TabIndex = 20;
            this.cBSex.SelectedIndexChanged += new System.EventHandler(this.cBSex_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Giới tính";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // tBdateGV
            // 
            this.tBdateGV.CustomFormat = "dd/MM/yyyy";
            this.tBdateGV.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tBdateGV.Location = new System.Drawing.Point(440, 78);
            this.tBdateGV.Name = "tBdateGV";
            this.tBdateGV.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tBdateGV.Size = new System.Drawing.Size(155, 20);
            this.tBdateGV.TabIndex = 22;
            this.tBdateGV.UseWaitCursor = true;
            this.tBdateGV.Value = new System.DateTime(2023, 7, 17, 0, 0, 0, 0);
            // 
            // btnAddGV
            // 
            this.btnAddGV.AutoSize = true;
            this.btnAddGV.Location = new System.Drawing.Point(700, 66);
            this.btnAddGV.Name = "btnAddGV";
            this.btnAddGV.Size = new System.Drawing.Size(88, 32);
            this.btnAddGV.TabIndex = 25;
            this.btnAddGV.Text = "Thêm";
            this.btnAddGV.UseVisualStyleBackColor = true;
            this.btnAddGV.Click += new System.EventHandler(this.btnAddGV_Click);
            // 
            // btnFixGV
            // 
            this.btnFixGV.AutoSize = true;
            this.btnFixGV.Location = new System.Drawing.Point(700, 119);
            this.btnFixGV.Name = "btnFixGV";
            this.btnFixGV.Size = new System.Drawing.Size(88, 32);
            this.btnFixGV.TabIndex = 26;
            this.btnFixGV.Text = "Sửa";
            this.btnFixGV.UseVisualStyleBackColor = true;
            // 
            // btnFindGV
            // 
            this.btnFindGV.AutoSize = true;
            this.btnFindGV.Location = new System.Drawing.Point(700, 12);
            this.btnFindGV.Name = "btnFindGV";
            this.btnFindGV.Size = new System.Drawing.Size(88, 32);
            this.btnFindGV.TabIndex = 27;
            this.btnFindGV.Text = "Tìm kiếm";
            this.btnFindGV.UseVisualStyleBackColor = true;
            this.btnFindGV.Click += new System.EventHandler(this.btnFindGV_Click);
            // 
            // btnDelGV
            // 
            this.btnDelGV.AutoSize = true;
            this.btnDelGV.Location = new System.Drawing.Point(700, 172);
            this.btnDelGV.Name = "btnDelGV";
            this.btnDelGV.Size = new System.Drawing.Size(88, 32);
            this.btnDelGV.TabIndex = 28;
            this.btnDelGV.Text = "Xóa";
            this.btnDelGV.UseVisualStyleBackColor = true;
            // 
            // dgvGV
            // 
            this.dgvGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGV.Location = new System.Drawing.Point(23, 239);
            this.dgvGV.Name = "dgvGV";
            this.dgvGV.Size = new System.Drawing.Size(748, 207);
            this.dgvGV.TabIndex = 29;
            this.dgvGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tBStartDate
            // 
            this.tBStartDate.Location = new System.Drawing.Point(440, 157);
            this.tBStartDate.Name = "tBStartDate";
            this.tBStartDate.Size = new System.Drawing.Size(155, 20);
            this.tBStartDate.TabIndex = 35;
            // 
            // tBEmail
            // 
            this.tBEmail.Location = new System.Drawing.Point(89, 184);
            this.tBEmail.Name = "tBEmail";
            this.tBEmail.Size = new System.Drawing.Size(155, 20);
            this.tBEmail.TabIndex = 36;
            // 
            // tBEndDate
            // 
            this.tBEndDate.Location = new System.Drawing.Point(440, 184);
            this.tBEndDate.Name = "tBEndDate";
            this.tBEndDate.Size = new System.Drawing.Size(155, 20);
            this.tBEndDate.TabIndex = 37;
            this.tBEndDate.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(354, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "Ngày bắt đầu ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(354, 187);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 39;
            this.label11.Text = "Ngày kết thúc";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 187);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 40;
            this.label12.Text = "Email";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // tBFind
            // 
            this.tBFind.Location = new System.Drawing.Point(211, 19);
            this.tBFind.Name = "tBFind";
            this.tBFind.Size = new System.Drawing.Size(483, 20);
            this.tBFind.TabIndex = 44;
            // 
            // QLGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(793, 450);
            this.Controls.Add(this.tBFind);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tBEndDate);
            this.Controls.Add(this.tBEmail);
            this.Controls.Add(this.tBStartDate);
            this.Controls.Add(this.dgvGV);
            this.Controls.Add(this.btnDelGV);
            this.Controls.Add(this.btnFindGV);
            this.Controls.Add(this.btnFixGV);
            this.Controls.Add(this.btnAddGV);
            this.Controls.Add(this.tBdateGV);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cBSex);
            this.Controls.Add(this.cBMH);
            this.Controls.Add(this.tBCCCD);
            this.Controls.Add(this.tBAddress);
            this.Controls.Add(this.tBPhone);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBmaGV);
            this.Controls.Add(this.tBID);
            this.Controls.Add(this.tBName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QLGV";
            this.Text = "Quản lý Giáo viên";
            this.Load += new System.EventHandler(this.QLGV_Load);
            this.Resize += new System.EventHandler(this.QLGV_Resize_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBName;
        private System.Windows.Forms.TextBox tBID;
        private System.Windows.Forms.TextBox tBmaGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tBPhone;
        private System.Windows.Forms.TextBox tBAddress;
        private System.Windows.Forms.TextBox tBCCCD;
        private System.Windows.Forms.ComboBox cBMH;
        private System.Windows.Forms.ComboBox cBSex;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.DateTimePicker tBdateGV;
        private System.Windows.Forms.Button btnAddGV;
        private System.Windows.Forms.Button btnFixGV;
        private System.Windows.Forms.Button btnFindGV;
        private System.Windows.Forms.Button btnDelGV;
        private System.Windows.Forms.DataGridView dgvGV;
        private System.Windows.Forms.TextBox tBEmail;
        private System.Windows.Forms.TextBox tBEndDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tBStartDate;
        private System.Windows.Forms.TextBox tBFind;
    }
}