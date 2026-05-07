namespace MainForm
{
    partial class DuyetDon
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
            this.LoaiDon = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GridView_DuyetDon = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_DuyetDon)).BeginInit();
            this.SuspendLayout();
            // 
            // LoaiDon
            // 
            this.LoaiDon.FormattingEnabled = true;
            this.LoaiDon.Location = new System.Drawing.Point(854, 164);
            this.LoaiDon.Name = "LoaiDon";
            this.LoaiDon.Size = new System.Drawing.Size(224, 24);
            this.LoaiDon.TabIndex = 0;
            this.LoaiDon.SelectedIndexChanged += new System.EventHandler(this.LoaiDon_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(29, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "DUYỆT ĐƠN NGHỈ PHÉP";
            // 
            // GridView_DuyetDon
            // 
            this.GridView_DuyetDon.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GridView_DuyetDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_DuyetDon.Location = new System.Drawing.Point(36, 203);
            this.GridView_DuyetDon.Name = "GridView_DuyetDon";
            this.GridView_DuyetDon.RowHeadersWidth = 51;
            this.GridView_DuyetDon.RowTemplate.Height = 24;
            this.GridView_DuyetDon.Size = new System.Drawing.Size(1042, 370);
            this.GridView_DuyetDon.TabIndex = 6;
            this.GridView_DuyetDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_DuyetDon_CellContentClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(702, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 23);
            this.label10.TabIndex = 10;
            this.label10.Text = "Tình trạng đơn:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(35, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(281, 28);
            this.label6.TabIndex = 26;
            this.label6.Text = "DANH SÁCH ĐƠN XIN NGHỈ";
            // 
            // DuyetDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.GridView_DuyetDon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoaiDon);
            this.Name = "DuyetDon";
            this.Size = new System.Drawing.Size(1138, 670);
            this.Load += new System.EventHandler(this.DuyetDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView_DuyetDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox LoaiDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GridView_DuyetDon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
    }
}
