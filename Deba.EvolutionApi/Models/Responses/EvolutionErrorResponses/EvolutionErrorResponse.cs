namespace Deba.EvolutionApi.Models.Responses.EvolutionErrorResponses;

public class EvolutionErrorResponse
{
    public int Status { get; set; }
    public string Error { get; set; } = null!;
    public EvolutionResponse Response { get; set; } = null!;
}
