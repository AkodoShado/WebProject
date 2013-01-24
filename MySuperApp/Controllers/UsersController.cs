using MySuperApp.Models;
using MySuperApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MySuperApp.Controllers
{
    public class UsersController : ApiController
    {
        public UserViewModel Get(int id)
        {
            var userRepo =  new UserRepository();
            return new UserViewModel(userRepo.Get(id));
        }

        public void Save(UserViewModel user)
        {
        }
    }
}
