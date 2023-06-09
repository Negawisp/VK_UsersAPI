﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.Model;

namespace Domain.EntityConfiguraion
{
    public class UserStateConfiguration : IEntityTypeConfiguration<UserState>
    {
        public void Configure(EntityTypeBuilder<UserState> builder)
        {
            // Primary key and indexes
            builder.HasKey(state => state.Id);
            builder.HasIndex(state => state.Code);

            // Properties
            builder.Property(state => state.Id)
                .HasColumnName("id")
                .ValueGeneratedOnAdd()
                .IsRequired();

            builder.Property(state => state.Code)
                .HasColumnName("code")
                .IsRequired();

            builder.Property(state => state.Description)
                .HasColumnName("description")
                .IsRequired(false);
        }
    }
}
