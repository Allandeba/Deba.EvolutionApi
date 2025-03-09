using Deba.EvolutionApi.Models.Requests.SendText;
using Deba.EvolutionApi.Models.Responses;
using Deba.EvolutionApi.Models.Responses.SendText;

namespace Deba.EvolutionApi.Interfaces;

public interface IEvolutionApiService
{
    Task<Response<SendTextResponse?>> SendTextAsync(string instanceName, SendTextRequest request);
}