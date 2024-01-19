using System;
using System.Collections.Generic;
using System.Text;
using Umi.Localization;
using Volo.Abp.Application.Services;

namespace Umi;

/* Inherit your application services from this class.
 */
public abstract class UmiAppService : ApplicationService
{
    protected UmiAppService()
    {
        LocalizationResource = typeof(UmiResource);
    }
}
