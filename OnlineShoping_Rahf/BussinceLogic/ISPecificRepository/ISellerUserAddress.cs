using DataAcsses.Entity;
using OnlineShoppingSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;
using static OnlineShoppingSystem.Models.DTOOnlineShopping;

namespace BussinceLogic.ISPecificRepository
{
    public interface ISellerUserAddress
    {
        void InserUser(EditProfileSellerDTO obj);
        List<UserAdress> GetAllAddressUser(int id);
        void DeleteUserAddress(int id);
        void InserSeller(SellerAddressDTO obj);

        //SellerAdress GetSeller(string id);
        SellerAdress GetSeller(int id);

        void UpdateSeller(SellerAddressDTO obj);
        void UpdateUserAddress(EditProfileSellerDTO obj);
        void DeleteSeller(int id);

        List<SellerAddressDTO> GetAllAddress(int id);
    }
}
