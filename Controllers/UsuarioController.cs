using Microsoft.AspNetCore.Mvc;

namespace ApiWebCSharp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        [HttpGet("obterDataHoraAtual")]
        public IActionResult obterDataHora()
        {
            var obj = new
            {
                Data = DateTime.Now.ToLongDateString(),
                Hora = DateTime.Now.ToShortTimeString(),
            };

            return Ok(obj);
        }

        [HttpGet("apresentar/{nome}")]
        public IActionResult Apresentar(String nome)
        {
            var mensagem = $"ola {nome}, seja bem vindo!";
            return Ok(new { mensagem });
        }

    }
}
