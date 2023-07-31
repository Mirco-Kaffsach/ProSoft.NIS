using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProSoft.NIS.Contracts.DataModels;

namespace ProSoft.NIS.Data.MsSqlServer.ModelConfigurations;

/// <summary>
/// Static Class RackItemConfigurations.
/// </summary>
public static class RackItemConfigurations
{
	public static void ConfigureDatabaseEntity(this EntityTypeBuilder<RackItem> entity)
	{
		entity.ToTable("RackItems", Schemas.Data).HasKey(pk => pk.Id);

		entity.Property(p => p.Id).ValueGeneratedOnAdd();

		entity.HasMany(ri => ri.Ports).WithOne(p => p.RackItem).HasForeignKey(p => p.RackItemId);
	}
}
