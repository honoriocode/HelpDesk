using HelpDesk.Application.ViewModels.Chamada;
using HelpDesk.Application.ViewModels.Local;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk.Application.Interfaces;

public interface IChamadaServices
{
    Task<IQueryable<ResponseChamadaViewModel>> GetAll();
    Task<ResponseChamadaViewModel> GetById(Guid id);

    Task<ServiceResponse> Edit(Guid id, RequestChamadaViewModel request);
}
