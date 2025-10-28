using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etapa4_API.Modelos;

[Table("Dispositivo")]
public class Dispositivo
{
    public int Id { get; set; }
    public string? Patrimonio { get; set; }
    public string? Nome { get; set; }
    public string? Categoria { get; set; }
    public string? Status { get; set; }
    public string? Responsavel { get; set; }
}
