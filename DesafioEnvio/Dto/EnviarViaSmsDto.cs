namespace DesafioEnvio.Dto;

public class EnviarViaSmsDto : EnviarBaseDto
{
    public string Ddi { get; set; }
    public string Ddd { get; set; }
    public string Numero { get; set; }
    public string Mensagem { get; set; }
}
