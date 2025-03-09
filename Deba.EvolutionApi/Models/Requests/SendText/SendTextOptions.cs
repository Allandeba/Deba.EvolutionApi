namespace Deba.EvolutionApi.Models.Requests.SendText;

public class SendTextOptions
{
    public int Delay { get; set; }
    public Quoted? Quoted { get; set; }
    public bool linkPreview { get; set; }
    public bool mentionsEveryOne { get; set; }
    public IEnumerable<string>? Mentioned { get; set; }
}