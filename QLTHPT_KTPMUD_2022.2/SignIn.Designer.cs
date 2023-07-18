using System.Data.SqlClient;

namespace QLTHPT_KTPMUD_2022._2
{
    partial class signIn
    {
        MainPage mainpage; //Tạo 1 đối tượng và 1 
        //Tao 1 chuoi ket noi SQL server
        string strConnection = "Data Source=DESKTOP-2D0LUGD;Initial Catalog=qlthpt;Integrated Security=True";
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
            this.logo = new System.Windows.Forms.PictureBox();
            this.Incorrect = new System.Windows.Forms.Label();
            this.cBPass = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // tBUserName
            // 
            this.tBUserName.Location = new System.Drawing.Point(356, 188);
            this.tBUserName.Name = "tBUserName";
            this.tBUserName.Size = new System.Drawing.Size(134, 20);
            this.tBUserName.TabIndex = 0;
            this.tBUserName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tBPass
            // 
            this.tBPass.Location = new System.Drawing.Point(356, 234);
            this.tBPass.Name = "tBPass";
            this.tBPass.Size = new System.Drawing.Size(134, 20);
            this.tBPass.TabIndex = 1;
            this.tBPass.UseSystemPasswordChar = true;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.BackColor = System.Drawing.Color.Silver;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(289, 191);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(55, 13);
            this.labelUserName.TabIndex = 2;
            this.labelUserName.Text = "Tài khoản";
            this.labelUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelUserName.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.BackColor = System.Drawing.Color.Silver;
            this.labelPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPass.Location = new System.Drawing.Point(289, 240);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(52, 13);
            this.labelPass.TabIndex = 3;
            this.labelPass.Text = "Mật khẩu";
            this.labelPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPass.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(384, 273);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(75, 23);
            this.btnSignIn.TabIndex = 4;
            this.btnSignIn.Text = "Đăng nhập";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.button1_Click);
            // 
            // logo
            // 
            this.logo.BackgroundImage = global::QLTHPT_KTPMUD_2022._2.Properties.Resources.logo;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("logo.InitialImage")));
            this.logo.Location = new System.Drawing.Point(341, 64);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(149, 118);
            this.logo.TabIndex = 6;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.signIn_Resize);
            this.logo.Resize += new System.EventHandler(this.signIn_Resize);
            // 
            // Incorrect
            // 
            this.Incorrect.AutoSize = true;
            this.Incorrect.Location = new System.Drawing.Point(353, 257);
            this.Incorrect.Name = "Incorrect";
            this.Incorrect.Size = new System.Drawing.Size(0, 13);
            this.Incorrect.TabIndex = 7;
            this.Incorrect.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // cBPass
            // 
            this.cBPass.AutoSize = true;
            this.cBPass.Location = new System.Drawing.Point(496, 236);
            this.cBPass.Name = "cBPass";
            this.cBPass.Size = new System.Drawing.Size(95, 17);
            this.cBPass.TabIndex = 8;
            this.cBPass.Text = "Hiển mật khẩu";
            this.cBPass.UseVisualStyleBackColor = true;
            this.cBPass.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(154, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(556, 55);
            this.label2.TabIndex = 10;
            this.label2.Text = "QUẢN LÝ THPT TUẤN KIỆT";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // signIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::QLTHPT_KTPMUD_2022._2.Properties.Resources.background_school;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cBPass);
            this.Controls.Add(this.Incorrect);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.tBPass);
            this.Controls.Add(this.tBUserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "signIn";
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.signIn_Load);
            this.Resize += new System.EventHandler(this.signIn_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBUserName;
        private System.Windows.Forms.TextBox tBPass;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label Incorrect;
        private System.Windows.Forms.CheckBox cBPass;
        private System.Windows.Forms.Label label2;
    }
}

