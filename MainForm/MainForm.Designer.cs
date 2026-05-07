namespace MainForm
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btn_phuCap = new System.Windows.Forms.Button();
            this.btn_phongBan = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_NhanVien = new System.Windows.Forms.Button();
            this.btn_DuyetDon = new System.Windows.Forms.Button();
            this.btn_TinhLuong = new System.Windows.Forms.Button();
            this.btn_ThongKe = new System.Windows.Forms.Button();
            this.btn_GanPhuCap = new System.Windows.Forms.Button();
            this.btn_HopDong = new System.Windows.Forms.Button();
            this.btn_XinNghi = new System.Windows.Forms.Button();
            this.btn_XemLuong = new System.Windows.Forms.Button();
            this.btn_ThongTin = new System.Windows.Forms.Button();
            this.btn_Backup = new System.Windows.Forms.Button();
            this.btn_Restore = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.btn_ChucVu = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_phuCap
            // 
            this.btn_phuCap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_phuCap.FlatAppearance.BorderSize = 0;
            this.btn_phuCap.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_phuCap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_phuCap.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_phuCap.Image = ((System.Drawing.Image)(resources.GetObject("btn_phuCap.Image")));
            this.btn_phuCap.Location = new System.Drawing.Point(609, 3);
            this.btn_phuCap.Name = "btn_phuCap";
            this.btn_phuCap.Size = new System.Drawing.Size(94, 63);
            this.btn_phuCap.TabIndex = 1;
            this.btn_phuCap.Text = "Phụ Cấp";
            this.btn_phuCap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_phuCap.UseVisualStyleBackColor = false;
            this.btn_phuCap.Click += new System.EventHandler(this.btn_phuCap_Click);
            // 
            // btn_phongBan
            // 
            this.btn_phongBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_phongBan.FlatAppearance.BorderSize = 0;
            this.btn_phongBan.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_phongBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_phongBan.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_phongBan.Image = ((System.Drawing.Image)(resources.GetObject("btn_phongBan.Image")));
            this.btn_phongBan.Location = new System.Drawing.Point(809, 3);
            this.btn_phongBan.Name = "btn_phongBan";
            this.btn_phongBan.Size = new System.Drawing.Size(94, 66);
            this.btn_phongBan.TabIndex = 0;
            this.btn_phongBan.Text = " Phòng ban";
            this.btn_phongBan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_phongBan.UseVisualStyleBackColor = false;
            this.btn_phongBan.Click += new System.EventHandler(this.btn_phongBan_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.flowLayoutPanel1.Controls.Add(this.btn_NhanVien);
            this.flowLayoutPanel1.Controls.Add(this.btn_DuyetDon);
            this.flowLayoutPanel1.Controls.Add(this.btn_TinhLuong);
            this.flowLayoutPanel1.Controls.Add(this.btn_ThongKe);
            this.flowLayoutPanel1.Controls.Add(this.btn_HopDong);
            this.flowLayoutPanel1.Controls.Add(this.btn_GanPhuCap);
            this.flowLayoutPanel1.Controls.Add(this.btn_phuCap);
            this.flowLayoutPanel1.Controls.Add(this.btn_ChucVu);
            this.flowLayoutPanel1.Controls.Add(this.btn_phongBan);
            this.flowLayoutPanel1.Controls.Add(this.btn_XinNghi);
            this.flowLayoutPanel1.Controls.Add(this.btn_XemLuong);
            this.flowLayoutPanel1.Controls.Add(this.btn_ThongTin);
            this.flowLayoutPanel1.Controls.Add(this.btn_Backup);
            this.flowLayoutPanel1.Controls.Add(this.btn_Restore);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1408, 68);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // btn_NhanVien
            // 
            this.btn_NhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_NhanVien.FlatAppearance.BorderSize = 0;
            this.btn_NhanVien.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_NhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NhanVien.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NhanVien.Image = ((System.Drawing.Image)(resources.GetObject("btn_NhanVien.Image")));
            this.btn_NhanVien.Location = new System.Drawing.Point(3, 3);
            this.btn_NhanVien.Name = "btn_NhanVien";
            this.btn_NhanVien.Size = new System.Drawing.Size(94, 63);
            this.btn_NhanVien.TabIndex = 2;
            this.btn_NhanVien.Text = "Nhân viên";
            this.btn_NhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_NhanVien.UseVisualStyleBackColor = false;
            this.btn_NhanVien.Click += new System.EventHandler(this.btn_NhanVien_Click);
            // 
            // btn_DuyetDon
            // 
            this.btn_DuyetDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_DuyetDon.FlatAppearance.BorderSize = 0;
            this.btn_DuyetDon.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_DuyetDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DuyetDon.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DuyetDon.Image = ((System.Drawing.Image)(resources.GetObject("btn_DuyetDon.Image")));
            this.btn_DuyetDon.Location = new System.Drawing.Point(103, 3);
            this.btn_DuyetDon.Name = "btn_DuyetDon";
            this.btn_DuyetDon.Size = new System.Drawing.Size(94, 63);
            this.btn_DuyetDon.TabIndex = 4;
            this.btn_DuyetDon.Text = "Duyệt đơn";
            this.btn_DuyetDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_DuyetDon.UseVisualStyleBackColor = false;
            this.btn_DuyetDon.Click += new System.EventHandler(this.btn_DuyetDon_Click);
            // 
            // btn_TinhLuong
            // 
            this.btn_TinhLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_TinhLuong.FlatAppearance.BorderSize = 0;
            this.btn_TinhLuong.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_TinhLuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TinhLuong.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TinhLuong.Image = ((System.Drawing.Image)(resources.GetObject("btn_TinhLuong.Image")));
            this.btn_TinhLuong.Location = new System.Drawing.Point(203, 3);
            this.btn_TinhLuong.Name = "btn_TinhLuong";
            this.btn_TinhLuong.Size = new System.Drawing.Size(94, 63);
            this.btn_TinhLuong.TabIndex = 5;
            this.btn_TinhLuong.Text = "Tính lương";
            this.btn_TinhLuong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_TinhLuong.UseVisualStyleBackColor = false;
            this.btn_TinhLuong.Click += new System.EventHandler(this.btn_TinhLuong_Click);
            // 
            // btn_ThongKe
            // 
            this.btn_ThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_ThongKe.FlatAppearance.BorderSize = 0;
            this.btn_ThongKe.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_ThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThongKe.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThongKe.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThongKe.Image")));
            this.btn_ThongKe.Location = new System.Drawing.Point(303, 3);
            this.btn_ThongKe.Name = "btn_ThongKe";
            this.btn_ThongKe.Size = new System.Drawing.Size(94, 63);
            this.btn_ThongKe.TabIndex = 12;
            this.btn_ThongKe.Text = "Thống kê";
            this.btn_ThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_ThongKe.UseVisualStyleBackColor = false;
            this.btn_ThongKe.Click += new System.EventHandler(this.btn_ThongKe_Click);
            // 
            // btn_GanPhuCap
            // 
            this.btn_GanPhuCap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_GanPhuCap.FlatAppearance.BorderSize = 0;
            this.btn_GanPhuCap.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_GanPhuCap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GanPhuCap.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GanPhuCap.Image = ((System.Drawing.Image)(resources.GetObject("btn_GanPhuCap.Image")));
            this.btn_GanPhuCap.Location = new System.Drawing.Point(503, 3);
            this.btn_GanPhuCap.Name = "btn_GanPhuCap";
            this.btn_GanPhuCap.Size = new System.Drawing.Size(100, 66);
            this.btn_GanPhuCap.TabIndex = 6;
            this.btn_GanPhuCap.Text = "Gán phụ cấp";
            this.btn_GanPhuCap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_GanPhuCap.UseVisualStyleBackColor = false;
            this.btn_GanPhuCap.Click += new System.EventHandler(this.btn_GanPhuCap_Click);
            // 
            // btn_HopDong
            // 
            this.btn_HopDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_HopDong.FlatAppearance.BorderSize = 0;
            this.btn_HopDong.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_HopDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HopDong.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HopDong.Image = ((System.Drawing.Image)(resources.GetObject("btn_HopDong.Image")));
            this.btn_HopDong.Location = new System.Drawing.Point(403, 3);
            this.btn_HopDong.Name = "btn_HopDong";
            this.btn_HopDong.Size = new System.Drawing.Size(94, 63);
            this.btn_HopDong.TabIndex = 3;
            this.btn_HopDong.Text = "Hợp đồng";
            this.btn_HopDong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_HopDong.UseVisualStyleBackColor = false;
            this.btn_HopDong.Click += new System.EventHandler(this.btn_HopDong_Click);
            // 
            // btn_XinNghi
            // 
            this.btn_XinNghi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_XinNghi.FlatAppearance.BorderSize = 0;
            this.btn_XinNghi.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_XinNghi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XinNghi.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XinNghi.Image = ((System.Drawing.Image)(resources.GetObject("btn_XinNghi.Image")));
            this.btn_XinNghi.Location = new System.Drawing.Point(909, 3);
            this.btn_XinNghi.Name = "btn_XinNghi";
            this.btn_XinNghi.Size = new System.Drawing.Size(94, 63);
            this.btn_XinNghi.TabIndex = 8;
            this.btn_XinNghi.Text = "Xin nghỉ";
            this.btn_XinNghi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_XinNghi.UseVisualStyleBackColor = false;
            this.btn_XinNghi.Click += new System.EventHandler(this.btn_XinNghi_Click);
            // 
            // btn_XemLuong
            // 
            this.btn_XemLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_XemLuong.FlatAppearance.BorderSize = 0;
            this.btn_XemLuong.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_XemLuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XemLuong.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XemLuong.Image = ((System.Drawing.Image)(resources.GetObject("btn_XemLuong.Image")));
            this.btn_XemLuong.Location = new System.Drawing.Point(1009, 3);
            this.btn_XemLuong.Name = "btn_XemLuong";
            this.btn_XemLuong.Size = new System.Drawing.Size(94, 63);
            this.btn_XemLuong.TabIndex = 9;
            this.btn_XemLuong.Text = "Xem lương";
            this.btn_XemLuong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_XemLuong.UseVisualStyleBackColor = false;
            this.btn_XemLuong.Click += new System.EventHandler(this.btn_XemLuong_Click);
            // 
            // btn_ThongTin
            // 
            this.btn_ThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_ThongTin.FlatAppearance.BorderSize = 0;
            this.btn_ThongTin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_ThongTin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThongTin.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThongTin.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThongTin.Image")));
            this.btn_ThongTin.Location = new System.Drawing.Point(1109, 3);
            this.btn_ThongTin.Name = "btn_ThongTin";
            this.btn_ThongTin.Size = new System.Drawing.Size(94, 66);
            this.btn_ThongTin.TabIndex = 7;
            this.btn_ThongTin.Text = "Thông tin";
            this.btn_ThongTin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_ThongTin.UseVisualStyleBackColor = false;
            this.btn_ThongTin.Click += new System.EventHandler(this.btn_ThongTin_Click);
            // 
            // btn_Backup
            // 
            this.btn_Backup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Backup.FlatAppearance.BorderSize = 0;
            this.btn_Backup.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Backup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Backup.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Backup.Image = ((System.Drawing.Image)(resources.GetObject("btn_Backup.Image")));
            this.btn_Backup.Location = new System.Drawing.Point(1209, 3);
            this.btn_Backup.Name = "btn_Backup";
            this.btn_Backup.Size = new System.Drawing.Size(94, 63);
            this.btn_Backup.TabIndex = 10;
            this.btn_Backup.Text = "Sao lưu";
            this.btn_Backup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Backup.UseVisualStyleBackColor = false;
            this.btn_Backup.Click += new System.EventHandler(this.btn_Backup_Click);
            // 
            // btn_Restore
            // 
            this.btn_Restore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Restore.FlatAppearance.BorderSize = 0;
            this.btn_Restore.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Restore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Restore.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Restore.Image = ((System.Drawing.Image)(resources.GetObject("btn_Restore.Image")));
            this.btn_Restore.Location = new System.Drawing.Point(1309, 3);
            this.btn_Restore.Name = "btn_Restore";
            this.btn_Restore.Size = new System.Drawing.Size(94, 66);
            this.btn_Restore.TabIndex = 11;
            this.btn_Restore.Text = "Khôi phục";
            this.btn_Restore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Restore.UseVisualStyleBackColor = false;
            this.btn_Restore.Click += new System.EventHandler(this.btn_Restore_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 501);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.SystemColors.Control;
            this.contentPanel.Controls.Add(this.splitter1);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 68);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1408, 501);
            this.contentPanel.TabIndex = 2;
            // 
            // btn_ChucVu
            // 
            this.btn_ChucVu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_ChucVu.FlatAppearance.BorderSize = 0;
            this.btn_ChucVu.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_ChucVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChucVu.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChucVu.Image = ((System.Drawing.Image)(resources.GetObject("btn_ChucVu.Image")));
            this.btn_ChucVu.Location = new System.Drawing.Point(709, 3);
            this.btn_ChucVu.Name = "btn_ChucVu";
            this.btn_ChucVu.Size = new System.Drawing.Size(94, 66);
            this.btn_ChucVu.TabIndex = 13;
            this.btn_ChucVu.Text = "Chức vụ";
            this.btn_ChucVu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_ChucVu.UseVisualStyleBackColor = false;
            this.btn_ChucVu.Click += new System.EventHandler(this.btn_ChucVu_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1408, 569);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "Quản Lý Nhân Sự";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.contentPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_phongBan;
        private System.Windows.Forms.Button btn_phuCap;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Button btn_NhanVien;
        private System.Windows.Forms.Button btn_HopDong;
        private System.Windows.Forms.Button btn_DuyetDon;
        private System.Windows.Forms.Button btn_TinhLuong;
        private System.Windows.Forms.Button btn_GanPhuCap;
        private System.Windows.Forms.Button btn_ThongTin;
        private System.Windows.Forms.Button btn_XinNghi;
        private System.Windows.Forms.Button btn_XemLuong;
        private System.Windows.Forms.Button btn_Backup;
        private System.Windows.Forms.Button btn_Restore;
        private System.Windows.Forms.Button btn_ThongKe;
        private System.Windows.Forms.Button btn_ChucVu;
    }
}

