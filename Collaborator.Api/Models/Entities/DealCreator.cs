using Newtonsoft.Json;

namespace Collaborator.Api.Models.Entities;

[JsonObject(MemberSerialization.OptIn)]
public class DealCreator
{
    #nullable disable annotations
    
    [JsonProperty(Required = Required.Always)]
    public int Id { get; init; }

    [JsonProperty(Required = Required.Always)]
    public string Name { get; init; }

    [JsonProperty(Required = Required.Always)]
    public string Url { get; init; }

    #nullable enable annotations
}
