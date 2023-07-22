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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maMHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenMHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLTHPT_20222DataSet = new QLTHPT_KTPMUD_2022._2.QLTHPT_20222DataSet();
            this.Back = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.tBFind = new System.Windows.Forms.TextBox();
            this.Find = new System.Windows.Forms.Button();
            this.tBName = new System.Windows.Forms.TextBox();
            this.tBID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mHTableAdapter = new QLTHPT_KTPMUD_2022._2.QLTHPT_20222DataSetTableAdapters.MHTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTHPT_20222DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maMHDataGridViewTextBoxColumn,
            this.tenMHDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mHBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(256, 232);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(602, 341);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // maMHDataGridViewTextBoxColumn
            // 
            this.maMHDataGridViewTextBoxColumn.DataPropertyName = "MaMH";
            this.maMHDataGridViewTextBoxColumn.HeaderText = "MaMH";
            this.maMHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maMHDataGridViewTextBoxColumn.Name = "maMHDataGridViewTextBoxColumn";
            this.maMHDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenMHDataGridViewTextBoxColumn
            // 
            this.tenMHDataGridViewTextBoxColumn.DataPropertyName = "TenMH";
            this.tenMHDataGridViewTextBoxColumn.HeaderText = "TenMH";
            this.tenMHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenMHDataGridViewTextBoxColumn.Name = "tenMHDataGridViewTextBoxColumn";
            this.tenMHDataGridViewTextBoxColumn.Width = 125;
            // 
            // mHBindingSource
            // 
            this.mHBindingSource.DataMember = "MH";
            this.mHBindingSource.DataSource = this.qLTHPT_20222DataSet;
            // 
            // qLTHPT_20222DataSet
            // 
            this.qLTHPT_20222DataSet.DataSetName = "QLTHPT_20222DataSet";
            this.qLTHPT_20222DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(12, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(108, 42);
            this.Back.TabIndex = 1;
            this.Back.Text = "Quay lại";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(882, 68);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(115, 43);
            this.Add.TabIndex = 2;
            this.Add.Text = "Thêm";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(882, 126);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(115, 43);
            this.Update.TabIndex = 3;
            this.Update.Text = "Sửa";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(882, 189);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(115, 43);
            this.Delete.TabIndex = 4;
            this.Delete.Text = "Xoá";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // tBFind
            // 
            this.tBFind.Location = new System.Drawing.Point(256, 21);
            this.tBFind.Name = "tBFind";
            this.tBFind.Size = new System.Drawing.Size(602, 22);
            this.tBFind.TabIndex = 5;
            this.tBFind.TextChanged += new System.EventHandler(this.tBFind_TextChanged);
            // 
            // Find
            // 
            this.Find.Location = new System.Drawing.Point(882, 12);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(115, 43);
            this.Find.TabIndex = 6;
            this.Find.Text = "Tìm kiếm";
            this.Find.UseVisualStyleBackColor = true;
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // tBName
            // 
            this.tBName.Location = new System.Drawing.Point(256, 89);
            this.tBName.Name = "tBName";
            this.tBName.Size = new System.Drawing.Size(602, 22);
            this.tBName.TabIndex = 7;
            // 
            // tBID
            // 
            this.tBID.Location = new System.Drawing.Point(256, 163);
            this.tBID.Name = "tBID";
            this.tBID.Size = new System.Drawing.Size(602, 22);
            this.tBID.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tên Môn học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(136, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mã Môn học";
            // 
            // mHTableAdapter
            // 
            this.mHTableAdapter.ClearBeforeFill = true;
            // 
            // QLMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 612);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBID);
            this.Controls.Add(this.tBName);
            this.Controls.Add(this.Find);
            this.Controls.Add(this.tBFind);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.dataGridView1);
            this.Name = "QLMH";
            this.Text = "QLMH";
            this.Load += new System.EventHandler(this.QLMH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTHPT_20222DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TextBox tBFind;
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.TextBox tBName;
        private System.Windows.Forms.TextBox tBID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private QLTHPT_20222DataSet qLTHPT_20222DataSet;
        private System.Windows.Forms.BindingSource mHBindingSource;
        private QLTHPT_20222DataSetTableAdapters.MHTableAdapter mHTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maMHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenMHDataGridViewTextBoxColumn;
    }
}