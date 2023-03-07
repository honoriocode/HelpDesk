using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk.Domain.Entities.Requests
{
    internal class AddUsuarioRequest
    {
        [Required(ErrorMessage = "Insira o seu email ")]
        [StringLength(100)]
        public string Login { get; private set; } = string.Empty;

        [Range(8, 30, ErrorMessage = "Crie a senha : mínimo de 8 caracteres e máximo de 30 caracteres ")]
        public string Senha { get; private set; } = string.Empty;
        public TipoUsuario TiposUsuario { get; private set; } = null!;

        [Required(ErrorMessage = "O Campo contato é obrigatório")]
        [StringLength(100)]
        public string Contato { get; private set; } = string.Empty;

        //Data e status para todas as classes
        public DateTime CriadoEm { get; private set; }
        public DateTime? AtualizadoEm { get; private set; }
    }
}
