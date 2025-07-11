using TestAbp.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace TestAbp.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class TestAbpController : AbpControllerBase
{
    protected TestAbpController()
    {
        LocalizationResource = typeof(TestAbpResource);
    }
}
