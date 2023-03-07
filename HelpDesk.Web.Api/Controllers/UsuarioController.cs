using HelpDesk.Application.Interfaces;
using HelpDesk.Application.ViewModels.Usuario;
using HelpDesk.Domain.Entities;
using HelpDesk.Infra.Data.Context;
using Microsoft.AspNetCore.Mvc;

namespace HelpDesk.Web.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public sealed class UsuarioController : ControllerBase
    {
        private readonly IUsuarioServices _usuarioServices;

        public UsuarioController(IUsuarioServices usuarioServices)
        {
            _usuarioServices = usuarioServices;
        }

        [HttpPost]
        public IActionResult Adiciona([FromBody] UsuarioController usuario)
        {
            try
            {


                return CreatedAtAction(nameof(RecuperaUsuarioPorID), new { Id = usuario.Id }, usuario);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

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
            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] RequestUsuarioViewModel viewModel)
        {
            var response = await _usuarioServices.Edit(id, viewModel);

            if (response)
                return Ok("Usuário editado com sucesso!");

            return BadRequest("Erro ao editar o usuário.");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var response = await _usuarioServices.Remove(id);

            return CustomResponse(response.Message);
        }

      
    }
}
