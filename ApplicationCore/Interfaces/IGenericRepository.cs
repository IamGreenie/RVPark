using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        // Get a single object by its id
        T GetById(int id);
        // The 'predicate' Func<T, bool> represents a function that takes type T and returns bool
        // Expression<Func<T, bool>> is a description of a function as an expression tree, it is compiled at run time and can be translated to other languages
        // asNoTracking is readonly results, and includes is a join of other objects
        // includes should be a comma seperatable string
        T Get(Expression<Func<T, bool>> predicate, bool asNoTracking = false, string includes = null );
        // same as get but asynchronous
        Task<T> GetAsync(Expression<Func<T, bool>> predicate, bool asNoTracking = false, string includes = null );
        // return list of type T to iterate on
        IEnumerable<T> List();
        // same as List but allows you to pass an expression to get, then order by another expression, with optional join
        IEnumerable<T> List(Expression<Func<T, bool>> predicate, Expression<Func<T, int>> orderBy = null, string includes = null);
        // same as sortable list but async
        Task<IEnumerable<T>> ListAsync(Expression<Func<T, bool>> predicate, Expression<Func<T, int>> orderBy = null, string includes = null);

        // create new entity
        void Add(T entity);
        // remove an entity
        void Delete(T entity);
        // remove multiple entities
        void Delete(IEnumerable<T> entities);
        // update an entity
        void Update(T entity);
    }
}
