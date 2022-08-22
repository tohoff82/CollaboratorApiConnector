using Newtonsoft.Json;

namespace Collaborator.Api.Models.Value;

[JsonObject(MemberSerialization.OptIn)]
public class Pagination
{
    [JsonProperty(Required = Required.Always)]
    public int TotalCount { get; init; }

    [JsonProperty(Required = Required.Always)]
    public int PageSize { get; init; }

    [JsonProperty(Required = Required.Always)]
    public int Page { get; init; }

    [JsonProperty(Required = Required.Always)]
    public int PageCount { get; init; }
}
