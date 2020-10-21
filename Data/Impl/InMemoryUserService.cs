using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication.Data.Models;
using WebApplication.Data.Models;

namespace WebApplication.Data.Impl
{
    public class InMemoryUserService : IUserService
    {
        private List<User> users;

        public InMemoryUserService()
        {
            users = new []
            {
                new User
                {
                    username = "Bigworthybutt",
                    password = "12345",
                    authorityLevel = 1
                },
                new User
                {
                    username = "Smellybob",
                    password = "password",
                    authorityLevel = 4
                }
            }.ToList();

        }
        
        public User ValidateUser(string username, string password)
        {
            User first = users.FirstOrDefault(user => user.username.Equals(username));
            if(first == null){
            throw new Exception("User not found");
            }
            if (!first.password.Equals(password))
            {
                throw new Exception("Incorrect password"); 
            }

            return first;
        }
        
        
    }
}