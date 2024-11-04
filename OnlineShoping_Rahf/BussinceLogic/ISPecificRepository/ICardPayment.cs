using OnlineShoppingSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;
using static OnlineShoppingSystem.Models.DTOOnlineShopping;

namespace BussinceLogic.ISPecificRepository
{
    public interface ICardPayment
    {
        void InserCard(PaymentCardDTO obj);
        List<CardsPayment> GetCard(int id);
        void UpdateCard(PaymentCardDTO obj);
        PaymentCardDTO GetCards(int id);
        void DeleteCard(int id);
        List<Status> GetAllstatus();

    }
}
