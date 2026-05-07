using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class PhongBanBUS
    {
        QLNSEntities db = new QLNSEntities();
        public object GetListPhongBan()
        {
            try
            {
                using (var db = new QLNSEntities())
                {
                    return db.sp_GetListPhongBan().ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tải danh mục phụ cấp: " + ex.Message);
            }
        }
        public bool ThemPhongBan(string tenPB, string diaDiem)
        {
            try
            {
                db.sp_ThemPhongBan(tenPB, diaDiem);
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
        public bool SuaPhongBan(string maPB, string tenPBMoi, string diaDiemMoi)
        {
            try
            {
                db.sp_SuaPhongBan(maPB, tenPBMoi, diaDiemMoi);
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
        public bool XoaPhongBan(string maPB)
        {
            try
            {
                db.sp_XoaPhongBan(maPB);
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
