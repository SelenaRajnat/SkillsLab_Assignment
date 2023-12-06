using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;
using EmployeeTrainingRegistration.Models;

namespace DataAccessLayer.Repository
{
    public interface IRegisterRepository
    {
        bool InsertNewEmployee(Employee employee);
    }
}
