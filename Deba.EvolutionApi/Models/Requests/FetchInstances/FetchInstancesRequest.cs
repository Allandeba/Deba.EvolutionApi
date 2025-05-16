namespace Deba.EvolutionApi.Models.Requests.FetchInstances;

public class FetchInstancesRequest : Request
{
    public string? InstanceName { get; set; }
    public string? InstanceId { get; set; }
}