using HelpDesk.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace HelpDesk.Infra.Data.Context;

public class ApplicationContext : DbContext
{
    public ApplicationContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Usuario> Usuarios => Set<Usuario>();
    public DbSet<TipoUsuario> TiposUsuarios => Set<TipoUsuario>();
    public DbSet<Local> Locais => Set<Local>();
    public DbSet<Equipamento> Equipamentos => Set<Equipamento>();
    public DbSet<Chamada> Chamadas => Set<Chamada>();
}
