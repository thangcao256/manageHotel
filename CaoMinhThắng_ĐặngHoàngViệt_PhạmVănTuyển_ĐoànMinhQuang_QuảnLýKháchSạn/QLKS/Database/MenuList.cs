using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.Database
{
    public class MenuList
    {
        public MenuList(string ten_DV, int soluong, float gia_DV = 0, float tong = 0)
        {

            this.Ten_DV = ten_DV;
            this.Soluong = soluong;
            this.Gia_DV = gia_DV;
            this.tong = tong;
        }

        public MenuList(DataRow row)
        {

            this.ten_DV = row["ten_DV"].ToString();
            this.Soluong = (int)row["soluong"];
            this.Gia_DV = (float)Convert.ToDouble(row["gia_DV"].ToString());
            this.tong = (float)Convert.ToDouble(row["TT"].ToString());
        }

        private float gia_DV;
        private int soluong;
        private string ten_DV;
        private float tong;

        public float Gia_DV { get => gia_DV; set => gia_DV = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public string Ten_DV { get => ten_DV; set => ten_DV = value; }
        public float Tong { get => tong; set => tong = value; }
    }
}
