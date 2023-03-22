using QLKS.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QLKS.DAO
{
    public class PHONGDAO
    {
        private static PHONGDAO instance;

        public static PHONGDAO Instance
        {
            get { if (instance == null) instance = new PHONGDAO(); return PHONGDAO.instance; }
            private set { PHONGDAO.instance = value; }
        }
        private PHONGDAO() { }

        public static int TableWidth = 80;
        public static int TableHeight = 80;

        public List<PHONG> LoadRoomList()
        {
            List<PHONG> RoomList = new List<PHONG>(); //Chuyển từng Rows thành List<Room> //Xây hàm dụng để dataRow đưa vào

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetRoomListt");

            foreach (DataRow item in data.Rows) //Đưa item vào DataRow
            {
                PHONG table = new PHONG(item);
                RoomList.Add(table);
            }

            return RoomList;
        }
        public List<PHONG> GetRoomByRoomTypeID(string id_LP)
        {
            List<PHONG> list = new List<PHONG>();

            string query = "select * from PHONG where id_LP = '" + id_LP + "'";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                PHONG room = new PHONG(item);
                list.Add(room);
            }

            return list;
        }
    }
}
