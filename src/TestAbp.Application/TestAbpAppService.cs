using System;
using System.Collections.Generic;
using System.Text;
using TestAbp.Localization;
using Volo.Abp.Application.Services;

namespace TestAbp;

/* Inherit your application services from this class.
 */
public abstract class TestAbpAppService : ApplicationService
{
    protected TestAbpAppService()
    {
        LocalizationResource = typeof(TestAbpResource);
    }
}
