namespace Deba.EvolutionApi.Models.Requests.SendText;

public class SendTextRequest : Request
{
    public string? InstanceName { get; set; }
    public string? Number { get; set; }
    public string? Text { get; set; }
    public SendTextOptions? Options { get; set; }
}