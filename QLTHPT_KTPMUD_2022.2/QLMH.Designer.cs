namespace QLTHPT_KTPMUD_2022._2
{
    partial class QLMH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLMH));
            this.dgvMH = new System.Windows.Forms.DataGridView();
            this.Back = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tBFind = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.tBName = new System.Windows.Forms.TextBox();
            this.tBID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMH)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMH
            // 
            this.dgvMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMH.Location = new System.Drawing.Point(192, 188);
            this.dgvMH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvMH.Name = "dgvMH";
            this.dgvMH.RowHeadersWidth = 51;
            this.dgvMH.RowTemplate.Height = 24;
            this.dgvMH.Size = new System.Drawing.Size(452, 277);
            this.dgvMH.TabIndex = 0;
            this.dgvMH.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMH_RowHeaderMouseClick);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(9, 10);
            this.Back.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(81, 34);
            this.Back.TabIndex = 1;
            this.Back.Text = "Quay lại";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(662, 55);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 35);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.Add_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(662, 102);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(86, 35);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.Update_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(662, 154);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 35);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // tBFind
            // 
            this.tBFind.Location = new System.Drawing.Point(192, 17);
            this.tBFind.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tBFind.Name = "tBFind";
            this.tBFind.Size = new System.Drawing.Size(452, 20);
            this.tBFind.TabIndex = 5;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(662, 10);
            this.btnFind.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(86, 35);
            this.btnFind.TabIndex = 6;
            this.btnFind.Text = "Tìm kiếm";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.Find_Click);
            // 
            // tBName
            // 
            this.tBName.Location = new System.Drawing.Point(192, 72);
            this.tBName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tBName.Name = "tBName";
            this.tBName.Size = new System.Drawing.Size(452, 20);
            this.tBName.TabIndex = 7;
            // 
            // tBID
            // 
            this.tBID.Location = new System.Drawing.Point(192, 132);
            this.tBID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tBID.Name = "tBID";
            this.tBID.Size = new System.Drawing.Size(452, 20);
            this.tBID.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tên Môn học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mã Môn học";
            // 
            // QLMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 497);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBID);
            this.Controls.Add(this.tBName);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.tBFind);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.dgvMH);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "QLMH";
            this.Text = "Quản lý Môn học ";
            this.Load += new System.EventHandler(this.QLMH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMH;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tBFind;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox tBName;
        private System.Windows.Forms.TextBox tBID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn maMHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenMHDataGridViewTextBoxColumn;
    }
}