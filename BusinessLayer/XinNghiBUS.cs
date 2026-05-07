using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class XinNghiBUS
    {
        public object LayDanhSachDon()
        {
            using (var db = new QLNSEntities())
            {
                return db.sp_XemDonXinNghiCaNhan().ToList();
            }
        }
        public bool NopDon(DateTime tuNgay, DateTime denNgay, string lyDo)
        {
            using (var db = new QLNSEntities())
            {
                int result = db.sp_ThemDonXinNghi(tuNgay, denNgay, lyDo);
                return result > 0;
            }
        }
    }
}
