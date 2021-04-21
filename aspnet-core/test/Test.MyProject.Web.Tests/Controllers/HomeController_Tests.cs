using System.Threading.Tasks;
using Test.MyProject.Models.TokenAuth;
using Test.MyProject.Web.Controllers;
using Shouldly;
using Xunit;

namespace Test.MyProject.Web.Tests.Controllers
{
    public class HomeController_Tests: MyProjectWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}