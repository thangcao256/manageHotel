using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLKS.Database;


namespace QLKS
{
    public partial class fTaiKhoan : Form
    {
        public fTaiKhoan()
        {
            InitializeComponent();
            load_data();

        }
        // hàm xóa trắng dữ liệu ở text box
        private void clearTxtBox()
        {
            txtMatk.Clear();
            txtTentk.Clear();
            txtMatkhau.Clear();
            txtMatk.Clear();
            txtTen.Clear();
            txtSdt.Clear();
            txtDiachi.Clear();
            txtEmail.Clear();
            cbbGioitinh.Items.Clear();
        }
        // hàm kiểm tra có tồn tại sdt Khách hành tương ứng hay không
        private int kiemTraTonTai()
        {
            QLKSContextDB context = new QLKSContextDB();
            TAIKHOAN kh = context.TAIKHOAN.FirstOrDefault(p => p.sdt == txtSdt.Text || p.id_TK == txtMatk.Text);
            if (kh == null)
                return 1;
            else
                return -1;
        }
        //hàm binding gridview từ list tai khoan
        private void BindGrid(List<TAIKHOAN> listKhachHang)
        {
            gvTaikhoan.Rows.Clear();
            foreach (var item in listKhachHang)
            {
                int index = gvTaikhoan.Rows.Add();
                gvTaikhoan.Rows[index].Cells[0].Value = item.id_TK;
                gvTaikhoan.Rows[index].Cells[1].Value = item.ten_TK;
                gvTaikhoan.Rows[index].Cells[2].Value = item.matkhau_TK;
                gvTaikhoan.Rows[index].Cells[3].Value = item.tenhienthi_TK;
                gvTaikhoan.Rows[index].Cells[4].Value = item.gioitinh;
                gvTaikhoan.Rows[index].Cells[5].Value = item.sdt;
                gvTaikhoan.Rows[index].Cells[6].Value = item.diachi;
                gvTaikhoan.Rows[index].Cells[7].Value = item.email;
            }
        }

        //hàm load data
        private void load_data()
        {
            QLKSContextDB context = new QLKSContextDB();
            List<TAIKHOAN> listtaikhoan = context.TAIKHOAN.ToList();
            BindGrid(listtaikhoan);
        }
        /// nút thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn đã muốn thoát chưa?", "Thông báo", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }
        // trở về màn hình cũ
        private void btnTrove_Click(object sender, EventArgs e)
        {
            this.Hide();
            fQLKS fm = new fQLKS();
            fm.ShowDialog();
            this.Close();
        }
        //click vào 1 dòng bất kì và xuất ra thông tin khách hàng
        private void gvTaikhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.gvTaikhoan.Rows[e.RowIndex];
                txtMatk.Text = row.Cells[0].Value.ToString();
                txtTentk.Text = row.Cells[1].Value.ToString();
                txtMatkhau.Text = row.Cells[2].Value.ToString();
                txtTen.Text = row.Cells[3].Value.ToString();
                cbbGioitinh.Text = row.Cells[4].Value.ToString();
                txtSdt.Text = row.Cells[5].Value.ToString();
                txtDiachi.Text = row.Cells[6].Value.ToString();
                txtEmail.Text = row.Cells[7].Value.ToString();
            }
        }
        // hàm tải data
        private void fTaiKhoan_Load(object sender, EventArgs e)
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
                if (txtMatk.Text == "" || txtTen.Text == "" || txtSdt.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK);
                }
                else
                
                try
                {
                    int temp = kiemTraTonTai();
                    if (temp == 1)
                    {
                        
                        temp = gvTaikhoan.Rows.Add();
                        TAIKHOAN tk = new TAIKHOAN
                        {
                            id_TK = txtMatk.Text,
                            ten_TK = txtTentk.Text,
                            matkhau_TK = txtMatkhau.Text,
                            tenhienthi_TK = txtTen.Text,
                            gioitinh = cbbGioitinh.Text,
                            sdt = txtSdt.Text,
                            diachi = txtDiachi.Text,
                            email = txtEmail.Text,
 
                        };
                        context.TAIKHOAN.Add(tk);
                        context.SaveChanges();
                        clearTxtBox();
                        MessageBox.Show("Thêm mới thông tin tài khoản thành công!", "Thông báo", MessageBoxButtons.OK);
                        load_data();
                    }
                    else
                    {
                        MessageBox.Show("Đã tồn tại tài khoản với mã này hoặc số điện thoại này!", "Thông báo", MessageBoxButtons.OK);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }
        //nút làm mới danh sách
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
        // Xoá tài khoản
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string matk = txtMatk.Text;
            QLKSContextDB context = new QLKSContextDB();
            if (matk == "")
                MessageBox.Show("Vui lòng nhập mã của tài khoản cần xóa!", "Thông báp", MessageBoxButtons.OK);
            try
            {
                for (int i = 0; i < gvTaikhoan.Rows.Count; i++)
                {
                    if (gvTaikhoan.Rows[i].Cells[0].Value.ToString() == matk)
                    {
                        TAIKHOAN dbxoa = context.TAIKHOAN.FirstOrDefault(p => p.id_TK == txtMatk.Text || p.sdt == txtSdt.Text);
                        if (dbxoa != null)
                        {
                            DialogResult dr = MessageBox.Show("Bạn có muốn xóa thông tin tài khoản này?", "Thông báo", MessageBoxButtons.YesNo);
                            if (dr == DialogResult.Yes)
                            {
                                context.TAIKHOAN.Remove(dbxoa);
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
        // Sửa tài khoản
        private void btnSua_Click(object sender, EventArgs e)
        {
            QLKSContextDB context = new QLKSContextDB();
            TAIKHOAN tk = context.TAIKHOAN.FirstOrDefault(p => p.id_TK == txtMatk.Text || p.sdt == txtSdt.Text);
            if (txtMatk.Text == "" || txtMatkhau.Text == "" || txtSdt.Text == "")
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK);
            else
            {
                try
                {
                    if (tk != null)
                    {
                        tk.id_TK = txtMatk.Text;
                        tk.ten_TK = txtTen.Text;
                        tk.matkhau_TK = txtMatkhau.Text;
                        tk.tenhienthi_TK = txtTen.Text;
                        tk.gioitinh = cbbGioitinh.Text;
                        tk.sdt = txtSdt.Text;
                        tk.diachi = txtDiachi.Text;
                        tk.email = txtEmail.Text;
                        context.SaveChanges();
                        clearTxtBox();
                        load_data();
                        MessageBox.Show("Sửa thông tin công!", "Thông báo", MessageBoxButtons.OK);
                        clearTxtBox();
                    }
                    else
                    {
                        MessageBox.Show("Không tồn tạitài khoản với số điện thoại vừa nhập!", "Thông báo", MessageBoxButtons.OK);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        // Tìm tài khoản
        private void btnTim_Click(object sender, EventArgs e)
        {
            QLKSContextDB context = new QLKSContextDB();
            var timtk = from k in context.TAIKHOAN
                        where (txtMatk.Text == k.id_TK || txtTen.Text == k.tenhienthi_TK || txtTentk.Text == k.ten_TK
                        || txtMatkhau.Text == k.matkhau_TK || cbbGioitinh.Text == k.gioitinh || txtSdt.Text == k.sdt 
                        || txtDiachi.Text == k.sdt || txtEmail.Text == k.email)
                        select new
                        {
                            mataikhoan  = k.id_TK,
                            tentaikhoan = k.ten_TK,
                            matkhau     = k.matkhau_TK,
                            tenhienthi  = k.tenhienthi_TK,
                            gioitinh    = k.gioitinh,
                            sdt         = k.sdt,
                            diachi      = k.diachi,
                            email       = k.email
                        };
            gvTaikhoan.Rows.Clear();
            foreach (var item in timtk)
            {
                int index = gvTaikhoan.Rows.Add();
                gvTaikhoan.Rows[index].Cells[0].Value = item.mataikhoan;
                gvTaikhoan.Rows[index].Cells[1].Value = item.tentaikhoan;
                gvTaikhoan.Rows[index].Cells[2].Value = item.matkhau;
                gvTaikhoan.Rows[index].Cells[3].Value = item.tenhienthi;
                gvTaikhoan.Rows[index].Cells[4].Value = item.gioitinh;
                gvTaikhoan.Rows[index].Cells[5].Value = item.sdt;
                gvTaikhoan.Rows[index].Cells[6].Value = item.diachi;
                gvTaikhoan.Rows[index].Cells[7].Value = item.email;
            }
        }
    }
}
