using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Repository.Base
{
    public abstract class Repository <T> where T:class
    {
        protected DbContext Db;

        protected DbSet<T> Table
        {
            get { return Db.Set<T>(); }
        }

        public Repository(DbContext db)
        {
           
            Db = db;
        }

        public virtual T GetById(int id)
        {
            
            return Table.Find(id);
        }

        public virtual List<T> GetAll()
        {
            return Table.ToList();
        }

        public virtual bool Update(T entity)
        {
            Table.Attach(entity);
            Db.Entry(entity).State = EntityState.Modified;
            return Db.SaveChanges() > 0;
        }

        public virtual bool Save(T entity)
        {
            Table.Add(entity);
            return Db.SaveChanges() > 0;
        }

        public virtual bool Remove(T entity)
        {
            Table.Remove(entity);
            return Db.SaveChanges() > 0;
        }

        public T GetFirstOrDefault(Func<T, bool> predicate)
        {
            return Table.FirstOrDefault(predicate);

        }

        public List<T> Get(Func<T, bool> predicate)
        {
            return Table.Where(predicate).ToList();
        } 
    }
}
