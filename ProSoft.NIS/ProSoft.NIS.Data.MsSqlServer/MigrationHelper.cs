using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ProSoft.NIS.Data.MsSqlServer;

/// <summary>
/// Static Class MigrationHelper.
/// </summary>
public static class MigrationHelper
{
	public static IHost Migrate<T>(IHost host) where T : DbContext
	{
		ArgumentNullException.ThrowIfNull(host);

		using (var scope = host.Services.CreateScope())
		{
			var services = scope.ServiceProvider;
			//var logger = services.GetRequiredService<ILogger<DbContext>>();

			try
			{
				var db = services.GetRequiredService<T>();
				db.Database.Migrate();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
				//logger.LogError(ex, "An error occurred while migrating the database.");
			}
		}

		return host;
	}
}
