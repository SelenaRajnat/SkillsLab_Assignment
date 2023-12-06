using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTrainingRegistration.DataService
{
    public interface IDAL
    {
        SqlConnection Connection { get; }
        string Connect();
        string Connect(string connectionString);
        void Disconnect();
        int ExecuteQuery(string sql, List<SqlParameter> parameters);
        DataTable GetData(string sql, List<SqlParameter> parameters);
        DataTable GetDataWithConditions(string query, List<SqlParameter> parameters);
        DataTable RetrieveData(string sql);


    }
}
