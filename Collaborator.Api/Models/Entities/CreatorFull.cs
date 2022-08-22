using Collaborator.Api.Models.Value;
using Newtonsoft.Json;

namespace Collaborator.Api.Models.Entities;

[JsonObject(MemberSerialization.OptIn)]
public class CreatorFull
{
    #nullable disable annotations
    
    [JsonProperty(Required = Required.Always)]
    public int Id { get; init; }

    [JsonProperty(Required = Required.Always)]
    public string Name { get; init; }

    [JsonProperty(Required = Required.Always)]
    public string Url { get; init; }

    [JsonProperty(Required = Required.Always)]
    public string Categories { get; init; }

    [JsonProperty(Required = Required.Always)]
    public string Traffic { get; init; }

    [JsonProperty(Required = Required.Always)]
    public string Country { get; init; }

    [JsonProperty(Required = Required.DisallowNull)]
    public string Region { get; init; }

    [JsonProperty(Required = Required.DisallowNull)]
    public string Cities { get; init; }

    [JsonProperty(Required = Required.Always)]
    public string PlacementSpeed { get; init; }

    [JsonProperty("tf", Required = Required.Always)]
    public int TrustFlow { get; init; }

    [JsonProperty("cf", Required = Required.Always)]
    public int CitationFlow { get; init; }

    [JsonProperty("tr", Required = Required.Always)]
    public double TrustRank { get; init; }
    
    [JsonProperty(Required = Required.Always)]
    public string AlexaRank { get; init; }

    [JsonProperty("daMoz", Required = Required.Always)]
    public string MozDomainAuthority { get; init; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public string IndexYandex { get; init; }

    [JsonProperty(Required = Required.Always)]
    public string IndexGoogle { get; init; }

    [JsonProperty(Required = Required.Always)]
    public string SiteAge { get; init; }

    [JsonProperty(Required = Required.Always)]
    public string LinkExchange { get; init; }

    [JsonProperty(Required = Required.Always)]
    public string DomainZone { get; init; }

    [JsonProperty(Required = Required.Always)]
    public string SiteType { get; init; }

    [JsonProperty(Required = Required.Always)]
    public string AddedToSystem { get; init; }

    [JsonProperty(Required = Required.Always)]
    public CreatorPrice[] Prices { get; init; }
    
    #nullable enable annotations
}
