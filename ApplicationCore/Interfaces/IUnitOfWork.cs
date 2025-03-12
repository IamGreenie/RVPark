//using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface IUnitOfWork
    {

        // TODO: Add new model here when created in models
        //public IGenericRepository<Category> Category { get; }

        // save changes to database source
        int Commit();

        Task<int> CommitAsync();
    }
}
