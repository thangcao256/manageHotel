using QLKS.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.DAO
{
    public class HOADONDAO
    {
        private static HOADONDAO instance;
        // Đóng gói
        public static HOADONDAO Instance
        {
            get { if (instance == null) instance = new HOADONDAO(); return HOADONDAO.instance; }
            private set { HOADONDAO.instance = value; }
        }

        private HOADONDAO() { }

        public void CheckOut(int id_HD)
        {
            string query = " UPDATE HOADON Set ngaytra = GETDATE(), tinhtrang = 1 where id_HD = " + id_HD;

            DataProvider.Instance.ExecuteNonQuery(query);
        }


        public int GetUncheckBillIDByRoomID(string id_P) //lấy ra ra mã hoá đơn từ mã phòng 
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.HOADON WHERE id_P = N'" + id_P + "' and tinhtrang = 0");

            if (data.Rows.Count > 0)
            {
                HOADON bill = new HOADON(data.Rows[0]); // lấy row 0 là row đầu tiên là row id
                return bill.id_HD; 
            }
            else
            {
                return -1;
            }
            
        }
        public bool InsertBill(string id_KH, string id_P)
        {
            string query = string.Format("USP_InsertBilll @idCustomer = '{0}' , @idRoom = '{1}' ", id_KH, id_P);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;

        }

        public DataTable GetBillListByDate(DateTime ngayvao, DateTime ngaytra)
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_GetListBillByDate @ngayvao , @ngaytra", new object[] { ngayvao, ngaytra });
        }
    }
}
