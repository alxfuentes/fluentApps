using System.Collections.Generic;

namespace fluentApps.Data.Base
{
    public interface IRepository<T, IdT>
    {
        T GetById(IdT id, bool shouldLock);
        List<T> GetAll();
        List<T> GetByExample(T exampleInstance, params string[] propertiesToExclude);
        T GetUniqueByExample(T exampleInstance, params string[] propertiesToExclude);
        T Save(T entity);
        T SaveOrUpdate(T entity);
        void Delete(T entity);
        void CommitChanges();
    }
}
