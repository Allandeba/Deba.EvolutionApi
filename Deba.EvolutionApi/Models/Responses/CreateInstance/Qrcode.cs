namespace Deba.EvolutionApi.Models.Responses.CreateInstance;

public class Qrcode
{
    public string? PairingCode { get; set; }
    public string? Code { get; set; }
    public string? Base64 { get; set; }
    public int? Count { get; set; }
}