using ProvaBlue.Models;
using ProvaBlue.Models.Base;
using System.Linq.Expressions;

namespace ProvaBlue.Repository.Generic {
    public interface IGenericRepository<T> where T : BaseModel{
        Task<List<T>> FindAll();
        T FindById(int id);
        T FindByPredicate(Expression<Func<T, bool>> predicate);
        Task<T> Create(T item);
        Task<T> Update(T item);
        void Delete(int id);
    }
}
