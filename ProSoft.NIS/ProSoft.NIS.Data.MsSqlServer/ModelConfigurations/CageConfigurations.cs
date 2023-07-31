using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProSoft.NIS.Contracts.DataModels;

namespace ProSoft.NIS.Data.MsSqlServer.ModelConfigurations;

/// <summary>
/// Static Class CageConfigurations.
/// </summary>
public static class CageConfigurations
{
	public static void ConfigureDatabaseEntity(this EntityTypeBuilder<Cage> entity)
	{
		entity.ToTable("Cages", Schemas.Data).HasKey(pk => pk.Id);

		entity.Property(p => p.Id).ValueGeneratedOnAdd();

		entity.HasMany(c => c.Racks).WithOne(r => r.Cage).HasForeignKey(r => r.CageId).OnDelete(DeleteBehavior.NoAction);
	}
}
