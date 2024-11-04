using BussinceLogic.ISPecificRepository;
using DataAcsses.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OnlineShoppingSystem.Models;
using OnlineShoppingSystem.Models.Genaric;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Text;
using static OnlineShoppingSystem.Models.DTOOnlineShopping;

namespace BussinceLogic.SpecificRepository
{
   public class CommanServer : ICommanServer
    {
        private readonly IGenaricRepository<Image> genaricRepositoryimage;
        private readonly IGenaricRepository<City> genaricRepostorycity;
        private readonly IGenaricRepository<Country> CountrygenaricRepository;
        private readonly IHttpContextAccessor httpContextAccessor;




        public CommanServer(GenaricRepostory<Image> _genaricRepostoryimage,
            GenaricRepostory<City> _genaricRepostorycity,
            GenaricRepostory<Country> _CountrygenaricRepository,
            IHttpContextAccessor _httpContextAccessor
           )
        {
            genaricRepositoryimage = _genaricRepostoryimage ;
            genaricRepostorycity = _genaricRepostorycity ;
            CountrygenaricRepository = _CountrygenaricRepository;
            httpContextAccessor = _httpContextAccessor;
        }
        public void DeleteImage(int id)
        {
            
            var image = genaricRepositoryimage.GetAlls().Where(x => x.ProductId == id).
                FirstOrDefault().Id;
            //var img = context.Images.Find(image);
            genaricRepositoryimage.Delete(image);
            genaricRepositoryimage.Save();
        }

       
        public List<City> GetAllCites(int id)
        {

            List<City> ListCites = genaricRepostorycity.GetAlls().Where(a => a.CountryId == id).ToList();
            return ListCites;
        }

      
        public List<Country> GetAllCountries()
        {
            List<Country> ListCountries = CountrygenaricRepository.GetAlls().ToList();
            return ListCountries;
        }

     

        public Image GetImage(int id)
        {
            Image image = genaricRepositoryimage.GetAlls()
                .Where(x => x.UserId == id).LastOrDefault();
            return image;

        }

        public ImageDTO GetImages(int id)
        {
            Image image = genaricRepositoryimage.GetAlls()
                .Where(x => x.ProductId == id).LastOrDefault();
            ImageDTO obj = new ImageDTO
            {
              
                Data=image.Data
            };
            return obj;
        }

        public void InsertImage(Image obj)
        {
            var userid = httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            //string userid = HttpContext.Session.GetString("UserId");

            //byte[] imageBytes = null;
            //BinaryReader reader = new BinaryReader(image.OpenReadStream());
            //imageBytes = reader.ReadBytes((int)image.Length);

            //List<Image> images = new List<Image>();
            //images.Add(new Image
            //{
            //    Name = image.Name,
            //    ContentType = image.ContentType,
            //    Data = imageBytes,
            //    UserId = Convert.ToInt32(userid)

            //});

            genaricRepositoryimage.Insert(obj);
            genaricRepositoryimage.Save();
        }

       

        public void UpdateImage(Image obj)
        {
            genaricRepositoryimage.Update(obj);
            genaricRepositoryimage.Save();
        }
      

    }
}
