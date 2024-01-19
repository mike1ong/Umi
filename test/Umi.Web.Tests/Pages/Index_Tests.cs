using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Umi.Pages;

public class Index_Tests : UmiWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
