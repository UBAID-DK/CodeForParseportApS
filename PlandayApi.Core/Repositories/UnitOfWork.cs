using PlandayApi.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlandayApi.Instrastructor.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(ITaskRepository taskRepository)
        {
            Tasks = taskRepository;
        }
        public ITaskRepository Tasks { get; }
    }
}
