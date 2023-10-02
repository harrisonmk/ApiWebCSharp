using ApiWebCSharp.Context;
using ApiWebCSharp.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ApiWebCSharp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContatoController : ControllerBase
    {

        private readonly AgendaContext _context;

        public ContatoController(AgendaContext context)
        {
           _context = context;
        }

        [HttpPost]
        public IActionResult create(Contato contato)
        {
            _context.Add(contato);
            _context.SaveChanges();
            return CreatedAtAction(nameof(ObterPorId),new {id = contato.Id},contato);
        }


        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id) 
        {
            var contato = _context.Contatos.Find(id);

            if(contato == null)
            {
                return NotFound();
            }

            return Ok(contato);
        }


        [HttpGet("obterPorNome")]
        public IActionResult obterPorNome(String nome)
        {
            var contatos = _context.Contatos.Where(x => x.Nome.Contains(nome));
            
            return Ok(contatos);
        }



        [HttpPut("{id}")]
        public IActionResult atualizar(int id,Contato contato)
        {
            var contatoBanco = _context.Contatos.Find(id);

            if(contatoBanco == null)
            {
                return NotFound();
            }

            contatoBanco.Nome = contato.Nome;
            contatoBanco.Telefone = contato.Telefone;
            contatoBanco.Ativo = contato.Ativo;

            _context.Contatos.Update(contatoBanco);
            _context.SaveChanges();

            return Ok(contatoBanco);
        }

        [HttpDelete("{id}")]
        public IActionResult deletar(int id) 
        {
            var contatoBancp = _context.Contatos.Find(id);

            if(contatoBancp == null)
            {
                return NotFound();
            }

            _context.Contatos.Remove(contatoBancp);
            _context.SaveChanges();
            
            return NoContent();

        }





    }
}
