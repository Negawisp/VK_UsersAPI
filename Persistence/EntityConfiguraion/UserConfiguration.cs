using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.Model;

namespace Domain.EntityConfiguraion
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        const string userGroup_foreignKeyPropertyName = "UserGroupId";
        const string userState_foreignKeyPropertyName = "UserStateId";

        public void Configure(EntityTypeBuilder<User> builder)
        {
            // Primary key and indexes
            builder.HasKey(user => user.Id);
            builder.HasIndex(user => user.Login).IsUnique();

            // Properties
            builder.Property(user => user.Id)
                .HasColumnName("id")
                .ValueGeneratedOnAdd()
                .IsRequired();

            builder.Property(user => user.Login)
                .HasColumnName("login")
                .IsRequired();

            builder.Property(user => user.Password)
                .HasColumnName("password")
                .IsRequired();

            builder.Property<int>(userGroup_foreignKeyPropertyName)
                .HasColumnName("user_group_id")
                .IsRequired();
            builder.HasOne(user => user.UserGroup)
                .WithMany()
                .HasForeignKey(userGroup_foreignKeyPropertyName)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            builder.Property<int>(userState_foreignKeyPropertyName)
                .HasColumnName("user_state_id")
                .IsRequired();
            builder.HasOne(user => user.UserState)
                .WithMany()
                .HasForeignKey(userState_foreignKeyPropertyName)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();
        }
    }
}
