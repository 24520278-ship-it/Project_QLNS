using DataLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ChamCongBUS
    {
        public void ImportCSV(string filePath)
        {
            using (var db = new QLNSEntities())
            {
                string sqlCommand = $@"
                    BULK INSERT BANGCHAMCONG
                    FROM '{filePath}'
                    WITH (
                        FIELDTERMINATOR = ',',   -- Dấu ngăn cách giữa các cột
                        ROWTERMINATOR = '\n',    -- Dấu ngăn cách giữa các dòng (xuống dòng)
                        FIRSTROW = 1,            -- Bắt đầu đọc từ dòng số 1 (do file không có tiêu đề)
                        CODEPAGE = '65001'       -- Hỗ trợ đọc file mã hóa UTF-8 (chống lỗi font)
                    );
                ";

                try
                {
                    db.Database.ExecuteSqlCommand(sqlCommand);
                }
                catch (SqlException ex)
                {
                    throw new Exception("Lỗi từ SQL Server khi đọc file: " + ex.Message);
                }
            }
        }
    }
}
