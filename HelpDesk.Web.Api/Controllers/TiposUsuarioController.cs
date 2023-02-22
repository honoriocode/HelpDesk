using Microsoft.AspNetCore.Mvc;

namespace HelpDesk.Web.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TiposUsuarioController
    {
        // criando uma lista para armazenar as infos
        private static List<TiposUsuario> tiposUsuarios = new List<TiposUsuario>();

        [HttpPost]
        public void Adiciona([FromBody] TiposUsuario tiposUsuario)
        {
            tiposUsuarios.Add(tiposUsuario);

            return CreatedAtAction(nameof(RecuperaTiposusuarioPorID, tiposUsuario: TiposUsuario), new { tiposUsuario.Id }, tiposUsuario);
        }

        private void CreatedAtAction(string v, object value, TiposUsuario tiposUsuario)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public IActionResult RecuperaTiposUsuario(TiposUsuario tiposUsuario)
        {
            return Ok(tiposUsuario);
        }

        private IActionResult Ok(List<TiposUsuario> tiposUsuarios)
        {
            throw new NotImplementedException();
        }

        [HttpGet("{Id}")]
        public IActionResult RecuperaTiposusuarioPorID(int Id, TiposUsuario tiposUsuario)
        {
            TiposUsuario tiposUsuario = tiposUsuarios.FirstOrDefault(tiposuser => tiposuser.Id == Id );

            if (tiposUsuario != null)
            {
                return Ok(tiposUsuario);  
            }
            return NotFound();
        }
    }
}
