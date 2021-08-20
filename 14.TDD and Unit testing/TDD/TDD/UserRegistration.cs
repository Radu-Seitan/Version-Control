using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    public class UserRegistration
    {
        public static List<string> UserDatabase = new();
        
        public bool Register(string firstName, string lastName, int age = 18)
        {
            if(firstName.Equals("") && lastName.Equals(""))
            {
                return false;
            }

            try
            { 
                UserDatabase.Add($"{firstName} {lastName} {age}");
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public static IEnumerable<string> GetUserDatabase()
        {
            return UserDatabase;
        }
    }
}
