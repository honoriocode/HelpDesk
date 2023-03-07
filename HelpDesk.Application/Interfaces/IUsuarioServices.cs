using HelpDesk.Application.Services;
using HelpDesk.Application.ViewModels.Usuario;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk.Application.Interfaces;

public interface IUsuarioServices
{
    Task<IQueryable<ResponseUsuarioViewModel>> GetAll();
    Task<ResponseUsuarioViewModel> GetById(Guid id);

    Task<bool> Edit(Guid id, RequestUsuarioViewModel request);
    IActionResult AddUsuario(AddUsuarioRequest addUsuarioRequest);
}