using QLKS.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.DAO
{
    public class MenuListDAO
    {
        private static MenuListDAO instance;

        public static MenuListDAO Instance
        {
            get { if (instance == null) instance = new MenuListDAO(); return MenuListDAO.instance; }
            private set { MenuListDAO.instance = value; }
        }
        
        private MenuListDAO() { }

        // Lấy ra danh sách menu dịch vụ theo mã phòng
        public List<MenuList> GetListMenuByRoom(string id_P)
        {
            List<MenuList> listMenu = new List<MenuList>();

            string query = "SELECT s.ten_DV, bi.soluong, s.gia_DV, s.gia_DV*bi.soluong as TT FROM dbo.CHITIETHOADON AS bi, dbo.HOADON AS b, dbo.DICHVU AS s WHERE bi.id_HD = b.id_HD AND bi.id_DV = s.id_DV AND b.tinhtrang = 0 AND b.id_P = '" + id_P + "'" ;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                MenuList menu = new MenuList(item);

                listMenu.Add(menu);
            }

            return listMenu;
        }
    }
}
