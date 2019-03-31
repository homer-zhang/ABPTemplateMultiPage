using System.Threading.Tasks;
using Abp.Application.Services;
using X.Dev.Sessions.Dto;

namespace X.Dev.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
