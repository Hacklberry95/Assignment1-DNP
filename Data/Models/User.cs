using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Data.Models
{
    public class User
    {
        public string username;
        public string password;
        public int authorityLevel;

        /*public User(string username, string password, int authorityLevel)
        {
            this.username = username;
            this.password = password;
            this.authorityLevel = authorityLevel;
        }*/
        
        public int getAuthority()
        {
            return authorityLevel;
        }
    }
}