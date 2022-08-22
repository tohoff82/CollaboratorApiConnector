using Collaborator.Api.Models.Value;
using Newtonsoft.Json;

namespace Collaborator.Api.Models.Rest;

[JsonObject(MemberSerialization.OptIn)]
public class ApiResponse<T> where T : class
{
    [JsonConstructor]
    public ApiResponse() {}

    public ApiResponse(List<T> items, Pagination pagination)
    {
             Items = items;
        Pagination = pagination;
    }

    #nullable disable annotations

    [JsonProperty(Required = Required.Always)]
    public List<T> Items { get; init; }

    [JsonProperty(Required = Required.Always)]
    public Pagination Pagination { get; init; }

    #nullable restore annotations
}
