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
    public partial class HopDong : UserControl
    {
        public HopDong()
        {
            InitializeComponent();
        }
        HopDongBUS hdBUS = new HopDongBUS();
        private void HopDong_Load(object sender, EventArgs e)
        {
            // Khởi động app thì chạy lệnh này để tự động cập nhật trạng thái hợp đồng theo ngày
            hdBUS.TuDongCapNhatTrangThai();
            LoadData();
        }
        private void LoadData(string tuKhoa = "")
        {
            GridViewHD.DataSource = hdBUS.GetDanhSachHopDong(tuKhoa);
            if (GridViewHD.Columns.Count > 0)
            {
                GridViewHD.Columns["MaHD"].HeaderText = "Mã HĐ";
                GridViewHD.Columns["MaNV"].HeaderText = "Mã NV";
                GridViewHD.Columns["HoTen"].HeaderText = "Họ Tên Nhân Viên";
                GridViewHD.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
                GridViewHD.Columns["GioiTinh"].HeaderText = "Giới Tính";
                GridViewHD.Columns["NgayBD"].HeaderText = "Ngày Bắt Đầu";
                GridViewHD.Columns["NgayKT"].HeaderText = "Ngày Kết Thúc";
                GridViewHD.Columns["NgayKy"].HeaderText = "Ngày Ký";
                GridViewHD.Columns["MucLuong"].HeaderText = "Mức Lương";
                GridViewHD.Columns["MucLuong"].DefaultCellStyle.Format = "N0";
                GridViewHD.Columns["TrangThai"].HeaderText = "Trạng Thái";
            }
        }
        private void GridViewHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = GridViewHD.Rows[e.RowIndex];
                txb_HoTen.Text = row.Cells["HoTen"].Value?.ToString();
                txb_MaNV.Text = row.Cells["MaNV"].Value?.ToString();

                if (row.Cells["MucLuong"].Value != null)
                {
                    txb_MucLuong.Text = Convert.ToDecimal(row.Cells["MucLuong"].Value).ToString("N0");
                }
                else
                {
                    txb_MucLuong.Text = "";
                }
                txb_NgayBD.Text = Convert.ToDateTime(row.Cells["NgayBD"].Value).ToString("dd/MM/yyyy");
                txb_NgayKT.Text = Convert.ToDateTime(row.Cells["NgayKT"].Value).ToString("dd/MM/yyyy");
                txb_NgayKy.Text = Convert.ToDateTime(row.Cells["NgayKy"].Value).ToString("dd/MM/yyyy");
            }
        }
        private void txb_MaNV_Leave(object sender, EventArgs e)
        {
            string maNV = txb_MaNV.Text.Trim();
            if (!string.IsNullOrEmpty(maNV))
            {
                string hoTen = hdBUS.KiemTraVaLayTenNhanVien(maNV);
                if (hoTen != null)
                {
                    txb_HoTen.Text = hoTen;
                }
                else
                {
                    txb_HoTen.Text = "Không tìm thấy nhân viên!";
                }
            }
            else
            {
                txb_HoTen.Text = "";
            }
        }
        private void txb_TimKiem_TextChanged(object sender, EventArgs e)
        {
            string tuKhoa = txb_TimKiem.Text.Trim();
            LoadData(tuKhoa);
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            string maNV = txb_MaNV.Text.Trim();
            string chuoiMucLuong = txb_MucLuong.Text.Trim();

            if (string.IsNullOrEmpty(maNV))
            {
                MessageBox.Show("Vui lòng nhập Mã Nhân Viên để thêm hợp đồng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txb_MaNV.Focus();
                return;
            }

            string chuoiNgayBD = txb_NgayBD.Text.Trim();
            DateTime? ngayBD = null;
            if (!string.IsNullOrEmpty(chuoiNgayBD))
            {
                if (DateTime.TryParseExact(chuoiNgayBD, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out DateTime parsedDate))
                    ngayBD = parsedDate;
                else
                {
                    MessageBox.Show("Ngày bắt đầu không hợp lệ! Vui lòng nhập đúng định dạng (VD: 25/02/2023).", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            string chuoiNgayKT = txb_NgayKT.Text.Trim();
            DateTime? ngayKT = null;
            if (!string.IsNullOrEmpty(chuoiNgayKT))
            {
                if (DateTime.TryParseExact(chuoiNgayKT, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out DateTime parsedDate))
                    ngayKT = parsedDate;
                else
                {
                    MessageBox.Show("Ngày kết thúc không hợp lệ! Vui lòng nhập đúng định dạng (VD: 25/02/2024).", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            string chuoiNgayKy = txb_NgayKy.Text.Trim();
            DateTime? ngayKy = null;
            if (!string.IsNullOrEmpty(chuoiNgayKy))
            {
                if (DateTime.TryParseExact(chuoiNgayKy, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out DateTime parsedDate))
                    ngayKy = parsedDate;
                else
                {
                    MessageBox.Show("Ngày ký không hợp lệ! Vui lòng nhập đúng định dạng (VD: 25/02/2023).", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            try
            {
                decimal.TryParse(chuoiMucLuong, out decimal mucLuong);
                if (hdBUS.ThemHopDong(ngayBD, ngayKT, ngayKy, mucLuong, maNV))
                {
                    MessageBox.Show($"Thêm thành công hợp đồng cho nhân viên [{maNV}]!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadData();
                    txb_MaNV.Text = "";
                    txb_HoTen.Text = "";
                    txb_MucLuong.Text = "";
                    txb_NgayBD.Text = "";
                    txb_NgayKT.Text = "";
                    txb_NgayKy.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi khi thêm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (ex.Message.Contains("không tồn tại"))
                {
                    txb_MaNV.Focus();
                    txb_MaNV.SelectAll();
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string maHD = GridViewHD.CurrentRow.Cells["MaHD"].Value?.ToString();
            string maNV = txb_MaNV.Text.Trim();
            string chuoiMucLuong = txb_MucLuong.Text.Trim();

            if (string.IsNullOrEmpty(maNV))
            {
                MessageBox.Show("Mã nhân viên không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string chuoiNgayBD = txb_NgayBD.Text.Trim();
            DateTime? ngayBD = null;
            if (!string.IsNullOrEmpty(chuoiNgayBD))
            {
                if (DateTime.TryParseExact(chuoiNgayBD, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out DateTime parsedDate))
                    ngayBD = parsedDate;
                else
                {
                    MessageBox.Show("Ngày bắt đầu không hợp lệ (VD: 25/12/2023).", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            string chuoiNgayKT = txb_NgayKT.Text.Trim();
            DateTime? ngayKT = null;
            if (!string.IsNullOrEmpty(chuoiNgayKT))
            {
                if (DateTime.TryParseExact(chuoiNgayKT, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out DateTime parsedDate))
                    ngayKT = parsedDate;
                else
                {
                    MessageBox.Show("Ngày kết thúc không hợp lệ (VD: 25/12/2024).", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            string chuoiNgayKy = txb_NgayKy.Text.Trim();
            DateTime? ngayKy = null;
            if (!string.IsNullOrEmpty(chuoiNgayKy))
            {
                if (DateTime.TryParseExact(chuoiNgayKy, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out DateTime parsedDate))
                    ngayKy = parsedDate;
                else
                {
                    MessageBox.Show("Ngày ký không hợp lệ (VD: 25/12/2023).", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            try
            {
                decimal.TryParse(chuoiMucLuong, out decimal mucLuong);
                if (hdBUS.SuaHopDong(maHD, ngayBD, ngayKT, ngayKy, mucLuong, maNV))
                {
                    MessageBox.Show("Cập nhật thông tin hợp đồng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    txb_MaNV.Text = "";
                    txb_HoTen.Text = "";
                    txb_MucLuong.Text = "";
                    txb_NgayBD.Text = "";
                    txb_NgayKT.Text = "";
                    txb_NgayKy.Text = "";
                    maHD = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi khi sửa", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (ex.Message.Contains("chủ sở hữu"))
                {
                    txb_MaNV.Focus();
                }
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            string maHD = GridViewHD.CurrentRow.Cells["MaHD"].Value?.ToString();

            if (string.IsNullOrEmpty(maHD))
            {
                MessageBox.Show("Không thể xác định được Mã Hợp Đồng để hủy!", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult dialogResult = MessageBox.Show(
                $"Bạn có CHẮC CHẮN muốn hủy hợp đồng [{maHD}] trước thời hạn không?",
                "Xác nhận Hủy Hợp Đồng",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    if (hdBUS.HuyHopDong(maHD))
                    {
                        MessageBox.Show("Đã hủy hợp đồng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        txb_HoTen.Text = "";
                        txb_MaNV.Text = "";
                        txb_MucLuong.Text = "";
                        txb_NgayBD.Text = "";
                        txb_NgayKT.Text = "";
                        txb_NgayKy.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    // Nếu lỡ bấm hủy cái hợp đồng đã hủy rồi, lỗi từ Store Procedure sẽ bay lên đây
                    MessageBox.Show(ex.Message, "Lỗi khi hủy", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}   
