using Collaborator.Api.Exceptions;
using Collaborator.Api.Models;
using Microsoft.Extensions.DependencyInjection;

using static Collaborator.Api.Utils.Constants;

namespace Collaborator.Api;

public static class Connector
{
    public static void AddCryptopay(this IServiceCollection services, CollaboratorCredentials credentials, double httpLifetime = 3)
    {
        services.AddHttpClient<ApiContext>(httpClient =>
        {
            httpClient.BaseAddress = new Uri(credentials.ApiUrl);
            httpClient.DefaultRequestHeaders.Add(AUTH_HEADER, credentials.ApiToken);
        }).SetHandlerLifetime(TimeSpan.FromMinutes(httpLifetime));

        services.AddScoped<ICollaboratorPublicService>(x => new CollaboratorPublicService(x.GetService<ApiContext>()
            ?? throw new CollaboratorException("Collaborator ApiContext must be not null")));
    }

    public static ICollaboratorPublicService GetIstance(HttpClient httpClient, CollaboratorCredentials credentials)
    {
        httpClient.BaseAddress = new Uri(credentials.ApiUrl);
        httpClient.DefaultRequestHeaders.Add(AUTH_HEADER, credentials.ApiToken);

        return new CollaboratorPublicService(new ApiContext(httpClient));
    }
}
