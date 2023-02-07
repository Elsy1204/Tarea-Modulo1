using FastDeliveryApi.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FastDeliveryApi.Data.Configurations;
public class CustomerConfiguration : IEntityTypeConfiruration<customer>
{
    public void Configure(EntityTypeBuilder<customer> builder)
{
    builder.HasKey(b => b.Id);

    builder.Property(b => b.Name)
        .HasMaxLength(100)
        .HasColumnType("text")
        .IsRequired();

    builder.Property(b => b.PhoneNumber)
        .HasMaxLength(9)
        .HasColumnType("text")
        .HasColumnName("PhoneNumbercustomer");

    builder.Property(b => b.Email)
        .HasMaxLength(120)
        .HasColumnType("text")
        .IsRequired();

    builder.Property(b => b.Address)
        .HasMaxLength(100)
        .HasColumnType("text")
        .IsRequired();

    builder.HasData (
        new customer
        {
            Id = 1,
            Name = "Els Renter",
            Email = "reyes@.com",
            Address = "La Union",
            PhoneNumber ="0001-0000",
            Status = true
        }
    );
}
    
}
