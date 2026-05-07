using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;

namespace MainForm
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string taiKhoan = txb_TK.Text.Trim();
            string matKhau = txb_MK.Text.Trim();

            if (string.IsNullOrEmpty(taiKhoan) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Tài khoản và Mật khẩu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string serverName = @".\SQLEXPRESS";
            string dbName = "QLNS";
            string adoConnStr = $"Server={serverName};Database={dbName};User Id={taiKhoan};Password={matKhau};TrustServerCertificate=True;";
            try
            {
                using (SqlConnection conn = new SqlConnection(adoConnStr))
                {
                    conn.Open();
                    string queryRole = @"SELECT
                    IS_SRVROLEMEMBER('sysadmin') AS IsAdmin,
                    IS_MEMBER('Role_NhanSu') AS IsNhanSu, 
                    IS_MEMBER('Role_NhanVien') AS IsNhanVien,
                    IS_MEMBER('Role_KeToan') AS IsKeToan";

                    using (SqlCommand cmd = new SqlCommand(queryRole, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int isAdmin = reader["IsAdmin"] != DBNull.Value ? Convert.ToInt32(reader["IsAdmin"]) : 0;
                                int isNhanSu = reader["IsNhanSu"] != DBNull.Value ? Convert.ToInt32(reader["IsNhanSu"]) : 0;
                                int isNhanVien = reader["IsNhanVien"] != DBNull.Value ? Convert.ToInt32(reader["IsNhanVien"]) : 0;
                                int isKeToan = reader["IsKeToan"] != DBNull.Value ? Convert.ToInt32(reader["IsKeToan"]) : 0;

                                if (isAdmin == 1) UserSession.Role = "Role_Admin";
                                else if (isNhanSu == 1) UserSession.Role = "Role_NhanSu";
                                else if (isKeToan == 1) UserSession.Role = "Role_KeToan";
                                else if (isNhanVien == 1) UserSession.Role = "Role_NhanVien";
                                else
                                {
                                    MessageBox.Show("Tài khoản này có tồn tại nhưng chưa được phân quyền truy cập hệ thống!", "Từ chối truy cập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                        }
                    }
                    UserSession.MaNV = taiKhoan;
                    UserSession.EFConnectionString = $"metadata=res://*/Model1.csdl|res://*/Model1.ssdl|res://*/Model1.msl;provider=System.Data.SqlClient;provider connection string=\"{adoConnStr}MultipleActiveResultSets=True;App=EntityFramework\"";

                    string tenQuyen = "";
                    if (UserSession.Role == "Role_Admin") tenQuyen = "Quản Trị Hệ Thống";
                    else if (UserSession.Role == "Role_NhanSu") tenQuyen = "Quản lý Nhân Sự";
                    else if (UserSession.Role == "Role_KeToan") tenQuyen = "Kế Toán";
                    else tenQuyen = "Nhân Viên";

                    MessageBox.Show($"Đăng nhập thành công!\nXin chào: {UserSession.MaNV}\nVai trò: {tenQuyen}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MainForm frm = new MainForm();
                    frm.Show();
                    this.Hide();
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 18456)
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!", "Lỗi Đăng Nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Không thể kết nối đến máy chủ CSDL. Vui lòng kiểm tra lại tên Server.\n\nChi tiết: " + ex.Message, "Lỗi Kết Nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
