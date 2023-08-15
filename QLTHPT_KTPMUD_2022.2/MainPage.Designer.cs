using System.Data.SqlClient;

namespace QLTHPT_KTPMUD_2022._2
{
    partial class MainPage
    {

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
            this.menuQLHS = new System.Windows.Forms.ToolStripMenuItem();
            this.signOut = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuQLGV
            // 
            this.menuQLGV.Name = "menuQLGV";
            this.menuQLGV.Size = new System.Drawing.Size(139, 24);
            this.menuQLGV.Text = "Quản lý Giáo viên";
            this.menuQLGV.Click += new System.EventHandler(this.menuQLGV_Click);
            // 
            // menuQLLH
            // 
            this.menuQLLH.Name = "menuQLLH";
            this.menuQLLH.Size = new System.Drawing.Size(130, 24);
            this.menuQLLH.Text = "Quản lý Lớp học";
            this.menuQLLH.Click += new System.EventHandler(this.menuQLLH_Click);
            // 
            // menuQLBCTK
            // 
            this.menuQLBCTK.Name = "menuQLBCTK";
            this.menuQLBCTK.Size = new System.Drawing.Size(193, 24);
            this.menuQLBCTK.Text = "Quản lý Báo cáo thống kê";
            // 
            // menuQLMH
            // 
            this.menuQLMH.Name = "menuQLMH";
            this.menuQLMH.Size = new System.Drawing.Size(135, 24);
            this.menuQLMH.Text = "Quản lý Môn học";
            this.menuQLMH.Click += new System.EventHandler(this.menuQLMH_Click);
            // 
            // menuQLKQHT
            // 
            this.menuQLKQHT.Name = "menuQLKQHT";
            this.menuQLKQHT.Size = new System.Drawing.Size(182, 24);
            this.menuQLKQHT.Text = "Quản lý Kết quả học tập";
            this.menuQLKQHT.Click += new System.EventHandler(this.menuQLKQHT_Click);
            // 
            // menuQLTK
            // 
            this.menuQLTK.Name = "menuQLTK";
            this.menuQLTK.Size = new System.Drawing.Size(139, 24);
            this.menuQLTK.Text = "Quản lý Tài khoản";
            this.menuQLTK.Click += new System.EventHandler(this.menuQLTK_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
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
            this.menuStrip1.Size = new System.Drawing.Size(1505, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menuQLHS
            // 
            this.menuQLHS.Name = "menuQLHS";
            this.menuQLHS.Size = new System.Drawing.Size(134, 24);
            this.menuQLHS.Text = "Quản lý Học sinh";
            this.menuQLHS.Click += new System.EventHandler(this.menuQLHS_Click);
            // 
            // signOut
            // 
            this.signOut.Name = "signOut";
            this.signOut.Size = new System.Drawing.Size(91, 24);
            this.signOut.Text = "Đăng xuất";
            this.signOut.Click += new System.EventHandler(this.signOut_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(882, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 40);
            this.button1.TabIndex = 11;
            this.button1.Text = "Choose file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1119, 255);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 35);
            this.button2.TabIndex = 12;
            this.button2.Text = "Play";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1119, 318);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 37);
            this.button3.TabIndex = 13;
            this.button3.Text = "Stop";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(332, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(534, 22);
            this.textBox1.TabIndex = 14;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1119, 386);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 37);
            this.button4.TabIndex = 15;
            this.button4.Text = "Pause";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(332, 106);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(745, 417);
            this.axWindowsMediaPlayer1.TabIndex = 10;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLTHPT_KTPMUD_2022._2.Properties.Resources.background_inside;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1505, 570);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainPage";
            this.Text = "Trang chủ";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
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
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
    }
}