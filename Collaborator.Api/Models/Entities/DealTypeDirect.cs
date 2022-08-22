using Newtonsoft.Json;

namespace Collaborator.Api.Models.Entities;

[JsonObject(MemberSerialization.OptIn)]
public class DealTypeDirect : DealTypeBase
{
    #nullable disable annotations

    [JsonProperty(Required = Required.Always)]
    public string Price { get; init; }

    [JsonProperty(Required = Required.Always)]
    public string PricePublication { get; init; }

    [JsonProperty(Required = Required.Always)]
    public bool IsSpellingFree { get; init; }

    #nullable enable annotations

    [JsonProperty(Required = Required.AllowNull)]
    public DateTime? DateOfPlacement { get; init; }

    [JsonProperty(Required = Required.AllowNull)]
    public string? UrlOfPublishedArticle { get; init; }

    [JsonProperty(Required = Required.AllowNull)]
    public string? PriceSpelling { get; init; }

    [JsonProperty(Required = Required.AllowNull)]
    public string? PriceAnnouncement { get; init; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public string? PriceInsurance { get; init; }
}
