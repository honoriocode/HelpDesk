using HelpDesk.Application.ViewModels.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk.Application.Interfaces;

public interface IUsuarioServices : IAppServices<RequestUsuarioViewModel>
{
    Task<IQueryable<ResponseUsuarioViewModel>> GetAll();
    Task<ResponseUsuarioViewModel> GetById(Guid id);

    Task<ServiceResponse> Edit(Guid id, RequestUsuarioViewModel request);
}
