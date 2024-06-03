using DesafioEnvio.Dto;
using DesafioEnvio.Interfaces;

namespace DesafioEnvio.Services;

public class EnviarEmailService : IEnviarService
{
    public string Enviar(EnviarBaseDto mensagem)
    {
        var emailDto = mensagem as EnviarViaEmailDto;

        if (emailDto is null)
            return "email dto inválido";

        return $"mensagem: {emailDto.Mensagem} para: {emailDto.EmailDestinatario} | {emailDto.EmailRemetente}";
    }
}
