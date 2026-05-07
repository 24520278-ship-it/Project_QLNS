using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class HopDongBUS
    {
        QLNSEntities db = new QLNSEntities();
        public object GetDanhSachHopDong(string tuKhoa = "")
        {
            try
            {
                using (var db = new QLNSEntities())
                {
                    return db.sp_GetDanhSachHopDong(tuKhoa).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tải danh sách hợp đồng: " + ex.Message);
            }
        }
        public string KiemTraVaLayTenNhanVien(string maNV)
        {
            db = new QLNSEntities();
            var nv = db.NHANVIENs.FirstOrDefault(x => x.MaNV == maNV);
            return nv != null ? nv.HoTen : null;
        }
        public bool ThemHopDong(DateTime? ngayBD, DateTime? ngayKT, DateTime? ngayKy, decimal mucLuong, string maNV)
        {
            try
            {
                db.sp_ThemHopDong(ngayBD, ngayKT, ngayKy, mucLuong, maNV);
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
        public bool SuaHopDong(string maHD, DateTime? ngayBD, DateTime? ngayKT, DateTime? ngayKy, decimal mucLuong, string maNV)
        {
            try
            {
                db.sp_SuaHopDong(maHD, ngayBD, ngayKT, ngayKy, mucLuong, maNV);
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
        public bool HuyHopDong(string maHD)
        {
            try
            {
                db.sp_HuyHopDong(maHD);
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
        public void TuDongCapNhatTrangThai()
        {
            try
            {
                db.sp_TuDongCapNhatTrangThaiHD();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi cập nhật trạng thái tự động: " + ex.Message);
            }
        }
    }
}
