using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            string currentRole = UserSession.Role;
            PhanQuyenGiaoDien(currentRole);
        }
        private void PhanQuyenGiaoDien(string tenRole)
        {
            btn_NhanVien.Visible = false;
            btn_DuyetDon.Visible = false;
            btn_TinhLuong.Visible = false;
            btn_GanPhuCap.Visible = false;
            btn_HopDong.Visible = false;
            btn_phuCap.Visible = false;  
            btn_phongBan.Visible = false; 
            btn_ThongTin.Visible = false;
            btn_XinNghi.Visible = false;
            btn_XemLuong.Visible = false;
            btn_Backup.Visible = false;
            btn_Restore.Visible = false;
            btn_ThongKe.Visible = false;
            btn_ChucVu.Visible = false;
            if (string.IsNullOrEmpty(tenRole)) return;
            switch (tenRole)
            {
                case "Role_Admin":
                    btn_Backup.Visible = true;
                    btn_Restore.Visible = true;
                    btn_Backup_Click(null, null);
                    break;
                case "Role_NhanVien":
                    btn_XinNghi.Visible = true;
                    btn_XemLuong.Visible = true;
                    btn_ThongTin.Visible = true;
                    btn_XinNghi_Click(null, null);
                    break;

                case "Role_KeToan":
                    btn_TinhLuong.Visible = true;
                    btn_ThongKe.Visible = true;
                    btn_TinhLuong_Click(null, null);
                    break;

                case "Role_NhanSu":
                    btn_NhanVien.Visible = true;
                    btn_DuyetDon.Visible = true;
                    btn_GanPhuCap.Visible = true;
                    btn_HopDong.Visible = true;
                    btn_phuCap.Visible = true;
                    btn_phongBan.Visible = true;
                    btn_ChucVu.Visible =  true;
                    btn_NhanVien_Click(null, null);
                    break;
            }
        }

        private Color defaultColor = Color.FromArgb(224, 224, 224);
        private Color activeColor = Color.FromArgb(193, 216, 240);
        private void ResetMenuButtonColors()
        {
            btn_NhanVien.BackColor = defaultColor;
            btn_DuyetDon.BackColor = defaultColor;
            btn_TinhLuong.BackColor = defaultColor;
            btn_GanPhuCap.BackColor = defaultColor;
            btn_HopDong.BackColor = defaultColor;
            btn_phuCap.BackColor = defaultColor;
            btn_phongBan.BackColor = defaultColor;
            btn_ThongTin.BackColor = defaultColor;
            btn_XinNghi.BackColor = defaultColor;  
            btn_XemLuong.BackColor = defaultColor;
            btn_Backup.BackColor = defaultColor;
            btn_Restore.BackColor = defaultColor;
            btn_ThongKe.BackColor = defaultColor;
            btn_ChucVu.BackColor = defaultColor;
        }
        private void btn_phongBan_Click(object sender, EventArgs e)
        {
            ResetMenuButtonColors();
            btn_phongBan.BackColor = activeColor;

            contentPanel.Controls.Clear();
            PhongBan ucPB = new PhongBan();
            ucPB.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(ucPB);
        }
        private void btn_phuCap_Click(object sender, EventArgs e)
        {
            ResetMenuButtonColors();
            btn_phuCap.BackColor = activeColor;

            contentPanel.Controls.Clear();
            PhuCap ucCV = new PhuCap();
            ucCV.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(ucCV);
        }

        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            ResetMenuButtonColors();
            btn_NhanVien.BackColor = activeColor;

            contentPanel.Controls.Clear();
            NhanVien ucNV = new NhanVien();
            ucNV.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(ucNV);
        }

        private void btn_HopDong_Click(object sender, EventArgs e)
        {
            ResetMenuButtonColors();
            btn_HopDong.BackColor = activeColor;

            contentPanel.Controls.Clear();
            HopDong ucHD = new HopDong();
            ucHD.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(ucHD);
        }

        private void btn_DuyetDon_Click(object sender, EventArgs e)
        {
            ResetMenuButtonColors();
            btn_DuyetDon.BackColor = activeColor;

            contentPanel.Controls.Clear();
            DuyetDon ucDD = new DuyetDon();
            ucDD.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(ucDD);
        }

        private void btn_TinhLuong_Click(object sender, EventArgs e)
        {
            ResetMenuButtonColors();
            btn_TinhLuong.BackColor = activeColor;

            contentPanel.Controls.Clear();
            TinhLuong ucTL = new TinhLuong();
            ucTL.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(ucTL);
        }

        private void btn_GanPhuCap_Click(object sender, EventArgs e)
        {
            ResetMenuButtonColors();
            btn_GanPhuCap.BackColor = activeColor;

            contentPanel.Controls.Clear();
            QLPhuCap ucQLPC = new QLPhuCap();
            ucQLPC.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(ucQLPC);
        }

        private void btn_ThongTin_Click(object sender, EventArgs e)
        {
            ResetMenuButtonColors();
            btn_ThongTin.BackColor = activeColor;

            contentPanel.Controls.Clear();
            ThongTinNhanVien ucTTNV = new ThongTinNhanVien();
            ucTTNV.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(ucTTNV);
        }

        private void btn_XinNghi_Click(object sender, EventArgs e)
        {
            ResetMenuButtonColors();
            btn_XinNghi.BackColor = activeColor;

            contentPanel.Controls.Clear();
            XinNghi ucXN = new XinNghi();
            ucXN.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(ucXN);
        }

        private void btn_XemLuong_Click(object sender, EventArgs e)
        {
            ResetMenuButtonColors();
            btn_XemLuong.BackColor = activeColor;

            contentPanel.Controls.Clear();
            XemLuong ucXL = new XemLuong();
            ucXL.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(ucXL);
        }

        private void btn_Backup_Click(object sender, EventArgs e)
        {
            ResetMenuButtonColors();
            btn_Backup.BackColor = activeColor;

            contentPanel.Controls.Clear();
            Backup ucBU = new Backup();
            ucBU.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(ucBU);
        }

        private void btn_Restore_Click(object sender, EventArgs e)
        {
            ResetMenuButtonColors();
            btn_Restore.BackColor = activeColor;

            contentPanel.Controls.Clear();
            Restore ucRS = new Restore();
            ucRS.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(ucRS);
        }

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            ResetMenuButtonColors();
            btn_ThongKe.BackColor = activeColor;

            contentPanel.Controls.Clear();
            ThongKe ucTK = new ThongKe();
            ucTK.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(ucTK);
        }

        private void btn_ChucVu_Click(object sender, EventArgs e)
        {
            ResetMenuButtonColors();
            btn_ChucVu.BackColor = activeColor;

            contentPanel.Controls.Clear();
            ChucVu ucCV = new ChucVu();
            ucCV.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(ucCV);
        }
    }
}
