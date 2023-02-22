using System;
using Flunt.Validations;
using HelpDesk.Domain.Core;

namespace HelpDesk.Domain.Entities;

//Class Done
public sealed class Usuario : Entity 
{
    private Usuario() //Empty Constructor for EF
    { }

    public Usuario(
        string nome, string login, string senha, TiposUsuario tiposUsuario, string contato, DateTime criadoEm, 
        DateTime? atualizadoEm, bool status)
    {
        Nome = nome;
        Login = login;
        Senha = senha;
        TiposUsuario = tiposUsuario;
        Contato = contato;
        CriadoEm = criadoEm;
        AtualizadoEm = atualizadoEm;
        Status = status;
    }

    

	public string Nome { get; private set; } = string.Empty;
    public string Login { get; private set; } = string.Empty;
	public string Senha { get; private set; } = string.Empty;
	public TiposUsuario TiposUsuario { get; private set; } = null!;
    public string Contato { get; private set; } = string.Empty;

    //Data e status para todas as classes
    public DateTime CriadoEm { get; private set; }
    public DateTime? AtualizadoEm { get; private set; }

	public bool Status { get; private set; }

	public void Ativo()
	{
		if (IsValid)
			Status = true;
	}

    public void Desativado()
    {
        if (IsValid)
            Status = false;
    }

}
