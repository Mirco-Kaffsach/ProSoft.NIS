using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ProSoft.NIS.Data.MsSqlServer.DependencyInjection;

/// <summary>
/// Static Class DatabaseServices.
/// </summary>
public static class DatabaseServices
{
	public static IServiceCollection AddDataEngines(this IServiceCollection services)
	{
		services
			.AddDbContextFactory<DatabaseContext>
			(
				sqlOptions =>
					sqlOptions
						.UseSqlServer(Environment.GetEnvironmentVariable("PROSOFT_NIS_CONNECTIONSTRING"))
						.EnableDetailedErrors()
			);

		return services;
	}
}
