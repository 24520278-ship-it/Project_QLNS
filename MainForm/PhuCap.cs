using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class PhuCap : UserControl
    {
        public PhuCap()
        {
            InitializeComponent();
        }
        PhuCapBUS pcBUS = new PhuCapBUS();
        private void ChucVu_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            GridViewPC.DataSource = pcBUS.GetListPhuCap();
            if (GridViewPC.Columns["NHANPHUCAPs"] != null)
            {
                GridViewPC.Columns["NHANPHUCAPs"].Visible = false;
            }
            if (GridViewPC.Columns.Count > 0) 
            {
                GridViewPC.Columns["MaPC"].HeaderText = "Mã PC";
                GridViewPC.Columns["MaPC"].Width = 100; 
                GridViewPC.Columns["TenPC"].HeaderText = "Tên Phụ Cấp";
                GridViewPC.Columns["TenPC"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; 
                GridViewPC.Columns["SoTien"].HeaderText = "Số Tiền (VNĐ)";
                GridViewPC.Columns["SoTien"].Width = 150; 
                GridViewPC.Columns["SoTien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; 
                GridViewPC.Columns["SoTien"].DefaultCellStyle.Format = "N0"; 
            }
        }

        private void GridViewPC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = GridViewPC.Rows[e.RowIndex];
                txb_TenPC.Text = row.Cells["TenPC"].Value?.ToString();
                txb_ST.Text = row.Cells["SoTien"].Value?.ToString();
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string tenPC = txb_TenPC.Text.Trim();
            string chuoiSoTien = txb_ST.Text.Trim();

            if (string.IsNullOrEmpty(tenPC) || string.IsNullOrEmpty(chuoiSoTien))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Tên phụ cấp và Số tiền!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            decimal soTien;
            if (!decimal.TryParse(chuoiSoTien, out soTien))
            {
                MessageBox.Show("Số tiền không hợp lệ! Vui lòng chỉ nhập số.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Gọi BUS để thêm
            try
            {
                if (pcBUS.ThemPhuCap(tenPC, soTien))
                {
                    MessageBox.Show("Thêm phụ cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txb_TenPC.Text = "";
                    txb_ST.Text = "";

                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string maPC = GridViewPC.CurrentRow.Cells["MaPC"].Value.ToString();

            // 3. Lấy dữ liệu mới từ TextBox
            string tenMoi = txb_TenPC.Text.Trim();
            string chuoiSoTien = txb_ST.Text.Trim();

            // Validate rỗng
            if (string.IsNullOrEmpty(tenMoi) || string.IsNullOrEmpty(chuoiSoTien))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Tên phụ cấp và Số tiền!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate kiểu số
            decimal soTienMoi;
            if (!decimal.TryParse(chuoiSoTien, out soTienMoi))
            {
                MessageBox.Show("Số tiền không hợp lệ! Vui lòng chỉ nhập số.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (soTienMoi <= 0)
            {
                MessageBox.Show("Số tiền không được nhỏ hơn hoặc bằng 0!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 4. Gọi BUS để thực hiện sửa
            try
            {
                if (pcBUS.SuaPhuCap(maPC, tenMoi, soTienMoi))
                {
                    MessageBox.Show("Cập nhật thông tin phụ cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Làm sạch các ô nhập liệu
                    txb_TenPC.Text = "";
                    txb_ST.Text = "";

                    // Load lại danh sách để hiển thị dữ liệu mới
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string maPC = GridViewPC.CurrentRow.Cells["MaPC"].Value.ToString();
            string tenPC = GridViewPC.CurrentRow.Cells["TenPC"].Value.ToString();

            // 3. Hiển thị hộp thoại cảnh báo rủi ro mất dữ liệu liên quan
            DialogResult dialogResult = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa phụ cấp '{tenPC}' không?\n\n" +
                $"LƯU Ý: Thao tác này sẽ đồng thời xóa luôn tất cả các dữ liệu cấp phát phụ cấp này cho các nhân viên (nếu có)!",
                "Cảnh báo xóa dữ liệu",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning); // Dùng icon Warning màu vàng thay vì Question

            // 4. Nếu người dùng chọn Yes thì tiến hành xóa
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    // Gọi BUS để thực hiện xóa
                    if (pcBUS.XoaPhuCap(maPC))
                    {
                        MessageBox.Show("Đã xóa phụ cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Làm sạch các ô nhập liệu
                        txb_TenPC.Text = "";
                        txb_ST.Text = "";

                        // Tải lại dữ liệu lên lưới
                        LoadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
