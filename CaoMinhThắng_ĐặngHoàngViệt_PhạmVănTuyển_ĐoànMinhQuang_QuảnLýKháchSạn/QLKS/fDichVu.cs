using QLKS.Database;
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

namespace QLKS
{
    public partial class fDichVu : Form
    {
        public fDichVu()
        {
            InitializeComponent();
            LoadDichvuList();
        }

        // hàm xóa trắng dữ liệu ở text box
        private void clearTxtBox()
        {
            txtMadv.Clear();
            txtTendv.Clear();
            txtDg.Clear();
        }
        // hàm kiểm tra có tồn tại mã phòng tương ứng hay không
        private int kiemTraTonTai()
        {
            QLKSContextDB context = new QLKSContextDB();
            PHONG kh = context.PHONG.FirstOrDefault(p => p.id_P == txtMadv.Text);
            if (kh == null)
                return 1;
            else
                return -1;
        }
        //hàm binding gridview từ list phòng
        private void BindGrid(List<DICHVU> listDichvu)
        {
            dgvDichvu.Rows.Clear();
            foreach (var item in listDichvu)
            {
                int index = dgvDichvu.Rows.Add();
                dgvDichvu.Rows[index].Cells[0].Value = item.id_DV;
                dgvDichvu.Rows[index].Cells[1].Value = item.ten_DV;
                dgvDichvu.Rows[index].Cells[2].Value = item.gia_DV;
            }
        }
        private void LoadDichvuList()
        {
            QLKSContextDB context = new QLKSContextDB();
            List<DICHVU> listDichvu = context.DICHVU.ToList();
            BindGrid(listDichvu);
        }

        private void btnTrove_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            QLKSContextDB context = new QLKSContextDB();
            var timdv = from k in context.DICHVU
                       where (txtMadv.Text == k.id_DV || txtTendv.Text == k.ten_DV)
                       select new
                       {
                           madv = k.id_DV,
                           tendv = k.ten_DV,
                           giadv = k.gia_DV,
                       };
            dgvDichvu.Rows.Clear();
            foreach (var item in timdv)
            {
                int index = dgvDichvu.Rows.Add();
                dgvDichvu.Rows[index].Cells[0].Value = item.madv;
                dgvDichvu.Rows[index].Cells[1].Value = item.tendv;
                dgvDichvu.Rows[index].Cells[2].Value = item.giadv;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            QLKSContextDB context = new QLKSContextDB();
            if (txtMadv.Text == "" || txtTendv.Text == "" || txtDg.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK);
            }
            else

                try
                {
                    int temp = kiemTraTonTai();
                    if (temp == 1)
                    {

                        temp = dgvDichvu.Rows.Add();
                        PHONG p = new PHONG
                        {
                            id_P = txtMadv.Text,
                            id_LP = txtTendv.Text,
                            ten_P = txtDg.Text,

                        };
                        context.PHONG.Add(p);
                        context.SaveChanges();
                        clearTxtBox();
                        MessageBox.Show("Thêm mới thông tin dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK);
                        LoadDichvuList();
                    }
                    else
                    {
                        MessageBox.Show("Đã tồn tại dịch vụ này!", "Thông báo", MessageBoxButtons.OK);
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
            DICHVU dv = context.DICHVU.FirstOrDefault(pp => pp.id_DV == txtMadv.Text);
            if (txtMadv.Text == "" || txtTendv.Text == "" || txtDg.Text == "")
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK);
            else
            {
                try
                {
                    int x = Convert.ToInt32(txtMadv.Text);
                    if (dv != null)
                    {
                        dv.id_DV = txtMadv.Text;
                        dv.ten_DV = txtTendv.Text;
                        dv.gia_DV = x;
                        context.SaveChanges();
                        clearTxtBox();
                        LoadDichvuList();
                        MessageBox.Show("Sửa thông tin công!", "Thông báo", MessageBoxButtons.OK);
                        clearTxtBox();
                    }
                    else
                    {
                        MessageBox.Show("Không tồn tại dịch vụ vừa nhập!", "Thông báo", MessageBoxButtons.OK);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgvDichvu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvDichvu.Rows[e.RowIndex];
                dgvDichvu.Text = row.Cells[0].Value.ToString();
                dgvDichvu.Text = row.Cells[1].Value.ToString();
                dgvDichvu.Text = row.Cells[2].Value.ToString();
            }
        }

        private void fDichVu_Load(object sender, EventArgs e)
        {
            try
            {
                LoadDichvuList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
