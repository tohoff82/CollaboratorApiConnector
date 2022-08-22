namespace Collaborator.Api.Models.Rest.Requests;

internal class GetDealOwnersListRequest : ApiRequest
{
    public GetDealOwnersListRequest() : base()
            => Path.Append("/public/deal/list-owner");
}
