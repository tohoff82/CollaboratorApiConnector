using Newtonsoft.Json;

namespace Collaborator.Api.Models.Entities;

[JsonObject(MemberSerialization.OptIn)]
public class DealType : DealTypeBase
{
    #nullable disable annotations

    [JsonProperty(Required = Required.Always)]
    public AvailablePlacementFormat[] AvailablePlacementFormats { get; init; }

    #nullable enable annotations
}
