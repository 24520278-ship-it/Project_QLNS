namespace MainForm
{
    partial class Restore
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
            this.btn_ChonFileToanBo = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txb_FileToanBo = new System.Windows.Forms.TextBox();
            this.btn_KhoiPhuc = new System.Windows.Forms.Button();
            this.rad_KhoiPhucKetHop = new System.Windows.Forms.RadioButton();
            this.rad_KhoiPhucToanBo = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_FileBoSung = new System.Windows.Forms.TextBox();
            this.btn_ChonFileBoSung = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(19, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 38);
            this.label1.TabIndex = 7;
            this.label1.Text = "KHÔI PHỤC DỮ LIỆU";
            // 
            // btn_ChonFileToanBo
            // 
            this.btn_ChonFileToanBo.AutoSize = true;
            this.btn_ChonFileToanBo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChonFileToanBo.Location = new System.Drawing.Point(618, 235);
            this.btn_ChonFileToanBo.Name = "btn_ChonFileToanBo";
            this.btn_ChonFileToanBo.Size = new System.Drawing.Size(134, 32);
            this.btn_ChonFileToanBo.TabIndex = 17;
            this.btn_ChonFileToanBo.Text = "Chọn file toàn bộ";
            this.btn_ChonFileToanBo.UseVisualStyleBackColor = true;
            this.btn_ChonFileToanBo.Click += new System.EventHandler(this.btn_ChonFileToanBo_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(25, 241);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(266, 23);
            this.label10.TabIndex = 16;
            this.label10.Text = "Đường dẫn file sao lưu toàn bộ:";
            // 
            // txb_FileToanBo
            // 
            this.txb_FileToanBo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_FileToanBo.Location = new System.Drawing.Point(325, 238);
            this.txb_FileToanBo.Name = "txb_FileToanBo";
            this.txb_FileToanBo.ReadOnly = true;
            this.txb_FileToanBo.Size = new System.Drawing.Size(260, 27);
            this.txb_FileToanBo.TabIndex = 15;
            // 
            // btn_KhoiPhuc
            // 
            this.btn_KhoiPhuc.AutoSize = true;
            this.btn_KhoiPhuc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_KhoiPhuc.Location = new System.Drawing.Point(618, 374);
            this.btn_KhoiPhuc.Name = "btn_KhoiPhuc";
            this.btn_KhoiPhuc.Size = new System.Drawing.Size(135, 32);
            this.btn_KhoiPhuc.TabIndex = 18;
            this.btn_KhoiPhuc.Text = "Khôi phục";
            this.btn_KhoiPhuc.UseVisualStyleBackColor = true;
            this.btn_KhoiPhuc.Click += new System.EventHandler(this.btn_KhoiPhuc_Click);
            // 
            // rad_KhoiPhucKetHop
            // 
            this.rad_KhoiPhucKetHop.AutoSize = true;
            this.rad_KhoiPhucKetHop.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_KhoiPhucKetHop.Location = new System.Drawing.Point(25, 158);
            this.rad_KhoiPhucKetHop.Name = "rad_KhoiPhucKetHop";
            this.rad_KhoiPhucKetHop.Size = new System.Drawing.Size(473, 24);
            this.rad_KhoiPhucKetHop.TabIndex = 20;
            this.rad_KhoiPhucKetHop.TabStop = true;
            this.rad_KhoiPhucKetHop.Text = "Khôi phục kết hợp (cần file sao lưu toàn bộ và file sao lưu bổ sung)";
            this.rad_KhoiPhucKetHop.UseVisualStyleBackColor = true;
            // 
            // rad_KhoiPhucToanBo
            // 
            this.rad_KhoiPhucToanBo.AutoSize = true;
            this.rad_KhoiPhucToanBo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_KhoiPhucToanBo.Location = new System.Drawing.Point(25, 107);
            this.rad_KhoiPhucToanBo.Name = "rad_KhoiPhucToanBo";
            this.rad_KhoiPhucToanBo.Size = new System.Drawing.Size(152, 24);
            this.rad_KhoiPhucToanBo.TabIndex = 19;
            this.rad_KhoiPhucToanBo.TabStop = true;
            this.rad_KhoiPhucToanBo.Text = "Khôi phục toàn bộ";
            this.rad_KhoiPhucToanBo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(25, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 23);
            this.label2.TabIndex = 22;
            this.label2.Text = "Đường dẫn file sao lưu bổ sung:";
            // 
            // txb_FileBoSung
            // 
            this.txb_FileBoSung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_FileBoSung.Location = new System.Drawing.Point(325, 303);
            this.txb_FileBoSung.Name = "txb_FileBoSung";
            this.txb_FileBoSung.ReadOnly = true;
            this.txb_FileBoSung.Size = new System.Drawing.Size(260, 27);
            this.txb_FileBoSung.TabIndex = 21;
            // 
            // btn_ChonFileBoSung
            // 
            this.btn_ChonFileBoSung.AutoSize = true;
            this.btn_ChonFileBoSung.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChonFileBoSung.Location = new System.Drawing.Point(618, 300);
            this.btn_ChonFileBoSung.Name = "btn_ChonFileBoSung";
            this.btn_ChonFileBoSung.Size = new System.Drawing.Size(135, 32);
            this.btn_ChonFileBoSung.TabIndex = 23;
            this.btn_ChonFileBoSung.Text = "Chọn file bổ sung";
            this.btn_ChonFileBoSung.UseVisualStyleBackColor = true;
            this.btn_ChonFileBoSung.Click += new System.EventHandler(this.btn_ChonFileBoSung_Click);
            // 
            // Restore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_ChonFileBoSung);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_FileBoSung);
            this.Controls.Add(this.rad_KhoiPhucKetHop);
            this.Controls.Add(this.rad_KhoiPhucToanBo);
            this.Controls.Add(this.btn_KhoiPhuc);
            this.Controls.Add(this.btn_ChonFileToanBo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txb_FileToanBo);
            this.Controls.Add(this.label1);
            this.Name = "Restore";
            this.Size = new System.Drawing.Size(1241, 641);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ChonFileToanBo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txb_FileToanBo;
        private System.Windows.Forms.Button btn_KhoiPhuc;
        private System.Windows.Forms.RadioButton rad_KhoiPhucKetHop;
        private System.Windows.Forms.RadioButton rad_KhoiPhucToanBo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_FileBoSung;
        private System.Windows.Forms.Button btn_ChonFileBoSung;
    }
}
