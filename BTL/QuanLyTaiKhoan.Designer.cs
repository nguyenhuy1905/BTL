namespace BTL
{
    partial class QuanLyTaiKhoan
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
            this.grdTK = new System.Windows.Forms.DataGridView();
            this.chon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admin = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdTK)).BeginInit();
            this.SuspendLayout();
            // 
            // grdTK
            // 
            this.grdTK.AllowUserToAddRows = false;
            this.grdTK.AllowUserToResizeColumns = false;
            this.grdTK.AllowUserToResizeRows = false;
            this.grdTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chon,
            this.Column1,
            this.admin});
            this.grdTK.Location = new System.Drawing.Point(250, 111);
            this.grdTK.Name = "grdTK";
            this.grdTK.Size = new System.Drawing.Size(296, 216);
            this.grdTK.TabIndex = 11;
            // 
            // chon
            // 
            this.chon.HeaderText = "Chọn";
            this.chon.Name = "chon";
            this.chon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.chon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.chon.Width = 50;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tên tài khoản";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // admin
            // 
            this.admin.HeaderText = "Quản trị viên";
            this.admin.Name = "admin";
            this.admin.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Thêm tài khoản";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(66, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // QuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 395);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grdTK);
            this.Name = "QuanLyTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.QuanLyTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdTK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdTK;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn admin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
