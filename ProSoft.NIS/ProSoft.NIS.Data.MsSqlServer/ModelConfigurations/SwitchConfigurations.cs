using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProSoft.NIS.Contracts.DataModels;

namespace ProSoft.NIS.Data.MsSqlServer.ModelConfigurations;

/// <summary>
/// Static Class SwitchConfigurations.
/// </summary>
public static class SwitchConfigurations
{
	public static void ConfigureDatabaseEntity(this EntityTypeBuilder<Switch> entity)
	{
		entity.ToTable("Switches", Schemas.Data);
	}
}
