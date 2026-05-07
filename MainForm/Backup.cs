using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MainForm
{
    public partial class Backup : UserControl
    {
        public Backup()
        {
            InitializeComponent();
            rad_SaoLuuToanBo.Checked = true;
        }
        private void btn_ChonThuMuc_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                fbd.Description = "Chọn thư mục để lưu file Backup";
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    txb_ThuMuc.Text = fbd.SelectedPath;
                }
            }
        }

        private void btn_SaoLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txb_ThuMuc.Text))
            {
                MessageBox.Show("Vui lòng chọn thư mục để lưu file trước!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string thoiGian = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            string dbName = "QLNS";
            string fileName = "";
            string backupQuery = "";

            if (rad_SaoLuuToanBo.Checked)
            {
                fileName = $"Backup_Full_{thoiGian}.bak";
                string fullPath = Path.Combine(txb_ThuMuc.Text, fileName);

                backupQuery = $@"BACKUP DATABASE [{dbName}] 
                                 TO DISK = '{fullPath}' 
                                 WITH INIT, FORMAT";
            }
            else if (rad_SaoLuuBoSung.Checked)
            {
                fileName = $"Backup_Differential_{thoiGian}.bak";
                string fullPath = Path.Combine(txb_ThuMuc.Text, fileName);

                backupQuery = $@"BACKUP DATABASE [{dbName}] 
                                 TO DISK = '{fullPath}' 
                                 WITH DIFFERENTIAL";
            }
            try
            {
                string masterConnectionString = @"data source=.\SQLEXPRESS;initial catalog=master;user id=Admin;password=Admin_123;trustservercertificate=True;";

                using (SqlConnection conn = new SqlConnection(masterConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(backupQuery, conn))
                    {
                        cmd.CommandTimeout = 0;
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show($"Sao lưu thành công!\nFile đã được lưu với tên: {fileName}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException sqlEx)
            {
                if (sqlEx.Message.Contains("Cannot perform a differential backup"))
                {
                    MessageBox.Show("Lỗi Logic: Bạn không thể 'Sao lưu bổ sung' khi chưa có bản 'Sao lưu toàn bộ' nào.\nVui lòng chọn 'Sao lưu toàn bộ' để chạy lần đầu tiên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Lỗi từ SQL Server: " + sqlEx.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txb_ThuMuc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
