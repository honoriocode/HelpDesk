using System;
using System.ComponentModel.DataAnnotations;
using Flunt.Validations;
using HelpDesk.Domain.Core;

public class Equipamento : Entity
{
    public Equipamento(string numeroSerie, DateTime dataEmissao, string fornecedor, string cnpj, 
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
    [Required(ErrorMessage = "O Campo Numero de série é obrigatório")]
    public string NumeroSerie { get; private set; } = string.Empty;

    [Required(ErrorMessage = "O Campo Data de Emissão é obrigatório")]
    public DateTime DataEmissao { get; private set; }

    [Required(ErrorMessage = "O Campo Fornecedor é obrigatório")]
    public string Fornecedor { get; private set; } = string.Empty;

    [Required(ErrorMessage = "O Campo CNPJ é obrigatório")]
    public string Cnpj { get; private set; } = string.Empty;

    [Required(ErrorMessage = "O Campo Data é obrigatório")]
    public DateTime Data { get; private set; }

    [Required(ErrorMessage = "O Campo Marca é obrigatório")]
    public string Marca { get; private set; } = string.Empty;

    [Required(ErrorMessage = "O Campo Memória é obrigatório")]
    public string Memoria { get; private set; } = string.Empty;

    [Required(ErrorMessage = "O Campo HD é obrigatório")]
    public string Hd { get; private set; } = string.Empty;

    [Required(ErrorMessage = "O Campo Processador é obrigatório")]
    public string Processador { get; private set; } = string.Empty;


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
