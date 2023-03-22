using QLKS.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.DAO
{
    public class LOAIPHONGDAO
    {
        private static LOAIPHONGDAO instance;

        public static LOAIPHONGDAO Instance
        {
            get { if (instance == null) instance = new LOAIPHONGDAO(); return LOAIPHONGDAO.instance; }
            private set { LOAIPHONGDAO.instance = value; }
        }

        private LOAIPHONGDAO() { }

        // Lấy ra danh sách thể loại phòng
        public List<LOAIPHONG> GetListRoomType()
        {
            List<LOAIPHONG> list = new List<LOAIPHONG>();

            string query = "select * from LOAIPHONG";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                LOAIPHONG roomtype = new LOAIPHONG(item);
                list.Add(roomtype);
            }

            return list;
        }

        // Lấy ra danh sách phòng theo mã loại phòng
        public LOAIPHONG GetRoomTypeByID(string id_LP)
        {
            LOAIPHONG roomtype = null;

            string query = "select * from PHONG where id_LP = '" + id_LP + "'";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                roomtype = new LOAIPHONG(item);
                return roomtype;
            }

            return roomtype;
        }
    }
}
