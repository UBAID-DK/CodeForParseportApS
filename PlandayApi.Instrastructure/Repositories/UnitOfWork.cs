using Planday.Application.Interfaces;
using PlandayApi.Application.Interfaces;

namespace PlandayApi.Infrastructure.Repositories
    {
    /// <summary>
    /// Unit of Work is referred to as a single transaction that involves multiple operations of insert/update/delete and so
    /// on kinds. To say it in simple words, it means that for a specific user action (say registration on a website), all
    /// the transactions like insert/update/delete and so on are done in one single transaction, rather then doing multiple
    /// database transactions. This means, one unit of work here involves insert/update/delete operations, all in one single
    /// transaction
    /// </summary>
    public class UnitOfWork : IUnitOfWork
        {
        public UnitOfWork(ITaskRepository taskRepository)
            {
            Tasks = taskRepository;
            }
        public ITaskRepository Tasks { get; }
        }
    }
