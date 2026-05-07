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
    public partial class ThongTinNhanVien : UserControl
    {
        private ThongTinNvBUS bus = new ThongTinNvBUS();
        public ThongTinNhanVien()
        {
            InitializeComponent();
        }
        private void ThongTinNhanVien_Load(object sender, EventArgs e)
        {
            try
            {
                var dsInfo = bus.LayThongTinCaNhan() as IEnumerable<dynamic>;
                var nv = dsInfo?.FirstOrDefault();

                if (nv != null)
                {
                    txb_HoTen.Text = nv.HoTen?.ToString();
                    if (nv.NgaySinh != null)
                    {
                        txb_NgaySinh.Text = nv.NgaySinh.ToString("dd/MM/yyyy");
                    }

                    txb_GioiTinh.Text = nv.GioiTinh?.ToString();
                    txb_DiaChi.Text = nv.DiaChi?.ToString();
                    txb_SDT.Text = nv.Sdt?.ToString();
                    txb_Email.Text = nv.Email?.ToString();
                    txb_ChucVu.Text = nv.TenCV?.ToString();
                    txb_PhongBan.Text = nv.TenPB?.ToString();
                }
            }
            catch (Exception ex)
            {
                // Nếu SQL Server chặn quyền SELECT trên các bảng liên quan, lỗi sẽ hiện ở đây
                MessageBox.Show("Lỗi tải thông tin: " + ex.Message, "Thông báo hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                string hoTen = txb_HoTen.Text.Trim();
                string gioiTinh = txb_GioiTinh.Text.Trim();
                string diaChi = txb_DiaChi.Text.Trim();
                string sdt = txb_SDT.Text.Trim();
                string email = txb_Email.Text.Trim();

                DateTime ngaySinh;
                if (!DateTime.TryParseExact(txb_NgaySinh.Text.Trim(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out ngaySinh))
                {
                    MessageBox.Show("Vui lòng nhập ngày sinh theo định dạng dd/MM/yyyy", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool isSuccess = bus.CapNhatThongTin(hoTen, ngaySinh, gioiTinh, diaChi, sdt, email);

                if (isSuccess)
                    MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Cập nhật thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
