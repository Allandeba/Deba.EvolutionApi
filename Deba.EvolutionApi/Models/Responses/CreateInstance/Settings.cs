namespace Deba.EvolutionApi.Models.Responses.CreateInstance;

public class Settings
{
    public bool? RejectCall { get; set; }
    public string? MsgCall { get; set; }
    public bool? GroupsIgnore { get; set; }
    public bool? AlwaysOnline { get; set; }
    public bool? ReadMessages { get; set; }
    public bool? ReadStatus { get; set; }
    public bool? SyncFullHistory { get; set; }
    public string? WavoipToken { get; set; }
}
