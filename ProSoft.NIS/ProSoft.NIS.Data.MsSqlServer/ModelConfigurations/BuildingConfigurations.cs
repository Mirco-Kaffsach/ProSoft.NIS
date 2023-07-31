using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProSoft.NIS.Contracts.DataModels;

namespace ProSoft.NIS.Data.MsSqlServer.ModelConfigurations;

/// <summary>
/// Static Class BuildingConfigurations.
/// </summary>
public static class BuildingConfigurations
{
	public static void ConfigureDatabaseEntity(this EntityTypeBuilder<Building> entity)
	{
		entity.ToTable("Buildings", Schemas.Data).HasKey(pk => pk.Id);

		entity.Property(p => p.Id).ValueGeneratedOnAdd();

		entity.HasMany(b => b.Floors).WithOne(f => f.Building).HasForeignKey(f => f.BuildingId);
	}
}
