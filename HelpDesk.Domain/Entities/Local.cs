using System;
using System.ComponentModel.DataAnnotations;
using Flunt.Validations;
using HelpDesk.Domain.Core;

//Class done
public class Local : Entity
{
    private Local() //Empty Constructor for EF
    { }
    public Local(string? description, string? endereco, string? cEP, string? estado, 
        string? cidade, DateTime criadoEm, DateTime? atualizadoEm, bool status)
    {
        Description = description;
        Endereco = endereco;
        CEP = cEP;
        Estado = estado;
        Cidade = cidade;
        CriadoEm = criadoEm;
        AtualizadoEm = atualizadoEm;
        Status = status;
    }
    [Required(ErrorMessage = "O Campo descrição é obrigatório")]
    public string Description { get; private set; } = string.Empty;

    [Required(ErrorMessage = "O Campo endereço é obrigatório")]
    public string Endereco { get; private set; } = string.Empty;

    [Required(ErrorMessage = "O Campo CEP é obrigatório")]
    public string CEP { get; private set; } = string.Empty;

    [Required(ErrorMessage = "O Campo Estado é obrigatório")]
    public string Estado { get; private set; } = string.Empty;

    [Required(ErrorMessage = "O Campo cidade é obrigatório")]
    public string Cidade { get; private set; } = string.Empty;


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

}
