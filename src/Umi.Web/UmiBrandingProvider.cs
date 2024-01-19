using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Umi.Web;

[Dependency(ReplaceServices = true)]
public class UmiBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Umi";
}
