using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DataProvider
    {
        private static DataProvider instance;
        private string connectionSTR = @"Data Source=LAPTOP-92HVSNLS\SQLEXPRESS;Initial Catalog=QuanLyNhaHang;Integrated Security=True";
        public static DataProvider Instance {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set => instance = value; }
        private DataProvider() { }
        public DataTable ExtecuteQuery(string query, object[] parameters = null)
        {
            DataTable data = new DataTable();
            using(SqlConnection connection=new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (parameters != null)
                {
                    int i = 0;
                    string[] listPara = query.Split(' ');
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameters[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }

        public int ExtecuteNonQuery(string query, object[] parameters = null)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (parameters != null)
                {
                    int i = 0;
                    string[] listPara = query.Split(' ');
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameters[i]);
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
