using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class QLPhuCapBUS
    {
        QLNSEntities db = new QLNSEntities();
        public object GetListNhanPhuCap()
        {
            try
            {
                using (var db = new QLNSEntities())
                {
                    return db.sp_GetListNhanPhuCap().ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tải danh sách nhận phụ cấp: " + ex.Message);
            }
        }
        public string KiemTraVaLayTenNhanVien(string maNV)
        {
            db = new QLNSEntities();
            var nv = db.NHANVIENs.FirstOrDefault(x => x.MaNV == maNV);
            return nv != null ? nv.HoTen : null;
        }
        public bool ThemNhanPhuCap(string maNV, string tenPC, string noiDung)
        {
            try
            {
                db.sp_ThemNhanPhuCap(maNV, tenPC, noiDung);
                return true;
            }
            catch (Exception ex)
            {
                Exception inner = ex;
                while (inner.InnerException != null) inner = inner.InnerException;
                throw new Exception(inner.Message);
            }
        }
        public bool XoaNhanPhuCap(string maNV, string maPC)
        {
            try
            {
                db.sp_XoaNhanPhuCap(maNV, maPC);
                return true;
            }
            catch (Exception ex)
            {
                Exception inner = ex;
                while (inner.InnerException != null) inner = inner.InnerException;
                throw new Exception(inner.Message);
            }
        }
    }
}
