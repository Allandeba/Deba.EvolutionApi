namespace Deba.EvolutionApi.Models.Responses.SendText
{
    public class SendTextResponse
    {
        public SendTextKey? Key { get; set; }
        public string? PushName { get; set; }
        public Message? Message { get; set; }
        public string? ContextInfo { get; set; }
        public string? MessageType { get; set; }
        public string? MessageTimestamp { get; set; }
        public string? InstanceId { get; set; }
        public string? Source { get; set; }
    }

    public abstract class Message
    {
        public string? Conversation { get; set; }
    }

    public abstract class SendTextKey
    {
        public string? RemoteJid { get; set; }
        public bool FromMe { get; set; }
        public string? Id { get; set; }
    }
}