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
    public partial class DuyetDon : UserControl
    {
        public DuyetDon()
        {
            InitializeComponent();
        }
        private void SetupGridView()
        {
            GridView_DuyetDon.Columns.Clear();
            GridView_DuyetDon.AutoGenerateColumns = false;

            // --- 1. TẠO CÁC CỘT DỮ LIỆU ---

            DataGridViewTextBoxColumn colMaDon = new DataGridViewTextBoxColumn();
            colMaDon.Name = "colMaDon";
            colMaDon.HeaderText = "Mã Đơn";
            colMaDon.DataPropertyName = "MaDon"; 
            colMaDon.Width = 80;
            GridView_DuyetDon.Columns.Add(colMaDon);

            DataGridViewTextBoxColumn colHoTen = new DataGridViewTextBoxColumn();
            colHoTen.Name = "colHoTen";
            colHoTen.HeaderText = "Họ Tên Nhân Viên";
            colHoTen.DataPropertyName = "HoTen";
            colHoTen.Width = 150;
            GridView_DuyetDon.Columns.Add(colHoTen);

            DataGridViewTextBoxColumn colTuNgay = new DataGridViewTextBoxColumn();
            colTuNgay.Name = "colTuNgay";
            colTuNgay.HeaderText = "Từ Ngày";
            colTuNgay.DataPropertyName = "TuNgay";
            colTuNgay.DefaultCellStyle.Format = "dd/MM/yyyy"; 
            GridView_DuyetDon.Columns.Add(colTuNgay);

            DataGridViewTextBoxColumn colDenNgay = new DataGridViewTextBoxColumn();
            colDenNgay.Name = "colDenNgay";
            colDenNgay.HeaderText = "Đến Ngày";
            colDenNgay.DataPropertyName = "DenNgay";
            colDenNgay.DefaultCellStyle.Format = "dd/MM/yyyy";
            GridView_DuyetDon.Columns.Add(colDenNgay);

            DataGridViewTextBoxColumn colLyDo = new DataGridViewTextBoxColumn();
            colLyDo.Name = "colLyDo";
            colLyDo.HeaderText = "Lý Do Nghỉ";
            colLyDo.DataPropertyName = "LyDo";
            colLyDo.Width = 300; 
            GridView_DuyetDon.Columns.Add(colLyDo);

            DataGridViewTextBoxColumn colTrangThai = new DataGridViewTextBoxColumn();
            colTrangThai.Name = "colTrangThai";
            colTrangThai.HeaderText = "Trạng Thái";
            colTrangThai.DataPropertyName = "TrangThaiHienThi";
            GridView_DuyetDon.Columns.Add(colTrangThai);

            DataGridViewButtonColumn btnDuyet = new DataGridViewButtonColumn();
            btnDuyet.Name = "colDuyet";
            btnDuyet.HeaderText = "";
            btnDuyet.Text = "Duyệt ✅";
            btnDuyet.UseColumnTextForButtonValue = true;
            btnDuyet.Width = 80;
            GridView_DuyetDon.Columns.Add(btnDuyet);

            DataGridViewButtonColumn btnTuChoi = new DataGridViewButtonColumn();
            btnTuChoi.Name = "colTuChoi";
            btnTuChoi.HeaderText = ""; 
            btnTuChoi.Text = "Từ chối ❌";
            btnTuChoi.UseColumnTextForButtonValue = true;
            btnTuChoi.Width = 80;
            GridView_DuyetDon.Columns.Add(btnTuChoi);
        }
        DuyetDonBUS ddBUS = new DuyetDonBUS();
        private void DuyetDon_Load(object sender, EventArgs e)
        {
            LoaiDon.Items.Clear();
            LoaiDon.Items.Add("Chờ duyệt"); // Index = 0
            LoaiDon.Items.Add("Đã duyệt");  // Index = 1
            LoaiDon.Items.Add("Từ chối");   // Index = 2

            SetupGridView();

            // CHỈ CẦN DÒNG NÀY LÀ ĐỦ: Nó sẽ kích hoạt sự kiện SelectedIndexChanged -> tự gọi LoadData() với index = 0
            LoaiDon.SelectedIndex = 0;
        }

        private void LoadData()
        {
            int filterStatus = LoaiDon.SelectedIndex;

            // CHỐT CHẶN: Nếu ComboBox chưa chọn gì (-1) thì thoát luôn, không làm gì cả
            if (filterStatus < 0) return;

            GridView_DuyetDon.DataSource = ddBUS.LayDanhSachDon(filterStatus);

            // Ẩn hiện cột nút bấm (Phải kiểm tra xem cột đã tồn tại chưa để chống lỗi văng app)
            bool isPending = (filterStatus == 0);
            if (GridView_DuyetDon.Columns.Contains("colDuyet"))
                GridView_DuyetDon.Columns["colDuyet"].Visible = isPending;
            if (GridView_DuyetDon.Columns.Contains("colTuChoi"))
                GridView_DuyetDon.Columns["colTuChoi"].Visible = isPending;
        }

        private void LoaiDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void GridView_DuyetDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // 1. Lấy MaDon từ cột tương ứng (Phải đảm bảo cột MaDon đã được Setup DataPropertyName)
            string maDon = GridView_DuyetDon.Rows[e.RowIndex].Cells["colMaDon"].Value.ToString();
            string tenNV = GridView_DuyetDon.Rows[e.RowIndex].Cells["colHoTen"].Value.ToString();

            // 2. Xử lý nút Duyệt
            if (GridView_DuyetDon.Columns[e.ColumnIndex].Name == "colDuyet")
            {
                if (MessageBox.Show($"Xác nhận DUYỆT đơn của {tenNV}?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (ddBUS.CapNhatTrangThai(maDon, 1)) 
                    {
                        MessageBox.Show("Đã duyệt thành công!");
                        LoadData();
                    }
                }
            }
            if (GridView_DuyetDon.Columns[e.ColumnIndex].Name == "colTuChoi")
            {
                if (MessageBox.Show($"Từ chối đơn của {tenNV}?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (ddBUS.CapNhatTrangThai(maDon, 2)) // 2: Từ chối
                    {
                        MessageBox.Show("Đã từ chối đơn.");
                        LoadData();
                    }
                }
            }
        }
    }
}
