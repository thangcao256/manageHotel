using QLKS.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.DAO
{
    public class KHACHHANGDAO
    {
        private static KHACHHANGDAO instance;

        public static KHACHHANGDAO Instance
        {
            get { if (instance == null) instance = new KHACHHANGDAO(); return KHACHHANGDAO.instance; }
            private set => instance = value;
        }
        private KHACHHANGDAO() { }

        public List<KHACHHANG> LoadCustomer()
        {
            List<KHACHHANG> CustomerList = new List<KHACHHANG>(); //Chuyển từng Rows thành List<Room> //Xây hàm dụng để dataRow đưa vào

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_LoadCustomerr");

            foreach (DataRow item in data.Rows) //Đưa item vào DataRow
            {
                KHACHHANG table = new KHACHHANG(item);
                CustomerList.Add(table);
            }

            return CustomerList;
        }

    }
}
