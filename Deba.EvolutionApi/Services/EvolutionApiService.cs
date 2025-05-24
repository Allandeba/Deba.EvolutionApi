using System.Net.Http.Json;
using Deba.EvolutionApi.Extensions;
using Deba.EvolutionApi.Interfaces;
using Deba.EvolutionApi.Models.Requests.ConnectInstance;
using Deba.EvolutionApi.Models.Requests.CreateInstance;
using Deba.EvolutionApi.Models.Requests.FetchInstances;
using Deba.EvolutionApi.Models.Requests.LogoutInstance;
using Deba.EvolutionApi.Models.Requests.SendText;
using Deba.EvolutionApi.Models.Responses;
using Deba.EvolutionApi.Models.Responses.ConnectInstance;
using Deba.EvolutionApi.Models.Responses.ConnectionState;
using Deba.EvolutionApi.Models.Responses.CreateInstance;
using Deba.EvolutionApi.Models.Responses.FetchInstances;
using Deba.EvolutionApi.Models.Responses.LogoutInstance;
using Deba.EvolutionApi.Models.Responses.SendText;

namespace Deba.EvolutionApi.Services;

internal class EvolutionApiService(HttpClient client) : IEvolutionApiService
{
    private static string _sendTextPath = "message/sendText/{0}";
    private static string _connectionStatePath = "instance/connectionState/{0}";
    private static string _fetchInstancesPath = "instance/fetchInstances{0}";
    private static string _createInstancePath = "instance/create";
    private static string _connectInstancePath = "instance/connect/{0}";
    private static string _logoutInstancePath = "/instance/logout/{0}";

    public async Task<Response<SendTextResponse?>> SendTextAsync(SendTextRequest request)
    {
        try
        {
            var path = string.Format(_sendTextPath, request.InstanceName);
            var response = await client.PostAsync(path, request.ToHttpContent());

            return response.IsSuccessStatusCode
                ? new Response<SendTextResponse?> { Message = "Mensagem enviada com sucesso" }
                : new Response<SendTextResponse?>(null, 404, "Não foi possível enviar a mensagem", await response.Content.ReadAsStringAsync());
        }
        catch (Exception ex)
        {
            return new Response<SendTextResponse?>(null, 500, $"Erro não esperado ao enviar a mensagem: {ex.Message}", ex.InnerException?.Message);
        }
    }
    
    public async Task<Response<ConnectionStateResponse?>> CheckConnectionStateAsync(ConnectionStateRequest request)
    {
        try
        {
            var path = string.Format(_connectionStatePath, request.InstanceName);
            var response = await client.GetAsync(path);

            return response.IsSuccessStatusCode
                    ? new Response<ConnectionStateResponse?> { Data = await response.Content.ReadFromJsonAsync<ConnectionStateResponse>() }
                    : new Response<ConnectionStateResponse?>(null, 404, "Não foi encontrado uma conexão para a instancia", await response.Content.ReadAsStringAsync());
        }
        catch (Exception ex)
        {
            return new Response<ConnectionStateResponse?>(null, 500, $"Erro não esperado ao verificar conexão com a instancia: {ex.Message}", ex.InnerException?.Message);
        }
    }

    public async Task<Response<FetchInstancesResponse?>> FetchInstancesAsync(FetchInstancesRequest request)
    {
        try
        {
            var queryParams = new Dictionary<string, string>();
            if (request.InstanceName != null)
                queryParams["instanceName"] = Uri.EscapeDataString(request.InstanceName);

            if (request.InstanceId != null)
                queryParams["instanceId"] = Uri.EscapeDataString(request.InstanceId);

            var parameters = queryParams.Any()
                ? "?" + string.Join("&", queryParams.Select(param => $"{param.Key}={param.Value}"))
                : string.Empty;

            var path = string.Format(_fetchInstancesPath, parameters);
            var response = await client.GetAsync(path);

            return response.IsSuccessStatusCode
                    ? new Response<FetchInstancesResponse?> { Data = await response.Content.ReadFromJsonAsync<FetchInstancesResponse>() }
                    : new Response<FetchInstancesResponse?>(null, 404, "Não foi possível recuperar instancia(s)", await response.Content.ReadAsStringAsync());
        }
        catch (Exception ex)
        {
            return new Response<FetchInstancesResponse?>(null, 500, $"Erro não esperado ao recuperar instancia(s): {ex.Message}", ex.InnerException?.Message);
        }
    }

    public async Task<Response<CreateInstanceResponse?>> CreateInstanceAsync(CreateInstanceRequest request)
    {
        try
        {
            var response = await client.PostAsync(_createInstancePath, request.ToHttpContent());

            return response.IsSuccessStatusCode
                    ? new Response<CreateInstanceResponse?> { Data = await response.Content.ReadFromJsonAsync<CreateInstanceResponse>() }
                    : new Response<CreateInstanceResponse?>(null, 404, "Não foi possível criar instancia", await response.Content.ReadAsStringAsync());
        }
        catch (Exception ex)
        {
            return new Response<CreateInstanceResponse?>(null, 500, $"Erro não esperado criar instancia: {ex.Message}", ex.InnerException?.Message);
        }
    }

    public async Task<Response<ConnectInstanceResponse?>> ConnectInstanceAsync(ConnectInstanceRequest request)
    {
        try
        {
            var path = string.Format(_connectInstancePath, request.InstanceName);
            var response = await client.GetAsync(path);

            return response.IsSuccessStatusCode
                    ? new Response<ConnectInstanceResponse?> { Data = await response.Content.ReadFromJsonAsync<ConnectInstanceResponse>() }
                    : new Response<ConnectInstanceResponse?>(null, 404, "Não foi possível conectar com a instancia", await response.Content.ReadAsStringAsync());
        }
        catch (Exception ex)
        {
            return new Response<ConnectInstanceResponse?>(null, 500, $"Erro não esperado ao conectar com a instancia: {ex.Message}", ex.InnerException?.Message);
        }
    }

    public async Task<Response<LogoutInstanceResponse?>> LogoutInstanceAsync(LogoutInstanceRequest request)
    {
        try
        {
            var path = string.Format(_logoutInstancePath, request.InstanceName);
            var response = await client.DeleteAsync(path);

            return response.IsSuccessStatusCode
                    ? new Response<LogoutInstanceResponse?> { Data = await response.Content.ReadFromJsonAsync<LogoutInstanceResponse>() }
                    : new Response<LogoutInstanceResponse?>(null, 404, "Não foi possível efetuar o logout da instancia", await response.Content.ReadAsStringAsync());
        }
        catch (Exception ex)
        {
            return new Response<LogoutInstanceResponse?>(null, 500, $"Erro não esperado ao efetuar o logout da instancia: {ex.Message}", ex.InnerException?.Message);
        }
    }
}