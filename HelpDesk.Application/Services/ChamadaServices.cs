using HelpDesk.Application.Interfaces;
using HelpDesk.Application.ViewModels.Chamada;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk.Application.Services
{
    internal class ChamadaServices : IChamadaServices
    {
        public Task<ServiceResponse> Edit(Guid id, RequestChamadaViewModel request)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<ResponseChamadaViewModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ResponseChamadaViewModel> GetById(Guid id)
        {
            throw new NotImplementedException();
        }
    }

    private object dbContext;

    public Task<ServiceResponse> Edit(Guid id, RequestChamadaViewModel request)
    {
        throw new NotImplementedException();
    }

    public Task<IQueryable<ResponseChamadaViewModel>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<ResponseChamadaViewModel> GetById(Guid id)
    {
        throw new NotImplementedException();
    }

    Task<bool> IChamadaServices.Edit(Guid id, RequestChamadaViewModel request)
    {
        throw new NotImplementedException();
    }

    [HttpPost]
    public async Task<IActionResult> AddChamada(AddChamadaRequest addChamadaRequest)
    {

        var usuario = new UsuarioServices()
        {
            Id = Guid.NewGuid(),
            Description = addChamadaRequest.Description,
            CriadoEm = addChamadaRequest.CriadoEm,
            AtualizadoEm = addChamadaRequest.AtualizadoEm,
            Status = addChamadaRequest.Status
        };

        await dbContext.Chamada.AddAsync(chamada);
        await dbContext.SaveChangesAsync();

        return Ok(chamada);

    }

    [ApiController]
    [Route("api/[controller]")]

    public class ChamadasController : ControllerAttribute
    {
        private readonly ApplicationContext dBContext;

        public ChamadasController(ApplicationContext dBContext)
        {
            DBContext = dBContext;
        }

        public ApplicationContext DBContext { get; }

        [HttpGet]
        public Task<IActionResult> GetAllChamadas()
        {

            return OK(dBContext.Chamadas.ToList());

        }

        [HttpGet]
        [Route("{Id:guid}")]
        public async Task<IActionResult> GetChamada([FromRoute] Guid id)
        {
            var chamada = await dBContext.Chamadas.FindAsync(id);

            if (chamada == null)
            {
                return NotFound();
            }

            return Ok(chamada);
        }

        private IActionResult Ok(object chamada)
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

    IActionResult IChamadaServices.AddChamada(AddChamadaRequest addChamadaRequest)
    {
        throw new NotImplementedException();
    }

    [HttpPut]
    [Route("{Id:guid}")]
    public async Task<IActionResult> UpdateChamada([FromRoute] Guid id, UpdateChamadaRequest updateChamadaRequest)
    {
        var chamada = await dBContext.Chamadas.FindAsync(id);

        if (chamada != null)
        {
            Id = Guid.NewGuid(),
            Description = addChamadaRequest.Description,
            CriadoEm = addChamadaRequest.CriadoEm,
            AtualizadoEm = addChamadaRequest.AtualizadoEm,
            Status = addChamadaRequest.Status

            await dbContext.SaveChangesAsync();

            return Ok(chamada);
        }

        return NotFound();

    }

    IActionResult Ok(object chamada)
    {
        throw new NotImplementedException();
    }

    [HttpDelete]
    [Route("{Id:guid}")]
    public async Task<IActionResult> DeleteChamada([FromRoute] Guid id)
    {
        var chamada = await dbContext.Chamadas.FindAsync(id);

        if (chamada != null)
        {
            dbContext.Remove(chamada);
            await dbContext.SaveChangesAsync();
            return Ok(chamada)
        }

        return NotFound();
    }

    private IActionResult Ok(object chamada)
    {
        throw new NotImplementedException();
    }
}


}
