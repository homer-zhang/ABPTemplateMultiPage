using System.Threading.Tasks;
using Abp.Application.Services;
using X.Dev.Configuration.Dto;

namespace X.Dev.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}