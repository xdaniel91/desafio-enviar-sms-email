using DesafioEnvio.Dto;
using DesafioEnvio.Interfaces;
using DesafioEnvio.Services;
using Microsoft.AspNetCore.Mvc;

namespace DesafioEnvio.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MensagemController : ControllerBase
    {

        [HttpPost("sms")]
        public IActionResult EnviarSms([FromBody] EnviarViaSmsDto enviarViaSmsDto)
        {
            IEnviarService svc = new EnviarSmsService();

            var result = svc.Enviar(enviarViaSmsDto);
            return Ok(result);
        }

        [HttpPost("email")]
        public IActionResult EnviarEmail([FromBody] EnviarViaEmailDto enviarViaEmailDto)
        {
            IEnviarService svc = new EnviarEmailService();

            var result = svc.Enviar(enviarViaEmailDto);
            return Ok(result);
        }
    }
}