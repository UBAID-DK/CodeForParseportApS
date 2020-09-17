using PlandayApi.Core.ModelView;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PlandayApi.Application.Interfaces
    {
    /// <summary>
    /// A repository is nothing but a class defined for an entity, with all the operations possible on that specific entity.
    /// For example, a repository for an entity Customer, will have basic CRUD operations and any other possible  operations
    /// related to it. A Repository Pattern can be implemented in Following ways:
    /// One repository per entity(non-generic) : This type of implementation involves the use of one repository class for
    /// each entity.For example, if you have two entities Order and Customer, each entity will have its own repository.
    /// Generic repository: A generic repository is the one that can be used for all the entities, in other words it can be
    /// either used for Order or Customer or any other entity
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IGenericRepository<T> where T : class
        {
        Task<T> GetAll();
        Task<T> GetById(int id);
        Task<T> GetSize();
        Task<bool> Delete(int id);
        Task<bool> Update(T entity);
        Task<bool> SwiftShift(int fId, int sId);
        }
    }
