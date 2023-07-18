using System.Data.SqlClient;

namespace QLTHPT_KTPMUD_2022._2
{
    partial class MainPage
    {
        QLGV qlgv;
        //QLHS qlhs;
        //QLLH qllh;
        //QLBCTK qlbctk;
        //QLMH qlmh;
        //QLKQHT qlkqht;
        //QLTK qltk;
        string strConnection = "Data Source=DESKTOP-K4OTG6Q\\MSQLL;Initial Catalog=qlthpt;Integrated Security=True";
        SqlConnection conn;
        SqlCommand cmd;
        signIn signin;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.menuQLGV = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQLLH = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQLBCTK = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQLMH = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQLKQHT = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQLTK = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.signOut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQLHS = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuQLGV
            // 
            this.menuQLGV.Name = "menuQLGV";
            this.menuQLGV.Size = new System.Drawing.Size(112, 20);
            this.menuQLGV.Text = "Quản lý Giáo viên";
            this.menuQLGV.Click += new System.EventHandler(this.menuQLGV_Click);
            // 
            // menuQLLH
            // 
            this.menuQLLH.Name = "menuQLLH";
            this.menuQLLH.Size = new System.Drawing.Size(106, 20);
            this.menuQLLH.Text = "Quản lý Lớp học";
            this.menuQLLH.Click += new System.EventHandler(this.menuQLLH_Click);
            // 
            // menuQLBCTK
            // 
            this.menuQLBCTK.Name = "menuQLBCTK";
            this.menuQLBCTK.Size = new System.Drawing.Size(155, 20);
            this.menuQLBCTK.Text = "Quản lý Báo cáo thống kê";
            // 
            // menuQLMH
            // 
            this.menuQLMH.Name = "menuQLMH";
            this.menuQLMH.Size = new System.Drawing.Size(111, 20);
            this.menuQLMH.Text = "Quản lý Môn học";
            // 
            // menuQLKQHT
            // 
            this.menuQLKQHT.Name = "menuQLKQHT";
            this.menuQLKQHT.Size = new System.Drawing.Size(146, 20);
            this.menuQLKQHT.Text = "Quản lý Kết quả học tập";
            this.menuQLKQHT.Click += new System.EventHandler(this.menuQLKQHT_Click);
            // 
            // menuQLTK
            // 
            this.menuQLTK.Name = "menuQLTK";
            this.menuQLTK.Size = new System.Drawing.Size(113, 20);
            this.menuQLTK.Text = "Quản lý Tài khoản";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuQLGV,
            this.menuQLHS,
            this.menuQLLH,
            this.menuQLBCTK,
            this.menuQLMH,
            this.menuQLKQHT,
            this.menuQLTK,
            this.signOut});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1129, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // signOut
            // 
            this.signOut.Name = "signOut";
            this.signOut.Size = new System.Drawing.Size(73, 20);
            this.signOut.Text = "Đăng xuất";
            this.signOut.Click += new System.EventHandler(this.signOut_Click);
            // 
            // menuQLHS
            // 
            this.menuQLHS.Name = "menuQLHS";
            this.menuQLHS.Size = new System.Drawing.Size(110, 20);
            this.menuQLHS.Text = "Quản lý Học sinh";
            this.menuQLHS.Click += new System.EventHandler(this.menuQLHS_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLTHPT_KTPMUD_2022._2.Properties.Resources.background_inside;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1129, 463);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainPage";
            this.Text = "Trang chủ";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem menuQLGV;
        private System.Windows.Forms.ToolStripMenuItem menuQLLH;
        private System.Windows.Forms.ToolStripMenuItem menuQLBCTK;
        private System.Windows.Forms.ToolStripMenuItem menuQLMH;
        private System.Windows.Forms.ToolStripMenuItem menuQLKQHT;
        private System.Windows.Forms.ToolStripMenuItem menuQLTK;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem signOut;
        private System.Windows.Forms.ToolStripMenuItem menuQLHS;
    }
}