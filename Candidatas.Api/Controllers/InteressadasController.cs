using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Candidatas.Api.Data;
using Candidatas.Api.Models;

namespace Candidatas.Api.Controllers
{
    [ApiController]
    [Route("[Controller]/ListarTodasInteressa")] //  /Interessadas
    public class InteressadasController : ControllerBase
    {
        private readonly CandidatasContext _context;

        public InteressadasController(CandidatasContext context)
        {
            _context = context;
        }
        // Buscar Todas Interessadas
        [HttpGet]
        public ActionResult<List<Interessada>> GetAll() =>
            _context.Interessadas.ToList();

        // Buscar Por Email
        [HttpGet("BuscarPorEmail")]
        public async Task<ActionResult<Interessada>> BuscarPorEmail(string email)
        {
            var interessada = await _context.Interessadas.SingleOrDefaultAsync(i => i.Email == email);

            if (interessada == null)
            {
                return NotFound();
            }

            return interessada;
        }

        // Cadastrar Interessada
        [HttpPost("CadastrarNovaInteressada")]
        public async Task<IActionResult> CadastrarInteressada(Interessada interessada)
        {
            _context.Interessadas.Add(interessada);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(BuscarPorEmail), new { email = interessada.Email }, interessada);
        }

        // Alterar Interessada
        [HttpPut("AlterarInteressada")]
        public async Task<IActionResult> AlterarInteressada(int id, Interessada interessada)
        {
            if (id != interessada.Id)
            {
                return BadRequest();
            }

            _context.Entry(interessada).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }


        // Deletar Interessada
        // DELETE: api/TodoItems/5
        [HttpDelete("DeletarInteressada")]
        public async Task<IActionResult> DeletarInteressada(int id)
        {
            var interessada = await _context.Interessadas.FindAsync(id);
            if (interessada == null)
            {
                return NotFound();
            }

            _context.Interessadas.Remove(interessada);
            await _context.SaveChangesAsync();

            return NoContent();
        }

    }
}