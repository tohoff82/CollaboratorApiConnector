using Collaborator.Api.Models.Value;
using Newtonsoft.Json;

namespace Collaborator.Api.Models.Entities;

[JsonObject(MemberSerialization.OptIn)]
public class DealTypeBase
{
    #nullable disable annotations

    [JsonProperty(Required = Required.Always)]
    public int Id { get; init; }

    [JsonProperty(Required = Required.Always)]
    public DealProject Project { get; init; }

    [JsonProperty(Required = Required.Always)]
    public DealCreator Creator { get; init; }

    [JsonProperty(Required = Required.Always)]
    public DealPlacementFormat PlacementFormat { get; init; }

    [JsonProperty(Required = Required.Always)]
    public string Status { get; init; }

    [JsonProperty(Required = Required.Always)]
    public DealAnchor[] Anchors { get; init; }

    #nullable enable annotations
}
