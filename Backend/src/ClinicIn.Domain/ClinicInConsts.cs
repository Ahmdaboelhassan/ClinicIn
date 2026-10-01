using Volo.Abp.Identity;

namespace ClinicIn;

public static class ClinicInConsts
{
    public const string DbTablePrefix = "App";
    public const string? DbSchema = null;
    public const string AdminEmailDefaultValue = IdentityDataSeedContributor.AdminEmailDefaultValue;
    public const string AdminPasswordDefaultValue = "1q2w3E*";


    public const int NamesMaxLength = 1000;
   
}
