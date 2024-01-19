using Umi.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Umi.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class UmiPageModel : AbpPageModel
{
    protected UmiPageModel()
    {
        LocalizationResourceType = typeof(UmiResource);
    }
}
