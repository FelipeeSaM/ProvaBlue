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
            try {
                return _dbSet.ToListAsync();
            }
            catch(Exception) {
                throw;
            }
        }

        public Task<T> FindById(int id) {
            try {
                return _dbSet.FirstOrDefaultAsync(c => c.Id.Equals(id));
            }
            catch(Exception) {
                throw;
            }
        }

        public async Task<T> Create(T item) {
            try {
                if(item != null) {
                    _dbSet.Add(item);
                    await _context.SaveChangesAsync();
                }
            }
            catch(Exception) {
                throw;
            }
            return item;
        }

        public async Task<T> Update(T item) {
            var result = _dbSet.SingleOrDefault(c => c.Id.Equals(item.Id));
            try {
                if(result != null) {
                    _dbSet.Entry(result).CurrentValues.SetValues(item);
                    _context.SaveChangesAsync();
                }
            }
            catch(Exception) {
                throw;
            }
            return item;
        }

        public async void Delete(int id) {
            try {
                var result = await FindById(id);
                if(result != null) {
                    _dbSet.Remove(result);
                    _context.SaveChanges();
                }
            }
            catch(Exception) {
                throw;
            }
        }

    }
}
