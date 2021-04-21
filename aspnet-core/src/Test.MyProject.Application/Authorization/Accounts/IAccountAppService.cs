using System.Threading.Tasks;
using Abp.Application.Services;
using Test.MyProject.Authorization.Accounts.Dto;

namespace Test.MyProject.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
