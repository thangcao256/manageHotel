using QLKS.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS
{
    public partial class fQLKS : Form
    {
        public fQLKS()
        {
            InitializeComponent();
            Mochunang();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.timer.Text = string.Format(" {0} {1}", DateTime.Now.ToString("dd/MM/yyyy"), DateTime.Now.ToString("hh:mm:ss tt"));
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            fQLPhong f0 = new fQLPhong();
            this.Hide();
            f0.ShowDialog();
            this.Show();
        }

        private void btnKhachhang_Click(object sender, EventArgs e)
        {
            fKhachHang f0 = new fKhachHang();
            f0.Show();
        }

        private void btnDichvu_Click(object sender, EventArgs e)
        {
            fDichVu f0 = new fDichVu();
            f0.Show();
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            fThongKe f0 = new fThongKe();
            f0.Show();
        }

        private void tsmnTrogiup_Click(object sender, EventArgs e)
        {
            fTroGiup f0 = new fTroGiup();
            f0.Show();
        }

        private void tsmnThongtin_Click(object sender, EventArgs e)
        {
            fThongTin f0 = new fThongTin();
            f0.Show();
        }

        private void tsmnCapnhattt_Click(object sender, EventArgs e)
        {
            fThongTinCN f0 = new fThongTinCN();
            f0.Show();
        }

        private void tsmnDoimk_Click(object sender, EventArgs e)
        {
            fDatLaiMK f0 = new fDatLaiMK();
            f0.Show();
        }

        private void tsmnQuanly_Click(object sender, EventArgs e)
        {
            fTaiKhoan f0 = new fTaiKhoan();
            f0.Show();
        }

        private void tsmnDangxuat_Click(object sender, EventArgs e)
        {
            Change();
            //MessageBox.Show("Đăng xuất thành công!");
            this.Close();
        }
        private void Change()
        {
            QLKSContextDB context = new QLKSContextDB();
            TAIKHOAN tk = context.TAIKHOAN.FirstOrDefault(p => p.trangthai == "1");
            if (tk != null)
            {
                tk.trangthai = "0";
            }
            context.SaveChanges();
        }

        private void fQLKS_Load(object sender, EventArgs e)
        {

        }

        private void fQLKS_FormClosed(object sender, FormClosedEventArgs e)
        {
            Change();
            MessageBox.Show("Đăng xuất thành công!");
            this.Close();
        }
        private void Mochunang()
        {
            QLKSContextDB context = new QLKSContextDB();
            TAIKHOAN tk = context.TAIKHOAN.FirstOrDefault(p => p.trangthai == "1");
            if(tk == null)
            {
                tsmnQuanly.Enabled = true;
                tsmnDoimk.Enabled = false;
            }
        }
    }
}
