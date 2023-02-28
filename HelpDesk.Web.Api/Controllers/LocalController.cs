using Microsoft.AspNetCore.Mvc;

namespace HelpDesk.Web.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LocalController
    {
        // criando uma lista para armazenar as infos
        private static List<LocalController> tiposUsuarios = new List<LocalController>();

        public object Local { get; private set; }
        public int Id { get; private set; }

        [HttpPost]
        public void Adiciona([FromBody] LocalController local)
        {
            tiposUsuarios.Add(local);

            return CreatedAtAction(nameof(RecuperaTiposusuarioPorID, tiposUsuario: TiposUsuario), new { tiposUsuario.Id }, tiposUsuario);
        }

        private string nameof(Func<int, TiposUsuarioController, IActionResult> recuperaTiposusuarioPorID, object tiposUsuario)
        {
            throw new NotImplementedException();
        }

        private void CreatedAtAction(string v, object value, TiposUsuarioController tiposUsuario)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public IActionResult RecuperaTiposUsuario(TiposUsuarioController tiposUsuario)
        {
            return Ok(tiposUsuario);
        }

        private IActionResult Ok(TiposUsuarioController tiposUsuario)
        {
            throw new NotImplementedException();
        }

        private IActionResult Ok(List<TiposUsuarioController> tiposUsuarios)
        {
            throw new NotImplementedException();
        }

        [HttpGet("{Id}")]
        public IActionResult RecuperaTiposusuarioPorID(int Id, TiposUsuarioController tiposUsuario)
        {

            if ((TiposUsuario)tiposUsuarios.FirstOrDefault(tiposuser => tiposuser.Id == Id) != null)
            {
                return Ok((TiposUsuario)tiposUsuarios.FirstOrDefault(tiposuser => tiposuser.Id == Id));
            }
            return NotFound();
        }

        private IActionResult Ok(TiposUsuario tiposUsuario)
        {
            throw new NotImplementedException();
        }

        private IActionResult NotFound()
        {
            throw new NotImplementedException();
        }



    }
}
