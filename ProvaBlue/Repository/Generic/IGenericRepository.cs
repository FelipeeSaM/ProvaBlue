using ProvaBlue.Models.Base;

namespace ProvaBlue.Repository.Generic {
    public interface IGenericRepository<T> where T : BaseModel{
        Task<List<T>> FindAll();
        T FindById(int id);
        Task<T> Create(T item);
        Task<T> Update(T item);
        void Delete(int id);
    }
}
