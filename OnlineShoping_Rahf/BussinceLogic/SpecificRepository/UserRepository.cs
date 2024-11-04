using BussinceLogic.ISPecificRepository;
using Microsoft.AspNetCore.Identity;
using OnlineShoppingSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BussinceLogic.SpecificRepository
{
   public class UserRepository:IUser
    {
        private readonly UserManager<User> userManager;
        public UserRepository(UserManager<User> _userManager)
        {
            userManager = _userManager;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAllUser(int id)
        {
            throw new NotImplementedException();
        }

        public User GetUserByid(int id)
        {
            throw new NotImplementedException();
        }

        public void InsertUser(DTOOnlineShopping.UserDTO obj)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(DTOOnlineShopping.UserDTO obj)
        {
            throw new NotImplementedException();
        }
    }
}
