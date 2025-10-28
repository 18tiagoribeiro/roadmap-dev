using Etapa4_API.Data;
using Etapa4_API.Modelos;
using Microsoft.EntityFrameworkCore.Update;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace GerenciamentoDeProduto.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DispositivoController : ControllerBase
{
    private readonly AppDbContext _context;

    public DispositivoController(AppDbContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<ActionResult<Dispositivo>> PostDispositivos([FromBody] Dispositivo dispositivo)
    {
        bool exists = _context.Dispositivo.Any(d => d.Patrimonio == dispositivo.Patrimonio);
        if (exists)
        {
            return Conflict("Já existe um dispositivo com esse patrimonio.");
        }

        _context.Dispositivo.Add(dispositivo);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(PostDispositivos), new { id = dispositivo.Id }, new { message = "Conta salva no Banco de Dados!", dispositivo });
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Dispositivo>>> GetDispositivos()
    {
        var dispositivos = await _context.Dispositivo.ToListAsync();
        return Ok(dispositivos);
    }

    [HttpDelete("{patrimonio}")]
    public async Task<ActionResult> DeleteDispositivo(string patrimonio)
    {
        var dispositivo = await _context.Dispositivo
            .FirstOrDefaultAsync(d => d.Patrimonio == patrimonio);

        if (dispositivo == null)
        {
            return NotFound("Dispositivo não encontrado.");
        }

        _context.Dispositivo.Remove(dispositivo);
        await _context.SaveChangesAsync();

        return Ok("Dispositivo deletado com sucesso.");
    }


    [HttpPut]
    public async Task<ActionResult> UpdateDispositivo([FromBody] Dispositivo dispositivo)
    {
        var atualizarDispositivo = await _context.Dispositivo.FirstOrDefaultAsync(d => d.Nome == dispositivo.Nome);
        if (atualizarDispositivo == null)
        {
            return NotFound("Dispositivo não encontrado.");
        }
        atualizarDispositivo.Patrimonio = dispositivo.Patrimonio;
        atualizarDispositivo.Nome = dispositivo.Nome;
        atualizarDispositivo.Categoria = dispositivo.Categoria;
        atualizarDispositivo.Status = dispositivo.Status;
        atualizarDispositivo.Responsavel = dispositivo.Responsavel;
        _context.Dispositivo.Update(atualizarDispositivo);
        await _context.SaveChangesAsync();
        return Ok("Dispositivo atualizado com sucesso.");
    }
}


