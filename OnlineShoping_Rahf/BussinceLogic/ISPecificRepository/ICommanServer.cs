using DataAcsses.Entity;
using Microsoft.AspNetCore.Identity;
using OnlineShoppingSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;
using static OnlineShoppingSystem.Models.DTOOnlineShopping;

namespace BussinceLogic.ISPecificRepository
{
   public interface ICommanServer
    {
        List<City> GetAllCites(int id);
        List<Country> GetAllCountries();
       
        void InsertImage(Image obj);
        Image GetImage(int id);
        ImageDTO GetImages(int id);
        void UpdateImage(Image obj);
        void DeleteImage(int id);


    }
}
