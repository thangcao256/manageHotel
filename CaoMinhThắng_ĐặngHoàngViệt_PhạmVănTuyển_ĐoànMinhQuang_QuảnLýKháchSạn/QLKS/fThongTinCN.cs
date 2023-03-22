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
    public partial class fThongTinCN : Form
    {
        public fThongTinCN()
        {
            InitializeComponent();
            Hienthi();
            Mochunang();
        }

        private void Hienthi()
        {
            QLKSContextDB context = new QLKSContextDB();
            TAIKHOAN tk = context.TAIKHOAN.FirstOrDefault(p => p.trangthai == "1");
            if(tk != null)
            {
                txtTenhienthi.Text = tk.tenhienthi_TK;
                txtIdtk.Text = tk.id_TK;
                txtTentk.Text = tk.ten_TK;
                cbbGioitinh.Text = tk.gioitinh;
                txtDiachi.Text = tk.diachi;
                txtSdt.Text = tk.sdt;
                txtGmail.Text = tk.email;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            QLKSContextDB context = new QLKSContextDB();
            TAIKHOAN tk = context.TAIKHOAN.FirstOrDefault(p => p.trangthai == "1");
            if(cbbGioitinh.Text != "" && txtDiachi.Text !="" && txtSdt.Text !="" && txtGmail.Text != "")
            {
                tk.gioitinh = cbbGioitinh.Text;
                tk.diachi = txtDiachi.Text;
                tk.sdt = txtSdt.Text;
                tk.email = txtGmail.Text;
                context.SaveChanges();
                MessageBox.Show("Cập nhật thông tin thành công!");
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK);
            }
        }
        private void Mochunang()
        {
            QLKSContextDB context = new QLKSContextDB();
            TAIKHOAN tk = context.TAIKHOAN.FirstOrDefault(p => p.trangthai == "1");
            if (tk == null)
            {
                btnCapNhat.Enabled = false;
            }
        }
    }
}
