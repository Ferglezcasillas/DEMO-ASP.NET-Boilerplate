using System.Threading.Tasks;
using Abp.Application.Services;
using Test.MyProject.Sessions.Dto;

namespace Test.MyProject.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
