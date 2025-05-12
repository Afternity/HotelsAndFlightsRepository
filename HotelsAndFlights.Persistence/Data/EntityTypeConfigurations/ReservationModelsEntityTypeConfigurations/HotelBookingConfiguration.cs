using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using HotelsAndFlights.Domain.ReservationModels;

namespace HotelsAndFlights.Persistence.Data.EntityTypeConfigurations.ReservationModelsEntityTypeConfigurations
{
    public class HotelBookingConfiguration : IEntityTypeConfiguration<HotelBooking>
    {
        public void Configure(EntityTypeBuilder<HotelBooking> builder)
        {
            builder.HasKey(hotelBooking => new
            {
                hotelBooking.BookingId,
                hotelBooking.FlightId
            });

            builder.Property(hotelBooking => hotelBooking.SeatClass)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(hotelBooking => hotelBooking.Passengers)
                .IsRequired()
                .HasMaxLength(10);

            builder.HasOne(hotelBooking => hotelBooking.Booking)
                .WithMany(booking => booking.HotelBookings)
                .HasForeignKey(hotelBooking => hotelBooking.BookingId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(hotelBooking => hotelBooking.Flight)
                .WithMany(flight => flight.HotelBookings)
                .HasForeignKey(hotelBooking => hotelBooking.FlightId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
