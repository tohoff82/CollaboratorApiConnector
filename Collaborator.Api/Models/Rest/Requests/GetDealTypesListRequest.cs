namespace Collaborator.Api.Models.Rest.Requests;

internal class GetDealTypesListRequest : ApiRequest
{
    public GetDealTypesListRequest() : base()
            => Path.Append("/public/deal/response-list");
}
