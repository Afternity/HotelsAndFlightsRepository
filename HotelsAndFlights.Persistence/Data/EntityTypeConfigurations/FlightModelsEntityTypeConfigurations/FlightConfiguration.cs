using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using HotelsAndFlights.Domain.FlightModels;

namespace HotelsAndFlights.Persistence.Data.EntityTypeConfigurations.FlightModelsEntityTypeConfigurations
{
    public class FlightConfiguration : IEntityTypeConfiguration<Flight>
    {
        public void Configure(EntityTypeBuilder<Flight> builder)
        {
            builder.HasKey(flight => flight.Id);

            builder.Property(flight => flight.Airline)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(flight => flight.DepartureCity)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(flight => flight.ArrivalCity)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(flight => flight.DepartureTime)
                .IsRequired();
            builder.Property(flight => flight.Duration)
                .IsRequired()
                .HasConversion(
                    v => v.Ticks,
                    v => TimeSpan.FromTicks(v));

            builder.HasMany(flight => flight.FlightSeats)
                .WithOne(flightSeats => flightSeats.Flight)
                .HasForeignKey(flightSeats => flightSeats.FlightId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(flight => flight.HotelBookings)
            .WithOne(hotelBooking => hotelBooking.Flight)
                .HasForeignKey(hotelBooking => hotelBooking.FlightId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasIndex(flight => flight.DepartureTime);
        }
    }
}
