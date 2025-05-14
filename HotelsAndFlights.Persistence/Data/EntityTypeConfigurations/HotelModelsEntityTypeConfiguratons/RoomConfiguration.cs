using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using HotelsAndFlights.Domain.Models.HotelModels;

namespace HotelsAndFlights.Persistence.Data.EntityTypeConfigurations.HotelModelsEntityTypeConfiguratons
{
    public class RoomConfiguration : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            builder.HasKey(room => room.Id);

            builder.Property(room => room.RoomNumber)
                .IsRequired()
                .HasMaxLength(10)
                .HasConversion(
                    v => v.Trim().ToUpper(),
                    v => v);

            builder.HasOne(room => room.Hotel)
                .WithMany(room => room.Rooms)
                .HasForeignKey(room => room.HotelId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(room => room.RoomType)
                .WithMany(roomType => roomType.Rooms)
                .HasForeignKey(room => room.RoomTypeId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
