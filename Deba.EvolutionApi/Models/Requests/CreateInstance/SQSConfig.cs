namespace Deba.EvolutionApi.Models.Requests.CreateInstance;

public class SQSConfig
{
    public bool? Enabled { get; set; }
    public List<string>? Events { get; set; } 
}
