using Newtonsoft.Json;

namespace Collaborator.Api.Models.Entities;

[JsonObject(MemberSerialization.OptIn)]
public class DealProject
{
    #nullable disable annotations

    [JsonProperty(Required = Required.Always)]
    public int Id { get; init; }

    [JsonProperty(Required = Required.Always)]
    public string Name { get; init; }

    #nullable enable annotations
}
