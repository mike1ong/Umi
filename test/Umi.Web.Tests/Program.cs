using Microsoft.AspNetCore.Builder;
using Umi;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
await builder.RunAbpModuleAsync<UmiWebTestModule>();

public partial class Program
{
}
