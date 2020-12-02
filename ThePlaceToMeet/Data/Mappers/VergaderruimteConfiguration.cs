using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ThePlaceToMeet.Models.Domain;

namespace ThePlaceToMeet.Data.Mappers
{
    public class VergaderruimteConfiguration : IEntityTypeConfiguration<Vergaderruimte>
    {
        public void Configure(EntityTypeBuilder<Vergaderruimte> builder)
        {
            builder.ToTable("Vergaderruimte");
            builder.HasMany(t => t.Reservaties).WithOne(t => t.Vergaderruimte).IsRequired().OnDelete(DeleteBehavior.Restrict);
        }
    }
}
