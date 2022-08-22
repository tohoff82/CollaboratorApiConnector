namespace Collaborator.Api.Models.Rest.Requests;

internal class GetCreatorsListRequest : ApiRequest
{
    public GetCreatorsListRequest() : base()
            => Path.Append("/public/creator/list");
}
