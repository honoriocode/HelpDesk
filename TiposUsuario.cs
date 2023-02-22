using System;
using Flunt.Validations;

public class TiposUsuario : Entity
{

    public void UpdateDescription(Description description)
    {
        AddNotifications(description);

        if (IsValid)
            Description = description;
    }

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
