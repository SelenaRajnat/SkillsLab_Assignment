using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace EmployeeTrainingRegistration.DataService
{
    public class DAL : IDAL
    {
        public SqlConnection Connection { get; private set; }
        public string Connect()
        {
            try
            {
                var connectionString = ConfigurationManager.AppSettings["DefaultConnectionString"];
                if (!string.IsNullOrEmpty(connectionString))
                {
                    Connection = new SqlConnection(connectionString);
                    Connection.Open();
                }
            }
            catch (Exception ex)
            {
                return "Unable to find the connection string " + ex.Message;
            }
            return "DB Connect: OK";
        }
        public string Connect(string connectionString)
        {
            try
            {
                if (!string.IsNullOrEmpty(connectionString))
                {
                    Connection = new SqlConnection(connectionString);
                    Connection.Open();
                }
            }
            catch (Exception ex)
            {
                return "Unable to find the connection string " + ex.Message;
            }
            return "DB Connect: OK";
        }
        public void Disconnect()
        {
            if (Connection != null && Connection.State.Equals(ConnectionState.Open))
            {
                Connection.Close();
            }
        }
        public int ExecuteQuery(string query, List<SqlParameter> parameters)
        {
            Connect();
            using (SqlCommand cmd = new SqlCommand(query, Connection))
            {
                cmd.Parameters.AddRange(parameters.ToArray());
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected;
            }
            //Disconnect();
        }
        public DataTable GetData(string query, List<SqlParameter> parameters)
        {
            Connect();
            DataTable dt = new DataTable();
            using (SqlCommand cmd = new SqlCommand(query, Connection))
            {
                cmd.Parameters.AddRange(parameters.ToArray());
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                return dt;
            }
        }
        public DataTable GetDataWithConditions(string query, List<SqlParameter> parameters)
        {
            Connect();
            DataTable dataTable = new DataTable();
            using (SqlCommand command = new SqlCommand(query, Connection))
            {
                command.CommandType = CommandType.Text;
                if (parameters != null)
                {
                    parameters.ForEach(parameter => {
                        command.Parameters.AddWithValue(parameter.ParameterName, parameter.Value);
                    });
                }
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                {
                    dataAdapter.Fill(dataTable);
                }
            }
            Disconnect();
            return dataTable;
        }
        public DataTable RetrieveData(string sql)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["DefaultConnectionString"]))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        return dataTable;
                    }
                }
            }
        }

    }

}