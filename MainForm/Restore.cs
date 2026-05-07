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
using DataLayer;

namespace MainForm
{
    public partial class Restore : UserControl
    {
        public Restore()
        {
            InitializeComponent();
            rad_KhoiPhucToanBo.Checked = true;
            CapNhatTrangThaiUI();
            rad_KhoiPhucToanBo.CheckedChanged += (s, e) => CapNhatTrangThaiUI();
            rad_KhoiPhucKetHop.CheckedChanged += (s, e) => CapNhatTrangThaiUI();
        }
        private void CapNhatTrangThaiUI()
        {
            bool laKhoiPhucBoSung = rad_KhoiPhucKetHop.Checked;
            txb_FileBoSung.Enabled = laKhoiPhucBoSung;
            btn_ChonFileBoSung.Enabled = laKhoiPhucBoSung;
            if (!laKhoiPhucBoSung)
            {
                txb_FileBoSung.Clear();
            }
        }

        private void btn_ChonFileToanBo_Click(object sender, EventArgs e)
        {
            txb_FileToanBo.Text = ChonFileBackup("Chọn file sao lưu TOÀN BỘ (.bak)");
        }

        private void btn_ChonFileBoSung_Click(object sender, EventArgs e)
        {
            txb_FileBoSung.Text = ChonFileBackup("Chọn file sao lưu BỔ SUNG (.bak)");
        }
        private string ChonFileBackup(string tieuDe)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Backup Files (*.bak)|*.bak|All Files (*.*)|*.*";
                ofd.Title = tieuDe;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    return ofd.FileName;
                }
            }
            return ""; 
        }

        private void btn_KhoiPhuc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txb_FileToanBo.Text))
            {
                MessageBox.Show("Vui lòng chọn File sao lưu toàn bộ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (rad_KhoiPhucKetHop.Checked && string.IsNullOrWhiteSpace(txb_FileBoSung.Text))
            {
                MessageBox.Show("Vui lòng chọn File sao lưu bổ sung!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dialogResult = MessageBox.Show(
                "CẢNH BÁO: Dữ liệu hiện tại sẽ bị thay thế bằng dữ liệu từ file Backup.\nBạn có tiếp tục không?",
                "Xác nhận khôi phục",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialogResult == DialogResult.No) return;

            string dbName = "QLNS";
            string restoreQuery = "";

            if (rad_KhoiPhucToanBo.Checked)
            {
                // Ngắt kết nối - Khôi phục dữ liệu - Mở lại kết nối
                restoreQuery = $@"ALTER DATABASE [{dbName}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
                                  RESTORE DATABASE [{dbName}] FROM DISK = '{txb_FileToanBo.Text}' WITH REPLACE;
                                  ALTER DATABASE [{dbName}] SET MULTI_USER;";
            }
            else if (rad_KhoiPhucKetHop.Checked)
            {
                // Ngắt kết nối - Khôi phục dữ liệu - Mở lại kết nối
                restoreQuery = $@"ALTER DATABASE [{dbName}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
                                  RESTORE DATABASE [{dbName}] FROM DISK = '{txb_FileToanBo.Text}' WITH REPLACE, NORECOVERY;
                                  RESTORE DATABASE [{dbName}] FROM DISK = '{txb_FileBoSung.Text}' WITH RECOVERY;
                                  ALTER DATABASE [{dbName}] SET MULTI_USER;";
            }
            string masterConnectionString = @"data source=.\SQLEXPRESS;initial catalog=master;user id=Admin;password=Admin_123;trustservercertificate=True;";

            try
            {
                using (SqlConnection conn = new SqlConnection(masterConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(restoreQuery, conn))
                    {
                        cmd.CommandTimeout = 0; 
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Khôi phục dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txb_FileToanBo.Clear();
                txb_FileBoSung.Clear();
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Lỗi CSDL: " + sqlEx.Message, "Lỗi Restore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
