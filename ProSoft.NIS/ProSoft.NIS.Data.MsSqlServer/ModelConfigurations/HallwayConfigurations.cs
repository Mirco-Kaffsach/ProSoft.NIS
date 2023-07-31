using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProSoft.NIS.Contracts.DataModels;

namespace ProSoft.NIS.Data.MsSqlServer.ModelConfigurations;

/// <summary>
/// Static Class HallwayConfigurations.
/// </summary>
public static class HallwayConfigurations
{
	public static void ConfigureDatabaseEntity(this EntityTypeBuilder<Hallway> entity)
	{
		entity.ToTable("Hallways", Schemas.Data).HasKey(pk => pk.Id);

		entity.Property(p => p.Id).ValueGeneratedOnAdd();

		entity.HasMany(h => h.Rooms).WithOne(r => r.Hallway).HasForeignKey(r => r.HallwayId);
	}
}
