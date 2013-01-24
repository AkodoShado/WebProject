using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MySuperApp.Repository
{
    public class User
    {
        public string Name{get; set;}
        public string Surname{get; set;}
        public string Email{get; set;}
    }

    public class UserRepository
    {
        public User Get(int id)
        {
            return new User
            {
                Name = "Michał",
                Surname = "Wójcik",
                Email = "misza.wojcik@gmail.com",
            };
        }
    }
}