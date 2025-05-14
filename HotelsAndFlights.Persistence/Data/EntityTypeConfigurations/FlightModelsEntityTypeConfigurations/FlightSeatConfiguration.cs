using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;
using HotelsAndFlights.Domain.Models.FlightModels;

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
                .IsRequired();
            
            builder.HasOne(flighSeat => flighSeat.Flight)
                .WithMany(fligh => fligh.FlightSeats)
                .HasForeignKey(flighSeat => flighSeat.FlightId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasIndex(flightSeat => flightSeat.SeatClass);
        }
    }
}
