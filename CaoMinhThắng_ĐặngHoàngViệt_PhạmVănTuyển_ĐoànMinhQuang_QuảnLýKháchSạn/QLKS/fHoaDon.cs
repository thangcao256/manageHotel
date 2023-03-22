using QLKS.DAO;
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
    public partial class fHoaDon : Form
    {
        public fHoaDon()
        {
            InitializeComponent();
            LoadList();
        }

        void LoadList()
        {
            LoadLoaiPhong();
            LoadDtgvHoadon();
            LoadKhachHang();
            DatPhongBinding();
        }
        void LoadDtgvHoadon()
        {
            string query = "USP_LoadDatPhongg";
            dtgvHoadon.DataSource = DataProvider.Instance.ExecuteQuery(query); //hiện thị dữ liệu lên dtgv

        }
        void DatPhongBinding()
        {
            cbbKhachhang.DataBindings.Add(new Binding("Text", dtgvHoadon.DataSource, "Khách hàng", true, DataSourceUpdateMode.Never));
            cbbLoaiphong.DataBindings.Add(new Binding("Text", dtgvHoadon.DataSource, "Loại phòng", true, DataSourceUpdateMode.Never));
            cbbPhong.DataBindings.Add(new Binding("Text", dtgvHoadon.DataSource, "Phòng", true, DataSourceUpdateMode.Never));
        }
        void LoadLoaiPhong()
        {
            List<LOAIPHONG> listRoomType = LOAIPHONGDAO.Instance.GetListRoomType();
            cbbLoaiphong.DataSource = listRoomType;
            cbbLoaiphong.DisplayMember = "ten_LP";
        }
        void LoadKhachHang()
        {
            List<KHACHHANG> CustomerList = KHACHHANGDAO.Instance.LoadCustomer();
            cbbKhachhang.DataSource = CustomerList;
            cbbKhachhang.DisplayMember = "ten";
        }
        void LoadRoomListByRoomTypeID(string id_LP)
        {
            List<PHONG> listFood = PHONGDAO.Instance.GetRoomByRoomTypeID(id_LP);
            cbbPhong.DataSource = listFood;
            cbbPhong.DisplayMember = "ten_P";
        }

        private void cbbLoaiphong_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id_LP = "";

            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            LOAIPHONG selected = cb.SelectedItem as LOAIPHONG;
            id_LP = selected.id_LP;

            LoadRoomListByRoomTypeID(id_LP);
        }

        private void btnThue_Click(object sender, EventArgs e)
        {
            string idCustomer = (cbbKhachhang.SelectedItem as KHACHHANG).id_KH;
            string idRoom = (cbbPhong.SelectedItem as PHONG).id_P;
            DialogResult d = MessageBox.Show("Bạn có chắc chắn muốn thuê phòng này không?", "Xác nhận lần cuối !", MessageBoxButtons.OKCancel);
            if(d == DialogResult.OK)
            {
                if (HOADONDAO.Instance.InsertBill(idCustomer, idRoom))
                {
                    MessageBox.Show("Thuê phòng thành công!");
                    LoadDtgvHoadon();
                }
                else
                {
                    MessageBox.Show("Thuê phòng thất bại!!!");
                }
            }
            else
            {
                MessageBox.Show("Đặt thì đặt, không đặt thì đặt !", " :'>>>>>",  MessageBoxButtons.OK);
            }
            
        }

        private void btnTrove_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
