using Collaborator.Api.Models.Value;
using Newtonsoft.Json;

namespace Collaborator.Api.Models.Entities;

[JsonObject(MemberSerialization.OptIn)]
public class OwnerDeal
{
    #nullable disable annotations

    [JsonProperty(Required = Required.Always)]
    public int Id { get; init; }

    [JsonProperty(Required = Required.Always)]
    public string Status { get; init; }

    [JsonProperty(Required = Required.Always)]
    public DateTime CreatedAt { get; init; }

    [JsonProperty(Required = Required.Always)]
    public string Site { get; init; }

    [JsonProperty(Required = Required.Always)]
    public string PublicationType { get; init; }

    [JsonProperty(Required = Required.Always)]
    public string Format { get; init; }

    [JsonProperty(Required = Required.Always)]
    public string CustomerName { get; init; }

    [JsonProperty(Required = Required.Always)]
    public string PublicationUrl { get; init; }

    [JsonProperty(Required = Required.Always)]
    public string Price { get; init; }

    [JsonProperty(Required = Required.Always)]
    public string PricePublication { get; init; }

    [JsonProperty(Required = Required.Always)]
    public bool Found { get; init; }
    
    [JsonProperty(Required = Required.Always)]
    public bool IndexGoogle { get; init; }

    #nullable enable annotations

    [JsonProperty(Required = Required.AllowNull)]
    public DateTime? UpdatedAt { get; init; }

    // [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
    // public DealTask? Task { get; init; }

    [JsonProperty(Required = Required.AllowNull)]
    public string? PriceSpelling { get; init; }

    [JsonProperty(Required = Required.AllowNull)]
    public string? PriceAnnouncement { get; init; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public string? PriceInsurance { get; init; }

    [JsonProperty(Required = Required.AllowNull)]
    public string? PriceContrCategories { get; init; }
}
