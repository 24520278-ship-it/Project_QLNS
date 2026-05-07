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
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace MainForm
{
    public partial class TinhLuong : UserControl
    {
        public TinhLuong()
        {
            InitializeComponent();
        }
        TinhLuongBUS luongBUS = new TinhLuongBUS();
        private void FormTinhLuong_Load(object sender, EventArgs e)
        {
            SetupGridView();
        }
        private void SetupGridView()
        {
            GridView_BangLuong.Columns.Clear();
            GridView_BangLuong.AutoGenerateColumns = false;
            GridView_BangLuong.AllowUserToAddRows = false; 
            GridView_BangLuong.ReadOnly = true;      

            GridView_BangLuong.Columns.Add(new DataGridViewTextBoxColumn { Name = "colMaNV", HeaderText = "Mã NV", DataPropertyName = "MaNV", Width = 80 });
            GridView_BangLuong.Columns.Add(new DataGridViewTextBoxColumn { Name = "colHoTen", HeaderText = "Họ Tên", DataPropertyName = "HoTen", Width = 160 });
            GridView_BangLuong.Columns.Add(new DataGridViewTextBoxColumn { Name = "colNgayLam", HeaderText = "Ngày Làm", DataPropertyName = "SoNgayLam", Width = 100 });
            GridView_BangLuong.Columns.Add(new DataGridViewTextBoxColumn { Name = "colCoPhep", HeaderText = "Nghỉ (Có phép)", DataPropertyName = "CoPhep", Width = 150 });
            GridView_BangLuong.Columns.Add(new DataGridViewTextBoxColumn { Name = "colKhongPhep", HeaderText = "Nghỉ (Không phép)", DataPropertyName = "KhongPhep", Width = 160 });
            DataGridViewTextBoxColumn colPhuCap = new DataGridViewTextBoxColumn { Name = "colPhuCap", HeaderText = "Phụ Cấp", DataPropertyName = "TongPhuCap", Width = 100 };
            colPhuCap.DefaultCellStyle.Format = "N0";
            GridView_BangLuong.Columns.Add(colPhuCap);

            DataGridViewTextBoxColumn colKhauTru = new DataGridViewTextBoxColumn { Name = "colKhauTru", HeaderText = "Khấu Trừ", DataPropertyName = "TongTru", Width = 100 };
            colKhauTru.DefaultCellStyle.Format = "N0";
            GridView_BangLuong.Columns.Add(colKhauTru);

            DataGridViewTextBoxColumn colThucLanh = new DataGridViewTextBoxColumn { Name = "colThucLanh", HeaderText = "Thực Lãnh", DataPropertyName = "TongLuong", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill };
            colThucLanh.DefaultCellStyle.Format = "N0";
            colThucLanh.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 9, FontStyle.Bold);
            colThucLanh.DefaultCellStyle.ForeColor = Color.Red;
            GridView_BangLuong.Columns.Add(colThucLanh);
        }
        private void LoadData(int thang, int nam, bool hienThongBao = true)
        {
            var danhSachLuong = luongBUS.LayBangLuongTheoThang(thang, nam);
            GridView_BangLuong.DataSource = danhSachLuong;

            if (hienThongBao && GridView_BangLuong.Rows.Count == 0)
            {
                MessageBox.Show($"Đã chạy xong nhưng không tìm thấy nhân viên nào đủ điều kiện tính lương trong Tháng {thang}/{nam}.",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btn_TinhLuong_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txb_Thang.Text.Trim(), out int thang) || thang < 1 || thang > 12)
            {
                MessageBox.Show("Tháng không hợp lệ (1 - 12)!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txb_Thang.Focus();
                return;
            }

            if (!int.TryParse(txb_Nam.Text.Trim(), out int nam) || nam < 2000)
            {
                MessageBox.Show("Năm không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txb_Nam.Focus();
                return;
            }

            if (!decimal.TryParse(txb_CongChuan.Text.Trim(), out decimal congChuan) || congChuan <= 0)
            {
                MessageBox.Show("Số ngày công chuẩn phải là số lớn hơn 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txb_CongChuan.Focus();
                return;
            }
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                luongBUS.ThucThiTinhLuong(thang, nam, congChuan);
                LoadData(thang, nam);
                Cursor.Current = Cursors.Default;
                MessageBox.Show($"Đã chốt bảng lương tháng {thang}/{nam} thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show(ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_ImportCSV_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";
            openFileDialog.Title = "Chọn file chấm công chuẩn";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    ChamCongBUS ccBUS = new ChamCongBUS();
                    ccBUS.ImportCSV(openFileDialog.FileName);

                    Cursor.Current = Cursors.Default;
                    MessageBox.Show("Đã nạp toàn bộ dữ liệu chấm công thành công!",
                                    "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (System.Data.Entity.Infrastructure.DbUpdateException)
                {
                    Cursor.Current = Cursors.Default;
                    MessageBox.Show("Lỗi: Không thể lưu vào CSDL.\nVì bảng chấm công tháng này đã có trong CSDL.",
                                    "Lỗi Dữ Liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    Cursor.Current = Cursors.Default;
                    MessageBox.Show("Lỗi định dạng file: " + ex.Message,
                                    "Lỗi File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_XuatBangLuong_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txb_Thang.Text.Trim(), out int thang) || !int.TryParse(txb_Nam.Text.Trim(), out int nam))
            {
                MessageBox.Show("Vui lòng nhập Tháng và Năm trước khi xuất báo cáo!", "Cảnh báo");
                return;
            }
            LoadData(thang, nam, false);
            if (GridView_BangLuong.Rows.Count == 0)
            {
                MessageBox.Show($"Tháng {thang}/{nam} chưa được tính lương. Bạn cần bấm 'Tính Lương' trước khi xuất báo cáo!",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF Document (*.pdf)|*.pdf";
            sfd.FileName = $"BangLuong_Thang_{thang}_{nam}.pdf";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    XuatBaoCaoPDF(sfd.FileName, thang, nam);
                    Cursor.Current = Cursors.Default;
                    MessageBox.Show("Xuất báo cáo thành công!");
                }
                catch (Exception ex)
                {
                    Cursor.Current = Cursors.Default;
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
        private void XuatBaoCaoPDF(string filePath, int thang, int nam)
        {
            Document doc = new Document(PageSize.A4.Rotate(), 20f, 20f, 30f, 30f);
            PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
            doc.Open();

            // Cài đặt Font Tiếng Việt Unicode
            string fontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.ttf");
            BaseFont bf = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);

            iTextSharp.text.Font fontTitle = new iTextSharp.text.Font(bf, 16, iTextSharp.text.Font.BOLD, BaseColor.RED);
            iTextSharp.text.Font fontHeader = new iTextSharp.text.Font(bf, 11, iTextSharp.text.Font.BOLD);
            iTextSharp.text.Font fontNormal = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
            iTextSharp.text.Font fontBoldInfo = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.BOLD);

            // Header
            Paragraph title = new Paragraph($"BÁO CÁO LƯƠNG THÁNG {thang} / {nam}", fontTitle);
            title.Alignment = Element.ALIGN_CENTER;
            doc.Add(title);
            doc.Add(new Chunk("\n"));

            // Body (9 cột)
            PdfPTable table = new PdfPTable(9);
            table.WidthPercentage = 100;

            float[] widths = new float[] { 1f, 2f, 4f, 2f, 2.5f, 3f, 2.5f, 2.5f, 3f };
            table.SetWidths(widths);

            string[] headers = { "STT", "Mã NV", "Họ Tên", "Ngày Làm", "Nghỉ (Có phép)", "Nghỉ (Không phép)", "Phụ Cấp", "Khấu Trừ", "Thực Lãnh" };
            foreach (string h in headers)
            {
                PdfPCell cell = new PdfPCell(new Phrase(h, fontHeader));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                cell.BackgroundColor = new BaseColor(240, 240, 240);
                cell.PaddingBottom = 5f;
                table.AddCell(cell);
            }

            decimal tongChi = 0;
            int stt = 1; 

            foreach (DataGridViewRow row in GridView_BangLuong.Rows)
            {
                if (row.IsNewRow) continue;
                PdfPCell cellSTT = new PdfPCell(new Phrase(stt.ToString(), fontNormal));
                cellSTT.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cellSTT);

                table.AddCell(new Phrase(row.Cells["colMaNV"].Value?.ToString(), fontNormal));
                table.AddCell(new Phrase(row.Cells["colHoTen"].Value?.ToString(), fontNormal));

                PdfPCell cellNgayLam = new PdfPCell(new Phrase(row.Cells["colNgayLam"].Value?.ToString(), fontNormal));
                cellNgayLam.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cellNgayLam);

                PdfPCell cellCoPhep = new PdfPCell(new Phrase(row.Cells["colCoPhep"].Value?.ToString(), fontNormal));
                cellCoPhep.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cellCoPhep);

                PdfPCell cellKhongPhep = new PdfPCell(new Phrase(row.Cells["colKhongPhep"].Value?.ToString(), fontNormal));
                cellKhongPhep.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cellKhongPhep);

                PdfPCell cellPhuCap = new PdfPCell(new Phrase(Convert.ToDecimal(row.Cells["colPhuCap"].Value).ToString("N0"), fontNormal));
                cellPhuCap.HorizontalAlignment = Element.ALIGN_RIGHT;
                table.AddCell(cellPhuCap);

                PdfPCell cellKhauTru = new PdfPCell(new Phrase(Convert.ToDecimal(row.Cells["colKhauTru"].Value).ToString("N0"), fontNormal));
                cellKhauTru.HorizontalAlignment = Element.ALIGN_RIGHT;
                table.AddCell(cellKhauTru);

                decimal thucLanh = Convert.ToDecimal(row.Cells["colThucLanh"].Value);
                tongChi += thucLanh;

                PdfPCell cellThucLanh = new PdfPCell(new Phrase(thucLanh.ToString("N0"), fontNormal));
                cellThucLanh.HorizontalAlignment = Element.ALIGN_RIGHT;
                table.AddCell(cellThucLanh);

                stt++;
            }

            // Footer
            doc.Add(table);
            doc.Add(new Chunk("\n"));
            Paragraph pTongChi = new Paragraph($"TỔNG CHI CỦA CÔNG TY: {tongChi:N0} VNĐ", fontBoldInfo);
            pTongChi.Alignment = Element.ALIGN_LEFT;
            doc.Add(pTongChi);
            doc.Add(new Chunk("\n"));

            PdfPTable signTable = new PdfPTable(2);
            signTable.WidthPercentage = 100;

            PdfPCell cellLeft = new PdfPCell(new Phrase("Người lập bảng\n(Ký, ghi rõ họ tên)", fontNormal));
            cellLeft.Border = iTextSharp.text.Rectangle.NO_BORDER;
            cellLeft.HorizontalAlignment = Element.ALIGN_CENTER;
            signTable.AddCell(cellLeft);

            string ngayThang = $"TP.Hồ Chí Minh, ngày {DateTime.Now.Day:D2} tháng {DateTime.Now.Month:D2} năm {DateTime.Now.Year}\n";
            Paragraph pRight = new Paragraph();
            pRight.Add(new Chunk(ngayThang, fontNormal));
            pRight.Add(new Chunk("Đại diện Công ty Nhóm 10\n(Ký, đóng dấu)", fontBoldInfo));

            PdfPCell cellRight = new PdfPCell(pRight);
            cellRight.Border = iTextSharp.text.Rectangle.NO_BORDER;
            cellRight.HorizontalAlignment = Element.ALIGN_CENTER;
            signTable.AddCell(cellRight);

            doc.Add(signTable); 
            doc.Close();

        }
    }
}
