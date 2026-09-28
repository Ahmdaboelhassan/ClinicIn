using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ClinicIn.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class ClinicInDbContextFactory : IDesignTimeDbContextFactory<ClinicInDbContext>
{
    public ClinicInDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        
        ClinicInEfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<ClinicInDbContext>()
            .UseSqlite(configuration.GetConnectionString("Default"));
        
        return new ClinicInDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../ClinicIn.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false)
            .AddEnvironmentVariables();

        return builder.Build();
    }
}
