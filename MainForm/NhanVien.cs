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
    public partial class NhanVien : UserControl
    {
        public NhanVien()
        {
            InitializeComponent();
        }
        NhanVienBUS nvBUS = new NhanVienBUS();
        private void NhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            string tuKhoa = txb_TimKiem.Text.Trim();
            GridViewNV.DataSource = nvBUS.GetListNhanVien(ckb_HienThiDaNghi.Checked, tuKhoa);
            if (GridViewNV.Columns.Count > 0)
            {
                GridViewNV.Columns["MaNV"].HeaderText = "Mã NV";
                GridViewNV.Columns["HoTen"].HeaderText = "Họ Tên";
                GridViewNV.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
                GridViewNV.Columns["GioiTinh"].HeaderText = "Giới Tính";
                GridViewNV.Columns["DiaChi"].HeaderText = "Địa Chỉ";
                GridViewNV.Columns["Sdt"].HeaderText = "Số Điện Thoại";
                GridViewNV.Columns["Email"].HeaderText = "Email";
                GridViewNV.Columns["TenCV"].HeaderText = "Chức Vụ";
                GridViewNV.Columns["TenPB"].HeaderText = "Phòng Ban";
                GridViewNV.Columns["TrangThai"].HeaderText = "Trạng Thái";
            }
        }
        private void GridViewNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = GridViewNV.Rows[e.RowIndex];
                txb_HoTen.Text = row.Cells["HoTen"].Value?.ToString();
                txb_GioiTinh.Text = row.Cells["GioiTinh"].Value?.ToString();
                txb_NoiO.Text = row.Cells["DiaChi"].Value?.ToString();
                txb_SDT.Text = row.Cells["Sdt"].Value?.ToString();
                txb_Email.Text = row.Cells["Email"].Value?.ToString();
                txb_NgSinh.Text = Convert.ToDateTime(row.Cells["NgaySinh"].Value).ToString("dd/MM/yyyy");
                txb_ChucVu.Text = row.Cells["TenCV"].Value?.ToString();
                txb_PhongBan.Text = row.Cells["TenPB"].Value?.ToString();
            }
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            string hoTen = txb_HoTen.Text.Trim();
            string gioiTinh = txb_GioiTinh.Text.Trim();
            string diaChi = txb_NoiO.Text.Trim();
            string sdt = txb_SDT.Text.Trim();
            string email = txb_Email.Text.Trim();
            string tenCV = txb_ChucVu.Text.Trim();
            string tenPB = txb_PhongBan.Text.Trim();
            string chuoiNgaySinh = txb_NgSinh.Text.Trim();

            if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(tenCV) || string.IsNullOrEmpty(tenPB))
            {
                MessageBox.Show("Vui lòng nhập ít nhất Họ tên, Chức vụ và Phòng ban!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime? ngaySinh = null;
            if (!string.IsNullOrEmpty(chuoiNgaySinh))
            {
                if (DateTime.TryParseExact(chuoiNgaySinh, "dd/MM/yyyy",
                    System.Globalization.CultureInfo.InvariantCulture,
                    System.Globalization.DateTimeStyles.None,
                    out DateTime parsedDate))
                {
                    ngaySinh = parsedDate; 
                }
                else
                {
                    MessageBox.Show("Ngày sinh không hợp lệ! Vui lòng nhập đúng định dạng (VD: 05/02/1995).", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            try
            {
                if (nvBUS.ThemNhanVien(hoTen, ngaySinh, gioiTinh, diaChi, sdt, email, tenCV, tenPB))
                {
                    MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txb_HoTen.Text = "";
                    txb_NgSinh.Text = "";
                    txb_GioiTinh.Text = "";
                    txb_NoiO.Text = "";
                    txb_SDT.Text = "";
                    txb_Email.Text = "";
                    txb_ChucVu.Text = "";
                    txb_PhongBan.Text = "";
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
            string maNV = GridViewNV.CurrentRow.Cells["MaNV"].Value.ToString();
            string hoTen = txb_HoTen.Text.Trim();
            string gioiTinh = txb_GioiTinh.Text.Trim();
            string diaChi = txb_NoiO.Text.Trim();
            string sdt = txb_SDT.Text.Trim();
            string email = txb_Email.Text.Trim();
            string tenCV = txb_ChucVu.Text.Trim();
            string tenPB = txb_PhongBan.Text.Trim();
            string chuoiNgaySinh = txb_NgSinh.Text.Trim();
            if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(tenCV) || string.IsNullOrEmpty(tenPB))
            {
                MessageBox.Show("Vui lòng nhập ít nhất Họ tên, Chức vụ và Phòng ban!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DateTime? ngaySinh = null;
            if (!string.IsNullOrEmpty(chuoiNgaySinh))
            {
                if (DateTime.TryParseExact(chuoiNgaySinh, "dd/MM/yyyy",
                    System.Globalization.CultureInfo.InvariantCulture,
                    System.Globalization.DateTimeStyles.None,
                    out DateTime parsedDate))
                {
                    ngaySinh = parsedDate;
                }
                else
                {
                    MessageBox.Show("Ngày sinh không hợp lệ! Vui lòng nhập đúng định dạng (VD: 25/02/1995).", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            try
            {
                if (nvBUS.SuaNhanVien(maNV, hoTen, ngaySinh, gioiTinh, diaChi, sdt, email, tenCV, tenPB))
                {
                    MessageBox.Show("Cập nhật thông tin nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txb_HoTen.Text = "";
                    txb_NgSinh.Text = "";
                    txb_GioiTinh.Text = "";
                    txb_NoiO.Text = "";
                    txb_SDT.Text = "";
                    txb_Email.Text = "";
                    txb_ChucVu.Text = "";
                    txb_PhongBan.Text = "";
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_ThoiViec_Click(object sender, EventArgs e)
        {
            string trangThai = GridViewNV.CurrentRow.Cells["TrangThai"].Value.ToString();
            if (trangThai == "Đã nghỉ")
            {
                MessageBox.Show("Nhân viên này đã nghỉ việc rồi!", "Thông báo");
                return;
            }
            string maNV = GridViewNV.CurrentRow.Cells["MaNV"].Value.ToString();
            string tenNV = GridViewNV.CurrentRow.Cells["HoTen"].Value.ToString();
            DialogResult dr = MessageBox.Show($"Bạn có chắc chắn muốn cho nhân viên [{tenNV}] nghỉ việc không?\n(Dữ liệu sẽ được lưu trữ và không hiển thị trên danh sách hiện tại)",
                                              "Xác nhận thôi việc",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    if (nvBUS.ChoNghiViec(maNV))
                    {
                        MessageBox.Show("Cập nhật trạng thái nghỉ việc thành công!", "Thông báo");
                        LoadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi");
                }
            }
        }

        private void ckb_HienThiDaNghi_CheckedChanged(object sender, EventArgs e)
        {
            LoadData();
        }
        private void txb_TimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

    }
}
