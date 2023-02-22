using System;
using Flunt.Validations;

namespace HelpDesk.Domain.Entities;

public sealed class Usuario : Entity
{
	private Usuario() //Empty Constructor for EF
	{ }
	
	[Required(ErrorMessage = "Preencha com o seu nome")]
	public string NomeUsuario { get; private set; }

    [Required(ErrorMessage = "Insira o seu nome de usuário ou e-mail")]
    public string Login { get; private set; }

    [Range(8, 30, ErrorMessage = "Insira sua senha - Mínimo de 8 caracteres")]
    public string senha { get; private set; }

	public TiposUsuario TiposUsuario { get; private set; }

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
