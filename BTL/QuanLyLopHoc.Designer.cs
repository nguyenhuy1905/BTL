namespace BTL
{
    partial class QuanLyLopHoc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbxNamHoc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grdLop = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdLop)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxNamHoc
            // 
            this.cbxNamHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNamHoc.FormattingEnabled = true;
            this.cbxNamHoc.Items.AddRange(new object[] {
            "2019-2020",
            "2018-2019"});
            this.cbxNamHoc.Location = new System.Drawing.Point(58, 138);
            this.cbxNamHoc.Name = "cbxNamHoc";
            this.cbxNamHoc.Size = new System.Drawing.Size(121, 21);
            this.cbxNamHoc.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Năm học";
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(58, 103);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(121, 20);
            this.txtTenLop.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tên lớp";
            // 
            // grdLop
            // 
            this.grdLop.AllowUserToAddRows = false;
            this.grdLop.AllowUserToResizeColumns = false;
            this.grdLop.AllowUserToResizeRows = false;
            this.grdLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.siso,
            this.chon,
            this.id});
            this.grdLop.Location = new System.Drawing.Point(213, 94);
            this.grdLop.Name = "grdLop";
            this.grdLop.Size = new System.Drawing.Size(346, 216);
            this.grdLop.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tên lớp";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Năm học";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // siso
            // 
            this.siso.HeaderText = "Sĩ số";
            this.siso.Name = "siso";
            this.siso.ReadOnly = true;
            this.siso.Width = 50;
            // 
            // chon
            // 
            this.chon.HeaderText = "Chọn";
            this.chon.Name = "chon";
            this.chon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.chon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.chon.Width = 50;
            // 
            // id
            // 
            this.id.HeaderText = "Column3";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(58, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(518, 349);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(8, 8);
            this.button3.TabIndex = 17;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // QuanLyLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 365);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbxNamHoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenLop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdLop);
            this.Name = "QuanLyLopHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.QuanLyLopHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxNamHoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdLop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn siso;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chon;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
    }
}
