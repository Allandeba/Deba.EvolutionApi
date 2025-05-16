namespace Deba.EvolutionApi.Models.Responses.CreateInstance;

public class CreateInstanceResponse
{
    public Instance? Instance { get; set; }
    public string? Hash { get; set; }
    public Webhook? Webhook { get; set; }
    public Websocket? Websocket { get; set; }
    public Rabbitmq? Rabbitmq { get; set; }
    public Sqs? Sqs { get; set; }
    public Settings? Settings { get; set; }
    public Qrcode? Qrcode { get; set; }
}