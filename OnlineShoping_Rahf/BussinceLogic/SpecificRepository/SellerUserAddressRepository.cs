using BussinceLogic.ISPecificRepository;
using DataAcsses.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using OnlineShoppingSystem.Models;
using OnlineShoppingSystem.Models.Genaric;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using static OnlineShoppingSystem.Models.DTOOnlineShopping;

namespace BussinceLogic.SpecificRepository
{
    public class SellerUserAddressRepository:ISellerUserAddress
    {
        private readonly IGenaricRepository<SellerAdress> GenaricSeller;
        private readonly IGenaricRepository<UserAdress> GenaricUser;
        private readonly IHttpContextAccessor httpContextAccessor;
        public SellerUserAddressRepository(GenaricRepostory<SellerAdress> _GenaricSeller,
            GenaricRepostory<UserAdress> _GenaricUser, IHttpContextAccessor _httpContextAccessor)
        {
            GenaricSeller = _GenaricSeller;
            GenaricUser = _GenaricUser;
            httpContextAccessor = _httpContextAccessor;
        }

        public void InserSeller(SellerAddressDTO obj)
        {
            var sellerId = httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var repeted = Repeted(obj);
            if(repeted !=null)
            {
                SellerAdress seller = new SellerAdress
                {
                    SellerId = Convert.ToInt32(sellerId),
                    CityId = obj.CityId,
                    CountryId = obj.CountryId
                };
                GenaricSeller.Insert(seller);
                GenaricSeller.Save();
            }
            else
            {
               
              
            }
          
        }

        public void InserUser(EditProfileSellerDTO obj)
        {
            var userid = httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var repeet = Repert(obj);
            if(repeet !=null)
            {
                UserAdress User = new UserAdress
                {
                    USerId = Convert.ToInt32(userid),
                    CityId = obj.City,
                    CountryId = obj.Country,
                    Address = obj.Address
                };
                GenaricUser.Insert(User);
                GenaricUser.Save();
            }
            else
            {
               
            }
           
        }

        public EditProfileSellerDTO Repert(EditProfileSellerDTO obj)
        {
            var userid = httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var address = GenaricUser.GetAlls()
            .Where(x => x.CountryId == obj.Country
            && x.CityId == obj.City && x.Address == obj.Address)
            .FirstOrDefault();

            if (address == null)
            {
                EditProfileSellerDTO useraddress = new EditProfileSellerDTO
                {
                    Country = obj.Country,
                    City = obj.City,
                    Address = obj.Address
                };
                return useraddress;
            }
            else
            {
                return null;
            }
        }

        public SellerAdress GetSeller(int id)
        {
            return GenaricSeller.GetById(id);
        }

        public SellerAddressDTO Repeted(SellerAddressDTO obj)
        {
            var sellerId = httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);

            var address = GenaricSeller.GetAlls().
                Where(x => x.CityId == obj.CityId && x.CountryId==obj.CountryId).
                FirstOrDefault();
            if(address==null)
            {
              SellerAddressDTO model = new SellerAddressDTO
            {
                 CountryId = obj.CountryId,
                CityId=obj.CityId,
                SellerId= sellerId

              };
                return model;
            }
            else
            {
                return null;
            }
            
           
        }

        public void UpdateSeller(SellerAddressDTO obj)
        {
            var sellerId = httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var sellerAddres = GetSeller(Convert.ToInt32(sellerId));
            var repet = Repeted(obj);
            if (repet != null)
            {
                SellerAdress seller = new SellerAdress
                {
                    SellerId = Convert.ToInt32(sellerId),
                    CityId = obj.CityId,
                    CountryId = obj.CountryId
                };
                GenaricSeller.Update(seller);
                GenaricSeller.Save();
            }
            else
            {

                
            }

        }
        public void DeleteSeller(int id)
        {
            GenaricSeller.Delete(id);
            GenaricSeller.Save();
        }
        public void DeleteUserAddress(int id)
        {
            GenaricUser.Delete(id);
            GenaricUser.Save();
        }

        public List<SellerAddressDTO> GetAllAddress(int id)
        {
            var AllAddress = GenaricSeller.GetAlls().Include(a => a.City).Include(a => a.Country).
                 Where(a => a.SellerId == id).ToList();
            List<SellerAddressDTO> Address = new List<SellerAddressDTO>();
            
                Address.Add(new SellerAddressDTO
                {
                      ListOfAddress=AllAddress
                });
            

            return Address;
        }

        public List<UserAdress> GetAllAddressUser(int id)
        {
            var AllAddress = GenaricUser.GetAlls().Include(a => a.City).Include(a => a.Country).
                 Where(a => a.USerId == id).ToList();
            return AllAddress;
        }

        public void UpdateUserAddress(EditProfileSellerDTO obj)
        {
            var userid = httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var repeet = Repert(obj);
            if (repeet != null)
            {
                UserAdress User = new UserAdress
                {
                    USerId = Convert.ToInt32(userid),
                    CityId = obj.City,
                    CountryId = obj.Country,
                    Address = obj.Address
                };
                GenaricUser.Update(User);
                GenaricUser.Save();
            }
            else
            {
                
            }

        }
    }
}
