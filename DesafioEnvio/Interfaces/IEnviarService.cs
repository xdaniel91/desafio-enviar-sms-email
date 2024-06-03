using DesafioEnvio.Dto;

namespace DesafioEnvio.Interfaces;

public interface IEnviarService
{
    public string Enviar(EnviarBaseDto mensagem);
}
