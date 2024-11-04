using OnlineShoppingSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;
using static OnlineShoppingSystem.Models.DTOOnlineShopping;

namespace BussinceLogic.ISPecificRepository
{
    public interface IUser
    {
        void InsertUser(UserDTO obj);
        void UpdateUser(UserDTO obj);
        void Delete(int id);
        User GetUserByid(int id);
        List<User> GetAllUser(int id);
    }
}
