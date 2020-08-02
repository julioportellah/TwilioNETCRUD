using DataLayer.EfClasses;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace DataLayer.EfCode.Configurations
{
    public class PersonConfig : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> entity)
        {
            entity.HasIndex(p => p.PersonId);
            entity.Property(p => p.PersonId).HasColumnType("int");
            entity.Property(p => p.Name).HasColumnType("varchar(50)").IsRequired();
            entity.Property(p => p.FirstLastName).HasColumnType("varchar(50)").IsRequired();
            entity.Property(p => p.SecondLastName).HasColumnType("varchar(50)").IsRequired();
            entity.Property(p => p.BirthDate).HasColumnType("date").IsRequired();


        }
    }
}
