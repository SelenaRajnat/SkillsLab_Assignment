using System.Web.Mvc;
using BusinessLayer.Services;
using DataAccessLayer.Repository;
using EmployeeTrainingRegistration.DataService;
using Unity;
using Unity.Mvc5;

namespace SkillsLab_Assignment
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IDAL, DAL>();
            container.RegisterType<ILoginService, LoginService>();
            container.RegisterType<ILoginRepository, LoginRepository>();
            container.RegisterType<IRegisterService, RegisterService>();
            container.RegisterType<IRegisterRepository, RegisterRepository>();
            container.RegisterType<ITrainingRespository, TrainingRepository>();
            container.RegisterType<ITrainingService, TrainingService>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}