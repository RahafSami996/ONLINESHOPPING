using DataAcsses.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
namespace OnlineShoppingSystem.Models
{
    public class DTOOnlineShopping
    {
        public class UserDTO
        {
            public int Id { get; set; }
            [Required]
            public string UserName { get; set; }
            [Required]
            [EmailAddress]
            public string Email { get; set; }
            [Required]
            [DataType(DataType.PhoneNumber)]
            public string Phone { get; set; }
            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }
            //public List<IdentityRole> ListOfRoles { get; set; }

            [Required]
            [Display(Name = "User Role")]
            public string UserRole { get; set; }
        }
        public class LoginDto
        {
            public string Id { get; set; }
            public string UserName { get; set; }
            //public string UserId { get; set; }
            [Required]
            public string Email { get; set; }
            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }
            [Display(Name = "Remember Me")]
            public bool RememberMe { get; set; }
        }
        public class RoleDTO
        {
            [Required]
            public string RoleName { get; set; }
        }

        public class EditUserDTO
        {
            public EditUserDTO()
            {
                Roles = new List<string>();
            }
            public int Id { get; set; }
            [Required]
            public string UserName { get; set; }
            [Required]
            public string Email { get; set; }
            [Required]
            public string Address { get; set; }
            [DataType(DataType.PhoneNumber)]
            public string Phone { get; set; }
            [DataType(DataType.Password)]
            public string Password { get; set; }
            public IList<string> Roles { get; set; }
        }

        public class ImageDTO
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string ContentType { get; set; }
            public byte[] Data { get; set; }
        }
        public class EditRoleDTO
        {
            public EditRoleDTO()
            {
                Users = new List<string>();
            }
            public int Id { get; set; }
            public string RoleName { get; set; }
            public List<string> Users { get; set; }
        }

        public class UserRoleDTO
        {
            public int UserId { get; set; }
            public int RoleId { get; set; }
            public string UserName { get; set; }
            public bool IsSelected { get; set; }
        }
        public class SellerProfile
        {
            public int Id { get; set; }
            [Required]
            public string UserName { get; set; }
            [Required]
            public string  Phone { get; set; }
            [Required]
            public string Email { get; set; }

        }
        public class EditProfileSellerDTO
        {
            public EditProfileSellerDTO()
            {
                ListCities = new List<City>();
                ListCountries = new List<Country>();
                ListOfAddress = new List<UserAdress>();
                CardPayment = new List<CardsPayment>();
            }
            public int Id { get; set; }
            [Required]

            public string UserName { get; set; }
            public List<City> ListCities { get; set; }
            public List<UserAdress> ListOfAddress { get; set; }
            public List<Country> ListCountries { get; set; }
            [DataType(DataType.EmailAddress)]
            [Required]
            public string Email { get; set; }
            [DataType(DataType.PhoneNumber)]
            [Required]
            public string phone { get; set; }
            [DataType(DataType.Password)]
            [Required]
            public string Password { get; set; }
            public byte[] Image { get; set; }
            public string Address { get; set; }
            public int City { get; set; }
            public int Country { get; set; }
            public int UserId { get; set; }
            public List<CardsPayment> CardPayment { get; set; }
            //public string Name { get; set; }
            //[Display(Name = "Expire Date")]
            //public DateTime ExpireDate { get; set; }
            //public int Status { get; set; }
            //[Display(Name = "Total Credit Ammount")]
            //public double TotalCreditAmmount { get; set; }
            //[Display(Name = "Availabel Credit")]
            //public double AvailableCredit { get; set; }
            //[Display(Name = "Celling Of Order")]
            //public double CellingOfOrder { get; set; }
            //public List<Status> ListStatus { get; set; }

        }


      public class CreatProductDTO
      {

          //  public int ProductId { get; set; }
            [Display(Name ="Product Name")]
            [Required]

            public string ProductName { get; set; }
            [Required]

            public double Price { get; set; }
            [Required]

            public string Code { get; set; }
            [Required]

            public int Quantity { get; set; }
            [Required]

            public int TypeId { get; set; }
            public int SeasonId { get; set; } 
            public IFormFile logoFile { get; set; }

            public List<ColorSizeDTO> ListColorSize{get; set;}

            }

        public class ProductDTO
        {

            public int ProductId { get; set; }
            [Display(Name ="Product Name")]
            [Required]

            public string ProductName { get; set; }
            [Required]

            public double Price { get; set; }
            [Required]

            public string Code { get; set; }
            [Required]

            public int Quantity { get; set; }
            [Required]

            public int TypeId { get; set; }
           
            public int Color { get; set; }
            public int Size { get; set; }
            public int SeasonId { get; set; }
            public string Seasons { get; set; }
            public string Type { get; set; }
            public List<ColorSizeDTO> ListColorSize { get; set; }
            public List<Seasons> ListSeasons { get; set; }
           public List<TypeOfLeather> ListTypeOfLeathers { get; set; }
            public List<Color> ListColors { get; set; }
            public List<Size> ListSizes { get; set; }
            public List<ProductColorSize> ListSizesColor { get; set; }

            public IFormFile logoFile { get; set; }
            public byte[] Image { get; set; }
            //public IFormFile Image { get; set; }
            public string image { get; set; }
            public ICollection<Image> Listofimage { get; set; }
            public List<Products> Listproduct { get; set; }
            
            [Required]

            public int QuantityColor { get; set; }
            [Display(Name = "Quantity Product")]
            public int QuantityProduct { get; set; }
            public List<Color> ListColor { get; set; }
            public List<Size> ListSize { get; set; }
           

            //public List<ProductColorSize> ListColorSize { get; set; }

        }



        public class MyViewModel
          {
             public IEnumerable<DataAcsses.Entity.SellerAdress> Seller { get; set; }
             public OnlineShoppingSystem.Models.DTOOnlineShopping.SellerAddressDTO Sellers { get; set; }
           }

        public class ColorSizeDTO
        {
            public int ProductId { get; set; }
            //[Required]
            //[Display(Name ="Product Name")]
            //public string ProductName { get; set; }
            public int Quantity { get; set; }
           
            //public int QuantityProduct { get; set; }
            //public List<Color> ListColor { get; set; }
            //public List<Size> ListSize { get; set; }
            

            public int Color { get; set; }
            public int Size { get; set; }
            

            //public List<ProductColorSize> ListColorSize { get; set; }

        }
        public class SellerAddressDTO
            
        {
            public SellerAddressDTO()
            {
                ListCities = new List<City>();
                ListCountries = new List<Country>();
                ListOfAddress = new List<SellerAdress>();
            }
            public string SellerId { get; set; }
            public List<City> ListCities { get; set; }
            public List<Country> ListCountries { get; set; }

          
            [Display(Name ="City")]
            public int CityId { get; set; }
            [Display(Name = "Country")]
            public int CountryId { get; set; }
            public List<SellerAdress>ListOfAddress { set; get; }

           
        }
        public class userAddressDTO 

        {
            public userAddressDTO()
            {
                ListCities = new List<City>();
                ListCountries = new List<Country>();
                ListOfAddress = new List<UserAdress>();
            }
            public string userId { get; set; }
            public List<City> ListCities { get; set; }
            public List<Country> ListCountries { get; set; }

            public string Address { get; set; }
            [Display(Name = "City")]
            public int CityId { get; set; }
            [Display(Name = "Country")]
            public int CountryId { get; set; }
            public List<UserAdress> ListOfAddress { set; get; }


        }
        public class PaymentCardDTO
        {
            public int Id { get; set; }
            [Required]

            public string Name { get; set; }
            [Display(Name = "Expire Date")]
            [Required]

            public DateTime ExpireDate { get; set; }
            [Required]

            public int Status { get; set; }
            [Required]

            [Display(Name ="Total Credit Ammount")]
            public double TotalCreditAmmount { get; set; }
            [Required]

            [Display(Name ="Availabel Credit")]
            public double AvailableCredit { get; set; }
            [Required]

            [Display(Name = "Celling Of Order")]
            public double CellingOfOrder { get; set; }
            public List<Status> ListStatus { get; set; }
            public List<TypeOfLeather> ListTypeOfLeathers { get; set; }

        }

        public class CartDTO
        {
            public int Id { get; set; }
            public int ProductId { get; set; }
            public int Quantity { get; set; }
            [Required]

            public string ProductName { get; set; }
            [Required]

            public double Price { get; set; }
            [Required]

            public string ProductImage { get; set; }
            public Seasons Season { get; set; }
            public TypeOfLeather Type { get; set; }
            public ICollection<Image> Images { get; set; }
            public List<Seasons> ListSeasons { get; set; }
            public List<TypeOfLeather> ListTypeOfLeathers { get; set; }
            public List<Products> Listproduct { get; set; }
        }

    }
}