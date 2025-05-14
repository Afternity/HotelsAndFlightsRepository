using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using HotelsAndFlights.Domain.Models.ReservationModels;

namespace HotelsAndFlights.Persistence.Data.EntityTypeConfigurations.ReservationModelsEntityTypeConfigurations
{
    public class BookingConfiguration : IEntityTypeConfiguration<Booking>
    {
        public void Configure(EntityTypeBuilder<Booking> builder)
        {
            builder.HasKey(booking  => booking.Id);

            builder.Property(booking => booking.CreationDate)
                .IsRequired()
                .HasColumnType("datetime2");

            builder.HasOne(booking => booking.User)
                .WithMany(user => user.Bookings)
                .HasForeignKey(booking => booking.UserId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(booking => booking.HotelBookings)
                .WithOne(hotelBooking => hotelBooking.Booking)
                .HasForeignKey(booking => booking.BookingId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(booking => booking.FlightBookings)
                .WithOne(flightBooking => flightBooking.Booking)
                .HasForeignKey(booking => booking.BookingId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
