using OnlineShoppingSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BussinceLogic.ISPecificRepository
{
    public interface ISeasonType
    {
        List<Seasons> GetAllSeasons();
        List<TypeOfLeather> GetAllType();
    }
}
