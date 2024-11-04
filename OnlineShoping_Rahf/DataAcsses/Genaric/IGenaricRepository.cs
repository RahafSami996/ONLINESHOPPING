using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace OnlineShoppingSystem.Models.Genaric
{
   public interface IGenaricRepository<T> where T : class
    {
        List<T> GetAll();
        T GetById(int id);
        T GetByIdstring(string id);
        void Insert(T obj);
        void Update(T obj);
        void Delete(object id);

        //T GetById(Guid id);
        IEnumerable<T> Filter();
        IEnumerable<T> Filter(Func<T, bool> predicate);
        IQueryable<T> GetAlls();
        void Save();
        //IEnumerable<object> GetAllIncluding(Func<object, object> p1, Func<object, object> p2);
    }
}

