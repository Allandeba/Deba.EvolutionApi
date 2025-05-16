namespace Deba.EvolutionApi.Models.Responses.FetchInstances;

public class FetchInstancesSetting
{
    public string? Id { get; set; }
    public bool? RejectCall { get; set; }
    public string? MsgCall { get; set; }
    public bool? GroupsIgnore { get; set; }
    public bool? AlwaysOnline { get; set; }
    public bool? ReadMessages { get; set; }
    public bool? ReadStatus { get; set; }
    public bool? SyncFullHistory { get; set; }
    public string? WavoipToken { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public string? InstanceId { get; set; }
}