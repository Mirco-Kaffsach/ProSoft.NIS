using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProSoft.NIS.Contracts.DataModels;

namespace ProSoft.NIS.Data.MsSqlServer.ModelConfigurations;

/// <summary>
/// Static Class RoomConfigurations.
/// </summary>
public static class RoomConfigurations
{
	public static void ConfigureDatabaseEntity(this EntityTypeBuilder<Room> entity)
	{
		entity.ToTable("Rooms", Schemas.Data).HasKey(pk => pk.Id);

		entity.Property(p => p.Id).ValueGeneratedOnAdd();

		entity.HasMany(r => r.Cages).WithOne(c => c.Room).HasForeignKey(c => c.RoomId).OnDelete(DeleteBehavior.NoAction);
		entity.HasMany(r => r.Racks).WithOne(rack => rack.Room).HasForeignKey(rack => rack.RoomId).OnDelete(DeleteBehavior.NoAction);
	}
}
