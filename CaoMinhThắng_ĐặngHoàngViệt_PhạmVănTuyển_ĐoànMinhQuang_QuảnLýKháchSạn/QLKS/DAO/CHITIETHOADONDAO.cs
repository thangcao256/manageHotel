using QLKS.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.DAO
{
    public class CHITIETHOADONDAO
    {
        
        private static CHITIETHOADONDAO instance;
        // Đóng gói
        public static CHITIETHOADONDAO Instance
        {
            get { if (instance == null) instance = new CHITIETHOADONDAO(); return CHITIETHOADONDAO.instance; }
            private set { CHITIETHOADONDAO.instance = value; }
        }

        private CHITIETHOADONDAO() { }

        // Hàm thêm vào chi tiết hoá đơn mã hoá đơn, mã dịch vụ, số lượng dịch vụ
        public bool InsertBillInfo(int idBill, string idService, int intCount)
        {
            // string query = string.Format("INSERT INTO BillInfo([idBill], [idService], [intCount], [DateService]) Values ( {0} , {1} , {2} , GETDATE() )", idBill, idService, intCount );

            string query = string.Format("USP_InsertBillInfoo @idhoadon = {0} , @iddichvu = '{1}' , @soluong = {2} ", idBill, idService, intCount);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        // Hàm lấy thông tin chi tiết hoá đơn dựa trên mã hoá đơn
        public List<CHITIETHOADON> GetListBillInfo(int id) //id của Bill
        {
            List<CHITIETHOADON> listBillInfo = new List<CHITIETHOADON>();

            
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM BillInfo WHERE idBill= " + id);

            foreach (DataRow item in data.Rows)
            {
                CHITIETHOADON info = new CHITIETHOADON(item); //từ cái item khi nhấn button đưa vô
                listBillInfo.Add(info);
            }

            return listBillInfo; // Trả ra danh sách
        }
    }
}
