using HelpDesk.Domain.Entities;
using HelpDesk.Infra.Data.Context;
using Microsoft.AspNetCore.Mvc;

namespace HelpDesk.Web.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public sealed class UsuarioController : ControllerBase
    {
        private readonly ApplicationContext _context;
        private object request;
        private object _usuarioServices;

        public UsuarioController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Adiciona([FromBody] UsuarioController usuario)
        {
            _context.Usuarios.Add(usuario);
            _contextSaveChanges();

            return CreatedAtAction(nameof(RecuperaUsuarioPorID), new { Id = usuario.Id }, usuario);

        }

        [HttpGet]
        public IActionResult RecuperaUsuarios(TiposUsuarioController tiposUsuario)
        {
            return Ok(tiposUsuario);
        }

        [HttpGet("{Id}")]
        public IActionResult RecuperaUsuarioPorID(int Id, TiposUsuarioController tiposUsuario)
        {

            if ((Usuario)Usuario.FirstOrDefault(tiposuser => tiposuser.Id == Id) != null)
            {
                return Ok((Usuario)Usuario.FirstOrDefault(tiposuser => tiposuser.Id == Id));
            }
            return NotFound();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] UsuarioController usuario)
        {
            var response = await _usuarioServices.Edit(id, request);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var response = await _usuarioServices.Remove(id);

            return CustomResponse(response.Message);
        }

        private IActionResult CustomResponse(object message)
        {
            throw new NotImplementedException();
        }
    }
}
