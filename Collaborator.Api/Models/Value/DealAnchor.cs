using Newtonsoft.Json;

namespace Collaborator.Api.Models.Value;

[JsonObject(MemberSerialization.OptIn)]
public class DealAnchor
{
    #nullable disable annotations
    
    [JsonProperty(Required = Required.Always)]
    public string Anchor { get; init; }

    [JsonProperty(Required = Required.Always)]
    public string Url { get; init; }

    #nullable enable annotations
}
