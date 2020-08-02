using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Configurations
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder
                .HasKey(a => a.PersonId);

            builder
                .Property(m => m.PersonId);

            builder
                .Property(m => m.Name)
                .IsRequired()
                .HasMaxLength(50);
            
            builder
                .ToTable("Person");
        }
    }
}
