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
    public partial class fQLPhong : Form
    {
        public fQLPhong()
        {
            InitializeComponent();
            loadDSPhong();
        }
        void loadDSPhong()
        {
            QLKSContextDB context = new QLKSContextDB();
            List<PHONG> listPhong = context.PHONG.ToList();
            BindGrid(listPhong);
        }
        // hàm xóa trắng dữ liệu ở text box
        private void clearTxtBox()
        {
            txtMaphong.Clear();
            txtTenphong.Clear();
            txtLoaiphong.Clear();
            cbbTinhtrang.Items.Clear();
        }
        // hàm kiểm tra có tồn tại mã phòng tương ứng hay không
        private int kiemTraTonTai()
        {
            QLKSContextDB context = new QLKSContextDB();
            PHONG kh = context.PHONG.FirstOrDefault(p => p.id_P == txtMaphong.Text);
            if (kh == null)
                return 1;
            else
                return -1;
        }
        //hàm binding gridview từ list phòng
        private void BindGrid(List<PHONG> listPhong)
        {
            dtgvDsphong.Rows.Clear();
            foreach (var item in listPhong)
            {
                int index = dtgvDsphong.Rows.Add();
                dtgvDsphong.Rows[index].Cells[0].Value = item.id_P;
                dtgvDsphong.Rows[index].Cells[1].Value = item.ten_P;
                dtgvDsphong.Rows[index].Cells[2].Value = item.id_LP;
                dtgvDsphong.Rows[index].Cells[3].Value = item.tinhtrang;
            }
        }
        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            QLKSContextDB context = new QLKSContextDB();
            var timp = from k in context.PHONG
                       where (txtMaphong.Text == k.id_P || txtLoaiphong.Text == k.id_LP || txtTenphong.Text == k.ten_P
                       || cbbTinhtrang.Text == k.tinhtrang)
                       select new
                       {
                           maphong = k.id_P,
                           tenphong = k.ten_P,
                           loaiphong = k.id_LP,
                           tinhtrang = k.tinhtrang,
                       };
            dtgvDsphong.Rows.Clear();
            foreach (var item in timp)
            {
                int index = dtgvDsphong.Rows.Add();
                dtgvDsphong.Rows[index].Cells[0].Value = item.maphong;
                dtgvDsphong.Rows[index].Cells[1].Value = item.tenphong;
                dtgvDsphong.Rows[index].Cells[2].Value = item.loaiphong;
                dtgvDsphong.Rows[index].Cells[3].Value = item.tinhtrang;
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            try
            {
                loadDSPhong();
                clearTxtBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            QLKSContextDB context = new QLKSContextDB();
            if (txtMaphong.Text == "" || txtTenphong.Text == "" || txtLoaiphong.Text == "" || cbbTinhtrang.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK);
            }
            else

                try
                {
                    int temp = kiemTraTonTai();
                    if (temp == 1)
                    {

                        temp = dtgvDsphong.Rows.Add();
                        PHONG p = new PHONG
                        {
                            id_P = txtMaphong.Text,
                            id_LP = txtLoaiphong.Text,
                            ten_P = txtTenphong.Text,
                            tinhtrang = cbbTinhtrang.Text,


                        };
                        context.PHONG.Add(p);
                        context.SaveChanges();
                        clearTxtBox();
                        MessageBox.Show("Thêm mới thông tin phòng thành công!", "Thông báo", MessageBoxButtons.OK);
                        loadDSPhong();
                    }
                    else
                    {
                        MessageBox.Show("Đã tồn tại phòng này!", "Thông báo", MessageBoxButtons.OK);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string map = txtMaphong.Text;
            QLKSContextDB context = new QLKSContextDB();
            if (map == "")
                MessageBox.Show("Vui lòng nhập mã của phòng cần xóa!", "Thông báp", MessageBoxButtons.OK);
            try
            {
                for (int i = 0; i < dtgvDsphong.Rows.Count; i++)
                {
                    if (dtgvDsphong.Rows[i].Cells[0].Value.ToString() == map)
                    {
                        TAIKHOAN dbxoa = context.TAIKHOAN.FirstOrDefault(p => p.id_TK == txtMaphong.Text);
                        if (dbxoa != null)
                        {
                            DialogResult dr = MessageBox.Show("Bạn có muốn xóa thông tin phòng này?", "Thông báo", MessageBoxButtons.YesNo);
                            if (dr == DialogResult.Yes)
                            {
                                context.TAIKHOAN.Remove(dbxoa);
                                context.SaveChanges();
                                clearTxtBox();
                                loadDSPhong();
                                MessageBox.Show("Xóa thành công thông tin!", "Thông báo!", MessageBoxButtons.OK);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không tồn tại phòng có mã vừa nhập!", "Thông báo!", MessageBoxButtons.OK);
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
            PHONG p = context.PHONG.FirstOrDefault(pp => pp.id_P == txtMaphong.Text);
            if (txtMaphong.Text == "" || txtTenphong.Text == "" || txtLoaiphong.Text == "" || cbbTinhtrang.Text == "")
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK);
            else
            {
                try
                {
                    if (p != null)
                    {
                        p.id_P = txtMaphong.Text;
                        p.ten_P = txtTenphong.Text;
                        p.id_LP = txtLoaiphong.Text;
                        p.tinhtrang = cbbTinhtrang.Text;
                        context.SaveChanges();
                        clearTxtBox();
                        loadDSPhong();
                        MessageBox.Show("Sửa thông tin công!", "Thông báo", MessageBoxButtons.OK);
                        clearTxtBox();
                    }
                    else
                    {
                        MessageBox.Show("Không tồn tại phòng vừa nhập!", "Thông báo", MessageBoxButtons.OK);
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
            this.Close();
        }


        private void fQLPhong_Load(object sender, EventArgs e)
        {
            try
            {
                loadDSPhong();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDatphong_Click(object sender, EventArgs e)
        {
            fDatPhong f = new fDatPhong();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnLoaiphong_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đang cập nhật !", "Thông báo", MessageBoxButtons.OK);
        }

        private void dtgvDsphong_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgvDsphong.Rows[e.RowIndex];
                txtMaphong.Text = row.Cells[0].Value.ToString();
                txtTenphong.Text = row.Cells[1].Value.ToString();
                txtLoaiphong.Text = row.Cells[2].Value.ToString();
                cbbTinhtrang.Text = row.Cells[3].Value.ToString();
            }
        }
    }
}
