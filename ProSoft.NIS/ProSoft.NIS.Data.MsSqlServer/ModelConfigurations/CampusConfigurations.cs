using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProSoft.NIS.Contracts.DataModels;

namespace ProSoft.NIS.Data.MsSqlServer.ModelConfigurations;

/// <summary>
/// Static Class CampusConfigurations.
/// </summary>
public static class CampusConfigurations
{
	public static void ConfigureDatabaseEntity(this EntityTypeBuilder<Campus> entity)
	{
		entity.ToTable("Campuses", Schemas.Data).HasKey(pk => pk.Id);

		entity.Property(p => p.Id).ValueGeneratedOnAdd();

		entity.HasMany(c => c.Buildings).WithOne(b => b.Campus).HasForeignKey(b => b.CampusId);
	}
}
