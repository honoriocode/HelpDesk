using HelpDesk.Domain.Core;
using HelpDesk.Domain.Entities;
using System.Linq.Expressions;

namespace HelpDesk.Infra.Data.Repositories.Core
{
    public interface IRepository<T> where T : Entity
    {
        Task<Usuario> GetOneWhere(Expression<Func<Usuario, bool>> where);
        Task<IEnumerable<Usuario>> GetWhere(Expression<Func<Usuario, bool>> where);
        Task<IEnumerable<Usuario>> GetWhere(Expression<Func<Usuario, bool>> where);
    }
}