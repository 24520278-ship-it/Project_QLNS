using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ThongTinNvBUS
    {
        public object LayThongTinCaNhan()
        {
            using (var db = new QLNSEntities())
            {
                return db.sp_XemThongTinCaNhan().ToList();
            }
        }

        public bool CapNhatThongTin(string hoTen, DateTime ngaySinh, string gioiTinh, string diaChi, string sdt, string email)
        {
            using (var db = new QLNSEntities())
            {
                int result = db.sp_CapNhatThongTinCaNhan(hoTen, ngaySinh, gioiTinh, diaChi, sdt, email);
                return result > 0;
            }
        }
    }
}
