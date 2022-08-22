namespace Collaborator.Api.Models.Rest.Requests;

internal class GetDealsListRequest : ApiRequest
{
    public GetDealsListRequest() : base()
            => Path.Append("/public/deal/list");
}
