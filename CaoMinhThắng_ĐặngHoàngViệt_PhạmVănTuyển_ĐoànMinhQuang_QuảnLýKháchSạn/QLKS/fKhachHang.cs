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
    public partial class fKhachHang : Form
    {
        public fKhachHang()
        {
            InitializeComponent();
            load_data();

        }
        // hàm xóa trắng dữ liệu ở text box
        private void clearTxtBox()
        {
            txtMakh.Clear();
            txtTenkh.Clear();
            txtNgaysinh.Clear();
            cbbGioitinh.Items.Clear();
            txtCmnd.Clear();
            txtQuoctich.Clear();
        }
        // hàm kiểm tra có tồn tại sdt Khách hành tương ứng hay không
        private int kiemTraTonTai()
        {
            QLKSContextDB context = new QLKSContextDB();
            KHACHHANG kh = context.KHACHHANG.FirstOrDefault(p => p.id_KH == txtMakh.Text || p.cmnd == txtCmnd.Text);
            if (kh == null)
                return 1;
            else
                return -1;
        }
        //hàm binding gridview từ list tai khoan
        private void BindGrid(List<KHACHHANG> listKhachhang)
        {
            dtgvKhachhang.Rows.Clear();
            foreach (var item in listKhachhang)
            {
                int index = dtgvKhachhang.Rows.Add();
                dtgvKhachhang.Rows[index].Cells[0].Value = item.id_KH;
                dtgvKhachhang.Rows[index].Cells[1].Value = item.ten;
                dtgvKhachhang.Rows[index].Cells[2].Value = item.ngaysinh;
                dtgvKhachhang.Rows[index].Cells[3].Value = item.gioitinh;
                dtgvKhachhang.Rows[index].Cells[4].Value = item.cmnd;
                dtgvKhachhang.Rows[index].Cells[5].Value = item.quoctich;

            }
        }

        //hàm load data
        private void load_data()
        {
            QLKSContextDB context = new QLKSContextDB();
            List<KHACHHANG> listKhachhang = context.KHACHHANG.ToList();
            BindGrid(listKhachhang);
        }
        private void dtgvKhachhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgvKhachhang.Rows[e.RowIndex];
                txtMakh.Text = row.Cells[0].Value.ToString();
                txtTenkh.Text = row.Cells[1].Value.ToString();
                txtNgaysinh.Text = row.Cells[2].Value.ToString();
                cbbGioitinh.Text = row.Cells[3].Value.ToString();
                txtCmnd.Text = row.Cells[4].Value.ToString();
                txtQuoctich.Text = row.Cells[5].Value.ToString();

            }
        }

        private void fKhachHang_Load(object sender, EventArgs e)
        {
            try
            {
                load_data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            QLKSContextDB context = new QLKSContextDB();
            if (txtMakh.Text == "" || txtTenkh.Text == "" || txtCmnd.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK);
            }
            else

                try
                {
                    int temp = kiemTraTonTai();
                    if (temp == 1)
                    {

                        temp = dtgvKhachhang.Rows.Add();
                        KHACHHANG tk = new KHACHHANG
                        {
                            id_KH = txtMakh.Text,
                            ten = txtTenkh.Text,
                            ngaysinh = txtNgaysinh.Text,
                            gioitinh = cbbGioitinh.Text,
                            cmnd = txtCmnd.Text,
                            quoctich = txtQuoctich.Text,

                        };
                        context.KHACHHANG.Add(tk);
                        context.SaveChanges();
                        clearTxtBox();
                        MessageBox.Show("Thêm mới thông tin khách hàng thành công!", "Thông báo", MessageBoxButtons.OK);
                        load_data();
                    }
                    else
                    {
                        MessageBox.Show("Đã tồn tại khách hàng với mã này hoặc số điện thoại này!", "Thông báo", MessageBoxButtons.OK);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string makh = txtMakh.Text;
            QLKSContextDB context = new QLKSContextDB();
            if (makh == "")
                MessageBox.Show("Vui lòng nhập mã của tài khoản cần xóa!", "Thông báp", MessageBoxButtons.OK);
            try
            {
                for (int i = 0; i < dtgvKhachhang.Rows.Count; i++)
                {
                    if (dtgvKhachhang.Rows[i].Cells[0].Value.ToString() == makh)
                    {
                        KHACHHANG dbxoa = context.KHACHHANG.FirstOrDefault(p => p.id_KH == txtMakh.Text || p.cmnd == txtCmnd.Text);
                        if (dbxoa != null)
                        {
                            DialogResult dr = MessageBox.Show("Bạn có muốn xóa thông tin khách hàng này?", "Thông báo", MessageBoxButtons.YesNo);
                            if (dr == DialogResult.Yes)
                            {
                                context.KHACHHANG.Remove(dbxoa);
                                context.SaveChanges();
                                clearTxtBox();
                                load_data();
                                MessageBox.Show("Xóa thành công thông tin!", "Thông báo!", MessageBoxButtons.OK);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không tồn tại khách hàng có mã vừa nhập!", "Thông báo!", MessageBoxButtons.OK);
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            QLKSContextDB context = new QLKSContextDB();
            KHACHHANG tk = context.KHACHHANG.FirstOrDefault(p => p.id_KH == txtMakh.Text || p.cmnd == txtCmnd.Text);
            if (txtMakh.Text == "" || txtTenkh.Text == "" || txtCmnd.Text == "")
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK);
            else
            {
                try
                {
                    if (tk != null)
                    {
                        tk.id_KH = txtMakh.Text;
                        tk.ten = txtTenkh.Text;
                        tk.ngaysinh = txtNgaysinh.Text;
                        tk.gioitinh = cbbGioitinh.Text;
                        tk.cmnd = txtCmnd.Text;
                        tk.quoctich = txtQuoctich.Text;

                        context.SaveChanges();
                        clearTxtBox();
                        load_data();
                        MessageBox.Show("Sửa thông tin công!", "Thông báo", MessageBoxButtons.OK);
                        clearTxtBox();
                    }
                    else
                    {
                        MessageBox.Show("Không tồn tại khách hàng vừa nhập!", "Thông báo", MessageBoxButtons.OK);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnTrove_Click(object sender, EventArgs e)
        {
            this.Hide();
            fQLKS fm = new fQLKS();
            fm.ShowDialog();
            this.Close();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            QLKSContextDB context = new QLKSContextDB();
            var timtk = from k in context.KHACHHANG
                        where (txtMakh.Text == k.id_KH || txtTenkh.Text == k.ten || txtNgaysinh.Text == k.ngaysinh
                        || cbbGioitinh.Text == k.gioitinh || txtCmnd.Text == k.cmnd || txtQuoctich.Text == k.quoctich)
                        select new
                        {
                            mataikhoan = k.id_KH,
                            tentaikhoan = k.ten,
                            matkhau = k.ngaysinh,
                            tenhienthi = k.gioitinh,
                            gioitinh = k.cmnd,
                            sdt = k.quoctich,
                        };
            dtgvKhachhang.Rows.Clear();
            foreach (var item in timtk)
            {
                int index = dtgvKhachhang.Rows.Add();
                dtgvKhachhang.Rows[index].Cells[0].Value = item.mataikhoan;
                dtgvKhachhang.Rows[index].Cells[1].Value = item.tentaikhoan;
                dtgvKhachhang.Rows[index].Cells[2].Value = item.matkhau;
                dtgvKhachhang.Rows[index].Cells[3].Value = item.tenhienthi;
                dtgvKhachhang.Rows[index].Cells[4].Value = item.gioitinh;
                dtgvKhachhang.Rows[index].Cells[5].Value = item.sdt;

            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            try
            {
                load_data();
                clearTxtBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
