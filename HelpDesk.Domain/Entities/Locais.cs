using System;
using Flunt.Validations;
using HelpDesk.Domain.Core;

//Class done
public class Locais : Entity
{
    private Locais() //Empty Constructor for EF
    { }
    public Locais(string? description, string? endereco, string? cEP, string? estado, 
        string? cidade, DateTime criadoEm, DateTime? atualizadoEm, bool status)
    {
#pragma warning disable CS8601 // Possible null reference assignment.
        Description = description;
        Endereco = endereco;
        CEP = cEP;
        Estado = estado;
        Cidade = cidade;
        CriadoEm = criadoEm;
        AtualizadoEm = atualizadoEm;
        Status = status;
    }

    public string Description { get; private set; } = string.Empty;
    public string Endereco { get; private set; } = string.Empty;
    public string CEP { get; private set; } = string.Empty;
    public string Estado { get; private set; } = string.Empty;
    public string Cidade { get; private set; } = string.Empty;


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
