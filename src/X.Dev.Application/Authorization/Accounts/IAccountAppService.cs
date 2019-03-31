using System.Threading.Tasks;
using Abp.Application.Services;
using X.Dev.Authorization.Accounts.Dto;

namespace X.Dev.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
