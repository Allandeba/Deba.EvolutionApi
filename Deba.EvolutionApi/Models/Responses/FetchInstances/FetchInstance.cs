namespace Deba.EvolutionApi.Models.Responses.FetchInstances;

public class FetchInstance
{
    public string? Id { get; set; }
    public string? Name { get; set; }
    public string? ConnectionStatus { get; set; }
    public string? OwnerJid { get; set; }
    public string? ProfileName { get; set; }
    public string? ProfilePicUrl { get; set; }
    public string? Integration { get; set; }
    public object? Number { get; set; }
    public object? BusinessId { get; set; }
    public string? Token { get; set; }
    public string? ClientName { get; set; }
    public object? DisconnectionReasonCode { get; set; }
    public object? DisconnectionObject { get; set; }
    public object? DisconnectionAt { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public object? Chatwoot { get; set; }
    public object? Proxy { get; set; }
    public object? Rabbitmq { get; set; }
    public object? Sqs { get; set; }
    public object? Websocket { get; set; }
    public FetchInstancesSetting? Setting { get; set; }
    public FetchInstancesCount? _count { get; set; }
}