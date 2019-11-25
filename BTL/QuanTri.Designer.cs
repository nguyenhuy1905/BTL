namespace BTL
{
    partial class QuanTri
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
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýThuChiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýKhoảnThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýKhoảnChiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lớpHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýLớpHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýHọcSinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doiMK1 = new BTL.DoiMK();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýTàiKhoảnToolStripMenuItem,
            this.đổiMậtKhẩuToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            // 
            // quảnLýTàiKhoảnToolStripMenuItem
            // 
            this.quảnLýTàiKhoảnToolStripMenuItem.Name = "quảnLýTàiKhoảnToolStripMenuItem";
            this.quảnLýTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.quảnLýTàiKhoảnToolStripMenuItem.Text = "Quản lý tài khoản";
            this.quảnLýTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.QuảnLýTàiKhoảnToolStripMenuItem_Click);
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            this.đổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.ĐổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.ĐăngXuấtToolStripMenuItem_Click);
            // 
            // quảnLýThuChiToolStripMenuItem
            // 
            this.quảnLýThuChiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýKhoảnThuToolStripMenuItem,
            this.quảnLýKhoảnChiToolStripMenuItem});
            this.quảnLýThuChiToolStripMenuItem.Name = "quảnLýThuChiToolStripMenuItem";
            this.quảnLýThuChiToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.quảnLýThuChiToolStripMenuItem.Text = "Quản lý thu chi";
            this.quảnLýThuChiToolStripMenuItem.Click += new System.EventHandler(this.QuảnLýThuChiToolStripMenuItem_Click);
            // 
            // quảnLýKhoảnThuToolStripMenuItem
            // 
            this.quảnLýKhoảnThuToolStripMenuItem.Name = "quảnLýKhoảnThuToolStripMenuItem";
            this.quảnLýKhoảnThuToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.quảnLýKhoảnThuToolStripMenuItem.Text = "Quản lý khoản thu";
            this.quảnLýKhoảnThuToolStripMenuItem.Click += new System.EventHandler(this.QuảnLýKhoảnThuToolStripMenuItem_Click);
            // 
            // quảnLýKhoảnChiToolStripMenuItem
            // 
            this.quảnLýKhoảnChiToolStripMenuItem.Name = "quảnLýKhoảnChiToolStripMenuItem";
            this.quảnLýKhoảnChiToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.quảnLýKhoảnChiToolStripMenuItem.Text = "Quản lý khoản chi";
            this.quảnLýKhoảnChiToolStripMenuItem.Click += new System.EventHandler(this.quảnLýKhoảnChiToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tàiKhoảnToolStripMenuItem,
            this.quảnLýThuChiToolStripMenuItem,
            this.lớpHọcToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(798, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lớpHọcToolStripMenuItem
            // 
            this.lớpHọcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýLớpHọcToolStripMenuItem,
            this.quảnLýHọcSinhToolStripMenuItem});
            this.lớpHọcToolStripMenuItem.Name = "lớpHọcToolStripMenuItem";
            this.lớpHọcToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.lớpHọcToolStripMenuItem.Text = "Lớp học";
            // 
            // quảnLýLớpHọcToolStripMenuItem
            // 
            this.quảnLýLớpHọcToolStripMenuItem.Name = "quảnLýLớpHọcToolStripMenuItem";
            this.quảnLýLớpHọcToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.quảnLýLớpHọcToolStripMenuItem.Text = "Quản lý lớp học";
            this.quảnLýLớpHọcToolStripMenuItem.Click += new System.EventHandler(this.QuảnLýLớpHọcToolStripMenuItem_Click);
            // 
            // quảnLýHọcSinhToolStripMenuItem
            // 
            this.quảnLýHọcSinhToolStripMenuItem.Name = "quảnLýHọcSinhToolStripMenuItem";
            this.quảnLýHọcSinhToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.quảnLýHọcSinhToolStripMenuItem.Text = "Quản lý học sinh";
            this.quảnLýHọcSinhToolStripMenuItem.Click += new System.EventHandler(this.QuảnLýHọcSinhToolStripMenuItem_Click);
            // 
            // doiMK1
            // 
            this.doiMK1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.doiMK1.Location = new System.Drawing.Point(256, 108);
            this.doiMK1.Margin = new System.Windows.Forms.Padding(5);
            this.doiMK1.Name = "doiMK1";
            this.doiMK1.Size = new System.Drawing.Size(312, 240);
            this.doiMK1.TabIndex = 1;
            this.doiMK1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(147, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 53);
            this.label1.TabIndex = 2;
            this.label1.Text = "Phầm mềm quản lý thu chi";
            // 
            // QuanTri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BTL.Properties.Resources.nền_btl;
            this.ClientSize = new System.Drawing.Size(798, 449);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.doiMK1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuanTri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanTri";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Closed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýThuChiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýKhoảnThuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýKhoảnChiToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lớpHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýLớpHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýHọcSinhToolStripMenuItem;
        private DoiMK doiMK1;
        private System.Windows.Forms.Label label1;
    }
}