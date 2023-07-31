using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProSoft.NIS.Contracts.DataModels;

namespace ProSoft.NIS.Data.MsSqlServer.ModelConfigurations;

/// <summary>
/// Static Class FloorConfigurations.
/// </summary>
public static class FloorConfigurations
{
	public static void ConfigureDatabaseEntity(this EntityTypeBuilder<Floor> entity)
	{
		entity.ToTable("Floors", Schemas.Data).HasKey(pk => pk.Id);

		entity.Property(p => p.Id).ValueGeneratedOnAdd();

		entity.HasMany(f => f.Hallways).WithOne(h => h.Floor).HasForeignKey(h => h.FloorId);
	}
}
