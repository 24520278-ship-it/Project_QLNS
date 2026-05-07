using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ThongKeBUS
    {
        public object LayDuLieuThongKe(int thang, int nam, bool isTheoPhongBan)
        {
            try
            {
                using (var db = new QLNSEntities())
                {
                    if (isTheoPhongBan)
                    {
                        return db.sp_ThongKeLuongTheoPhongBan(thang, nam).ToList();
                    }
                    else
                    {
                        return db.sp_ThongKeLuongTheoChucVu(thang, nam).ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                Exception loiGoc = ex;
                while (loiGoc.InnerException != null)
                {
                    loiGoc = loiGoc.InnerException;
                }
                throw new Exception(loiGoc.Message);
            }
        }
    }
}
