using System;
using Xunit;
using Moq;
using System.Collections.Generic;
using System.Linq;

namespace TDD.Tests
{
    public class UserRegistrationTests : IDisposable
    {
        private UserRegistration _userRegistration = new();

        [Fact]
        public void User_Should_Be_Succesfully_Registered()
        {
            //Arrange
            string firstName = "first name";
            string lastName = "Last name";
            int age = 20;
            UserRegistration userRegistrationService = new();

            //Act
            bool result = _userRegistration.Register(firstName, lastName, age);

            //Assert
            Assert.Equal(result,true);
            Assert.Contains($"{firstName} {lastName} {age}", UserRegistration.GetUserDatabase());
        }

        [Fact]
        public void User_Should_Not_Be_Blank()
        {
            //Arrange
            string firstName = "";
            string lastName = "";
            int age = 18;
            UserRegistration userRegistrationService = new();

            //Act
            bool result = _userRegistration.Register(firstName, lastName, age);

            //Assert
            Assert.Equal(result, false);
            Assert.DoesNotContain($"{firstName} {lastName} {age}", UserRegistration.GetUserDatabase());
        }

        [Fact]
        public void Get_Users_Should_Return_All_Users()
        {
            //Arrange
            string firstName1 = "Andrei";
            string lastName1 = "Albu";
        
            string firstName2 = "Radu";
            string lastName2 = "Negru";

            UserRegistration userRegistrationService = new();
            _userRegistration.Register(firstName1, lastName2);
            _userRegistration.Register(firstName2, lastName2);

            //Act
            var result = UserRegistration.GetUserDatabase();

            //Assert
            Assert.NotNull(result);
            Assert.IsAssignableFrom<IEnumerable<string>>(result);
            Assert.Equal(2, result.Count());
        }
        public void Dispose()
        {
            UserRegistration.UserDatabase = new List<string>();
            _userRegistration = new();
        }
    }
}
