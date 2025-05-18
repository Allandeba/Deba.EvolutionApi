using Deba.EvolutionApi.Models.Requests.ConnectInstance;
using Deba.EvolutionApi.Models.Requests.CreateInstance;
using Deba.EvolutionApi.Models.Requests.FetchInstances;
using Deba.EvolutionApi.Models.Requests.SendText;
using Deba.EvolutionApi.Models.Responses;
using Deba.EvolutionApi.Models.Responses.ConnectInstance;
using Deba.EvolutionApi.Models.Responses.ConnectionState;
using Deba.EvolutionApi.Models.Responses.CreateInstance;
using Deba.EvolutionApi.Models.Responses.FetchInstances;
using Deba.EvolutionApi.Models.Responses.SendText;

namespace Deba.EvolutionApi.Interfaces;

public interface IEvolutionApiService
{
    Task<Response<SendTextResponse?>> SendTextAsync(string instanceName, SendTextRequest request);
    Task<Response<ConnectionStateResponse?>> CheckConnectionStateAsync(ConnectionStateRequest request);
    Task<Response<FetchInstancesResponse?>> FetchInstancesAsync(FetchInstancesRequest request);
    Task<Response<CreateInstanceResponse?>> CreateInstanceAsync(CreateInstanceRequest request);
    Task<Response<ConnectInstanceResponse?>> ConnectInstanceAsync(ConnectInstanceRequest request);
}