using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using HotelsAndFlights.Domain.Models.UserModels;

namespace HotelsAndFlights.Persistence.Data.EntityTypeConfigurations.UserModelsEntityTypeConfigurations
{
    public class UserTypeConfiguration : IEntityTypeConfiguration<UserType>
    {
        public void Configure(EntityTypeBuilder<UserType> builder)
        {
            builder.HasKey(userType => userType.Id);

            builder.Property(userType => userType.Type)
                .IsRequired()
                .HasMaxLength(50);

            builder.HasMany(userType => userType.Users)
                .WithOne(user => user.UserType)
                .HasForeignKey(user => user.UserTypeId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasIndex(userType => userType.Type)
                .IsUnique();
        }
    }
}
