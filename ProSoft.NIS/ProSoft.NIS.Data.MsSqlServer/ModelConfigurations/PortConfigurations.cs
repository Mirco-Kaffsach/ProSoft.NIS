using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProSoft.NIS.Contracts.DataModels;

namespace ProSoft.NIS.Data.MsSqlServer.ModelConfigurations;

/// <summary>
/// Static Class PortConfigurations.
/// </summary>
public static class PortConfigurations
{
	public static void ConfigureDatabaseEntity(this EntityTypeBuilder<Port> entity)
	{
		entity.ToTable("Ports", Schemas.Data).HasKey(pk => pk.Id);

		entity.Property(p => p.Id).ValueGeneratedOnAdd();
	}
}
