using System.Text;
using Newtonsoft.Json;

namespace Collaborator.Api.Models.Rest.Requests;

internal abstract class ApiRequest
{
    private readonly string _api = "/api";
    private const string _shema = "application/json";

    protected StringBuilder Path { get; set; }

    protected object RequestBody { get; set; }

    public ApiRequest()
    {
        Path = new StringBuilder(_api);
        RequestBody = new object();
    }

    public Uri Uri
        => new Uri($"{Path}", UriKind.Relative);

    public StringContent BodyContent
        => new StringContent(JsonConvert
            .SerializeObject(RequestBody),
                Encoding.UTF8, _shema);

}
