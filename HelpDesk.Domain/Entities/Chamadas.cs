using System;
using Flunt.Validations;
using HelpDesk.Domain.Core;

public class Chamadas : Entity
{

    public string? Description { get; private set; }
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
