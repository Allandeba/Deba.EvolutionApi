namespace Deba.EvolutionApi.Models.Requests.CreateInstance;

public class RabbitMQConfig
{
    public bool? Enabled { get; set; }
    public List<string>? Events { get; set; } 
}
