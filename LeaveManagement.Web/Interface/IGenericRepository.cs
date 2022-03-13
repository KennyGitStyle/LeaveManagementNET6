namespace LeaveManagement.Web.Interface
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> AddAsync(T entity);
        Task<List<T>> GetAllAsync();
        Task<bool> Exist(int id);
        Task UpdateAsync(T entity);
        Task<T> GetByIdAsync(int? id);
        Task DeleteAsync(int id);
        
        
    }
}
