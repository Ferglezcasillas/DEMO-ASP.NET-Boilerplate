using Abp.Application.Services;
using Test.MyProject.MultiTenancy.Dto;

namespace Test.MyProject.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

