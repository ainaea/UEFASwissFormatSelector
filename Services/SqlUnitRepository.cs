using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Linq.Expressions;
using UEFASwissFormatSelector.Models;

namespace UEFASwissFormatSelector.Services
{
    public class SqlUnitRepository<T> : DbSet<T>, IUnitRepository<T> where T : Identifiable
    {
        private readonly AppDbContext context;
        private readonly DbSet<T> dbSet;
        public SqlUnitRepository(AppDbContext dbContext)
        {
            context = dbContext;
            dbSet = dbContext.Set<T>();
        }

        //public SqlUnitRepository(AppDbContext dbContext, DbSet<T> customDbset)
        //{
        //    context = dbContext;
        //    dbSet = customDbset;
        //}
        public override IEntityType EntityType => dbSet.EntityType;

        public T? Find(Guid id)
        {
            T? entity = dbSet.Find(id);
            if (entity != null && typeof(T) == typeof(ScenarioInstance))
            {
                ScenarioInstance siEntity = entity as ScenarioInstance;
                siEntity.ClubsInScenarioInstance = context.ClubsInScenarioInstance.Where(cisi => cisi.ScenarioInstanceId == siEntity.Id).Include(cisi => cisi.Club)?.ToList();
                siEntity.Pots = context.Set<Pot>().Where(p => p.ScenarioInstanceId == id).Include(i=>i.ClubsInPot).ThenInclude(i => i.Club).ThenInclude(i => i.Country).ToList();
                return siEntity as T;
                //Try to return a fully scenario entity when requested by id especially clubsinscenarioinstance
            }
            return entity;
        }

        public void Add(T entity)
        {
            dbSet.Add(entity);
            context.SaveChanges();
        }

        public bool Remove(T entity)
        {
            dbSet.Remove(entity);
            context.SaveChanges();
            return true;
        }

        public void Update(T entity)
        {
            dbSet.Update(entity);
            //var xyz = dbSet.Attach(entity);
            //xyz.State = EntityState.Modified;
            context.SaveChanges();
        }
        public IEnumerator<T> GetEnumerator()
        {
            return new SqlUnitRepositoryEnumerator<T>(dbSet.ToList());
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int Count()
        {
            return dbSet.Count();
        }

        //public SqlUnitRepository<T> Include<TProperty>(Expression<Func<T, TProperty>> navigationPropertyPath) where TProperty : Identifiable
        //{
        //    var updatedDbSet = context.Set<T>().Include(navigationPropertyPath) as DbSet<T>;
        //    return new SqlUnitRepository<T>(context, updatedDbSet);
        //}
    }
}
