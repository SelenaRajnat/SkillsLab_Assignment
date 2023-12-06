using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeTrainingRegistration.Models;
using EmployeeTrainingRegistration.DataService;
using System.Diagnostics;
using System.Security.Principal;

namespace DataAccessLayer.Repository
{
    public class LoginRepository : ILoginRepository
    {
        private readonly IDAL _dataAccesslayer;

        private const string NewAccount = @"INSERT INTO UserAccount(EmailAddress, Password, RoleID) 
                                                  VALUES(@EmailAddress, @HashedPassword, @UserAccountStatus, @RoleID)";
        private const string AccountUsingEmailAddress = @"SELECT UserAccountID, EmailAddress, HashedPassword,RoleID 
                                                                FROM UserAccount WHERE EmailAddress=@emailAddress";
        private const string AuthenticateUserAccount = @"SELECT 1 FROM UserAccount WHERE EmailAddress=@EmailAddress AND HashedPassword = @Password";
        public LoginRepository(IDAL layer)
        {
            _dataAccesslayer = layer;
        }
        public UserAccount GetAccountByEmailAddress(string emailAddress)
        {
            UserAccount userAccount = new UserAccount();
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@emailAddress", emailAddress));
            var dataTable = _dataAccesslayer.GetDataWithConditions(AccountUsingEmailAddress, parameters);
            foreach (DataRow row in dataTable.Rows)
            {
                userAccount.UserAccountID = Convert.ToInt32(row["UserAccountID"]);
                userAccount.EmailAddress = row["EmailAddress"].ToString();
                userAccount.Password = row["HashedPassword"].ToString();
                userAccount.RoleID = Convert.ToInt32(row["RoleID"]);
            }
            return userAccount;
        }
        public bool InsertedNewAccount(UserAccount newUser)
        {
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter("@EmailAddress", newUser.EmailAddress));
                parameters.Add(new SqlParameter("@HashedPassword", newUser.Password));
                parameters.Add(new SqlParameter("@RoleID", newUser.RoleID));

                int userCount = _dataAccesslayer.ExecuteQuery(NewAccount, parameters);

                return userCount > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool IsAuthenticated(string emailAddress, string password)
        {
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@EmailAddress", SqlDbType.VarChar, 100) { Value = emailAddress },
                    new SqlParameter("@Password", SqlDbType.VarChar, 30) { Value = password}
                };
               // string sql = "SELECT 1 FROM login WHERE username=@EmailAddress AND password=@Password";
                var dataTable = _dataAccesslayer.GetData(AuthenticateUserAccount, parameters);

                return (dataTable.Rows.Count > 0);   
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

