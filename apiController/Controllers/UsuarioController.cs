using Microsoft.AspNetCore.Mvc;

namespace apiController.Controllers;

[ApiController]
[Route("[controller]")]
public class UsuarioController : ControllerBase
{
    [HttpGet("ObterDataHoraAtual")]
    public IActionResult ObterDataHora()
    {
        var obj = new
        {
            Data = DateTime.Now.ToLongDateString(),
            Hora = DateTime.Now.ToLongTimeString(),
        };
        return Ok(obj);
    }

    [HttpGet("ObterNome/{nome}")]
    public IActionResult ObterNome(string nome){
        return Ok("olá " + nome);
    }
}
