using System.Threading.Tasks;
using ArtmisNet.Ha90.Models.TokenAuth;
using ArtmisNet.Ha90.Web.Controllers;
using Shouldly;
using Xunit;

namespace ArtmisNet.Ha90.Web.Tests.Controllers
{
    public class HomeController_Tests: Ha90WebTestBase
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