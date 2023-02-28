using HelpDesk.Application.ViewModels.Local;
using HelpDesk.Application.ViewModels.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk.Application.Interfaces;

public interface ILocalServices : IAppServices<RequestLocalViewModel>
{
    Task<IQueryable<ResponseLocalViewModel>> GetAll();
    Task<ResponseLocalViewModel> GetById(Guid id);

    Task<ServiceResponse> Edit(Guid id, RequestLocalViewModel request);
}
