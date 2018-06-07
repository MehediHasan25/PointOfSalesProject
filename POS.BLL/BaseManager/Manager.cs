using POS.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.BLL.BaseManager
{
    public abstract class Manager<T> where T:class
    {
        protected Repository<T> Repository;

        public Manager(Repository<T> repository)
        {
            Repository = repository;
        }


        public virtual T GetById(int id)
        {
            return Repository.GetById(id);
        }


        public virtual List<T> GetAll()
        {
            return Repository.GetAll();
        }

        

        public virtual bool Save(T entity)
        {
            return Repository.Save(entity);
        }
        public virtual bool Update(T entity)
        {
            return Repository.Update(entity);
        }
        public virtual bool Remove(T entity)
        {

            return Repository.Remove(entity);
        }

        public T GetFirstOrDefault(Func<T, bool> predicate)
        {
            return Repository.GetFirstOrDefault(predicate);
        }
        public List<T> Get(Func<T, bool> predicate)
        {
            return Repository.Get(predicate);
        }
    }
}
