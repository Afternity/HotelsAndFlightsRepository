using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using HotelsAndFlights.Domain;
using HotelsAndFlights.Domain.HotelModels;

namespace HotelsAndFlights.Persistence.Data.EntityTypeConfigurations.HotelModelsEntityTypeConfiguratons
{
    public class RoomTypeConfiguration : IEntityTypeConfiguration<RoomType>
    {
        public void Configure(EntityTypeBuilder<RoomType> builder)
        {
            builder.HasKey(roomeType => roomeType.Id);

            builder.Property(roomType => roomType.Name)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(roomType => roomType.MaxGuests)
                .IsRequired()
                .HasMaxLength(15);
            builder.Property(roomType => roomType.BasePrice)
                .IsRequired()
                .HasColumnType("decimal(4, 2)");

            builder.HasMany(roomType => roomType.Rooms)
                .WithOne(room => room.RoomType)
                .HasForeignKey(roomType => roomType.RoomTypeId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
