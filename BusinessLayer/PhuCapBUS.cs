using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class PhuCapBUS
    {
        QLNSEntities db = new QLNSEntities();
        public object GetListPhuCap()
        {
            try
            {
                using (var db = new QLNSEntities())
                {
                    return db.sp_GetListPhuCap().ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tải danh mục phụ cấp: " + ex.Message);
            }
        }
        public bool ThemPhuCap(string tenPC, decimal soTien)
        {
            try
            {
                db.sp_ThemPhuCap(tenPC, (decimal?)soTien);
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
        public bool SuaPhuCap(string maPC, string tenPCMoi, decimal soTienMoi)
        {
            try
            {
                db.sp_SuaPhuCap(maPC, tenPCMoi, soTienMoi);
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
        public bool XoaPhuCap(string maPC)
        {
            try
            {
                db.sp_XoaPhuCap(maPC);
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
