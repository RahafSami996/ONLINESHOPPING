using BussinceLogic.ISPecificRepository;
using Microsoft.AspNetCore.Http;
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
    public class CardPaymentRepository:ICardPayment
    {
        private readonly IGenaricRepository<CardsPayment> Genariccard;
        private readonly IGenaricRepository<Status> GenaricStatus;
        private readonly IHttpContextAccessor httpContextAccessor;


        public CardPaymentRepository(GenaricRepostory<CardsPayment> _Genariccard,
            GenaricRepostory<Status> _GenaricStatus, IHttpContextAccessor _httpContextAccessor)
        {
            Genariccard = _Genariccard;
            GenaricStatus = _GenaricStatus;
            httpContextAccessor = _httpContextAccessor;
        }
        public void InserCard(PaymentCardDTO model)
        {
            var userid = httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);

            CardsPayment obj = new CardsPayment
            {

                Name = model.Name,
                ExpireDate = model.ExpireDate,
                StatusId = model.Status,
                TotalCreditAmount = model.TotalCreditAmmount,
                AvailableCredit = model.AvailableCredit,
                CellingOfOrder = model.CellingOfOrder,
                UserID = Convert.ToInt32(userid)
            };

            Genariccard.Insert(obj);
            Genariccard.Save();
        }

        public List<CardsPayment> GetCard(int id)
        {
            List<CardsPayment> Listcard = Genariccard.GetAlls().Where(x => x.UserID == id).ToList();
            return Listcard;
        }

        public PaymentCardDTO GetCards(int id)
        {
            var card = Genariccard.GetAlls().FirstOrDefault(a => a.UserID == id);
            PaymentCardDTO Cards = new PaymentCardDTO
            {
                ListStatus = GetAllstatus(),
                Name = card.Name,
                ExpireDate = card.ExpireDate,
                Status = card.StatusId,
                TotalCreditAmmount = card.TotalCreditAmount,
                AvailableCredit = card.AvailableCredit,
                CellingOfOrder = card.CellingOfOrder,


            };
            return Cards;

        }

        public void UpdateCard(PaymentCardDTO model)
        {
            var userid = httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);

            CardsPayment obj = new CardsPayment
            {
                Id = model.Id,
                Name = model.Name,
                ExpireDate = model.ExpireDate,
                StatusId = model.Status,
                TotalCreditAmount = model.TotalCreditAmmount,
                AvailableCredit = model.AvailableCredit,
                CellingOfOrder = model.CellingOfOrder,
                UserID = Convert.ToInt32(userid)
            };
            Genariccard.Update(obj);
            Genariccard.Save();
        }

        public void DeleteCard(int id)
        {
            Genariccard.Delete(id);
            Genariccard.Save();
        }
        public List<Status> GetAllstatus()
        {
            List<Status> ListStatus = GenaricStatus.GetAlls().ToList();
            return ListStatus;
        }
    }
}
