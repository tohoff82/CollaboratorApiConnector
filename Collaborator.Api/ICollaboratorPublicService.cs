using Collaborator.Api.Models.Entities;
using Collaborator.Api.Models.Rest;

namespace Collaborator.Api;

public interface ICollaboratorPublicService : IDisposable
{
    Task<ApiResponse<CreatorFull>> GetCreatorsListAsync(int pageNumber = 1);
    Task<ApiResponse<DealTypeDirect>> GetDealsListAsync(int pageNumber = 1);
    Task<ApiResponse<DealType>> GetDealTypesListasync(int pageNumber = 1);
    Task<ApiResponse<OwnerDeal>> GetOwnerDealsAsunc(int pageNumber = 1);
}
