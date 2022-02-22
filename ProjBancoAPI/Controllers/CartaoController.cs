using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjBancoAPI.Models;
using ProjBancoAPI.Persistence;

namespace ProjBancoAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CartaoController : ControllerBase
    {
        private BancoContext _context;

        public CartaoController(BancoContext context)
        {
            _context = context;
        }

        // POST /cartao
        // Recebe um json com as informações de cartao com extrato e lancamento no Body
        [HttpPost]
        public IActionResult Create([FromBody] Cartao cartao)
        {
            //Adiciona o cartao ao banco de dados
            _context.Cartoes.Add(cartao);
            // Commit
            _context.SaveChanges();

            // Retorna um http 201 created com o json do cartão cadastrado e o link no header para ele
            return CreatedAtAction(nameof(GetById), new { Id = cartao.Id }, cartao);
        }

        // GET /cartao/{id}?dias=1
        // Retorna um json com as informações de cartao com extrato e lancamentos
        [HttpGet("{id}")]
        public IActionResult GetById(int id, int dias)
        {
            // Busca o cartão e seu extrato pelo id
            Cartao cartao = _context.Cartoes.Include(c => c.Extrato)
                .Where(c => c.Id == id).FirstOrDefault();

            if (cartao != null)
            {
                // Busca os lançamentos cadastrados no extrato buscado anteriormente
                // Take(dias) faz retornar a quantidade de lancamentos pedida
                cartao.Extrato.Lancamentos = _context.Lancamentos.Where(l => l.ExtratoId == cartao.ExtratoId)
                    .Take(dias).ToList();

                // Http 200 Ok com o json de cartão
                return Ok(cartao);
            }
            else
                // Http 404 NotFound
                return NotFound();
        }

    }
}
