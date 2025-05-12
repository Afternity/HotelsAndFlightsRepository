using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using HotelsAndFlights.Domain.UserModels;

namespace HotelsAndFlights.Persistence.Data.EntityTypeConfigurations.UserModelsEntityTypeConfigurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(user => user.Id);

            builder.Property(user => user.UserName)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(user => user.Email)
                .IsRequired()
                .HasMaxLength(100)
                .HasConversion(
                    v => v.ToLower(),
                    v => v);
            builder.Property(user => user.PasswordHash)
                .IsRequired()
                .HasColumnType("varbinary(512)");
            builder.Property(user => user.PasswordSalt)
                .IsRequired()
                .HasColumnType("varbinary(512)");

            builder.HasOne(user => user.UserType)
                .WithMany(userType => userType.Users)
                .HasForeignKey(user => user.UserTypeId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(user => user.Bookings)
                .WithOne(booking => booking.User)
                .HasForeignKey(booking => booking.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasIndex(user => user.UserName)
                .IsUnique();
            builder.HasIndex(user => user.Email)
                .IsUnique();
        }
    }
}
