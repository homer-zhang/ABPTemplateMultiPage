using Abp.Application.Services;
using Abp.Application.Services.Dto;
using X.Dev.MultiTenancy.Dto;

namespace X.Dev.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
