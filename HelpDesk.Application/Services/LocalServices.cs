using HelpDesk.Application.Interfaces;
using HelpDesk.Application.ViewModels.Local;
using HelpDesk.Application.ViewModels.Usuario;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk.Application.Services
{
    internal class LocalServices : ILocalServices
    {
        public Task<ServiceResponse> Edit(Guid id, RequestLocalViewModel request)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<ResponseLocalViewModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ResponseLocalViewModel> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        Task<ServiceResponse> ILocalServices.Edit(Guid id, RequestLocalViewModel request)
        {
            throw new NotImplementedException();
        }
    }

    private object dbContext;

    public Task<ServiceResponse> Edit(Guid id, RequestLocalViewModel request)
    {
        throw new NotImplementedException();
    }

    public Task<IQueryable<ResponseLocalViewModel>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<ResponseLocalViewModel> GetById(Guid id)
    {
        throw new NotImplementedException();
    }

    Task<bool> ILocalServices.Edit(Guid id, RequestLocalViewModel request)
    {
        throw new NotImplementedException();
    }

    [HttpPost]
    public async Task<IActionResult> AddLocal(AddUsuarioRequest addLocalRequest)
    {

        var local = new LocalServices()
        {
            Id = Guid.NewGuid(),
            Description = addLocalRequest.Description,
            Endereco = addLocalRequest.Endereco,
            CEP = addLocalRequest.CEP,
            Estado = addLocalRequest.Estado,
            Cidade = addLocalRequest.Cidade,
            CriadoEm = addLocalRequest.CriadoEm,
            AtualizadoEm addLocalRequest.AtualizadoEm,
            Status = addLocalRequest.Status
        };

        await dbContext.Locais.AddAsync(local);
        await dbContext.SaveChangesAsync();

        return Ok(local);

    }

    [ApiController]
    [Route("api/[controller]")]

    public class LocaisController : ControllerAttribute
    {
        private readonly ApplicationContext dBContext;

        public LocaisController(ApplicationContext dBContext)
        {
            DBContext = dBContext;
        }

        public ApplicationContext DBContext { get; }

        [HttpGet]
        public Task<IActionResult> GetAllLocais()
        {

            return OK(dBContext.Locais.ToList());

        }

        [HttpGet]
        [Route("{Id:guid}")]
        public async Task<IActionResult> GetLocal([FromRoute] Guid id)
        {
            var local = await dBContext.Locais.FindAsync(id);

            if (local == null)
            {
                return NotFound();
            }

            return Ok(local);
        }

        private IActionResult Ok(object local)
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

    IActionResult ILocalServices.AddLocal(AddLocalRequest addLocalRequest)
    {
        throw new NotImplementedException();
    }

    [HttpPut]
    [Route("{Id:guid}")]
    public async Task<IActionResult> UpdateLocal([FromRoute] Guid id, UpdateLocalRequest updateLocalRequest)
    {
        var local = await dBContext.Locais.FindAsync(id);

        if (local != null)
        {
            Id = Guid.NewGuid(),
            Description = addLocalRequest.Description,
            Endereco = addLocalRequest.Endereco,
            CEP = addLocalRequest.CEP,
            Estado = addLocalRequest.Estado,
            Cidade = addLocalRequest.Cidade,
            CriadoEm = addLocalRequest.CriadoEm,
            AtualizadoEm addLocalRequest.AtualizadoEm,
            Status = addLocalRequest.Status

            await dbContext.SaveChangesAsync();

            return Ok(usuario);
        }

        return NotFound();

    }

    [HttpDelete]
    [Route("{Id:guid}")]
    public async Task<IActionResult> DeleteLocal([FromRoute] Guid id)
    {
        var local = await dbContext.Locais.FindAsync(id);

        if (local != null)
        {
            dbContext.Remove(local);
            await dbContext.SaveChangesAsync();
            return Ok(local)
        }

        return NotFound();
    }

    private IActionResult Ok(object local)
    {
        throw new NotImplementedException();
    }
}


}
