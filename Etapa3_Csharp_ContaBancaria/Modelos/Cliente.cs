using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etapa3_Csharp.Modelos;

public class Cliente
{
    public string Nome { get; set; }
    public string CPF { get; set; }
    public DateTime DataNascimento { get; set; }
    public string Telefone { get; set; }

    public Cliente (string nome, string cpf, DateTime dataNascimento, string telefone)
    {
        Nome = nome;
        CPF = cpf;
        DataNascimento = dataNascimento;
        Telefone = telefone;
    }

}
