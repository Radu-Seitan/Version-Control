using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.ProxyPattern
{
    class UserRegistration : IUserRegistration
    {
        private List<string> _userDatabase = new();

        public void ListAllUsers()
        {
            foreach (var p in _userDatabase)
            {
                Console.WriteLine($"{p}\n");
            }
        }

        public void RegisterUser()
        {
            Console.WriteLine("First name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Last name:");
            string lastName = Console.ReadLine();
            _userDatabase.Add($"{firstName} {lastName}");
            ListAllUsers();
        }
    }
}
