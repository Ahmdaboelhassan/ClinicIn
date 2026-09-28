using Microsoft.Extensions.Localization;
using ClinicIn.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace ClinicIn;

[Dependency(ReplaceServices = true)]
public class ClinicInBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<ClinicInResource> _localizer;

    public ClinicInBrandingProvider(IStringLocalizer<ClinicInResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
