using HelpDesk.Domain.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk.Infra.Data.Repositories.Core
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        private readonly HelpDeskContext _context;
        protected readonly DbSet<T> _dbSet;

        public Repository(HelpDeskContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public virtual async Task<IEnumerable<T>> GetAll() => await _dbSet.ToListAsync();

        public virtual async Task<IEnumerable<T>> GetWhere(Expression<Func<T, bool>> where)
            => await _dbSet.Where(where).ToListAsync();

#nullable disable
        public virtual async Task<T> GetOneWhere(Expression<Func<T, bool>> where)
            => await _dbSet.FirstOrDefaultAsync(where);
#nullable enable

        public async Task Insert(T entity) => await _dbSet.AddAsync(entity);

        public async Task Update(T entity) => await Task.Run(() => _dbSet.Update(entity));
    }
}
