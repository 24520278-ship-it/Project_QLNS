namespace MainForm
{
    partial class XinNghi
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
            this.GridView_Don = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Nop = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_LyDo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_NgayKT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_NgayBD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_MaNV = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Don)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridView_Don
            // 
            this.GridView_Don.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GridView_Don.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_Don.Location = new System.Drawing.Point(669, 204);
            this.GridView_Don.Name = "GridView_Don";
            this.GridView_Don.RowHeadersWidth = 51;
            this.GridView_Don.RowTemplate.Height = 24;
            this.GridView_Don.Size = new System.Drawing.Size(716, 216);
            this.GridView_Don.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(26, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "NỘP ĐƠN XIN NGHỈ PHÉP";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Nop);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txb_LyDo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txb_NgayKT);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txb_NgayBD);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txb_MaNV);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(541, 429);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đơn xin nghỉ";
            // 
            // btn_Nop
            // 
            this.btn_Nop.AutoSize = true;
            this.btn_Nop.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nop.Location = new System.Drawing.Point(405, 348);
            this.btn_Nop.Name = "btn_Nop";
            this.btn_Nop.Size = new System.Drawing.Size(78, 32);
            this.btn_Nop.TabIndex = 32;
            this.btn_Nop.Text = "Nộp đơn";
            this.btn_Nop.UseVisualStyleBackColor = true;
            this.btn_Nop.Click += new System.EventHandler(this.btn_Nop_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(16, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 23);
            this.label5.TabIndex = 31;
            this.label5.Text = "Lý do:";
            // 
            // txb_LyDo
            // 
            this.txb_LyDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_LyDo.Location = new System.Drawing.Point(168, 287);
            this.txb_LyDo.Name = "txb_LyDo";
            this.txb_LyDo.Size = new System.Drawing.Size(312, 27);
            this.txb_LyDo.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(16, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 23);
            this.label4.TabIndex = 29;
            this.label4.Text = "Ngày kết thúc:";
            // 
            // txb_NgayKT
            // 
            this.txb_NgayKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_NgayKT.Location = new System.Drawing.Point(168, 224);
            this.txb_NgayKT.Name = "txb_NgayKT";
            this.txb_NgayKT.Size = new System.Drawing.Size(187, 27);
            this.txb_NgayKT.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(16, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 23);
            this.label3.TabIndex = 27;
            this.label3.Text = "Ngày bắt đầu:";
            // 
            // txb_NgayBD
            // 
            this.txb_NgayBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_NgayBD.Location = new System.Drawing.Point(168, 155);
            this.txb_NgayBD.Name = "txb_NgayBD";
            this.txb_NgayBD.Size = new System.Drawing.Size(187, 27);
            this.txb_NgayBD.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 23);
            this.label2.TabIndex = 25;
            this.label2.Text = "Mã nhân viên:";
            // 
            // txb_MaNV
            // 
            this.txb_MaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_MaNV.Location = new System.Drawing.Point(168, 87);
            this.txb_MaNV.Name = "txb_MaNV";
            this.txb_MaNV.ReadOnly = true;
            this.txb_MaNV.Size = new System.Drawing.Size(187, 27);
            this.txb_MaNV.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(664, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(446, 28);
            this.label6.TabIndex = 25;
            this.label6.Text = "DANH SÁCH ĐƠN XIN NGHỈ CỦA NHÂN VIÊN";
            // 
            // XinNghi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridView_Don);
            this.Name = "XinNghi";
            this.Size = new System.Drawing.Size(1388, 646);
            this.Load += new System.EventHandler(this.XinNghi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Don)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridView_Don;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_LyDo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_NgayKT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_NgayBD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_MaNV;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_Nop;
        private System.Windows.Forms.Label label6;
    }
}
