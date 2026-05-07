namespace MainForm
{
    partial class TinhLuong
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
            this.label1 = new System.Windows.Forms.Label();
            this.txb_Thang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_Nam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_CongChuan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_TinhLuong = new System.Windows.Forms.Button();
            this.GridView_BangLuong = new System.Windows.Forms.DataGridView();
            this.btn_XuatBangLuong = new System.Windows.Forms.Button();
            this.btn_ImportCSV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_BangLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(17, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "TÍNH LƯƠNG THÁNG";
            // 
            // txb_Thang
            // 
            this.txb_Thang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Thang.Location = new System.Drawing.Point(85, 146);
            this.txb_Thang.Multiline = true;
            this.txb_Thang.Name = "txb_Thang";
            this.txb_Thang.Size = new System.Drawing.Size(187, 25);
            this.txb_Thang.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(19, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tháng:";
            // 
            // txb_Nam
            // 
            this.txb_Nam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Nam.Location = new System.Drawing.Point(368, 148);
            this.txb_Nam.Multiline = true;
            this.txb_Nam.Name = "txb_Nam";
            this.txb_Nam.Size = new System.Drawing.Size(187, 25);
            this.txb_Nam.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(315, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Năm:";
            // 
            // txb_CongChuan
            // 
            this.txb_CongChuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_CongChuan.Location = new System.Drawing.Point(774, 148);
            this.txb_CongChuan.Multiline = true;
            this.txb_CongChuan.Name = "txb_CongChuan";
            this.txb_CongChuan.Size = new System.Drawing.Size(187, 25);
            this.txb_CongChuan.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(590, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Số ngày công chuẩn:";
            // 
            // btn_TinhLuong
            // 
            this.btn_TinhLuong.AutoSize = true;
            this.btn_TinhLuong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TinhLuong.Location = new System.Drawing.Point(903, 705);
            this.btn_TinhLuong.Name = "btn_TinhLuong";
            this.btn_TinhLuong.Size = new System.Drawing.Size(93, 30);
            this.btn_TinhLuong.TabIndex = 14;
            this.btn_TinhLuong.Text = "Tính Lương";
            this.btn_TinhLuong.UseVisualStyleBackColor = true;
            this.btn_TinhLuong.Click += new System.EventHandler(this.btn_TinhLuong_Click);
            // 
            // GridView_BangLuong
            // 
            this.GridView_BangLuong.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GridView_BangLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_BangLuong.Location = new System.Drawing.Point(23, 225);
            this.GridView_BangLuong.Name = "GridView_BangLuong";
            this.GridView_BangLuong.RowHeadersWidth = 51;
            this.GridView_BangLuong.RowTemplate.Height = 24;
            this.GridView_BangLuong.Size = new System.Drawing.Size(1192, 465);
            this.GridView_BangLuong.TabIndex = 15;
            // 
            // btn_XuatBangLuong
            // 
            this.btn_XuatBangLuong.AutoSize = true;
            this.btn_XuatBangLuong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XuatBangLuong.Location = new System.Drawing.Point(1029, 705);
            this.btn_XuatBangLuong.Name = "btn_XuatBangLuong";
            this.btn_XuatBangLuong.Size = new System.Drawing.Size(192, 30);
            this.btn_XuatBangLuong.TabIndex = 16;
            this.btn_XuatBangLuong.Text = "Xuất báo cáo lương tháng";
            this.btn_XuatBangLuong.UseVisualStyleBackColor = true;
            this.btn_XuatBangLuong.Click += new System.EventHandler(this.btn_XuatBangLuong_Click);
            // 
            // btn_ImportCSV
            // 
            this.btn_ImportCSV.AutoSize = true;
            this.btn_ImportCSV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ImportCSV.Location = new System.Drawing.Point(1015, 143);
            this.btn_ImportCSV.Name = "btn_ImportCSV";
            this.btn_ImportCSV.Size = new System.Drawing.Size(164, 30);
            this.btn_ImportCSV.TabIndex = 17;
            this.btn_ImportCSV.Text = "Nhập File Chấm Công";
            this.btn_ImportCSV.UseVisualStyleBackColor = true;
            this.btn_ImportCSV.Click += new System.EventHandler(this.btn_ImportCSV_Click);
            // 
            // TinhLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_ImportCSV);
            this.Controls.Add(this.btn_XuatBangLuong);
            this.Controls.Add(this.GridView_BangLuong);
            this.Controls.Add(this.btn_TinhLuong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txb_CongChuan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txb_Nam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_Thang);
            this.Controls.Add(this.label1);
            this.Name = "TinhLuong";
            this.Size = new System.Drawing.Size(1408, 739);
            this.Load += new System.EventHandler(this.FormTinhLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView_BangLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_Thang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_Nam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_CongChuan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_TinhLuong;
        private System.Windows.Forms.DataGridView GridView_BangLuong;
        private System.Windows.Forms.Button btn_XuatBangLuong;
        private System.Windows.Forms.Button btn_ImportCSV;
    }
}
