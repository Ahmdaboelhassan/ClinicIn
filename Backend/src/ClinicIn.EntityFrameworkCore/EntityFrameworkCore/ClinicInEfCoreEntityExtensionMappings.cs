using ClinicIn.Entities;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Identity;
using Volo.Abp.ObjectExtending;
using Volo.Abp.Threading;

namespace ClinicIn.EntityFrameworkCore;

public static class ClinicInEfCoreEntityExtensionMappings
{
    private static readonly OneTimeRunner OneTimeRunner = new OneTimeRunner();

    public static void Configure()
    {
        ClinicInGlobalFeatureConfigurator.Configure();
        ClinicInModuleExtensionConfigurator.Configure();

        OneTimeRunner.Run(() =>
        {
            ObjectExtensionManager.Instance
             .MapEfCoreProperty<IdentityUser, int?>(
                 "BranchId",
                 (entityBuilder, propertyBuilder) =>
                 {
                     entityBuilder
                         .HasOne(typeof(Branch))
                         .WithMany()
                         .HasForeignKey("BranchId")
                         .OnDelete(DeleteBehavior.Restrict);
                 });
        });
    }
}
