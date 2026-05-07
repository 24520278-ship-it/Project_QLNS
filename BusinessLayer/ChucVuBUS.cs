using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class ChucVuBUS
    {
        QLNSEntities db = new QLNSEntities();
        public object GetListChucVu()
        {
            try
            {
                using (var db = new QLNSEntities())
                {
                    return db.sp_GetListChucVu().ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tải danh mục phụ cấp: " + ex.Message);
            }
        }
        public bool ThemChucVu(string tenCV)
        {
            try
            {
                db.sp_ThemChucVu(tenCV);
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
        public bool SuaChucVu(string maCV, string tenCVMoi)
        {
            try
            {
                db.sp_SuaChucVu(maCV, tenCVMoi);
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
        public bool XoaChucVu(string maCV)
        {
            try
            {
                db.sp_XoaChucVu(maCV);
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
    }
}
