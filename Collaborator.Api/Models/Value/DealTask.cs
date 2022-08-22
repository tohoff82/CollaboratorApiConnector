using Newtonsoft.Json;

namespace Collaborator.Api.Models.Value;

[JsonObject(MemberSerialization.OptIn)]
public class DealTask
{
    #nullable disable annotations

    [JsonProperty(Required = Required.Always)]
    public string Task { get; init; }

    [JsonProperty(Required = Required.Always)]
    public DealAnchor[] Anchors { get; init; }

    [JsonProperty(Required = Required.Always)]
    public bool AllowInclineAnchors { get; init; }

    #nullable enable annotations
}
