using System.Net.Mime;
using System.Text;
using System.Text.Json;
using Deba.EvolutionApi.Common;

namespace Deba.EvolutionApi.Extensions;

internal static class JsonExtensions
{
    public static HttpContent ToHttpContent<T>(this T obj)
    {
        var json = JsonSerializer.Serialize(obj, JsonOptions.Options);
        return new StringContent(json, Encoding.UTF8, MediaTypeNames.Application.Json);
    }    
}