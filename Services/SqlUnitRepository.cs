using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using UEFASwissFormatSelector.Models;

namespace UEFASwissFormatSelector.Services
{
    public class SqlUnitRepository<T> : DbSet<T>, IUnitRepository<T> where T : Identifiable
    {
        private readonly DbContext context;
        private readonly DbSet<T> dbSet;
        public SqlUnitRepository(AppDbContext dbContext)
        {
            context = dbContext;
            dbSet = dbContext.Set<T>();
        }
        public override IEntityType EntityType => dbSet.EntityType;

        public T? Find(Guid id)
        {            
            return dbSet.Find( id );
        }

        void IUnitRepository<T>.Add(T entity)
        {
            dbSet.Add(entity);
            context.SaveChanges();
        }

        bool IUnitRepository<T>.Remove(T entity)
        {
            dbSet.Remove(entity);
            context.SaveChanges();
            return true;
        }

        void IUnitRepository<T>.Update(T entity)
        {
            dbSet.Update(entity);
            //var xyz = dbSet.Attach(entity);
            //xyz.State = EntityState.Modified;
            context.SaveChanges();
        }
        public IEnumerator<T> GetEnumerator()
        {
            return dbSet.ToList().GetEnumerator();
        }
    }
}
