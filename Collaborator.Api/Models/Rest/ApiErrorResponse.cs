using Newtonsoft.Json;

namespace Collaborator.Api.Models.Rest;

[JsonObject(MemberSerialization.OptIn)]
internal class ApiErrorResponse
{
    #nullable disable annotations

    [JsonProperty(Required = Required.Always)]
    public string Name { get; init; }

    [JsonProperty(Required = Required.Always)]
    public string Message { get; init; }

    #nullable enable annotations

    [JsonProperty(Required = Required.Always)]
    public int Status {get; init;}
}
