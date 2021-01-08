using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaketyManagement.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;

        private String strConnection = @"Data Source=DESKTOP-T7UP8J0;Initial Catalog=BakeryManagement;Integrated Security=True";

        //private String strConnection = @"Data Source=DESKTOP-LG103V8;Initial Catalog=BakeryManagement;Integrated Security=True";
        public static DataProvider Instance
        {
            get
            {
                if (DataProvider.instance == null)
                {
                    instance = new DataProvider();
                }
                return instance;
            }
            private set => instance = value;
        }
        private DataProvider() { }
        public DataTable ExecuteQuery(String query,object[] parameters=null)
        {
            DataTable table = new DataTable();
            using(SqlConnection connection=new SqlConnection(strConnection))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (query!=null)
                {
                    Int32 i = 0;
                    String[] queries = query.Split(' ');
                    foreach (String str in queries)
                    {
                        if (str.Contains('@'))
                        {
                            command.Parameters.AddWithValue(str, parameters[i]);
                            i++;
                        }
                    }
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(table);
                }      
            }
            return table;
        }
        public Int32 ExecuteNonQuery(String query, object[] parameters=null)
        {
            Int32 result = 0;
            using (SqlConnection connection = new SqlConnection(strConnection))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (query != null)
                {
                    Int32 i = 0;
                    String[] queries = query.Split(' ');
                    foreach (String str in queries)
                    {
                        if (str.Contains('@'))
                        {
                            command.Parameters.AddWithValue(str, parameters[i]);
                            i++;
                        }
                    }
                    result = command.ExecuteNonQuery();
                }
            }
            return result;
        }
        public Object ExecuteScalar(String query, object[] parameters = null)
        {
            object result = null;
            using (SqlConnection connection = new SqlConnection(strConnection))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (query != null)
                {
                    Int32 i = 0;
                    String[] queries = query.Split(' ');
                    foreach (String str in queries)
                    {
                        if (str.Contains('@'))
                        {
                            command.Parameters.AddWithValue(str, parameters[i]);
                            i++;
                        }
                    }
                    result = command.ExecuteScalar();
                }
            }
            return result;
        }
    }
}
