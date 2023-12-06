using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Services;
using DataAccessLayer.Models;
using DataAccessLayer.Repository;
using EmployeeTrainingRegistration.Models;

namespace BusinessLayer.Services
{
    public class RegisterService : IRegisterService
    {
        private readonly IRegisterRepository _employeeRepository;
        public RegisterService(IRegisterRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public bool RegisterResults(Employee employee)
        {
            return _employeeRepository.InsertNewEmployee(employee);
        }
    }
}

