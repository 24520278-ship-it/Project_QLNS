using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace MainForm
{
    public partial class PhongBan : UserControl
    {
        public PhongBan()
        {
            InitializeComponent();
        }
        PhongBanBUS pbBUS = new PhongBanBUS();
        private void PhongBan_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            GridViewPB.DataSource = pbBUS.GetListPhongBan();
            if (GridViewPB.Columns["NHANVIENs"] != null)
            {
                GridViewPB.Columns["NHANVIENs"].Visible = false;
            }
            if (GridViewPB.Columns.Count > 0)
            {
                GridViewPB.Columns["MaPB"].HeaderText = "Mã PB";
                GridViewPB.Columns["MaPB"].Width = 100; 
                GridViewPB.Columns["TenPB"].HeaderText = "Tên Phòng Ban";
                GridViewPB.Columns["TenPB"].Width = 250; 
                GridViewPB.Columns["DiaDiem"].HeaderText = "Địa Điểm";
                GridViewPB.Columns["DiaDiem"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void GridViewPB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = GridViewPB.Rows[e.RowIndex];
                txb_TenPB.Text = row.Cells["TenPB"].Value?.ToString();
                txb_DD.Text = row.Cells["DiaDiem"].Value?.ToString();
            }
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            string ten = txb_TenPB.Text.Trim();
            string diaDiem = txb_DD.Text.Trim();
            if (string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(diaDiem))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Tên phòng ban và Địa điểm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                if (pbBUS.ThemPhongBan(ten, diaDiem))
                {
                    MessageBox.Show("Thêm phòng ban thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txb_TenPB.Text = "";
                    txb_DD.Text = "";
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
            string maPB = GridViewPB.CurrentRow.Cells["MaPB"].Value.ToString();
            string tenMoi = txb_TenPB.Text.Trim();
            string diaDiemMoi = txb_DD.Text.Trim();

            if (string.IsNullOrEmpty(tenMoi) || string.IsNullOrEmpty(diaDiemMoi))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Tên phòng ban và Địa điểm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                if (pbBUS.SuaPhongBan(maPB, tenMoi, diaDiemMoi))
                {
                    MessageBox.Show("Cập nhật thông tin phòng ban thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txb_TenPB.Text = "";
                    txb_DD.Text = "";
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
            string maPB = GridViewPB.CurrentRow.Cells["MaPB"].Value.ToString();
            string tenPB = GridViewPB.CurrentRow.Cells["TenPB"].Value.ToString();
            DialogResult dialogResult = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa phòng ban '{tenPB}' không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    if (pbBUS.XoaPhongBan(maPB))
                    {
                        MessageBox.Show("Xóa phòng ban thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txb_TenPB.Text = "";
                        txb_DD.Text = "";
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
