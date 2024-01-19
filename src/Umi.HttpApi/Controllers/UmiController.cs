using Umi.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Umi.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class UmiController : AbpControllerBase
{
    protected UmiController()
    {
        LocalizationResource = typeof(UmiResource);
    }
}
