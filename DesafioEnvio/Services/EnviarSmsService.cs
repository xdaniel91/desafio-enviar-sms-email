using DesafioEnvio.Dto;
using DesafioEnvio.Interfaces;

namespace DesafioEnvio.Services;

public class EnviarSmsService : IEnviarService
{
    public string Enviar(EnviarBaseDto mensagem)
    {
        var smsDto = mensagem as EnviarViaSmsDto;

        if (smsDto is null)
            return "sms dto inválido";

        return $"mensagem: {smsDto.Mensagem} para: {smsDto.Ddi} {smsDto.Ddd} {smsDto.Numero}";
    }
}
