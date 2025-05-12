using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using HotelsAndFlights.Domain.HotelModels;

namespace HotelsAndFlights.Persistence.Data.EntityTypeConfigurations.HotelModelsEntityTypeConfiguratons
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasKey(hotel => hotel.Id);

            builder.Property(hotel => hotel.Name)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(hotel => hotel.Location)
                .IsRequired()
                .HasMaxLength(200);
            builder.Property(hotel => hotel.Description)
                .IsRequired()
                .HasMaxLength(1000);
            builder.Property(hotel => hotel.Stars)
                .IsRequired()
                .HasColumnType("decimal(4, 2)");

            builder.HasMany(hotel => hotel.Rooms)
                .WithOne(room => room.Hotel)
                .HasForeignKey(room => room.HotelId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(hotel => hotel.HotelPhotos)
                .WithOne(hotelPhoto => hotelPhoto.Hotel)
                .HasForeignKey(hotelPhoto => hotelPhoto.HotelId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasIndex(hotel => hotel.Name);
        }
    }
}
