namespace MainForm
{
    partial class Backup
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
            this.label10 = new System.Windows.Forms.Label();
            this.txb_ThuMuc = new System.Windows.Forms.TextBox();
            this.btn_ChonThuMuc = new System.Windows.Forms.Button();
            this.rad_SaoLuuToanBo = new System.Windows.Forms.RadioButton();
            this.rad_SaoLuuBoSung = new System.Windows.Forms.RadioButton();
            this.btn_SaoLuu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(29, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "SAO LƯU DỮ LIỆU";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(38, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 23);
            this.label10.TabIndex = 13;
            this.label10.Text = "Thư mục:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txb_ThuMuc
            // 
            this.txb_ThuMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_ThuMuc.Location = new System.Drawing.Point(135, 120);
            this.txb_ThuMuc.Name = "txb_ThuMuc";
            this.txb_ThuMuc.ReadOnly = true;
            this.txb_ThuMuc.Size = new System.Drawing.Size(162, 27);
            this.txb_ThuMuc.TabIndex = 12;
            this.txb_ThuMuc.TextChanged += new System.EventHandler(this.txb_ThuMuc_TextChanged);
            // 
            // btn_ChonThuMuc
            // 
            this.btn_ChonThuMuc.AutoSize = true;
            this.btn_ChonThuMuc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChonThuMuc.Location = new System.Drawing.Point(357, 117);
            this.btn_ChonThuMuc.Name = "btn_ChonThuMuc";
            this.btn_ChonThuMuc.Size = new System.Drawing.Size(111, 32);
            this.btn_ChonThuMuc.TabIndex = 14;
            this.btn_ChonThuMuc.Text = "Chọn thư mục";
            this.btn_ChonThuMuc.UseVisualStyleBackColor = true;
            this.btn_ChonThuMuc.Click += new System.EventHandler(this.btn_ChonThuMuc_Click);
            // 
            // rad_SaoLuuToanBo
            // 
            this.rad_SaoLuuToanBo.AutoSize = true;
            this.rad_SaoLuuToanBo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_SaoLuuToanBo.Location = new System.Drawing.Point(42, 168);
            this.rad_SaoLuuToanBo.Name = "rad_SaoLuuToanBo";
            this.rad_SaoLuuToanBo.Size = new System.Drawing.Size(136, 24);
            this.rad_SaoLuuToanBo.TabIndex = 15;
            this.rad_SaoLuuToanBo.TabStop = true;
            this.rad_SaoLuuToanBo.Text = "Sao lưu toàn bộ";
            this.rad_SaoLuuToanBo.UseVisualStyleBackColor = true;
            // 
            // rad_SaoLuuBoSung
            // 
            this.rad_SaoLuuBoSung.AutoSize = true;
            this.rad_SaoLuuBoSung.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_SaoLuuBoSung.Location = new System.Drawing.Point(42, 219);
            this.rad_SaoLuuBoSung.Name = "rad_SaoLuuBoSung";
            this.rad_SaoLuuBoSung.Size = new System.Drawing.Size(542, 24);
            this.rad_SaoLuuBoSung.TabIndex = 16;
            this.rad_SaoLuuBoSung.TabStop = true;
            this.rad_SaoLuuBoSung.Text = "Sao lưu bổ sung (chỉ sao lưu dữ liệu thay đổi từ lần sao lưu toàn bộ gần nhất)";
            this.rad_SaoLuuBoSung.UseVisualStyleBackColor = true;
            // 
            // btn_SaoLuu
            // 
            this.btn_SaoLuu.AutoSize = true;
            this.btn_SaoLuu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaoLuu.Location = new System.Drawing.Point(42, 277);
            this.btn_SaoLuu.Name = "btn_SaoLuu";
            this.btn_SaoLuu.Size = new System.Drawing.Size(91, 32);
            this.btn_SaoLuu.TabIndex = 17;
            this.btn_SaoLuu.Text = "Sao lưu";
            this.btn_SaoLuu.UseVisualStyleBackColor = true;
            this.btn_SaoLuu.Click += new System.EventHandler(this.btn_SaoLuu_Click);
            // 
            // Backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_SaoLuu);
            this.Controls.Add(this.rad_SaoLuuBoSung);
            this.Controls.Add(this.rad_SaoLuuToanBo);
            this.Controls.Add(this.btn_ChonThuMuc);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txb_ThuMuc);
            this.Controls.Add(this.label1);
            this.Name = "Backup";
            this.Size = new System.Drawing.Size(1354, 664);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txb_ThuMuc;
        private System.Windows.Forms.Button btn_ChonThuMuc;
        private System.Windows.Forms.RadioButton rad_SaoLuuToanBo;
        private System.Windows.Forms.RadioButton rad_SaoLuuBoSung;
        private System.Windows.Forms.Button btn_SaoLuu;
    }
}
