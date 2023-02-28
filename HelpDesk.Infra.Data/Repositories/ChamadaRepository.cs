using HelpDesk.Domain.Entities;
using HelpDesk.Infra.Data.Repositories.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk.Infra.Data.Repositories
{

    public sealed class ChamadaRepository : Repository<Usuario>, IChamadaRepository
    {
        public ChamadaRepository(HelpDeskContext context) : base(context)
        { }

        public override async Task<IEnumerable<Usuario>> GetAll()
            => await _dbSet.Include(p => p.Provider).ToListAsync();

        public override async Task<IEnumerable<Usuario>> GetWhere(Expression<Func<Usuario, bool>> where)
            => await _dbSet.Include(p => p.Provider).Where(where).ToListAsync();

#nullable disable
        public override async Task<Usuario> GetOneWhere(Expression<Func<Usuario, bool>> where)
            => await _dbSet.Include(p => p.Provider).FirstOrDefaultAsync(where);
#nullable enable
    }
}
}
