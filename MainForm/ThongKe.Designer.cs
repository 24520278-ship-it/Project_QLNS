namespace MainForm
{
    partial class ThongKe
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
            this.rad_TheoChucPhu = new System.Windows.Forms.RadioButton();
            this.rad_TheoPhongBan = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.txb_Thang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_Nam = new System.Windows.Forms.TextBox();
            this.btn_XuatThongKe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(22, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 38);
            this.label1.TabIndex = 8;
            this.label1.Text = "THỐNG KÊ LƯƠNG";
            // 
            // rad_TheoChucPhu
            // 
            this.rad_TheoChucPhu.AutoSize = true;
            this.rad_TheoChucPhu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_TheoChucPhu.Location = new System.Drawing.Point(28, 264);
            this.rad_TheoChucPhu.Name = "rad_TheoChucPhu";
            this.rad_TheoChucPhu.Size = new System.Drawing.Size(276, 24);
            this.rad_TheoChucPhu.TabIndex = 22;
            this.rad_TheoChucPhu.TabStop = true;
            this.rad_TheoChucPhu.Text = "Thống kê lương 1 tháng theo chức vụ";
            this.rad_TheoChucPhu.UseVisualStyleBackColor = true;
            // 
            // rad_TheoPhongBan
            // 
            this.rad_TheoPhongBan.AutoSize = true;
            this.rad_TheoPhongBan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_TheoPhongBan.Location = new System.Drawing.Point(28, 213);
            this.rad_TheoPhongBan.Name = "rad_TheoPhongBan";
            this.rad_TheoPhongBan.Size = new System.Drawing.Size(298, 24);
            this.rad_TheoPhongBan.TabIndex = 21;
            this.rad_TheoPhongBan.TabStop = true;
            this.rad_TheoPhongBan.Text = "Thống kê lương 1 tháng theo phòng ban";
            this.rad_TheoPhongBan.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(28, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 23);
            this.label10.TabIndex = 24;
            this.label10.Text = "Tháng:";
            // 
            // txb_Thang
            // 
            this.txb_Thang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Thang.Location = new System.Drawing.Point(121, 129);
            this.txb_Thang.Name = "txb_Thang";
            this.txb_Thang.Size = new System.Drawing.Size(100, 27);
            this.txb_Thang.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(288, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 23);
            this.label2.TabIndex = 26;
            this.label2.Text = "Năm:";
            // 
            // txb_Nam
            // 
            this.txb_Nam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Nam.Location = new System.Drawing.Point(380, 129);
            this.txb_Nam.Name = "txb_Nam";
            this.txb_Nam.Size = new System.Drawing.Size(100, 27);
            this.txb_Nam.TabIndex = 25;
            // 
            // btn_XuatThongKe
            // 
            this.btn_XuatThongKe.AutoSize = true;
            this.btn_XuatThongKe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XuatThongKe.Location = new System.Drawing.Point(28, 334);
            this.btn_XuatThongKe.Name = "btn_XuatThongKe";
            this.btn_XuatThongKe.Size = new System.Drawing.Size(130, 32);
            this.btn_XuatThongKe.TabIndex = 27;
            this.btn_XuatThongKe.Text = "Xuất thống kê";
            this.btn_XuatThongKe.UseVisualStyleBackColor = true;
            this.btn_XuatThongKe.Click += new System.EventHandler(this.btn_XuatThongKe_Click);
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_XuatThongKe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_Nam);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txb_Thang);
            this.Controls.Add(this.rad_TheoChucPhu);
            this.Controls.Add(this.rad_TheoPhongBan);
            this.Controls.Add(this.label1);
            this.Name = "ThongKe";
            this.Size = new System.Drawing.Size(1351, 647);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rad_TheoChucPhu;
        private System.Windows.Forms.RadioButton rad_TheoPhongBan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txb_Thang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_Nam;
        private System.Windows.Forms.Button btn_XuatThongKe;
    }
}
