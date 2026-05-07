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
    public partial class ChucVu : UserControl
    {
        public ChucVu()
        {
            InitializeComponent();
        }
        ChucVuBUS cvBUS = new ChucVuBUS();
        private void LoadData()
        {
            try
            {
                GridViewCV.DataSource = cvBUS.GetListChucVu();
                if (GridViewCV.Columns.Count > 0)
                {
                    GridViewCV.Columns["MaCV"].HeaderText = "Mã Chức Vụ";
                    GridViewCV.Columns["TenCV"].HeaderText = "Tên Chức Vụ";
                    GridViewCV.Columns["TenCV"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FormChucVu_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void GridViewPB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = GridViewCV.Rows[e.RowIndex];
                txb_TenCV.Text = row.Cells["TenCV"].Value?.ToString();
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string tenCV = txb_TenCV.Text.Trim();
            if (string.IsNullOrEmpty(tenCV))
            {
                MessageBox.Show("Vui lòng nhập tên chức vụ cần thêm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txb_TenCV.Focus();
                return;
            }
            try
            {
                cvBUS.ThemChucVu(tenCV);
                MessageBox.Show("Thêm chức vụ mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txb_TenCV.Text = "";
                txb_TenCV.Focus();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi thêm mới", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string maCV = GridViewCV.CurrentRow.Cells["MaCV"].Value.ToString();
            string tenMoi = txb_TenCV.Text.Trim();
            if (string.IsNullOrEmpty(maCV))
            {
                MessageBox.Show("Vui lòng chọn một chức vụ trên danh sách để sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(tenMoi) )
            {
                MessageBox.Show("Vui lòng nhập tên chức vụ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                if (cvBUS.SuaChucVu(maCV, tenMoi))
                {
                    MessageBox.Show("Cập nhật thông tin chức vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txb_TenCV.Text = "";
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
            string maCV = GridViewCV.CurrentRow.Cells["MaCV"].Value.ToString();
            string tenCV = txb_TenCV.Text.Trim();
            if (string.IsNullOrEmpty(maCV))
            {
                MessageBox.Show("Vui lòng chọn một chức vụ trên danh sách để sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dialogResult = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa chức vụ '{tenCV}' không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    if (cvBUS.XoaChucVu(maCV))
                    {
                        MessageBox.Show("Xóa phòng ban thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txb_TenCV.Text = "";
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
