using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediaRotate.Domain.Interfaces
{
    public interface IDao<TEntity>
    {
        IEnumerable<TEntity> All();
        TEntity Add(TEntity entity);
        TEntity Save(TEntity entity);
        TEntity Find(int id);
        void Delete(TEntity entity);
        void Delete(int id);
        void SaveChanges();
    }
}
