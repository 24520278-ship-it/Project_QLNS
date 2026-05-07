using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class TinhLuongBUS
    {
        QLNSEntities db = new QLNSEntities();
        public void ThucThiTinhLuong(int thang, int nam, decimal congChuan)
        {
            try
            {
                db.sp_ChotBangLuongThang(thang, nam, congChuan);
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
        public object LayBangLuongTheoThang(int thang, int nam)
        {
            try
            {
                using (var db = new QLNSEntities())
                {
                    return db.sp_LayBangLuongTheoThang(thang, nam).ToList();
                }
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
