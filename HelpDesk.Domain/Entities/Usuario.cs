using System;
using System.ComponentModel.DataAnnotations;
using Flunt.Validations;
using HelpDesk.Domain.Core;

namespace HelpDesk.Domain.Entities;

//Class Done
public sealed class Usuario : Entity 
{
    private Usuario() //Empty Constructor for EF
    { }

    public Usuario(
        string nome, string login, string senha, TipoUsuario tiposUsuario, string contato, DateTime criadoEm, 
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



    [Required(ErrorMessage = "Insira o seu nome ")]
    [StringLength(100)]
	public string Nome { get; private set; } = string.Empty;
    
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

	public bool Status { get; private set; }
    public object Provider { get; set; }

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

    public void Add(object usuario)
    {
        throw new NotImplementedException();
    }

    public static Usuario FirstOrDefault(Func<object, bool> value)
    {
        throw new NotImplementedException();
    }
}
