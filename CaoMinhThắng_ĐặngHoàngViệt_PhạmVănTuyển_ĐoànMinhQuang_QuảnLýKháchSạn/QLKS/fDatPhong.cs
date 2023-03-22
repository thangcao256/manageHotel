using QLKS.DAO;
using QLKS.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS
{
    public partial class fDatPhong : Form
    {
        public fDatPhong()
        {
            InitializeComponent();
            LoadList();
        }

        private void btnTrove_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void LoadList()
        {
            LoadRoom();
            LoadServiceList();
        }

        void LoadServiceList()
        {
            List<DICHVU> ServiceList = DICHVUDAO.Instance.LoadServiceList();
            cbbDichvu.DataSource = ServiceList;
            cbbDichvu.DisplayMember = "ten_DV";
        }
        void LoadRoom()
        {
            flpnDsphong.Controls.Clear();
            List<PHONG> TableList = PHONGDAO.Instance.LoadRoomList();
            foreach (PHONG item in TableList)    //với mỗi table nằm trong TableList tạo nút button
            {
                Button btn = new Button()
                {
                    Width = PHONGDAO.TableWidth,
                    Height = PHONGDAO.TableHeight,
                };
                btn.Text = item.id_P + Environment.NewLine + item.tinhtrang;
                btn.Click += btn_click;
                btn.Tag = item;

                switch (item.tinhtrang)
                {
                    case "Sẵn sàng":
                        btn.BackColor = Color.Blue;
                        btn.ForeColor = Color.White;
                        break;
                    default:
                        btn.BackColor = Color.Yellow;
                        break;
                }
                flpnDsphong.Controls.Add(btn);//add controls vào Table;
            }
        }

        private void btn_click(object sender, EventArgs e)
        {
            string RoomID = ((sender as Button).Tag as PHONG).id_P;
            lvsDichvu.Tag = (sender as Button).Tag; //Lưu phòng khi chọn vào lsvBill
            ShowBill(RoomID);
        }

        void ShowBill(string id_P)
        {
            // List<BillInfo> listBillInfo = BillInfoDAO.Instance.GetListBillInfo(BillDAO.Instance.GetUncheckBillIDByRoomID(id));
            List<MenuList> listBillInfo = MenuListDAO.Instance.GetListMenuByRoom(id_P);
            lvsDichvu.Items.Clear();

            float totalPrice = 0;
            foreach (MenuList item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.Ten_DV.ToString());
                lsvItem.SubItems.Add(item.Soluong.ToString());
                lsvItem.SubItems.Add(item.Gia_DV.ToString());
                lsvItem.SubItems.Add(item.Tong.ToString());
                totalPrice += item.Tong;
                lvsDichvu.Items.Add(lsvItem);
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            txtTT.Text = totalPrice.ToString("c", culture);
 
        }

        private void btnThuephong_Click(object sender, EventArgs e)
        {
            fHoaDon f = new fHoaDon();
            this.Hide();
            f.ShowDialog();
            this.Show();
            LoadRoom();
        }

        private void btnThemkhach_Click(object sender, EventArgs e)
        {
            fKhachHang f = new fKhachHang();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnThanhtoan_Click(object sender, EventArgs e)
        {
            PHONG room = lvsDichvu.Tag as PHONG;
            if (room == null)
            {
                MessageBox.Show("Hãy chọn phòng muốn thanh toán!");
                return;
            }
            int idBill = HOADONDAO.Instance.GetUncheckBillIDByRoomID(room.id_P); //idbill = idroom khi chọn phòng

            if (idBill > -1)
            {
                if (MessageBox.Show("Bạn có chắc muốn thanh toán cho " + room.ten_P + " không ?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {

                    HOADONDAO.Instance.CheckOut(idBill);
                    ShowBill(room.id_P);
                    LoadRoom();
                }
            }
        }

        private void btnThemdv_Click(object sender, EventArgs e)
        {
            PHONG room = lvsDichvu.Tag as PHONG;

            int idBill = HOADONDAO.Instance.GetUncheckBillIDByRoomID(room.id_P); //Lấy ra phòng hiện tại khi chọn
            string idService = (cbbDichvu.SelectedItem as DICHVU).id_DV; //Lấy ra ID service
            int intCount = (int)nmrDichvu.Value;
            if (room == null)
            {
                MessageBox.Show("Hãy chọn Phòng");
                return;
            }

            if (idBill == -1)
            {
                MessageBox.Show("Phòng này chưa có khách!");
            }
            else
            {
                if (CHITIETHOADONDAO.Instance.InsertBillInfo(idBill, idService, intCount))
                {
                    MessageBox.Show("Thêm dịch vụ vào thành công!");
                    ShowBill(room.id_P);
                }
                else
                {
                    MessageBox.Show("Thêm dịch vụ thất bại!");
                }
            }
        }
    }
}
