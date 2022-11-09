using Collaborator.Api.Models.Entities;
using Collaborator.Api.Models.Rest;
using Collaborator.Api.Models.Rest.Requests;

namespace Collaborator.Api;

internal sealed class CollaboratorPublicService : ICollaboratorPublicService
{
    private readonly ApiContext _apiContext;

    public CollaboratorPublicService(ApiContext apiContext)
    {
        _apiContext = apiContext;
    }

    public Task<ApiResponse<CreatorFull>> GetCreatorsListAsync(int pageNumber)
        => _apiContext.HttpGetAsync<CreatorFull>(new GetCreatorsListRequest());

    public Task<ApiResponse<DealTypeDirect>> GetDealsListAsync(int pageNumber)
        => _apiContext.HttpGetAsync<DealTypeDirect>(new GetDealsListRequest());

    public Task<ApiResponse<DealType>> GetDealTypesListAsync(int pageNumber)
        => _apiContext.HttpGetAsync<DealType>(new GetDealTypesListRequest());

    public Task<ApiResponse<OwnerDeal>> GetOwnerDealsAsync(int pageNumber)
        => _apiContext.HttpGetAsync<OwnerDeal>(new GetDealOwnersListRequest());

    public void Dispose()
        => _apiContext.Dispose();
}
