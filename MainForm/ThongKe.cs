using BusinessLayer;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class ThongKe : UserControl
    {
        ThongKeBUS bus = new ThongKeBUS();
        public ThongKe()
        {
            InitializeComponent();
            rad_TheoPhongBan.Checked = true;
        }

        private void btn_XuatThongKe_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txb_Thang.Text.Trim(), out int thang) ||
                    !int.TryParse(txb_Nam.Text.Trim(), out int nam))
                {
                    MessageBox.Show("Vui lòng nhập tháng và năm hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool isPhongBan = rad_TheoPhongBan.Checked;
                string tenLoaiBaoCao = isPhongBan ? "PHÒNG BAN" : "CHỨC VỤ";
                var dsThongKe = bus.LayDuLieuThongKe(thang, nam, isPhongBan) as IEnumerable<dynamic>;

                if (dsThongKe == null || !dsThongKe.Any())
                {
                    MessageBox.Show($"Không có dữ liệu lương trong tháng {thang}/{nam}.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF File|*.pdf";
                sfd.FileName = $"BaoCaoThongKe_{tenLoaiBaoCao}_{thang}_{nam}.pdf";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    XuatBaoCaoThongKePDF(sfd.FileName, dsThongKe, thang, nam, tenLoaiBaoCao);
                    MessageBox.Show("Xuất báo cáo thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void XuatBaoCaoThongKePDF(string filePath, IEnumerable<dynamic> dsThongKe, int thang, int nam, string loaiBaoCao)
        {
            Document doc = new Document(PageSize.A4, 20f, 20f, 30f, 30f);
            PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
            doc.Open();

            // Cài đặt Font Tiếng Việt
            string fontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.ttf");
            BaseFont bf = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            iTextSharp.text.Font fontTitle = new iTextSharp.text.Font(bf, 16, iTextSharp.text.Font.BOLD, BaseColor.RED);
            iTextSharp.text.Font fontHeader = new iTextSharp.text.Font(bf, 11, iTextSharp.text.Font.BOLD);
            iTextSharp.text.Font fontNormal = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
            iTextSharp.text.Font fontBoldInfo = new iTextSharp.text.Font(bf, 11, iTextSharp.text.Font.BOLD);

            // Header
            Paragraph title = new Paragraph($"BÁO CÁO THỐNG KÊ CHI PHÍ LƯƠNG THEO {loaiBaoCao}\nTháng {thang} / Năm {nam}", fontTitle);
            title.Alignment = Element.ALIGN_CENTER;
            doc.Add(title);
            doc.Add(new Chunk("\n"));

            // Body
            PdfPTable table = new PdfPTable(6);
            table.WidthPercentage = 100;
            table.SetWidths(new float[] { 1f, 4f, 2f, 3f, 3f, 2f });
            string column2Name = loaiBaoCao == "PHÒNG BAN" ? "Tên Phòng Ban" : "Tên Chức Vụ";
            string[] headers = { "STT", column2Name, "Số NV", "Tổng Lương Chi Trả", "Lương trung bình", "Tỷ lệ (%)" };

            foreach (string h in headers)
            {
                PdfPCell cell = new PdfPCell(new Phrase(h, fontHeader));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                cell.BackgroundColor = new BaseColor(230, 230, 230);
                cell.PaddingBottom = 6f;
                table.AddCell(cell);
            }

            decimal grandTotal = 0;
            int stt = 1;
            foreach (var item in dsThongKe)
            {
                PdfPCell cellSTT = new PdfPCell(new Phrase(stt.ToString(), fontNormal));
                cellSTT.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cellSTT);

                table.AddCell(new Phrase(item.TenGoi.ToString(), fontNormal));

                PdfPCell cellSoNV = new PdfPCell(new Phrase(item.SoNhanVien.ToString(), fontNormal));
                cellSoNV.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cellSoNV);

                decimal tongLuong = Convert.ToDecimal(item.TongLuong);
                grandTotal += tongLuong; 

                PdfPCell cellTong = new PdfPCell(new Phrase(tongLuong.ToString("N0") + " đ", fontNormal));
                cellTong.HorizontalAlignment = Element.ALIGN_RIGHT;
                table.AddCell(cellTong);

                decimal luongTB = Convert.ToDecimal(item.LuongTrungBinh);
                PdfPCell cellTB = new PdfPCell(new Phrase(luongTB.ToString("N0") + " đ", fontNormal));
                cellTB.HorizontalAlignment = Element.ALIGN_RIGHT;
                table.AddCell(cellTB);

                decimal tyLe = Convert.ToDecimal(item.TyLe);
                PdfPCell cellTyLe = new PdfPCell(new Phrase(tyLe.ToString("0.00") + " %", fontNormal));
                cellTyLe.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cellTyLe);

                stt++;
            }

            PdfPCell cellEmpty = new PdfPCell(new Phrase("TỔNG CỘNG:", fontHeader));
            cellEmpty.Colspan = 3; 
            cellEmpty.HorizontalAlignment = Element.ALIGN_RIGHT;
            table.AddCell(cellEmpty);

            PdfPCell cellGrandTotal = new PdfPCell(new Phrase(grandTotal.ToString("N0") + " đ", fontHeader));
            cellGrandTotal.HorizontalAlignment = Element.ALIGN_RIGHT;
            table.AddCell(cellGrandTotal);

            PdfPCell cellBlank = new PdfPCell(new Phrase("-", fontHeader));
            cellBlank.HorizontalAlignment = Element.ALIGN_CENTER;
            table.AddCell(cellBlank);

            PdfPCell cellTyLeTong = new PdfPCell(new Phrase("100.00 %", fontHeader));
            cellTyLeTong.HorizontalAlignment = Element.ALIGN_CENTER;
            table.AddCell(cellTyLeTong);

            // Footer
            doc.Add(table);
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
