using HelpDesk.Application.ViewModels.Equipamento;
using HelpDesk.Application.ViewModels.Local;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk.Application.Interfaces;

public interface IEquipamentoServices
{
    Task<IQueryable<ResponseEquipamentoViewModel>> GetAll();
    Task<ResponseEquipamentoViewModel> GetById(Guid id);

    Task<ServiceResponse> Edit(Guid id, RequestEquipamentoViewModel request);
}
