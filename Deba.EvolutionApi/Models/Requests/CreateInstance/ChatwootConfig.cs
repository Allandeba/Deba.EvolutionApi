namespace Deba.EvolutionApi.Models.Requests.CreateInstance;

public class ChatwootConfig
{
    public string? ChatwootAccountId { get; set; }
    public string? ChatwootToken { get; set; }
    public string? ChatwootUrl { get; set; }
    public bool? ChatwootSignMsg { get; set; }
    public bool? ChatwootReopenConversation { get; set; }
    public bool? ChatwootConversationPending { get; set; }
    public bool? ChatwootImportContacts { get; set; }
    public string? ChatwootNameInbox { get; set; }
    public bool? ChatwootMergeBrazilContacts { get; set; }
    public bool? ChatwootImportMessages { get; set; }
    public int? ChatwootDaysLimitImportMessages { get; set; } 
    public string? ChatwootOrganization { get; set; }
    public string? ChatwootLogo { get; set; }
}