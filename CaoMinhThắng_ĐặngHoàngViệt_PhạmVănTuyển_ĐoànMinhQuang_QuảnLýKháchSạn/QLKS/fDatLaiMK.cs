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
    public partial class fDatLaiMK : Form
    {
        public fDatLaiMK()
        {
            InitializeComponent();
        }
        #region Sự kiện hiển thị mật khẩu và tắt đi
        int i = 1;
        int j = 1;
        private void lbEyes1_MouseHover(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = !txtMatKhau.UseSystemPasswordChar;
            if (i % 2 == 0)
            {
                lbEyes1.Symbol = "\uf070";
                i++;
            }
            else
            {
                lbEyes1.Symbol = "\uf06e";
                i++;
            }
        }
        private void lbEyes1_MouseLeave(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = !txtMatKhau.UseSystemPasswordChar;
            if (i % 2 == 0)
            {
                lbEyes1.Symbol = "\uf070";
                i++;
            }
            else
            {
                lbEyes1.Symbol = "\uf06e";
                i++;
            }
        }
        private void lbEyes2_MouseHover(object sender, EventArgs e)
        {
            txtNhapLaiMatKhau.UseSystemPasswordChar = !txtNhapLaiMatKhau.UseSystemPasswordChar;
            if (j % 2 == 0)
            {
                lbEyes2.Symbol = "\uf070";
                j++;
            }
            else
            {
                lbEyes2.Symbol = "\uf06e";
                j++;
            }
        }
        private void lbEyes2_MouseLeave(object sender, EventArgs e)
        {
            txtNhapLaiMatKhau.UseSystemPasswordChar = !txtNhapLaiMatKhau.UseSystemPasswordChar;
            if (j % 2 == 0)
            {
                lbEyes2.Symbol = "\uf070";
                j++;
            }
            else
            {
                lbEyes2.Symbol = "\uf06e";
                j++;
            }
        }
        #endregion
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //nút hủy

        //nút đồng ý đổi mật khẩu
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string tentk = txtTaiKhoan.Text;
            string matkhau = txtMatKhau.Text;
            string matkhaumoi = txtNhapLaiMatKhau.Text;
            if (txtTaiKhoan.Text != "")
            {
                if (txtMatKhau.Text != "")
                {
                    if (txtNhapLaiMatKhau.Text != "")
                    {
                        QLKSContextDB context = new QLKSContextDB();
                        TAIKHOAN tk = context.TAIKHOAN.FirstOrDefault(p => p.ten_TK == tentk);
                        if (tk == null)
                        {
                            MessageBox.Show("Bạn đã nhập sai tài khoản!", "Thông báo", MessageBoxButtons.OK);
                        }
                        else
                        {
                            QLKSContextDB context2 = new QLKSContextDB();
                            TAIKHOAN mk = context2.TAIKHOAN.FirstOrDefault(p => p.matkhau_TK == matkhau);
                            if(mk == null)
                            {
                                MessageBox.Show("Sai mật khẩu cũ. Vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK);
                            }
                            else
                            {
                                if (matkhau == matkhaumoi)
                                {
                                    MessageBox.Show("Mật khẩu đã được sử dụng. Vui lòng thay đổi!");
                                }
                                else
                                {
                                    tk.matkhau_TK = matkhaumoi;
                                    context.SaveChanges();
                                    MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK);
                                    this.Close();
                                }
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Vui Lòng nhập mật khẩu mới!", "Thông báo", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu hiện tại!", "Thông báo", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản!", "Thông báo", MessageBoxButtons.OK);
            }
            
        }
    }
}
