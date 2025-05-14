using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using HotelsAndFlights.Domain.Models.ReservationModels;

namespace HotelsAndFlights.Persistence.Data.EntityTypeConfigurations.ReservationModelsEntityTypeConfigurations
{
    public class FlightBookingConfiguration : IEntityTypeConfiguration<FlightBooking>
    {
        public void Configure(EntityTypeBuilder<FlightBooking> builder)
        {
            builder.HasKey(flightBooking => new
            {
                flightBooking.BookingId,
                flightBooking.RoomId
            });

            builder.Property(flightBooking => flightBooking.CheckInDate)
                .IsRequired()
                .HasColumnType("datetime");
            builder.Property(flightBooking => flightBooking.CheckOutDate)
                .IsRequired()
                .HasColumnType("datetime");

            builder.HasOne(flightBooking => flightBooking.Booking)
                .WithMany(booking => booking.FlightBookings)
                .HasForeignKey(flightBooking => flightBooking.BookingId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(flightBooking => flightBooking.Room)
                .WithMany(room => room.FlightBookings)
                .HasForeignKey(flightBooking => flightBooking.RoomId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
