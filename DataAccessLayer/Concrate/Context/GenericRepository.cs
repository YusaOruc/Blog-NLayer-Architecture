using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrate.Context
{
    public class GenericRepository<T> : IRepository<T> where T:class
    {
        
        Context context = new Context();
       
        
        public void Delete(T p)
        {
            var deletedEntity = context.Entry(p);
            deletedEntity.State = EntityState.Deleted;

            context.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            return context.Set<T>().SingleOrDefault(filter);
        }

        public void Insert(T p)
        {
            var addedEntity = context.Entry(p);
            addedEntity.State = EntityState.Added;

            context.SaveChanges();
        }

        public List<T> List()
        {
            return context.Set<T>().ToList();
            
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return context.Set<T>().Where(filter).ToList();

        }

        public void Update(T p)
        {
            var updatedEntity = context.Entry(p);
            updatedEntity.State = EntityState.Modified;

            context.SaveChanges();
        }
    }
}
