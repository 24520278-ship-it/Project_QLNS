using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class XemLuongBUS
    {
        public object LayThongTinLuong(int thang, int nam)
        {
            var db = new QLNSEntities();
            try
            {
                return db.sp_XemLuongThangCaNhan(thang, nam).ToList();
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
