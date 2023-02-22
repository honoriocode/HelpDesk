using System;
using Flunt.Validations;
using HelpDesk.Domain.Core;

public class Equipamentos : Entity
{
    public Equipamentos(string numeroSerie, DateTime dataEmissao, string fornecedor, string cnpj, 
        DateTime data, string marca, string memoria, string hd, string processador, DateTime criadoEm, 
        DateTime? atualizadoEm)
    {
        NumeroSerie = numeroSerie;
        DataEmissao = dataEmissao;
        Fornecedor = fornecedor;
        Cnpj = cnpj;
        Data = data;
        Marca = marca;
        Memoria = memoria;
        Hd = hd;
        Processador = processador;
        CriadoEm = criadoEm;
        AtualizadoEm = atualizadoEm;
    }

    //LocalID
    public string NumeroSerie { get; private set; } = string.Empty;
    public DateTime DataEmissao { get; private set; }
    public string Fornecedor { get; private set; } = string.Empty;
    public string Cnpj { get; private set; } = string.Empty;
    public DateTime Data { get; private set; }
    public string Marca { get; private set; } = string.Empty;
    public string Memoria { get; private set; } = string.Empty;
    public string Hd { get; private set; } = string.Empty;
    public string Processador { get; private set; } = string.Empty;


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
