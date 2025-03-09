using System.Net.Http.Json;
using Deba.EvolutionApi.Interfaces;
using Deba.EvolutionApi.Models.Requests.SendText;
using Deba.EvolutionApi.Models.Responses;
using Deba.EvolutionApi.Models.Responses.SendText;

namespace Deba.EvolutionApi.Services;

internal class EvolutionApiService(HttpClient client) : IEvolutionApiService
{
    private static string _sendTextPath = "message/sendText/{0}";
    
    public async Task<Response<SendTextResponse?>> SendTextAsync(string instanceName, SendTextRequest request)
    {
        try
        {
            var response = await client.PostAsJsonAsync(string.Format(_sendTextPath, instanceName), request);

            return response.IsSuccessStatusCode
                ? new Response<SendTextResponse?> { Message = "Mensagem enviada com sucesso" }
                : new Response<SendTextResponse?>(null, 404, "Não foi possível enviar a mensagem", await response.Content.ReadAsStringAsync());
        }
        catch (Exception ex)
        {
            return new Response<SendTextResponse?>(null, 500, $"Erro não esperado ao enviar a mensagem: {ex.Message}");
        }
    }
}