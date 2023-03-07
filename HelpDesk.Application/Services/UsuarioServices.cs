using HelpDesk.Application.Interfaces;
using HelpDesk.Application.ViewModels.Usuario;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk.Application.Services;


public sealed class UsuarioServices : IUsuarioServices
{
    private object dbContext;

    public Task<ServiceResponse> Edit(Guid id, RequestUsuarioViewModel request)
    {
        throw new NotImplementedException();
    }

    public Task<IQueryable<ResponseUsuarioViewModel>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<ResponseUsuarioViewModel> GetById(Guid id)
    {
        throw new NotImplementedException();
    }

    Task<bool> IUsuarioServices.Edit(Guid id, RequestUsuarioViewModel request)
    {
        throw new NotImplementedException();
    }    
    
    [HttpPost]
    public async Task<IActionResult> AddUsuario(AddUsuarioRequest addUsuarioRequest)
    {

        var usuario = new UsuarioServices()
        {
            Id = Guid.NewGuid(),
            Login = addUsuarioRequest.Login,
            Senha = addUsuarioRequest.Senha,
            TiposUsuario = addUsuarioRequest.TiposUsuario,
            Contato = addUsuarioRequest.Contato,
            CriadoEm = addUsuarioRequest.CriadoEm,
            AtualizadoEm addUsuarioRequest.AtualizadoEm
        };

        await dbContext.Usuarios.AddAsync(usuario);
        await dbContext.SaveChangesAsync();

        return Ok(usuario);

    }

    [ApiController]
    [Route("api/[controller]")]

    public class UsuariosController : ControllerAttribute
    {
        private readonly ApplicationContext dBContext;

        public UsuariosController(ApplicationContext dBContext) 
        {
            DBContext = dBContext;
        }

        public ApplicationContext DBContext { get; }

        [HttpGet]
        public Task<IActionResult> GetAllUsuarios()
        {
            
            return OK(dBContext.Usuarios.ToList());
           
        }

        [HttpGet]
        [Route("{Id:guid}")]
        public async Task<IActionResult> GetUsuario([FromRoute] Guid id)
        {
            var usuario = await dBContext.Usuarios.FindAsync(id);

            if (usuario == null)
            {
                return NotFound();
            }

            return Ok(usuario);
        }

        private IActionResult Ok(object usuario)
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

    IActionResult IUsuarioServices.AddUsuario(AddUsuarioRequest addUsuarioRequest)
    {
        throw new NotImplementedException();
    }

    [HttpPut]
    [Route("{Id:guid}")]
    public async Task<IActionResult> UpdateUsuario([FromRoute] Guid id, UpdateUsuarioRequest updateUsuarioRequest)
    {
        var usuario = await dBContext.Usuarios.FindAsync(id);

        if (usuario != null)
        {
            usuario.Login = updateUsuarioRequest.Login;
            usuario.Senha = updateUsuarioRequest.Senha;
            usuario.TiposUsuario = updateUsuarioRequest.TiposUsuario;
            usuario.Contato = updateUsuarioRequest.Contato;
            usuario.CriadoEm = updateUsuarioRequest.CriadoEm;
            usuario.AtualizadoEm = updateUsuarioRequest.AtualizadoEm;

            await dbContext.SaveChangesAsync();

            return Ok(usuario);
        }

        return NotFound();

    }

    [HttpDelete]
    [Route("{Id:guid}")]
    public async Task<IActionResult> DeleteTiposUsuarios([FromRoute] Guid id)
    {
        var contact = await dbContext.Usuarios.FindAsync(id);

        if (usuario != null)
        {
            dbContext.Remove(usuario);
            await dbContext.SaveChangesAsync();
            return Ok(usuario)
        }

        return NotFound();
    }

    private IActionResult Ok(object usuario)
    {
        throw new NotImplementedException();
    }
}
