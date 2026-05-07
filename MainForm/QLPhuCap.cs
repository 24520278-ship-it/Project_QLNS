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
    public partial class QLPhuCap : UserControl
    {
        QLPhuCapBUS qlpcBUS = new QLPhuCapBUS();
        string maPCDangChon = "";
        public QLPhuCap()
        {
            InitializeComponent();
        }
        private void QLPhuCap_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            GridViewPC.DataSource = qlpcBUS.GetListNhanPhuCap();

            if (GridViewPC.Columns.Count > 0)
            {
                GridViewPC.Columns["MaNV"].HeaderText = "Mã NV";
                GridViewPC.Columns["MaNV"].Width = 90;
                GridViewPC.Columns["HoTen"].HeaderText = "Họ Tên";
                GridViewPC.Columns["HoTen"].Width = 180;
                GridViewPC.Columns["MaPC"].Visible = false; 
                GridViewPC.Columns["TenPC"].HeaderText = "Tên Phụ Cấp";
                GridViewPC.Columns["TenPC"].Width = 180;
                GridViewPC.Columns["NoiDung"].HeaderText = "Nội Dung";
                GridViewPC.Columns["NoiDung"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        private void GridViewPC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = GridViewPC.Rows[e.RowIndex];
                txb_MaNV.Text = row.Cells["MaNV"].Value?.ToString();
                txb_HoTen.Text = row.Cells["HoTen"].Value?.ToString();
                txb_TenPC.Text = row.Cells["TenPC"].Value?.ToString();
                txb_ND.Text = row.Cells["NoiDung"].Value?.ToString();
                maPCDangChon = row.Cells["MaPC"].Value?.ToString();
            }
        }
        private void txb_MaNV_Leave(object sender, EventArgs e)
        {
            string maNV = txb_MaNV.Text.Trim();
            if (!string.IsNullOrEmpty(maNV))
            {
                string hoTen = qlpcBUS.KiemTraVaLayTenNhanVien(maNV);
                txb_HoTen.Text = hoTen != null ? hoTen : "Không tìm thấy NV!";
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string maNV = txb_MaNV.Text.Trim();
            string tenPC = txb_TenPC.Text.Trim();
            string noiDung = txb_ND.Text.Trim();

            if (string.IsNullOrEmpty(maNV) || string.IsNullOrEmpty(tenPC))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã NV và Tên Phụ Cấp!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                if (qlpcBUS.ThemNhanPhuCap(maNV, tenPC, noiDung))
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    txb_MaNV.Text = ""; txb_HoTen.Text = ""; txb_TenPC.Text = ""; txb_ND.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi khi thêm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string maNV = txb_MaNV.Text.Trim();

            if (string.IsNullOrEmpty(maNV) || string.IsNullOrEmpty(maPCDangChon))
            {
                MessageBox.Show("Vui lòng chọn 1 dòng trên bảng để xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show($"Bạn có chắc muốn xóa phụ cấp này của nhân viên [{maNV}] không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    if (qlpcBUS.XoaNhanPhuCap(maNV, maPCDangChon))
                    {
                        MessageBox.Show("Đã xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        txb_MaNV.Text = ""; txb_HoTen.Text = ""; txb_TenPC.Text = ""; txb_ND.Text = "";
                        maPCDangChon = ""; 
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi khi xóa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
