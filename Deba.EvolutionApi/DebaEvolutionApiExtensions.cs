using Deba.EvolutionApi.Common;
using Deba.EvolutionApi.Interfaces;
using Deba.EvolutionApi.Models.Options;
using Deba.EvolutionApi.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Deba.EvolutionApi
{
    public static class DebaEvolutionApiExtensions
    {
        public static IServiceCollection AddDebaEvolutionApi(this IServiceCollection services, EvolutionApiOptions options)
        {
            if (options is null)
                throw new ArgumentNullException($"{nameof(EvolutionApiOptions)} cannot be null");

            services.AddTransient<IEvolutionApiService, EvolutionApiService>();

            services.AddHttpClient<IEvolutionApiService, EvolutionApiService>(httpClient =>
            {
                httpClient.BaseAddress = new Uri(options.ApiUrl ?? string.Empty);
                httpClient.DefaultRequestHeaders.Add("ApiKey", options.ApiKey ?? string.Empty);
                httpClient.DefaultRequestHeaders.Add("User-Agent", UserAgents.Get());
            });

            return services;
        }
    }
}