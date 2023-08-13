namespace QLTHPT_KTPMUD_2022._2
{
    partial class QLTK
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
            this.tBmaTK = new System.Windows.Forms.TextBox();
            this.tBID = new System.Windows.Forms.TextBox();
            this.tBmaQL = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.tBFind = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvTK = new System.Windows.Forms.DataGridView();
            this.btnDelTK = new System.Windows.Forms.Button();
            this.btnFindTK = new System.Windows.Forms.Button();
            this.btnFixTK = new System.Windows.Forms.Button();
            this.btnAddTK = new System.Windows.Forms.Button();
            this.tBpass = new System.Windows.Forms.TextBox();
            this.tBTenND = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tBName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTK)).BeginInit();
            this.SuspendLayout();
            // 
            // tBmaTK
            // 
            this.tBmaTK.Location = new System.Drawing.Point(223, 143);
            this.tBmaTK.Margin = new System.Windows.Forms.Padding(4);
            this.tBmaTK.Name = "tBmaTK";
            this.tBmaTK.Size = new System.Drawing.Size(283, 22);
            this.tBmaTK.TabIndex = 165;
            // 
            // tBID
            // 
            this.tBID.Location = new System.Drawing.Point(223, 113);
            this.tBID.Margin = new System.Windows.Forms.Padding(4);
            this.tBID.Name = "tBID";
            this.tBID.Size = new System.Drawing.Size(283, 22);
            this.tBID.TabIndex = 164;
            this.tBID.TextChanged += new System.EventHandler(this.tBDiem1Tiet_TextChanged);
            // 
            // tBmaQL
            // 
            this.tBmaQL.Location = new System.Drawing.Point(223, 237);
            this.tBmaQL.Margin = new System.Windows.Forms.Padding(4);
            this.tBmaQL.Name = "tBmaQL";
            this.tBmaQL.Size = new System.Drawing.Size(283, 22);
            this.tBmaQL.TabIndex = 163;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(15, 14);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 48);
            this.btnBack.TabIndex = 159;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // tBFind
            // 
            this.tBFind.Location = new System.Drawing.Point(166, 27);
            this.tBFind.Margin = new System.Windows.Forms.Padding(4);
            this.tBFind.Name = "tBFind";
            this.tBFind.Size = new System.Drawing.Size(815, 22);
            this.tBFind.TabIndex = 158;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 240);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 155;
            this.label5.Text = "Mã quản lý";
            // 
            // dgvTK
            // 
            this.dgvTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTK.Location = new System.Drawing.Point(117, 338);
            this.dgvTK.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTK.Name = "dgvTK";
            this.dgvTK.RowHeadersWidth = 51;
            this.dgvTK.Size = new System.Drawing.Size(957, 296);
            this.dgvTK.TabIndex = 153;
            this.dgvTK.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTK_RowHeaderMouseClick);
            // 
            // btnDelTK
            // 
            this.btnDelTK.AutoSize = true;
            this.btnDelTK.Location = new System.Drawing.Point(798, 261);
            this.btnDelTK.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelTK.Name = "btnDelTK";
            this.btnDelTK.Size = new System.Drawing.Size(195, 60);
            this.btnDelTK.TabIndex = 152;
            this.btnDelTK.Text = "Xóa tài khoản";
            this.btnDelTK.UseVisualStyleBackColor = true;
            this.btnDelTK.Click += new System.EventHandler(this.btnDelTK_Click);
            // 
            // btnFindTK
            // 
            this.btnFindTK.AutoSize = true;
            this.btnFindTK.Location = new System.Drawing.Point(1002, 17);
            this.btnFindTK.Margin = new System.Windows.Forms.Padding(4);
            this.btnFindTK.Name = "btnFindTK";
            this.btnFindTK.Size = new System.Drawing.Size(121, 43);
            this.btnFindTK.TabIndex = 151;
            this.btnFindTK.Text = "Tìm kiếm";
            this.btnFindTK.UseVisualStyleBackColor = true;
            this.btnFindTK.Click += new System.EventHandler(this.btnFindTK_Click);
            // 
            // btnFixTK
            // 
            this.btnFixTK.AutoSize = true;
            this.btnFixTK.Location = new System.Drawing.Point(798, 175);
            this.btnFixTK.Margin = new System.Windows.Forms.Padding(4);
            this.btnFixTK.Name = "btnFixTK";
            this.btnFixTK.Size = new System.Drawing.Size(195, 60);
            this.btnFixTK.TabIndex = 150;
            this.btnFixTK.Text = "Sửa thông tin";
            this.btnFixTK.UseVisualStyleBackColor = true;
            this.btnFixTK.Click += new System.EventHandler(this.btnFixTK_Click);
            // 
            // btnAddTK
            // 
            this.btnAddTK.AutoSize = true;
            this.btnAddTK.Location = new System.Drawing.Point(798, 91);
            this.btnAddTK.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddTK.Name = "btnAddTK";
            this.btnAddTK.Size = new System.Drawing.Size(195, 60);
            this.btnAddTK.TabIndex = 149;
            this.btnAddTK.Text = "Tạo mới";
            this.btnAddTK.UseVisualStyleBackColor = true;
            this.btnAddTK.Click += new System.EventHandler(this.btnAddTK_Click);
            // 
            // tBpass
            // 
            this.tBpass.Location = new System.Drawing.Point(223, 207);
            this.tBpass.Margin = new System.Windows.Forms.Padding(4);
            this.tBpass.Name = "tBpass";
            this.tBpass.Size = new System.Drawing.Size(283, 22);
            this.tBpass.TabIndex = 146;
            // 
            // tBTenND
            // 
            this.tBTenND.Location = new System.Drawing.Point(223, 175);
            this.tBTenND.Margin = new System.Windows.Forms.Padding(4);
            this.tBTenND.Name = "tBTenND";
            this.tBTenND.Size = new System.Drawing.Size(283, 22);
            this.tBTenND.TabIndex = 145;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 211);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 144;
            this.label4.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 178);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 143;
            this.label3.Text = "Tên người dùng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 142;
            this.label2.Text = "Mã tài khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 141;
            this.label1.Text = "Mã ID";
            this.label1.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(115, 267);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 166;
            this.label6.Text = "Họ và tên";
            // 
            // tBName
            // 
            this.tBName.Location = new System.Drawing.Point(223, 267);
            this.tBName.Margin = new System.Windows.Forms.Padding(4);
            this.tBName.Name = "tBName";
            this.tBName.Size = new System.Drawing.Size(283, 22);
            this.tBName.TabIndex = 167;
            // 
            // QLTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 647);
            this.Controls.Add(this.tBName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tBmaTK);
            this.Controls.Add(this.tBID);
            this.Controls.Add(this.tBmaQL);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tBFind);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvTK);
            this.Controls.Add(this.btnDelTK);
            this.Controls.Add(this.btnFindTK);
            this.Controls.Add(this.btnFixTK);
            this.Controls.Add(this.btnAddTK);
            this.Controls.Add(this.tBpass);
            this.Controls.Add(this.tBTenND);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "QLTK";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.QLTK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tBmaTK;
        private System.Windows.Forms.TextBox tBID;
        private System.Windows.Forms.TextBox tBmaQL;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox tBFind;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvTK;
        private System.Windows.Forms.Button btnDelTK;
        private System.Windows.Forms.Button btnFindTK;
        private System.Windows.Forms.Button btnFixTK;
        private System.Windows.Forms.Button btnAddTK;
        private System.Windows.Forms.TextBox tBpass;
        private System.Windows.Forms.TextBox tBTenND;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tBName;
    }
}