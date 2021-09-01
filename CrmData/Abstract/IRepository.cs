using System;
using System.Collections.Generic;
using System.Text;

namespace CrmData.Abstract
{
    public interface IRepository<T>
    {
        List<T> getAll();
        T getById(int id);
        void Update(T entity);
        void Delete(T entity);
        void Create(T entity);
    }
}
