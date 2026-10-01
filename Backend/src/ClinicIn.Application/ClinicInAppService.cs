using ClinicIn.Localization;
using Volo.Abp.Application.Services;

namespace ClinicIn;

/* Inherit your application services from this class.*/
public abstract class ClinicInAppService : ApplicationService
{
    protected ClinicInAppService()
    {
        LocalizationResource = typeof(ClinicInResource);
    }
}
