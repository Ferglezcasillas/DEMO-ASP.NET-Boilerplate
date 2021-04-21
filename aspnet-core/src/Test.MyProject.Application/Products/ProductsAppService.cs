using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Test.MyProject.Authorization;

namespace Test.MyProject.Products
{
    [AbpAuthorize(PermissionNames.Pages_Products)]
    public class ProductsAppService : CrudAppService<Product, ProductDto>
    {
        public ProductsAppService(IRepository<Product, int> repository) : base(repository)
        {
        }
    }
}
