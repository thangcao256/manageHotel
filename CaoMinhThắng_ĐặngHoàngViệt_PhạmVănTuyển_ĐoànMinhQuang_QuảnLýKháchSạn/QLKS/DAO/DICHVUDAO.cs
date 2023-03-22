using QLKS.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.DAO
{
    public class DICHVUDAO
    {
        private static DICHVUDAO instance;

        public static DICHVUDAO Instance
        {
            get { if (instance == null) instance = new DICHVUDAO(); return DICHVUDAO.instance; }
            private set => instance = value;
        }
        private DICHVUDAO() { }

        //
        public List<DICHVU> LoadServiceList()
        {
            List<DICHVU> ServiceList = new List<DICHVU>(); //Chuyển từng Rows thành List<Room> //Xây hàm dụng để dataRow đưa vào

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetServicee");

            foreach (DataRow item in data.Rows) //Đưa item = từng cột trong csdl vào DataRow
            {
                DICHVU table = new DICHVU(item);
                ServiceList.Add(table);
            }

            return ServiceList;
        }

        public bool InsertService(string ten_DV, float gia_DV)
        {

            string query = string.Format("INSERT DICHVU ( ten_DV, gia_DV) VALUES ( N'{0}', {1})", ten_DV, gia_DV);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
