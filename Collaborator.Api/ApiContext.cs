using System.Net;
using Collaborator.Api.Exceptions;
using Collaborator.Api.Models.Rest;
using Collaborator.Api.Models.Rest.Requests;
using Newtonsoft.Json;

namespace Collaborator.Api;

internal class ApiContext : IDisposable
{
    private readonly HttpClient _httpClient;

    public ApiContext(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    internal async Task<ApiResponse<T>> HttpGetAsync<T>(ApiRequest request) where T : class
    {
        using var resp = await _httpClient
                .GetAsync(request.Uri).ConfigureAwait(false);

        return await UnpackAndGetResponse<T>(resp.Content, resp.StatusCode);
    }

    private async Task<ApiResponse<T>> UnpackAndGetResponse<T>(HttpContent content, HttpStatusCode code) where T : class
    {
        string json = await content.ReadAsStringAsync();

        var jsonRes = JsonConvert.DeserializeObject<ApiResponse<T>>(json) ?? throw new CollaboratorException(
            $"Request<{typeof(T).FullName}> returned an error:\n Responsed {nameof(json)} is null");

        content.Dispose();

        if (code == HttpStatusCode.OK) return jsonRes;

        if (code == HttpStatusCode.Unauthorized)
        {
            var answ = JsonConvert.DeserializeObject<ApiErrorResponse>(json);

            throw new CollaboratorException($"{answ!.Status} {answ.Name}\n{answ.Message}");
        }

        throw new CollaboratorException($"{(int)code} {code}");
    }

    public void Dispose()
    {
        _httpClient.Dispose();

        GC.SuppressFinalize(this);
    }
}
