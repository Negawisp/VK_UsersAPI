using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.Model;

namespace Domain.EntityConfiguraion
{
    public class UserGroupConfiguration : IEntityTypeConfiguration<UserGroup>
    {
        public void Configure(EntityTypeBuilder<UserGroup> builder)
        {
            // Primary key and indexes
            builder.HasKey(group => group.Id);
            builder.HasIndex(group => group.Code);

            // Properties
            builder.Property(group => group.Id)
                .HasColumnName("id")
                .ValueGeneratedOnAdd()
                .IsRequired();

            builder.Property(group => group.Code)
                .HasColumnName("code")
                .IsRequired();

            builder.Property(group => group.Description)
                .HasColumnName("description")
                .IsRequired(false);
        }
    }
}
