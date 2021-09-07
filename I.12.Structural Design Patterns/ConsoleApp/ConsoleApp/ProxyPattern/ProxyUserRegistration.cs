using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.ProxyPattern
{
    class ProxyUserRegistration : IUserRegistration
    {
        private IUserRegistration _userRegistrationService;
        public ProxyUserRegistration()
        {
            _userRegistrationService = new UserRegistration();
        }
        public bool CheckAccess()
        {
            Console.WriteLine("Enter credentials:");
            string id = Console.ReadLine(); 
            string password = Console.ReadLine(); 

            if (id.Equals("Adm1n") && password.Equals("123456789"))
            {
                return true; 
            }
            return false;
        }

        public void ListAllUsers()
        {
            if (CheckAccess())
            {
                _userRegistrationService.ListAllUsers();
            }
        }

        public void RegisterUser()
        {
            if(CheckAccess())
            {
                _userRegistrationService.RegisterUser();
            }
        }
    }
}
