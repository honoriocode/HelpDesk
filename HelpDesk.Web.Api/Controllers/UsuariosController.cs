using HelpDesk.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HelpDesk.Web.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuariosController
    {
      
        private static List<Usuario> usuarios = new List<Usuario>();

        [HttpPost]
        public void Adiciona([FromBody] Usuario usuario)
        {
            usuarios.Add(usuario);
        }


    }
}
