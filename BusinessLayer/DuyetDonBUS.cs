using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class DuyetDonBUS
    {
        QLNSEntities db = new QLNSEntities();
        public object LayDanhSachDon(int trangThai)
        {
            try
            {
                using (var db = new QLNSEntities())
                {
                    return db.sp_LayDanhSachDon(trangThai).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách đơn: " + ex.Message);
            }
        }
        public bool CapNhatTrangThai(string maDon, int trangThaiMoi)
        {
            try
            {
                db.sp_CapNhatTrangThaiDon(maDon, trangThaiMoi);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi database: " + ex.Message);
            }
        }
    }
}
