namespace Deba.EvolutionApi.Models.Requests.CreateInstance;

public class CreateInstanceRequest : Request
{
    public string? InstanceName { get; set; }
    public string? Token { get; set; }
    public string? Number { get; set; }
    public bool? QrCode { get; set; }
    public string? Integration { get; set; }
    public bool? RejectCall { get; set; }
    public string? MsgCall { get; set; }
    public bool? GroupsIgnore { get; set; }
    public bool? AlwaysOnline { get; set; }
    public bool? ReadMessages { get; set; }
    public bool? ReadStatus { get; set; }
    public bool? SyncFullHistory { get; set; }
    public string? ProxyHost { get; set; }
    public string? ProxyPort { get; set; }
    public string? ProxyProtocol { get; set; }
    public string? ProxyUsername { get; set; }
    public string? ProxyPassword { get; set; }
    public WebhookConfig? Webhook { get; set; }
    public RabbitMQConfig? RabbitMQ { get; set; }
    public SQSConfig? SQS { get; set; }
    public ChatwootConfig? Chatwoot { get; set; }
}
