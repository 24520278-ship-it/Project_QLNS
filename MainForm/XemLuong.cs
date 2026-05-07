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
    public partial class XemLuong : UserControl
    {
        private XemLuongBUS bus = new XemLuongBUS();
        public XemLuong()
        {
            InitializeComponent();
        }

        private void btn_Xem_Click(object sender, EventArgs e)
        {
            try
            {
                var thangText = txb_Thang.Text.Trim();
                var namText = txb_Nam.Text.Trim();

                if (!int.TryParse(thangText, out int thang))
                {
                    MessageBox.Show("Vui lòng nhập đúng tháng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(namText, out int nam))
                {
                    MessageBox.Show("Vui lòng nhập đúng năm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var dsLuong = bus.LayThongTinLuong(thang, nam) as IEnumerable<dynamic>;
                var luong = dsLuong?.FirstOrDefault();
                if (luong != null)
                {
                    txb_NgayLam.Text = luong.SoNgayLam.ToString();
                    txb_NghiCoPhep.Text = luong.SoNgayNghiCoPhep.ToString();
                    txb_NghiKhongPhep.Text = luong.SoNgayNghiKhongPhep.ToString();
                    txb_PhuCap.Text = luong.TongPhuCap.ToString("N0") + " VNĐ";
                    txb_TongTru.Text = luong.TongTru.ToString("N0") + " VNĐ";
                    txb_ThucNhan.Text = luong.TongLuong.ToString("N0") + " VNĐ";
                }
                else
                {
                    XoaTrangThongTin();
                    MessageBox.Show($"Lương tháng {thang}/{nam} chưa có dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void XoaTrangThongTin()
        {
            txb_NgayLam.Clear();
            txb_NghiCoPhep.Clear();
            txb_NghiKhongPhep.Clear();
            txb_PhuCap.Clear();
            txb_TongTru.Clear();
            txb_ThucNhan.Clear();
        }
    }
}
