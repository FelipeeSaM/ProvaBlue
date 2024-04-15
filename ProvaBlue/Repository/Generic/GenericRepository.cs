using Microsoft.EntityFrameworkCore;
using ProvaBlue.Db;
using ProvaBlue.Models.Base;

namespace ProvaBlue.Repository.Generic {
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseModel {

        private readonly Prova_db_context _context;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(Prova_db_context context) {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public Task<List<T>> FindAll() {
            return _dbSet.ToListAsync();
        }

        public T FindById(int id) {
            return _dbSet.First(c => c.Id.Equals(id));
        }

        public async Task<T> Create(T item) {
            if(item != null) {
                _dbSet.Add(item);
                await _context.SaveChangesAsync();
            }

            return item;
        }

        public async Task<T> Update(T item) {
            var result = _dbSet.SingleOrDefault(c => c.Id.Equals(item.Id));

            if(result != null) {
                _dbSet.Entry(result).CurrentValues.SetValues(item);
                _context.SaveChangesAsync();
            }

            return item;
        }

        public async void Delete(int id) {
            var result = FindById(id);

            if(result != null) {
                _dbSet.Remove(result);
                _context.SaveChanges();
            }

        }

    }
}
