using BussinceLogic.ISPecificRepository;
using OnlineShoppingSystem.Models;
using OnlineShoppingSystem.Models.Genaric;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BussinceLogic.SpecificRepository
{
   public class SeasonTypeRepository:ISeasonType
    {
        private readonly IGenaricRepository<Seasons> Genaricseasons;
        private readonly IGenaricRepository<TypeOfLeather> GenaricType;

        public SeasonTypeRepository(GenaricRepostory<Seasons> _Genaricseasons,
            GenaricRepostory<TypeOfLeather> _GenaricType)
        {
            Genaricseasons = _Genaricseasons;
            GenaricType = _GenaricType;
        }
        public List<Seasons> GetAllSeasons()
        {
            List<Seasons> ListSeason = Genaricseasons.GetAlls().ToList();
            return ListSeason;
        }

        public List<TypeOfLeather> GetAllType()
        {
            List<TypeOfLeather> ListType = GenaricType.GetAlls().ToList();
            return ListType;
        }
    }
}
