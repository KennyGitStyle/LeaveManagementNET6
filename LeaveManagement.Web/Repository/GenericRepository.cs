using LeaveManagement.Web.Data;
using LeaveManagement.Web.Interface;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagement.Web.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;

        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<T> AddAsync(T entity)
        {
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(int id)
        {
            var idExist = await GetByIdAsync(id);
            _context.Set<T>().Remove(idExist!);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> Exist(int id)
        {
            var getEntity = await GetByIdAsync(id);
            return getEntity is not null;

        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int? id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task UpdateAsync(T entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
