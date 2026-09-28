using ClinicIn.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ClinicIn.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ClinicInController : AbpControllerBase
{
    protected ClinicInController()
    {
        LocalizationResource = typeof(ClinicInResource);
    }
}
