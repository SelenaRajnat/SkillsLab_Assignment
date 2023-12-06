using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeTrainingRegistration.Models;

namespace DataAccessLayer.Repository
{
    public interface ILoginRepository
    {
        UserAccount GetAccountByEmailAddress(string emailAddress);
        bool InsertedNewAccount(UserAccount account);
        bool IsAuthenticated(string emailAddress, string password); 
    }
}
