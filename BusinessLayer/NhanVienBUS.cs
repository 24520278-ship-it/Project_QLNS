using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class NhanVienBUS
    {
        QLNSEntities db = new QLNSEntities();
        public object GetListNhanVien(bool hienThiTatCa, string tuKhoa = "")
        {
            try
            {
                using (var db = new QLNSEntities())
                {
                    return db.sp_GetListNhanVien(hienThiTatCa, tuKhoa).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tải danh sách nhân viên: " + ex.Message);
            }
        }
        public bool ThemNhanVien(string hoTen, DateTime? ngaySinh, string gioiTinh, string diaChi, string sdt, string email, string tenCV, string tenPB)
        {
            try
            {
                db.sp_ThemNhanVien(hoTen, ngaySinh, gioiTinh, diaChi, sdt, email, tenCV, tenPB);
                return true;
            }
            catch (Exception ex)
            {
                Exception innerEx = ex;
                while (innerEx.InnerException != null)
                {
                    innerEx = innerEx.InnerException;
                }
                throw new Exception(innerEx.Message);
            }
        }
        public bool SuaNhanVien(string maNV, string hoTen, DateTime? ngaySinh, string gioiTinh, string diaChi, string sdt, string email, string tenCV, string tenPB)
        {
            try
            {
                db.sp_SuaNhanVien(maNV, hoTen, ngaySinh, gioiTinh, diaChi, sdt, email, tenCV, tenPB);
                return true;
            }
            catch (Exception ex)
            {
                Exception innerEx = ex;
                while (innerEx.InnerException != null)
                {
                    innerEx = innerEx.InnerException;
                }
                throw new Exception(innerEx.Message);
            }
        }
        public bool ChoNghiViec(string maNV)
        {
            try
            {
                db.sp_ChoNghiViec(maNV);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật trạng thái nghỉ việc: " + ex.Message);
            }
        }

    }
}
