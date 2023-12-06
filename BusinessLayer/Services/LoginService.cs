using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Security;
using DataAccessLayer.Repository;
using EmployeeTrainingRegistration.Models;

namespace BusinessLayer.Services
{
    public class LoginService : ILoginService
    {
        private readonly ILoginRepository _accountRepository;
        public LoginService(ILoginRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }
        public bool LoginResults(string emailAddress, string password)
        {
            return _accountRepository.IsAuthenticated(emailAddress, password);
        }
    }
}

