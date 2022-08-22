using Newtonsoft.Json;

namespace Collaborator.Api.Models.Entities;

[JsonObject(MemberSerialization.OptIn)]
public class AvailablePlacementFormat : DealPlacementFormat
{
    #nullable disable annotations

    [JsonProperty(Required = Required.Always)]
    public string PricePublication { get; init; }

    [JsonProperty(Required = Required.Always)]
    public bool IsSpellingFree { get; init; }

    #nullable enable annotations

    [JsonProperty(Required = Required.AllowNull)]
    public string? PriceSpelling { get; init; }
}
