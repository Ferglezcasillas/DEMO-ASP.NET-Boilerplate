using System.Threading.Tasks;
using Test.MyProject.Configuration.Dto;

namespace Test.MyProject.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
