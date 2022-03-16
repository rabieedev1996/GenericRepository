using CodeFirst.Entities;
using System.Linq.Expressions;

namespace CodeFirst.Infrastructure.Interface
{
    public interface IBaseRepository<TEtity> where TEtity : EntityBase
    {
        Task<IReadOnlyList<TEtity>> GetAllAsync();
        Task<IReadOnlyList<TEtity>> GetAsync(Expression<Func<TEtity, bool>> predicate);
        Task<IReadOnlyList<TEtity>> GetAsync(Expression<Func<TEtity, bool>> predicate = null,
                                        Func<IQueryable<TEtity>, IOrderedQueryable<TEtity>> orderBy = null,
                                        string includeString = null,
                                        bool disableTracking = true);
        Task<IReadOnlyList<TEtity>> GetAsync(Expression<Func<TEtity, bool>> predicate = null,
                                       Func<IQueryable<TEtity>, IOrderedQueryable<TEtity>> orderBy = null,
                                       List<Expression<Func<TEtity, object>>> includes = null,
                                       bool disableTracking = true);
        Task<TEtity> GetByIdAsync(int id);
        Task<TEtity> AddAsync(TEtity entity);
        Task UpdateAsync(TEtity entity);
        Task DeleteAsync(TEtity entity);
    }
}
