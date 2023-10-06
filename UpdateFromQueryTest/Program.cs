using System.Data.Entity;
using DataAccess;
using Microsoft.Extensions.Configuration;

namespace UpdateFromQueryTest;

internal class Program
{
    static async Task Main(string[] args)
    {
        var configurationBuilder = new ConfigurationBuilder().AddUserSecrets<Program>();
        var configuration = configurationBuilder.Build();

        Z.EntityFramework.Extensions.LicenseManager.AddLicense(configuration["LicenseName"], configuration["LicenseKey"]);

        var dbContext = new AppDbContext(configuration["ConnectionString"]);

        await dbContext.Tests.CountAsync();

        dbContext.Database.Log = (sql) =>
        {
            Console.WriteLine();
            Console.WriteLine(sql);
        };

        using var transaction = dbContext.Database.BeginTransaction();
        await dbContext.Tests.UpdateFromQueryAsync(x => new DataAccess.Models.Test { IsActive = !x.IsActive });
    }
}