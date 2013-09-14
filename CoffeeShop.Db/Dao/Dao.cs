using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using CoffeeShop.Db.Context;
using MediaRotate.Domain.Interfaces;

namespace CoffeeShop.Db.Dao
{
    public class Dao<TEntity> : IDao<TEntity> where TEntity : class
    {
        private readonly CoffeeShopContext db = new CoffeeShopContext();

        private DbSet<TEntity> DbSet
        {
            get { return db.Set<TEntity>(); }
        }

        public IEnumerable<TEntity> All()
        {
            var list = DbSet.ToList();

            return list;
        }

        public TEntity Add(TEntity entity)
        {
            DbSet.Add(entity);
            SaveChanges();

            return entity;
        }

        public TEntity Save(TEntity entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            db.SaveChanges();

            return entity;
        }

        public TEntity Find(int id)
        {
            var entity = DbSet.Find(id);

            return entity;
        }

        public void Delete(TEntity entity)
        {
            DbSet.Remove(entity);
            SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = Find(id);

            Delete(entity);
            SaveChanges();
        }

        public void SaveChanges()
        {
            db.SaveChanges();
        }
    }
}
