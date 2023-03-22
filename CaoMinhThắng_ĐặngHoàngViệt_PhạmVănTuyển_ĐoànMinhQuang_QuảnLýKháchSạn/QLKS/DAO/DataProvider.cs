using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;
        // Đóng gói
        public static DataProvider Instance
        {
            //get => instance
            //set => instance = value
            get
            {
                if (instance == null) instance = new DataProvider();
                return DataProvider.instance;
            }
            private set { DataProvider.instance = value; }
        }

        // Hàm dựng (constructor)
        private DataProvider() { }

        // Kết nối Database
        // @ dấu trước : đường link tuyệt đối.
        string connectionSTR = "Data Source=MINHTHANG\\SQLEXPRESS;Initial Catalog=QLKS;Integrated Security=True";

        // Hàm để lấy dữ liệu từ database lên và dùng lại, sau này dùng chỉ cần thay đổi câu "query"
        // Dùng list object để có thể truyền nhiều tham số (paramster) vào
        public DataTable ExecuteQuery(string query, object[] parameter = null) //Truyền Parameter
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionSTR)) // Sử dụng database đã được kết nối ở trên
            {
                connection.Open();
                // Thực thi (Execute) câu truy vấn (query) đưuọc truyền vào phía trên trong
                // Sqlconnection có tên "connection" (Giống thao tác bên SQL Sever)
                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null) // Đặt điều kiện cho tham số
                {
                    string[] listPara = query.Split(' '); //Split theo khoảng trắng
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@')) //dấu @ chứa parameter, để add n parameter, có nghĩa là có tham số
                        {
                            command.Parameters.AddWithValue(item, parameter[i]); // Đưa tham số vào vị trí i
                            i++;
                        }
                    }
                }
                //Trung gian dữ liệu từ câu truy vấn đã được thực thi
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                // Đổ dữ liệu vào data
                adapter.Fill(data);

                connection.Close();
            }

            return data;
        }

        // Trả ra số lượng dòng thực thi thành công khi thêm, xoá, sửa dữ liệu
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;

            using (SqlConnection connection = new SqlConnection(connectionSTR)) // Sử dụng database đã được kết nối ở trên
            {
                connection.Open();
                // Thực thi (Execute) câu truy vấn (query) đưuọc truyền vào phía trên trong
                // Sqlconnection có tên "connection" (Giống thao tác bên SQL Sever)
                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)  // Đặt điều kiện cho tham số
                {
                    string[] listPara = query.Split(' '); //Split theo khoảng trắng
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@')) //dấu @ chứa parameter, để add n parameter, có nghĩa là có tham số
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);  // Đưa tham số vào vị trí i
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();

                connection.Close();
            }

            return data;
        }
    }
}
