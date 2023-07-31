using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProSoft.NIS.Contracts.DataModels;

namespace ProSoft.NIS.Data.MsSqlServer.ModelConfigurations;

/// <summary>
/// Static Class CabelConfigurations.
/// </summary>
public static class CabelConfigurations
{
	public static void ConfigureDatabaseEntity(this EntityTypeBuilder<Cable> entity)
	{
		entity.ToTable("Cables", Schemas.Data).HasKey(pk => pk.Id);

		entity.Property(p => p.Id).ValueGeneratedOnAdd();

		entity.HasOne(c => c.PortA).WithOne(p => p.CableA).HasForeignKey<Cable>(c => c.PortAId).OnDelete(DeleteBehavior.NoAction);
		entity.HasOne(c => c.PortB).WithOne(p => p.CableB).HasForeignKey<Cable>(c => c.PortBId).OnDelete(DeleteBehavior.NoAction);
	}
}
