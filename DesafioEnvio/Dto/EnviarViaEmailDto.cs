namespace DesafioEnvio.Dto;

public class EnviarViaEmailDto : EnviarBaseDto
{
    public string EmailDestinatario { get; set; }
    public string EmailRemetente { get; set; }
    public string Mensagem { get; set;}
}
