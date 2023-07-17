using System.Data.SqlClient;

namespace QLTHPT_KTPMUD_2022._2
{
    partial class signIn
    {
        MainPage mainpage; //Tạo 1 đối tượng và 1 
        //Tao 1 chuoi ket noi SQL server
        string strConnection = "Data Source=DESKTOP-K4OTG6Q\\MSQLL;Initial Catalog=qlthpt;Integrated Security=True";
        SqlConnection conn;
        SqlCommand cmd;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signIn));
            this.tBUserName = new System.Windows.Forms.TextBox();
            this.tBPass = new System.Windows.Forms.TextBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Incorrect = new System.Windows.Forms.Label();
            this.cBPass = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tBUserName
            // 
            this.tBUserName.Location = new System.Drawing.Point(354, 159);
            this.tBUserName.Name = "tBUserName";
            this.tBUserName.Size = new System.Drawing.Size(125, 20);
            this.tBUserName.TabIndex = 0;
            this.tBUserName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tBPass
            // 
            this.tBPass.Location = new System.Drawing.Point(354, 205);
            this.tBPass.Name = "tBPass";
            this.tBPass.Size = new System.Drawing.Size(125, 20);
            this.tBPass.TabIndex = 1;
            this.tBPass.UseSystemPasswordChar = true;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(294, 162);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(55, 13);
            this.labelUserName.TabIndex = 2;
            this.labelUserName.Text = "Tài khoản";
            this.labelUserName.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(294, 208);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(52, 13);
            this.labelPass.TabIndex = 3;
            this.labelPass.Text = "Mật khẩu";
            this.labelPass.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(375, 245);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(75, 23);
            this.btnSignIn.TabIndex = 4;
            this.btnSignIn.Text = "Đăng nhập";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(672, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "ĐĂNG NHẬP HỆ THỐNG QUẢN LÍ THPT TUẤN KIỆT";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::QLTHPT_KTPMUD_2022._2.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(354, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 97);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Incorrect
            // 
            this.Incorrect.AutoSize = true;
            this.Incorrect.Location = new System.Drawing.Point(382, 228);
            this.Incorrect.Name = "Incorrect";
            this.Incorrect.Size = new System.Drawing.Size(0, 13);
            this.Incorrect.TabIndex = 7;
            this.Incorrect.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // cBPass
            // 
            this.cBPass.AutoSize = true;
            this.cBPass.Location = new System.Drawing.Point(485, 207);
            this.cBPass.Name = "cBPass";
            this.cBPass.Size = new System.Drawing.Size(95, 17);
            this.cBPass.TabIndex = 8;
            this.cBPass.Text = "Hiển mật khẩu";
            this.cBPass.UseVisualStyleBackColor = true;
            this.cBPass.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // signIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::QLTHPT_KTPMUD_2022._2.Properties.Resources.background_school;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cBPass);
            this.Controls.Add(this.Incorrect);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.tBPass);
            this.Controls.Add(this.tBUserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "signIn";
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.signIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBUserName;
        private System.Windows.Forms.TextBox tBPass;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Incorrect;
        private System.Windows.Forms.CheckBox cBPass;
    }
}

