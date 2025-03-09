namespace Deba.EvolutionApi.Models.Requests.SendText;

public class Quoted
{
    // payload message or key.id only for get message in database
    public QuotedKey? Key { get; set; }
    public QuotedMessage? Message { get; set; }
}