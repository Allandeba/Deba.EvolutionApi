namespace Deba.EvolutionApi.Models.Requests.CreateInstance;

public class WebhookConfig
{
    public string? Url { get; set; }
    public bool? ByEvents { get; set; }
    public bool? Base64 { get; set; }
    public Dictionary<string, string>? Headers { get; set; } 
    public List<string>? Events { get; set; } 
}
