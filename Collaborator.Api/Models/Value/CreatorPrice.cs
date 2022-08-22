using Newtonsoft.Json;

namespace Collaborator.Api.Models.Value;

[JsonObject(MemberSerialization.OptIn)]
public class CreatorPrice
{
    #nullable disable annotations

    [JsonProperty(Required = Required.Always)]
    public string Name { get; init; }

    [JsonProperty(Required = Required.Always)]
    public string LinkType { get; init; }

    #nullable enable annotations

    [JsonProperty(Required = Required.AllowNull)]
    public string? PricePublication { get; init; }

    [JsonProperty(Required = Required.AllowNull)]
    public string? PriceSpelling { get; init; }

    [JsonProperty(Required = Required.AllowNull)]
    public string? PriceAnnouncement { get; init; }
}
