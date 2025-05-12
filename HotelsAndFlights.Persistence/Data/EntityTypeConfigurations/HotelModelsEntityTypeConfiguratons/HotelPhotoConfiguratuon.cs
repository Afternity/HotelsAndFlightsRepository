using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using HotelsAndFlights.Domain.HotelModels;

namespace HotelsAndFlights.Persistence.Data.EntityTypeConfigurations.HotelModelsEntityTypeConfiguratons
{
    public class HotelPhotoConfiguratuon : IEntityTypeConfiguration<HotelPhoto>
    {
        public void Configure(EntityTypeBuilder<HotelPhoto> builder)
        {
            builder.HasKey(hotelPhoto => hotelPhoto.Id);

            builder.Property(hotelPhoto => hotelPhoto.Url)
                .IsRequired()
                .HasConversion(
                    v => v!.ToString(),
                    v => new Uri(v));
            builder.Property(p => p.AltText)
                .IsRequired()
                .HasMaxLength(100);

            builder.HasOne(hotelPhoto => hotelPhoto.Hotel)
                .WithMany(hotel => hotel.HotelPhotos)
                .HasForeignKey(hotelPhoto => hotelPhoto.HotelId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
