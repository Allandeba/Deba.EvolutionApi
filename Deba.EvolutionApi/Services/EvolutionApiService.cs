using System.Net.Http.Json;
using Deba.EvolutionApi.Interfaces;
using Deba.EvolutionApi.Models.Requests.SendText;
using Deba.EvolutionApi.Models.Responses;
using Deba.EvolutionApi.Models.Responses.ConnectionState;
using Deba.EvolutionApi.Models.Responses.SendText;

namespace Deba.EvolutionApi.Services;

internal class EvolutionApiService(HttpClient client) : IEvolutionApiService
{
    private static string _sendTextPath = "message/sendText/{0}";
    private static string _connectionStatePath = "instance/connectionState/{0}";

    public async Task<Response<SendTextResponse?>> SendTextAsync(string instanceName, SendTextRequest request)
    {
        try
        {
            var path = string.Format(_sendTextPath, instanceName);
            var response = await client.PostAsJsonAsync(path, request);

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
            var response = await client.PostAsJsonAsync(path, request);

            return response.IsSuccessStatusCode
                    ? new Response<ConnectionStateResponse?> { Data = await response.Content.ReadFromJsonAsync<ConnectionStateResponse>() }
                    : new Response<ConnectionStateResponse?>(null, 404, "Não foi possível enviar a mensagem", await response.Content.ReadAsStringAsync());
        }
        catch (Exception ex)
        {
            return new Response<ConnectionStateResponse?>(null, 500, $"Erro não esperado ao enviar a mensagem: {ex.Message}", ex.InnerException?.Message);
        }
    }
}