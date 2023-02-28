using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk.Application.ViewModels.TiposUsuario;

public sealed record ResponseTiposUsuarioViewModel
{
    public Guid Id { get; set; }
    public string Description { get; set; } = null!;
    public DateTime ProductionDate { get; set; }
    public DateTime ExpirationDate { get; set; }
    public bool IsActive { get; set; }
    public ResponseTiposUsuarioViewModel? TiposUsuario { get; set; }
}
