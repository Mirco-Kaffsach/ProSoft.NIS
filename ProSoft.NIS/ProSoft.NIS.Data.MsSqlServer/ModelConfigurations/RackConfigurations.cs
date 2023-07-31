using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProSoft.NIS.Contracts.DataModels;

namespace ProSoft.NIS.Data.MsSqlServer.ModelConfigurations;

/// <summary>
/// Static Class RackConfigurations.
/// </summary>
public static class RackConfigurations
{
	public static void ConfigureDatabaseEntity(this EntityTypeBuilder<Rack> entity)
	{
		entity.ToTable("Racks", Schemas.Data).HasKey(pk => pk.Id);

		entity.Property(p => p.Id).ValueGeneratedOnAdd();

		entity.HasMany(r => r.RackItems).WithOne(ri => ri.Rack).HasForeignKey(ri => ri.RackId);
	}
}
