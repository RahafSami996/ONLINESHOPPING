using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace OnlineShoppingSystem.Models.Genaric
{
    public class GenaricRepostory<T> : IGenaricRepository<T> where T : class
    {
        private DbSet<T> table = null;
      
        private readonly OnlineShopingDbContext context=null;

        public GenaricRepostory(OnlineShopingDbContext context1)
        {
            context = context1;
            table = context.Set<T>();
           
        }

        public List<T> GetAll(int id)
        {
            return table.ToList();
        }
        public T GetByIdstring(string id)
        {
            return table.Find(id);
        }
        public T GetById(int id)
        {
            return table.Find(id);
        }
        public void Insert(T obj)
        {
            table.Add(obj);
        }
        public void Update(T obj)
        {
            table.Attach(obj);
            context.Entry(obj).State = EntityState.Modified;
        }
        public void Delete(object id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
        }
        public void Save()
        {
            context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return table.ToList();
        }
        public IQueryable<T>GetAlls()
        {
            return table;
        }
        //public virtual IQueryable<T> GetAllIncluding(params Expression<Func<T, object>>[] includeProperties)
        //{
        //    IQueryable<T> query = dbSet;
        //    foreach (var includeProperty in includeProperties)
        //    {
        //        query = query.Include(includeProperty);
        //    }
        //    return query;
        //}

        public IEnumerable<T> Filter()
        {
            return context.Set<T>();
        }

        public IEnumerable<T> Filter(Func<T, bool> predicate)
        {
            return context.Set<T>().Where(predicate);
        }

        
    }
}
