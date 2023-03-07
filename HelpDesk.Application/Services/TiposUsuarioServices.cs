using HelpDesk.Application.Interfaces;
using HelpDesk.Application.ViewModels.TiposUsuario;
using HelpDesk.Application.ViewModels.Usuario;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk.Application.Services
{
    internal class TiposUsuarioServices : ITiposUsuarioServices
    {
        public Task<ServiceResponse> Edit(Guid id, RequestTiposUsuarioViewModel request)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<ResponseTiposUsuarioViewModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ResponseTiposUsuarioViewModel> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        Task<ServiceResponse> ITiposUsuarioServices.Edit(Guid id, RequestTiposUsuarioViewModel request)
        {
            throw new NotImplementedException();
        }

        Task<ServiceResponse> ITiposUsuarioServices.Edit(Guid id, RequestTiposUsuarioViewModel request)
        {
            throw new NotImplementedException();
        }
    }

    private object dbContext;

    public Task<ServiceResponse> Edit(Guid id, RequestTiposUsuarioViewModel request)
    {
        throw new NotImplementedException();
    }

    public Task<IQueryable<ResponseTiposUsuarioViewModel>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<ResponseTiposUsuarioViewModel> GetById(Guid id)
    {
        throw new NotImplementedException();
    }

    Task<bool> ITiposUsuarioServices.Edit(Guid id, RequestTiposUsuarioViewModel request)
    {
        throw new NotImplementedException();
    }

    [HttpPost]
    public async Task<IActionResult> AddTiposUsuario(AddTiposUsuarioRequest addtiposUsuarioRequest)
    {

        var tiposUsuario = new TiposUsuarioServices()
        {
            Id = Guid.NewGuid(),
            Description = addtiposUsuarioRequest.Description,
            Status = addtiposUsuarioRequest.Status,
            CriadoEm = addtiposUsuarioRequest.CriadoEm,
            AtualizadoEm addtiposUsuarioRequest.AtualizadoEm
        };

        await dbContext.TiposUsuarios.AddAsync(tiposUsuario);
        await dbContext.SaveChangesAsync();

        return Ok(usuario);

    }

    [ApiController]
    [Route("api/[controller]")]

    public class TiposUsuariosController : ControllerAttribute
    {
        private readonly ApplicationContext dBContext;

        public TiposUsuariosController(ApplicationContext dBContext)
        {
            DBContext = dBContext;
        }

        public ApplicationContext DBContext { get; }

        [HttpGet]
        public Task<IActionResult> GetAllTiposUsuarios()
        {

            return OK(dBContext.TiposUsuarios.ToList());

        }

        [HttpGet]
        [Route("{Id:guid}")]
        public async Task<IActionResult> GetTiposUsuario([FromRoute] Guid id)
        {
            var usuario = await dBContext.tiposUsuarios.FindAsync(id);

            if (usuario == null)
            {
                return NotFound();
            }

            return Ok(tiposUsuario);
        }

        private IActionResult Ok(object tiposUsuario)
        {
            throw new NotImplementedException();
        }

        private IActionResult NotFound()
        {
            throw new NotImplementedException();
        }

        private IActionResult OK(object value)
        {
            throw new NotImplementedException();
        }
    }

    IActionResult ITiposUsuarioServices.AddTiposUsuario(AddTiposUsuarioRequest addTiposUsuarioRequest)
    {
        throw new NotImplementedException();
    }

    [HttpPut]
    [Route("{Id:guid}")]
    public async Task<IActionResult> UpdateTiposUsuario([FromRoute] Guid id, UpdateTiposUsuarioRequest updateTiposUsuarioRequest)
    {
        var usuario = await dBContext.TiposUsuarios.FindAsync(id);

        if (usuario != null)
        {
            usuario.Login = updateTiposUsuarioRequest.Login;
            usuario.Senha = updateTiposUsuarioRequest.Senha;
            usuario.TiposUsuario = updateTiposUsuarioRequest.TiposUsuario;
            usuario.Contato = updateTiposUsuarioRequest.Contato;
            usuario.CriadoEm = updateTiposUsuarioRequest.CriadoEm;
            usuario.AtualizadoEm = updateTiposUsuarioRequest.AtualizadoEm;

            await dbContext.SaveChangesAsync();

            return Ok(tiposUsuario);
        }

        return NotFound();

    }

    [HttpDelete]
    [Route("{Id:guid}")]
    public async Task<IActionResult> DeleteTiposUsuario([FromRoute] Guid id)
    {
        var contact = await dbContext.TiposUsuarios.FindAsync(id);

        if (tiposUsuario != null)
        {
            dbContext.Remove(tiposUsuario);
            await dbContext.SaveChangesAsync();
            return Ok(tiposUsuario)
        }

        return NotFound();
    }

    private IActionResult Ok(object tiposUsuario)
    {
        throw new NotImplementedException();
    }
}

}
