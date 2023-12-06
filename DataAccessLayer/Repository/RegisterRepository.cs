using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeTrainingRegistration.DataService;
using EmployeeTrainingRegistration.Models;
using DataAccessLayer.Models;

namespace DataAccessLayer.Repository
{
    public class RegisterRepository : IRegisterRepository
    {
        private readonly IDAL _dataAccesslayer;
        public RegisterRepository(IDAL layer)
        {
            _dataAccesslayer = layer;
        }
        public bool InsertNewEmployee(Employee employee)
        {
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>
                {
                new SqlParameter("@NIC", SqlDbType.VarChar, 15) { Value = employee.NationalIdentityNumber },
                new SqlParameter("@FirstName", SqlDbType.VarChar, 50) { Value = employee.FirstName },
                new SqlParameter("@LastName", SqlDbType.VarChar, 50) { Value = employee.LastName },
                new SqlParameter("@PhoneNumber", SqlDbType.Int) { Value = employee.PhoneNumber},
                new SqlParameter("@Department", SqlDbType.VarChar, 50) { Value = employee.Department },
                new SqlParameter("@ManagerName", SqlDbType.VarChar, 50) { Value = employee.ManagerName },
                new SqlParameter("@JobTitle", SqlDbType.VarChar, 50) { Value = employee.JobTitle},
                new SqlParameter("@EmailAddress", SqlDbType.VarChar, 50) { Value = employee.EmailAddress},
                new SqlParameter("@Password", SqlDbType.VarChar, 50) { Value = employee.NewPassword},
                };
                string sql = "INSERT INTO emp VALUES ('5',@NIC,@FirstName,@LastName,@PhoneNumber,@Department,@ManagerName,@JobTitle,@EmailAddress, @Password)";

                int userCount = _dataAccesslayer.ExecuteQuery(sql, parameters);

                return userCount > 0;
            }
            catch (Exception exInsert)
            {
                Console.Error.WriteLine("Error occur at Insertion." + exInsert.Message);
            }
            return false;
        }

    }
}

