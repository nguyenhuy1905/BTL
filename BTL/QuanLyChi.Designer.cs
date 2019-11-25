namespace BTL
{
    partial class QuanLyChi
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.txtChiTiet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.comboLoaiKhoanChi = new System.Windows.Forms.ComboBox();
            this.lOAIKHOANCHIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLTHUCHIDataSet1 = new BTL.QLTHUCHIDataSet1();
            this.lOAIKHOANCHITableAdapter = new BTL.QLTHUCHIDataSet1TableAdapters.LOAIKHOANCHITableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lbltong = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIKHOANCHIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTHUCHIDataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số tiền";
            // 
            // txtSoTien
            // 
            this.txtSoTien.Location = new System.Drawing.Point(141, 88);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(169, 22);
            this.txtSoTien.TabIndex = 1;
            // 
            // txtChiTiet
            // 
            this.txtChiTiet.Location = new System.Drawing.Point(141, 169);
            this.txtChiTiet.Multiline = true;
            this.txtChiTiet.Name = "txtChiTiet";
            this.txtChiTiet.Size = new System.Drawing.Size(169, 49);
            this.txtChiTiet.TabIndex = 3;
            this.txtChiTiet.Text = "Chi tiết...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chi Tiết";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Loại khoản chi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.id});
            this.dataGridView1.Location = new System.Drawing.Point(12, 240);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(862, 247);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cell_click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Số tiền";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ngày";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Chi tiết";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Loại khoản chi";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Người thêm";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(345, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Quản Lý Chi";
            // 
            // comboLoaiKhoanChi
            // 
            this.comboLoaiKhoanChi.DataSource = this.lOAIKHOANCHIBindingSource;
            this.comboLoaiKhoanChi.DisplayMember = "tenkhoanchi";
            this.comboLoaiKhoanChi.FormattingEnabled = true;
            this.comboLoaiKhoanChi.Location = new System.Drawing.Point(141, 132);
            this.comboLoaiKhoanChi.Name = "comboLoaiKhoanChi";
            this.comboLoaiKhoanChi.Size = new System.Drawing.Size(169, 24);
            this.comboLoaiKhoanChi.TabIndex = 8;
            this.comboLoaiKhoanChi.ValueMember = "ID";
            // 
            // lOAIKHOANCHIBindingSource
            // 
            this.lOAIKHOANCHIBindingSource.DataMember = "LOAIKHOANCHI";
            this.lOAIKHOANCHIBindingSource.DataSource = this.qLTHUCHIDataSet1;
            // 
            // qLTHUCHIDataSet1
            // 
            this.qLTHUCHIDataSet1.DataSetName = "QLTHUCHIDataSet1";
            this.qLTHUCHIDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOAIKHOANCHITableAdapter
            // 
            this.lOAIKHOANCHITableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(333, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 38);
            this.button1.TabIndex = 9;
            this.button1.Text = "Thêm Khoản Chi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(333, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 33);
            this.button2.TabIndex = 10;
            this.button2.Text = "Cập nhật";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.lbltong);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.endDate);
            this.groupBox1.Controls.Add(this.startDate);
            this.groupBox1.Location = new System.Drawing.Point(515, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 112);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lọc theo ngày";
            // 
            // startDate
            // 
            this.startDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDate.Location = new System.Drawing.Point(11, 49);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(93, 22);
            this.startDate.TabIndex = 0;
            this.startDate.Value = new System.DateTime(2019, 11, 25, 9, 58, 12, 0);
            // 
            // endDate
            // 
            this.endDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDate.Location = new System.Drawing.Point(110, 49);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(93, 22);
            this.endDate.TabIndex = 1;
            this.endDate.Value = new System.DateTime(2019, 11, 25, 9, 58, 20, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Từ ngày";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(107, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Đến";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(227, 47);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 27);
            this.button3.TabIndex = 4;
            this.button3.Text = "Lọc";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Tổng chi :";
            // 
            // lbltong
            // 
            this.lbltong.AutoSize = true;
            this.lbltong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltong.Location = new System.Drawing.Point(87, 83);
            this.lbltong.Name = "lbltong";
            this.lbltong.Size = new System.Drawing.Size(17, 17);
            this.lbltong.TabIndex = 6;
            this.lbltong.Text = "0";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(283, 47);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 27);
            this.button4.TabIndex = 7;
            this.button4.Text = "Bỏ lọc";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(333, 172);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(132, 30);
            this.button5.TabIndex = 12;
            this.button5.Text = "Xóa";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // QuanLyChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 499);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboLoaiKhoanChi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtChiTiet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSoTien);
            this.Controls.Add(this.label1);
            this.Name = "QuanLyChi";
            this.Text = "QuanLyChi";
            this.Load += new System.EventHandler(this.QuanLyChi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIKHOANCHIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTHUCHIDataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoTien;
        private System.Windows.Forms.TextBox txtChiTiet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboLoaiKhoanChi;
        private QLTHUCHIDataSet1 qLTHUCHIDataSet1;
        private System.Windows.Forms.BindingSource lOAIKHOANCHIBindingSource;
        private QLTHUCHIDataSet1TableAdapters.LOAIKHOANCHITableAdapter lOAIKHOANCHITableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.Label lbltong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}