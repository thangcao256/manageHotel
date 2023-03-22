//using QLKS.DAO;
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
    public partial class fDangNhap : Form
    {
        public fDangNhap()
        {
            InitializeComponent();
        }
        int i = 1;
        // Đóng form đăng nhập
        private void fDangNhap_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo!", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        #region Chức năng hiển thị mật khẩu
        private void lbEyes_Click(object sender, EventArgs e)
        {
            txtMatkhau.UseSystemPasswordChar = !txtMatkhau.UseSystemPasswordChar;
            if (i % 2 == 0)
            {
                lbEyes.Symbol = "\uf070";
                i++;
            }
            else
            {
                lbEyes.Symbol = "\uf06e";
                i++;
            }
        }
        private void chkHienthi_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Đang cập nhật!!!", "Thông báo", MessageBoxButtons.OK);
            //int j = 1;
            //txtMatkhau.UseSystemPasswordChar = !txtMatkhau.UseSystemPasswordChar;
            //if (j % 2 == 0)
            //{
            //    lbEyes.Symbol = "\uf070";
            //    j++;
            //}
            //else
            //{
            //    lbEyes.Symbol = "\uf06e";
            //    j++;
            //}
        }
        #endregion

        //Thoát ứng dụng
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Xoá sạch thông tin đăng nhập
        private void clearTxtBox()
        {
            txtDangNhap.Clear();
            txtMatkhau.Clear();
        }
        //Đăng nhập vào phần mềm
        private void btnDangnhap_Click_1(object sender, EventArgs e)
        {
            string tenDangNhap = txtDangNhap.Text;
            string matKhau = txtMatkhau.Text;
            if ((tenDangNhap == "admin" && matKhau == "admin") || (tenDangNhap == "trangnguyen" && matKhau == "trangnguyen"))
            {
                fQLKS f0 = new fQLKS();
                this.Hide();
                f0.ShowDialog();
                this.Show();
            }
            else
            {
                if (txtDangNhap.Text != "" && txtMatkhau.Text != "")
                {
                    using (var account = new QLKSContextDB())
                    {
                        if (account.TAIKHOAN.Any(tk => tk.ten_TK == tenDangNhap
                        && tk.matkhau_TK == matKhau))
                        {
                            Change();
                            MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK);
                            this.Hide();
                            fQLKS fmain = new fQLKS();
                            fmain.ShowDialog();
                            this.Show();
                            clearTxtBox();
                            
                        }
                        else
                        {
                            MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK);
                            clearTxtBox();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ tên tài khoản và mật khẩu!", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }
        // Thay đổi trạng thái của tài khoản từ đang off sang online
        private void Change()
        {
            QLKSContextDB context = new QLKSContextDB();
            TAIKHOAN tk = context.TAIKHOAN.FirstOrDefault(p => p.ten_TK == txtDangNhap.Text);
            tk.trangthai = "1";
            context.SaveChanges();
        }
    }
}
