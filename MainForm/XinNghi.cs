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
using DataLayer;

namespace MainForm
{
    public partial class XinNghi : UserControl
    {
        private XinNghiBUS bus = new XinNghiBUS();
        public XinNghi()
        {
            InitializeComponent();
        }
        private void XinNghi_Load(object sender, EventArgs e)
        {
            txb_MaNV.Text = UserSession.MaNV;
            LoadDanhSachDon();
        }
        private void LoadDanhSachDon()
        {
            try
            {
                GridView_Don.DataSource = bus.LayDanhSachDon();
                if (GridView_Don.Columns.Count > 0)
                {
                    GridView_Don.Columns["MaDon"].HeaderText = "Mã đơn";
                    GridView_Don.Columns["MaDon"].Width = 80;
                    GridView_Don.Columns["TuNgay"].HeaderText = "Ngày Bắt Đầu";
                    GridView_Don.Columns["TuNgay"].DefaultCellStyle.Format = "dd/MM/yyyy";
                    GridView_Don.Columns["TuNgay"].Width = 110;
                    GridView_Don.Columns["DenNgay"].HeaderText = "Ngày Kết Thúc";
                    GridView_Don.Columns["DenNgay"].DefaultCellStyle.Format = "dd/MM/yyyy";
                    GridView_Don.Columns["DenNgay"].Width = 110;
                    GridView_Don.Columns["LyDo"].HeaderText = "Lý Do";
                    GridView_Don.Columns["LyDo"].Width = 250;
                    GridView_Don.Columns["TrangThai"].HeaderText = "Trạng Thái";
                    GridView_Don.Columns["TrangThai"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách: " + ex.Message, "Thông báo hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Nop_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime tuNgay, denNgay;
                if (!DateTime.TryParseExact(txb_NgayBD.Text.Trim(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out tuNgay) ||
                    !DateTime.TryParseExact(txb_NgayKT.Text.Trim(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out denNgay))
                {
                    MessageBox.Show("Vui lòng nhập ngày theo định dạng dd/MM/yyyy", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string lyDo = txb_LyDo.Text.Trim();
                if (string.IsNullOrEmpty(lyDo))
                {
                    MessageBox.Show("Vui lòng nhập lý do xin nghỉ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool isSuccess = bus.NopDon(tuNgay, denNgay, lyDo);
                if (isSuccess)
                {
                    MessageBox.Show("Nộp đơn xin nghỉ thành công! Đơn đang ở trạng thái Chờ duyệt.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachDon(); 
                    txb_NgayBD.Clear();
                    txb_NgayKT.Clear();
                    txb_LyDo.Clear();
                }
                else
                {
                    MessageBox.Show("Nộp đơn thất bại, vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Exception loiGoc = ex;
                while (loiGoc.InnerException != null)
                {
                    loiGoc = loiGoc.InnerException;
                }
                MessageBox.Show(loiGoc.Message, "Cảnh báo dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
