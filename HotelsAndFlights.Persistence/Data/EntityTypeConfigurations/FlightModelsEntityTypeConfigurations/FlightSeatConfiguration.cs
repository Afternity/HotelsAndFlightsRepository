using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using HotelsAndFlights.Domain.FlightModels;
using System.ComponentModel.DataAnnotations;

namespace HotelsAndFlights.Persistence.Data.EntityTypeConfigurations.FlightModelsEntityTypeConfigurations
{
    public class FlightSeatConfiguration : IEntityTypeConfiguration<FlightSeat>
    {
        public void Configure(EntityTypeBuilder<FlightSeat> builder)
        {
            builder.HasKey(flightSeat => flightSeat.Id);

            builder.Property(flightSeat => flightSeat.SeatClass)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(flighSeat => flighSeat.Price)
                .IsRequired()
                .HasColumnType("decimal(8, 2)");
            builder.Property(flighSeat => flighSeat.AvailableCount)
                .IsRequired()
                .HasAnnotation("Range", new RangeAttribute(0, 350));
            
            builder.HasOne(flighSeat => flighSeat.Flight)
                .WithMany(flighSeat => flighSeat.FlightSeats)
                .HasForeignKey(flighSeat => flighSeat.FlightId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasIndex(flightSeat => flightSeat.SeatClass);
        }
    }
}
